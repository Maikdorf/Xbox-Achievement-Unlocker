﻿using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Memory;
using System.Threading;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using System.Net;

namespace Xbox_Achievement_Unlocker
{
    public partial class MainWindow : Form
    {
        public Mem m = new();
        bool attached = false;
        string filter1, filter2, filter3, filter4;

        private dynamic dataProfile, dataTitles;

        public static bool checkFileIncompatibilities;
        IDictionary<string, string> gamesCompatibles = new Dictionary<string, string>();
        public const string FileIncompatibleGames = "GamesListAll.csv";
        public const string DownloadFileIncompatibleGames = "download_GamesListAll.csv";

        //string currentSystemLanguage = System.Globalization.CultureInfo.CurrentCulture.Name;
        string currentSystemLanguage = "en-US";
        static HttpClientHandler handler = new()
        {
            AutomaticDecompression = System.Net.DecompressionMethods.GZip | System.Net.DecompressionMethods.Deflate
        };
        HttpClient client = new(handler);

        public MainWindow()
        {
            InitializeComponent();
        }

        private void BGWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                if (!m.OpenProcess("XboxPcApp"))
                {
                    attached = false;
                    Thread.Sleep(1000);
                    continue;
                }
                attached = true;
                Thread.Sleep(1000);
                BGWorker.ReportProgress(0);
            }
        }

        async void MainWindow_Shown(object sender, EventArgs e)
        {
            BGWorker.RunWorkerAsync();
            LST_GameFilterType.SelectedIndex = 2;
            try
            {
                Updater Updater = new();
                //update checker
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Add("Host", "api.github.com");
                client.DefaultRequestHeaders.Add("User-Agent",
                    "Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:108.0) Gecko/20100101 Firefox/108.0");
                client.DefaultRequestHeaders.Add("Accept-Encoding", "gzip, deflate, br");
                client.DefaultRequestHeaders.Add("Accept",
                    "text/html,application/xhtml+xml,application/xml;q=0.9,image/avif,image/webp,*/*;q=0.8");
                var responseString =
                    await client.GetStringAsync("https://api.github.com/repos/ItsLogic/Xbox-Achievement-unlocker/releases");
                var Jsonresponse = (dynamic)(new JArray());
                Jsonresponse = (dynamic)JArray.Parse(responseString);
                if (Jsonresponse[0].tag_name.ToString() != "1.8")
                    Updater.Show();
            }
            catch
            {
                MessageBox.Show("Failed to check for updates");
            }
        }

        private void BGWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (attached)
            {
                LBL_Attached.Text = "Attached to: " + m.GetProcIdFromName("XboxPcApp").ToString();
                LBL_Attached.ForeColor = Color.Green;
                BTN_GrabXauth.Enabled = true;
            }
            if (!attached)
            {
                LBL_Attached.Text = "Not attached to Xbox App";
                LBL_Attached.ForeColor = Color.Red;
                BTN_GrabXauth.Enabled = false;
                BTN_SpoofGame.Enabled = false;
                BTN_SaveToFile.Enabled = false;
                BTN_StatsEditor.Enabled = false;
            }
        }

        private void BGWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            BGWorker.RunWorkerAsync();
        }
        //define some xauth variables
        long XauthStartAddress;
        long XauthEndAddress;
        string XauthStartAddressHex;
        long XauthLength;
        public static string xauthtoken;

        private async void BTN_GrabXauth_Click(object sender, EventArgs e)
        {
            //TODO
            DialogResult dialogResult = MessageBox.Show("Do you want to download incompatible title data?", "Download Data", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                WebClient mywebClient = new();
                mywebClient.DownloadFile("https://lab.juanduncan.com/GamesListAll.csv", @"" + DownloadFileIncompatibleGames);
            }

            checkFileIncompatibilities = checkFileExist(DownloadFileIncompatibleGames);
            if (checkFileIncompatibilities)
            {
                if (checkFileExist(FileIncompatibleGames))
                {
                    Load_Incompatibility_Games_Data(DownloadFileIncompatibleGames);
                    IDictionary<string, string> downloadGamesCompatibles = gamesCompatibles;
                    Load_Incompatibility_Games_Data(FileIncompatibleGames);

                }
                else
                {
                    RenameFile(DownloadFileIncompatibleGames, FileIncompatibleGames);
                }

                Load_Incompatibility_Games_Data(FileIncompatibleGames);

            }

            if (TXT_Xauth.Text.Length > 10)
            {
                try
                {
                    xauthtoken = TXT_Xauth.Text;
                    LoadInfo();
                    BTN_GrabXauth.Text = "Refresh Info";
                }
                catch
                {
                    MessageBox.Show("There is an issue with the xauth token provided.");
                }
            }
            else
            {
                //this is actually the stupidest guess I have ever done while coding but it should work so I dont care
                IEnumerable<long> XauthScanList = await m.AoBScan("58 42 4C 33 2E 30 20 78 3D", true, true);
                string[] XauthStrings = new string[XauthScanList.Count()];
                var i = 0;
                foreach (var address in XauthScanList)
                {
                    XauthStrings[i] = m.ReadString(address.ToString("X"), length: 10000);
                    i++;
                }
                Dictionary<string, int> frequency = new();
                foreach (string str in XauthStrings)
                {
                    if (!frequency.ContainsKey(str))
                    {
                        frequency[str] = 1;
                    }
                    else
                    {
                        frequency[str]++;
                    }
                }
                string mostCommon = XauthStrings[0];
                int highestFrequency = 0;
                foreach (KeyValuePair<string, int> pair in frequency)
                {
                    if (pair.Value > highestFrequency)
                    {
                        mostCommon = pair.Key;
                        highestFrequency = pair.Value;
                    }
                }
                if (highestFrequency < 3)
                {
                    MessageBox.Show("Dont press the button as soon as the xbox app starts up.\nWait until it has loaded");
                    Thread.Sleep(500);
                    BTN_GrabXauth_Click(null, null);
                }
                else
                {
                    try
                    {
                        xauthtoken = mostCommon;
                        TXT_Xauth.Text = xauthtoken;
                        LoadInfo();
                        BTN_GrabXauth.Text = "Refresh Info";
                    }
                    catch
                    {
                        MessageBox.Show("Couldnt find xauth. Go click the FuckyWucky Fixer button until this doesnt happen.");
                    }
                }


            }
        }

        public void UpdaterGamesIncompatibles()
        {

        }

        public static string xuid;
        public static string responseString;
        AchievementList ALForm = new();
        public async void LoadAchievementList(object sender, EventArgs e)
        {
            PictureBox SelectedGame = (sender as PictureBox);

            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Add("x-xbl-contract-version", "4");
            client.DefaultRequestHeaders.Add("Accept-Encoding", "gzip, deflate");
            client.DefaultRequestHeaders.Add("accept", "application/json");
            client.DefaultRequestHeaders.Add("accept-language", currentSystemLanguage);
            try
            {
                client.DefaultRequestHeaders.Add("Authorization", xauthtoken);
            }
            catch (Exception exception)
            {
                MessageBox.Show(
                    "Couldnt find xauth. Go click the FuckyWucky Fixer button until this doesnt happen.");
                return;
            }
            client.DefaultRequestHeaders.Add("Host", "achievements.xboxlive.com");
            client.DefaultRequestHeaders.Add("Connection", "Keep-Alive");
            try
            {
                responseString = await client.GetStringAsync("https://achievements.xboxlive.com/users/xuid(" + xuid + ")/achievements?titleId=" + SelectedGame.Name.ToString() + "&maxItems=1000");
                AchievementList ALForm = new();
                ALForm.Show();
                ALForm.PopulateAchievementList(responseString);
            }
            catch (HttpRequestException ex)
            {

                if ((int)ex.StatusCode == 401)
                    MessageBox.Show("Couldnt find xauth. Go click the FuckyWucky Fixer button until this doesnt happen.", "401 Unauthorised");
                else
                    MessageBox.Show("something did a fucky wucky and I dont have a specific message for the error code", "fucky wucky");
            }


        }

        async void LoadInfo()
        {
            Panel_Compatible.Controls.Clear();
            Panel_inCompatible.Controls.Clear();
            //required headers for a request to go through. (just taken from a legitimate request to profile.xboxlive.com)
            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Add("x-xbl-contract-version", "2");
            client.DefaultRequestHeaders.Add("Accept-Encoding", "gzip, deflate");
            client.DefaultRequestHeaders.Add("accept", "application/json");
            client.DefaultRequestHeaders.Add("accept-language", currentSystemLanguage);
            try
            {
                client.DefaultRequestHeaders.Add("Authorization", xauthtoken);
            }
            catch (Exception exception)
            {
                MessageBox.Show(
                    "Couldnt find xauth. Go click the FuckyWucky Fixer button until this doesnt happen.",
                    "Xauth not found");
                return;
            }
            client.DefaultRequestHeaders.Add("Host", "profile.xboxlive.com");
            client.DefaultRequestHeaders.Add("Connection", "Keep-Alive");
            try
            {
                //query the users own profile using their xauth to find out profile information for future queries
                var responseString = await client.GetStringAsync("https://profile.xboxlive.com/users/me/profile/settings?settings=Gamertag,Gamerscore");
                var Jsonresponse = (dynamic)(new JObject());
                Jsonresponse = (dynamic)JObject.Parse(responseString);
                dataProfile = Jsonresponse;
                LBL_Gamertag.Text = "Gamertag: " + Jsonresponse.profileUsers[0].settings[0].value;
                LBL_Gamerscore.Text = "Gamerscore: " + Jsonresponse.profileUsers[0].settings[1].value;
                TXT_Xuid.Text = "XUID: " + Jsonresponse.profileUsers[0].id;
                xuid = Jsonresponse.profileUsers[0].id;
                BTN_SpoofGame.Enabled = true;
                BTN_SaveToFile.Enabled = true;
                BTN_StatsEditor.Enabled = true;
            }
            catch (HttpRequestException ex)
            {
                if ((int)ex.StatusCode == 401)
                    MessageBox.Show("Couldnt find xauth. Go click the FuckyWucky Fixer button until this doesnt happen.", "401 Unauthorised");
                else
                    MessageBox.Show("something did a fucky wucky and I dont have a specific message for the error code", "fucky wucky");
            }
            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Add("x-xbl-contract-version", "2");
            client.DefaultRequestHeaders.Add("Accept-Encoding", "gzip, deflate");
            client.DefaultRequestHeaders.Add("accept", "application/json");
            client.DefaultRequestHeaders.Add("accept-language", currentSystemLanguage);
            try
            {
                client.DefaultRequestHeaders.Add("Authorization", xauthtoken);
            }
            catch (Exception exception)
            {
                MessageBox.Show(
                    "Couldnt find xauth. Go click the FuckyWucky Fixer button until this doesnt happen.",
                    "Xauth not found");
                return;
            }
            client.DefaultRequestHeaders.Add("Host", "titlehub.xboxlive.com");
            client.DefaultRequestHeaders.Add("Connection", "Keep-Alive");
            try
            {
                string line = "", devices, titles;
                var responseString = await client.GetStringAsync("https://titlehub.xboxlive.com/users/xuid(" + xuid + ")/titles/titleHistory/decoration/Achievement,scid");
                var Jsonresponse = (dynamic)(new JObject());
                Jsonresponse = (dynamic)JObject.Parse(responseString);
                const int itemWidth = 150;
                const int rowHeight = 205;
                int itemCountPerRow = 5,
                    newline = 0,
                    itemWidthWithMargin = 0,
                    count = 0,
                    newline_i = 0,
                    itemWidthWithMargin_i = 0,
                    count_i = 0;



                dynamic title;
                dataTitles = Jsonresponse;
                PB_loading.Maximum = Jsonresponse.titles.Count;
                for (int i = 0; i < Jsonresponse.titles.Count; i++)
                {
                    PB_loading.Value += 1;

                    title = Jsonresponse.titles[i];
                    devices = title.devices.ToString();
                    titles = title.name.ToString() + " " + title.titleId.ToString();
                    if (!devices.Contains(filter1)
                        && !devices.Contains(filter2)
                        && !devices.Contains(filter3)
                        && !devices.Contains(filter4)
                        && titles.ToLower().Contains(TXT_GameFilterTitle.Text.ToLower()))
                    {
                        if (count % itemCountPerRow == 0 && count != 0)
                        {
                            newline += rowHeight;
                            count = 0;
                        }

                        if (count_i % itemCountPerRow == 0 && count_i != 0)
                        {
                            newline_i += rowHeight;
                            count_i = 0;
                        }

                        //here code create table
                        if (checkFileIncompatibilities)
                        {
                            if (gamesCompatibles.ContainsKey(title.titleId.ToString()) && gamesCompatibles[title.titleId.ToString()] == "incompatible")
                            {
                                itemWidthWithMargin_i = Draw_Picture_Game(Jsonresponse.titles[i], count_i, newline_i, Panel_inCompatible, itemWidth, itemWidthWithMargin_i, itemCountPerRow);
                                count_i++;
                                continue;
                            }
                            else
                            {
                                itemWidthWithMargin = Draw_Picture_Game(Jsonresponse.titles[i], count, newline, Panel_Compatible, itemWidth, itemWidthWithMargin, itemCountPerRow);
                                count++;
                            }
                        }
                        else
                        {
                            itemWidthWithMargin = Draw_Picture_Game(Jsonresponse.titles[i], count, newline, Panel_Compatible, itemWidth, itemWidthWithMargin, itemCountPerRow);
                            count++;

                            /*??? AGAIN
                            line += Jsonresponse.titles[i].modernTitleId + ","
                            + Jsonresponse.titles[i].name + ","
                            + "compatible"
                            //+ Jsonresponse.titles[i].displayImage.ToString()
                            + "\n";*/
                        }

                        //End New
                        if (i == 10) break;
                    }
                }
                /*??? AGAIN if (line != "")
                    SaveFileGameList(line);*/
            }
            catch (HttpRequestException ex)
            {
                if ((int)ex.StatusCode == 401)
                    MessageBox.Show("Couldnt find xauth. Go click the FuckyWucky Fixer button until this doesn't happen.", "401 Unauthorised");
                else
                    MessageBox.Show("something did a fucky wucky and I dont have a specific message for the error code", "fucky wucky");
            }
        }
        private void RenameFile(string sourceFilename, string destinationFilename)
        {
            try
            {
                if (File.Exists(destinationFilename))
                {
                    File.Delete(destinationFilename);
                }
                File.Copy(sourceFilename, destinationFilename);
                File.Delete(sourceFilename);
            }
            catch (Exception)
            {
                MessageBox.Show("Error rename File");
            }
        }
        private bool checkFileExist(string path)
        {
            if (File.Exists(path))
                return true;
            return false;
        }
        private void Load_Incompatibility_Games_Data(string path)
        {
            //PENSAR MEJOR EL TEMA DE COMO COJONES VAS A MANTENER LOS ARCHIVOS BIEN GUARDADOS!
            gamesCompatibles = new Dictionary<string, string>();
            String line;
            try
            {
                //Pass the file path and file name to the StreamReader constructor
                StreamReader sr = new(path);
                //Read the first line of text
                line = sr.ReadLine();
                while (line != null && line != "")
                {
                    string[] row = line.Split(",");
                    if (row[0].ToString() != "")
                        gamesCompatibles[row[0].ToString()] = row[2].ToString();
                    line = sr.ReadLine();
                }
                sr.Close();
            }
            catch (Exception)
            {
                MessageBox.Show(" Error loading incompatible game information");
            }
        }

        private int Draw_Picture_Game(dynamic game, int count, int newline, Panel location, int itemWidth = 150, int itemWidthWithMargin = 0, int itemCountPerRow = 6)
        {
            PictureBox GameImage = new()
            {
                Location = new Point(itemWidthWithMargin * count, newline),
                Size = new Size(itemWidth, 150),
                SizeMode = PictureBoxSizeMode.StretchImage,
                ImageLocation = game.displayImage.ToString() + "?w=512&h=512&format=jpg",
                Name = game.titleId.ToString(),
                Cursor = Cursors.Hand
            };
            GameImage.Click += new EventHandler(this.LoadAchievementList);
            if (count == 0)
                itemWidthWithMargin = GameImage.Width + GameImage.Margin.Left + GameImage.Margin.Right;
            TextBox textbox = new()
            {
                Location = new Point(itemWidthWithMargin * count, 150 + newline),
                Size = new Size(itemWidth, 20),
                BorderStyle = BorderStyle.None,
                Margin = new Padding(this.Margin.Left + 2, 0, this.Margin.Right + 2, 0),
                ReadOnly = true,
                Name = "txt_" + (count + 1),
                Text = game.name,
            };
            TextBox titleidBox = new()
            {
                Location = new Point(itemWidthWithMargin * count, 170 + newline),
                Size = new Size(itemWidth, 20),
                BorderStyle = BorderStyle.None,
                ReadOnly = true,
                Name = "txt_" + game.modernTitleId,
                Text = "TitleID: " + game.modernTitleId
            };

            location.Controls.Add(GameImage);
            location.Controls.Add(textbox);
            location.Controls.Add(titleidBox);
            if (count == 0)
                itemCountPerRow = Convert.ToInt32(Math.Floor(Convert.ToDouble(location.Width)
                    / (itemWidth + GameImage.Margin.Left + GameImage.Margin.Right)));
            return itemWidthWithMargin;
        }

        private static void SaveFileGameList(string line)
        {
            try
            {
                String path = "GamesListAll.csv";
                StreamWriter sw = new(path);
                sw.WriteLine(line);
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
        }
        private void BTN_SpoofGame_Click(object sender, EventArgs e)
        {
            Game_Spoofer SpoofForm = new(dataProfile, dataTitles);
            SpoofForm.Show();
        }
        private void BTN_StatsEditor_Click(object sender, EventArgs e)
        {
            StatsEditor StatsForm = new();
            StatsForm.Show();
        }

        private void LST_GameFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LST_GameFilterType.SelectedIndex == 0)
            {
                //All
                filter1 = "commands";
                filter2 = "commands";
                filter3 = "commands";
                filter4 = "commands";
            }
            else if (LST_GameFilterType.SelectedIndex == 1)
            {
                //Console Only
                filter1 = "Win32";
                filter2 = "commands";
                filter3 = "commands";
                filter4 = "commands";
            }
            else if (LST_GameFilterType.SelectedIndex == 2)
            {
                //New Gen
                filter1 = "Win32";
                filter2 = "Xbox360";
                filter3 = "commands";
                filter4 = "commands";
            }
            else if (LST_GameFilterType.SelectedIndex == 3)
            {
                //Win32
                filter1 = "Xbox360";
                filter2 = "XboxOne";
                filter3 = "XboxSeries";
                filter4 = "commands";
            }
        }

        async void BTN_SaveToFile_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamWriter writer = new("GameList.txt"))
                {
                    for (int i = 0; i < dataTitles.titles.Count; i++)
                    {
                        if (dataTitles.titles[i].modernTitleId.ToString().Length > 0)
                            writer.WriteLine(dataTitles.titles[i].modernTitleId.ToString() + "," + dataTitles.titles[i].name.ToString());
                    }
                }

            }
            catch (HttpRequestException ex)
            {
                if ((int)ex.StatusCode == 401)
                    MessageBox.Show("Couldnt find xauth. Go click the FuckyWucky Fixer button until this doesnt happen.", "401 Unauthorised");
                else
                    MessageBox.Show("something did a fucky wucky and I dont have a specific message for the error code", "fucky wucky");
            }
        }

        private void Skidbox_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", e.LinkText);
        }

        private void BTN_fixer_Click(object sender, EventArgs e)
        {
            TXT_Xauth.Text = "";
            //kill xboxapp.exe
            Process[] processes = Process.GetProcessesByName("XboxPcApp");
            foreach (Process process in processes)
            {
                process.Kill();
            }
            Thread.Sleep(5000);
            //open the uwp xbox app
            Process p = new();
            ProcessStartInfo startInfo = new()
            {
                UseShellExecute = true
            };
            startInfo.FileName = startInfo.FileName = @"shell:appsFolder\Microsoft.GamingApp_8wekyb3d8bbwe!Microsoft.Xbox.App";
            p.StartInfo = startInfo;
            p.Start();
            MessageBox.Show("This might not work first time. Click this button and refresh until it does.", "Fixer");
        }

        private void TXT_Xauth_TextChanged(object sender, EventArgs e)
        {
            BTN_GrabXauth.Enabled = true;
        }
    }
}
