﻿using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Memory;
using System.Threading;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using System.Reflection.Emit;
using System.Diagnostics;
using System.Net;

namespace Xbox_Achievement_Unlocker
{
    public partial class AchievementList : Form
    {
        public Stopwatch timer = new Stopwatch();
        public AchievementList()
        {
            InitializeComponent();
        }
        //string currentSystemLanguage = System.Globalization.CultureInfo.CurrentCulture.Name;
        string currentSystemLanguage = "en-US";
        public List<string> AchievementIDs = new List<string>();
        static HttpClientHandler handler = new HttpClientHandler()
        {
            AutomaticDecompression = System.Net.DecompressionMethods.GZip | System.Net.DecompressionMethods.Deflate
        };
        HttpClient client = new HttpClient(handler);
        bool active;
        string SCID;
        string TitleID, TitleName;
        string responseString, urlPicture_global_temp;
        List<string> UnlockableAchievements = new List<string>();


        #region bright warning shit for stupid people
        private const int RainbowLength = 360;
        private readonly Color[] Rainbow = new Color[RainbowLength];
        private void InitRainbow()
        {
            for (int i = 0; i < RainbowLength; i++)
            {
                Rainbow[i] = ColorFromHSV(i, 1, 1);
            }
        }

        private async void StartFlashing()
        {
            while (true)
            {
                for (int i = 0; i < RainbowLength; i++)
                {
                    label1.ForeColor = Rainbow[i];
                    await Task.Delay(1);
                }
            }
        }

        private Color ColorFromHSV(double hue, double saturation, double value)
        {
            int hi = Convert.ToInt32(Math.Floor(hue / 60)) % 6;
            double f = hue / 60 - Math.Floor(hue / 60);

            value = value * 255;
            int v = Convert.ToInt32(value);
            int p = Convert.ToInt32(value * (1 - saturation));
            int q = Convert.ToInt32(value * (1 - f * saturation));
            int t = Convert.ToInt32(value * (1 - (1 - f) * saturation));

            if (hi == 0) return Color.FromArgb(255, v, t, p);
            else if (hi == 1) return Color.FromArgb(255, q, v, p);
            else if (hi == 2) return Color.FromArgb(255, p, v, t);
            else if (hi == 3) return Color.FromArgb(255, p, q, v);
            else if (hi == 4) return Color.FromArgb(255, t, p, v);
            else return Color.FromArgb(255, v, p, q);
        }


        #endregion

        public string statsTrueAchivements(string nameGame)
        {
            try
            {
                string[] scapeCharacter = { "'", "®", "™", "’", ":", "(", ")", "-" };
                foreach (var character in scapeCharacter)
                    nameGame = nameGame.Replace(character, "");
                
                nameGame = nameGame.Replace(" ", "-");
                HtmlAgilityPack.HtmlWeb web = new();
                HtmlAgilityPack.HtmlDocument doc = web.Load("https://www.trueachievements.com/game/" + nameGame + "/completiontime");
                if (doc.DocumentNode.SelectNodes("//*[@id=\"divInfo\"]/p[1]/strong") != null)
                {
                    foreach (var item in doc.DocumentNode.SelectNodes("//*[@id=\"divInfo\"]/p[1]/strong"))
                    {
                        return item.InnerText.ToString();
                    }
                }
                return "No Data!";
            }
            catch
            {
                return "No Data!";
                throw;
            }
        }

        public async void PopulateAchievementList(string AchievementData, string urlPicture = "")
        {

            var Jsonresponse = (dynamic)(new JObject());
            Jsonresponse = (dynamic)JObject.Parse(AchievementData);
            if (Jsonresponse.achievements.Count == 0)
            {
                Close();
                MessageBox.Show("this game has no achivements", "fucky wucky");
            }
            else
            {
                urlPicture_global_temp = (urlPicture != "") ? urlPicture : urlPicture_global_temp;
                gameImage.ImageLocation = urlPicture_global_temp;
                SCID = Jsonresponse.achievements[0].serviceConfigId.ToString();
                TitleName = Jsonresponse.achievements[0].titleAssociations[0].name.ToString();
                TitleID = Jsonresponse.achievements[0].titleAssociations[0].id.ToString();
                this.Text = TitleName;
                LBL_TID.Text = TitleName;
                LBL_TID_UIXD.Text = TitleID;
                int achieved;
                lblLink_completationTime.Visible = true;
                lblLink_completationTime.Text = "Completion Time: " + statsTrueAchivements(TitleName);
                for (int i = 0; i < Jsonresponse.achievements.Count; i++)
                {
                    if (Jsonresponse.achievements[i].progression.requirements.Count != 0 && 
                        Jsonresponse.achievements[i].progression.requirements[0].id != "00000000-0000-0000-0000-000000000000")
                    {
                        InitRainbow();
                        MessageBox.Show("THIS GAME USES EVENT BASED ACHIVEMENTS.\nTHIS TOOL WILL CURRENTLY NOT WORK", "Warning");
                        label1.Visible = true;
                        StartFlashing();
                        break;
                    }                        
                    achieved = (Jsonresponse.achievements[i].progressState.ToString() == "Achieved") ? 2 : 0;
                    try
                    {
                        DGV_AchievementList.Rows.Add(
                            achieved,
                            Convert.ToDecimal(Jsonresponse.achievements[i].rarity.currentPercentage.ToString()),
                            Jsonresponse.achievements[i].name.ToString(),
                            Jsonresponse.achievements[i].description.ToString(),
                            "Gamerscore: " + Jsonresponse.achievements[i].rewards[0].value.ToString() +
                            "\nUnlock Time: " + Jsonresponse.achievements[i].progression.timeUnlocked.ToString(),
                            Convert.ToInt32(Jsonresponse.achievements[i].id)
                        );
                    }
                    catch
                    {
                        DGV_AchievementList.Rows.Add(0,
                            Jsonresponse.achievements[i].name.ToString(),
                            Jsonresponse.achievements[i].description.ToString(),
                            "There was a problem grabbing stats for this achievement.\n\n\n\n\n",
                            Convert.ToInt32(Jsonresponse.achievements[i].id)
                        );
                    }
                }
            }
        }
        void SelectAchievement(object sender, EventArgs e)
        {
            CheckBox SelectedAchievement = (sender as CheckBox);
            if (SelectedAchievement.Checked)
            {
                AchievementIDs.Add(SelectedAchievement.Name);
            }
            else
            {
                AchievementIDs.Remove(SelectedAchievement.Name);
            }
        }
        private void CheckBox_Images_CheckedChanged(object sender, EventArgs e)
        {
            //dont even know if I can put images in a data grid view lmao
        }

        void BTN_Unlock_Click(object sender, EventArgs e)
        {
            var requestbody = "{\"action\":\"progressUpdate\",\"serviceConfigId\":\"" + SCID + "\",\"titleId\":\"" + TitleID + "\",\"userId\":\"" + MainWindow.xuid + "\",\"achievements\":[";

            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Add("x-xbl-contract-version", "2");
            client.DefaultRequestHeaders.Add("Accept-Encoding", "gzip, deflate");
            client.DefaultRequestHeaders.Add("accept", "application/json");
            client.DefaultRequestHeaders.Add("accept-language", currentSystemLanguage);
            client.DefaultRequestHeaders.Add("Authorization", MainWindow.xauthtoken);
            client.DefaultRequestHeaders.Add("Host", "achievements.xboxlive.com");
            client.DefaultRequestHeaders.Add("Connection", "Keep-Alive");
            client.DefaultRequestHeaders.Add("User-Agent", "XboxServicesAPI/2021.10.20211005.0 c");
            client.DefaultRequestHeaders.Add("Signature", "RGFtbklHb3R0YU1ha2VUaGlzU3RyaW5nU3VwZXJMb25nSHVoLkRvbnRFdmVuS25vd1doYXRTaG91bGRCZUhlcmVEcmFmZlN0cmluZw==");
            //
            if (AchievementIDs.Count == 0)
            {
                MessageBox.Show("Select Achivements");
            }
            else
            {
                foreach (string id in AchievementIDs)
                {
                    requestbody = requestbody + "{\"id\":\"" + id + "\",\"percentComplete\":\"100\"},";
                }
                requestbody = requestbody.Remove(requestbody.Length - 1) + "]}";
                var bodyconverted = new StringContent(requestbody, Encoding.UTF8, "application/json");
                try
                {
                    client.PostAsync("https://achievements.xboxlive.com/users/xuid(" + MainWindow.xuid + ")/achievements/" + SCID + "/update", bodyconverted);
                }
                catch (HttpRequestException ex)
                {
                    if ((int)ex.StatusCode == 401)
                        MessageBox.Show("Xauth is not correct. Click the FuckyWucky Fixer button until the error goes away", "401 Unauthorised");
                    else
                        MessageBox.Show("something did a fucky wucky and I dont have a specific message for the error code", "fucky wucky");
                }


            }
        }

        private void BTN_UnlockAll_Click(object sender, EventArgs e)
        {

            var Jsonresponse = (dynamic)JObject.Parse(MainWindow.responseString);
            //create list for unlock all
            for (int i = 0; i < Jsonresponse.achievements.Count; i++)
            {
                if (Jsonresponse.achievements[i].progressState.ToString() != "Achieved")
                {
                    UnlockableAchievements.Add(Jsonresponse.achievements[i].id.ToString());
                }
            }

            var requestbody = "{\"action\":\"progressUpdate\",\"serviceConfigId\":\"" + SCID + "\",\"titleId\":\"" + TitleID + "\",\"userId\":\"" + MainWindow.xuid + "\",\"achievements\":[";

            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Add("x-xbl-contract-version", "2");
            client.DefaultRequestHeaders.Add("Accept-Encoding", "gzip, deflate");
            client.DefaultRequestHeaders.Add("accept", "application/json");
            client.DefaultRequestHeaders.Add("accept-language", currentSystemLanguage);
            client.DefaultRequestHeaders.Add("Authorization", MainWindow.xauthtoken);
            client.DefaultRequestHeaders.Add("Host", "achievements.xboxlive.com");
            client.DefaultRequestHeaders.Add("Connection", "Keep-Alive");
            client.DefaultRequestHeaders.Add("User-Agent", "XboxServicesAPI/2021.04.20210610.3 c");

            for (int i = 0; i < UnlockableAchievements.Count; i++)
            {
                requestbody = requestbody + "{\"id\":\"" + UnlockableAchievements[i] + "\",\"percentComplete\":\"100\"},";


                if (i % 50 == 0 || i == UnlockableAchievements.Count || i != 0)
                {
                    requestbody = requestbody.Remove(requestbody.Length - 1) + "]}";
                    var bodyconverted = new StringContent(requestbody);
                    try
                    {
                        client.PostAsync("https://achievements.xboxlive.com/users/xuid(" + MainWindow.xuid + ")/achievements/" + SCID + "/update", bodyconverted);
                    }
                    catch (HttpRequestException ex)
                    {
                        if ((int)ex.StatusCode == 401)
                            MessageBox.Show("Xauth is not correct. Click the FuckyWucky Fixer button until the error goes away", "401 Unauthorised");
                        else
                            MessageBox.Show("something did a fucky wucky and I dont have a specific message for the error code", "fucky wucky");
                    }

                    requestbody = "{\"action\":\"progressUpdate\",\"serviceConfigId\":\"" + SCID + "\",\"titleId\":\"" + TitleID + "\",\"userId\":\"" + MainWindow.xuid + "\",\"achievements\":[";
                }
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0
                || e.ColumnIndex < 0)
                return;

            if ((int)DGV_AchievementList.Rows[e.RowIndex].Cells[0].Value == 0)
            {
                AchievementIDs.Add(DGV_AchievementList.Rows[e.RowIndex].Cells["CL_ID"].Value.ToString());
                DGV_AchievementList.Rows[e.RowIndex].Cells[0].Value = 1;
            }
            else if ((int)DGV_AchievementList.Rows[e.RowIndex].Cells[0].Value == 1)
            {
                DGV_AchievementList.Rows[e.RowIndex].Cells[0].Value = 0;
                AchievementIDs.Remove(DGV_AchievementList.Rows[e.RowIndex].Cells["CL_ID"].Value.ToString());
            }

        }

        private void Check_UnlockAll_CheckedChanged(object sender, EventArgs e)
        {
            if (Check_UnlockAll.Checked)
            {
                BTN_UnlockAll.Enabled = true;
            }
            else
            {
                BTN_UnlockAll.Enabled = false;
            }
        }

        async void BTN_ALRefresh_Click(object sender, EventArgs e)
        {
            await RefreshList();
        }

        private async Task RefreshList()
        {
            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Add("x-xbl-contract-version", "4");
            client.DefaultRequestHeaders.Add("Accept-Encoding", "gzip, deflate");
            client.DefaultRequestHeaders.Add("accept", "application/json");
            client.DefaultRequestHeaders.Add("accept-language", currentSystemLanguage);
            client.DefaultRequestHeaders.Add("Authorization", MainWindow.xauthtoken);
            client.DefaultRequestHeaders.Add("Host", "achievements.xboxlive.com");
            client.DefaultRequestHeaders.Add("Connection", "Keep-Alive");
            DGV_AchievementList.Rows.Clear();
            responseString = await client.GetStringAsync("https://achievements.xboxlive.com/users/xuid(" + MainWindow.xuid + ")/achievements?titleId=" + TitleID + "&maxItems=1000");
            PopulateAchievementList(responseString);
        }

        private async void AchievementList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
                await RefreshList();

        }

        #region Incrusted Game Spoofer

        async void BTN_Spoof_Click(object sender, EventArgs e)
        {
            if (TitleID == null)
            {
                MessageBox.Show("You must select a game.\n Do you want to cause a bug?", "Game not selected", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return;
            }

            BTN_Spoof.Enabled = false;
            BTN_SpoofStop.Enabled = true;
            string uuiGame = TitleID;
            Task.Run(() => Spoofing(uuiGame));
        }

        public async Task Spoofing(string uuiGame)
        {
            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Add("x-xbl-contract-version", "3");
            client.DefaultRequestHeaders.Add("accept", "application/json");
            client.DefaultRequestHeaders.Add("Authorization", MainWindow.xauthtoken);

            var requestbody = new StringContent("{\"titles\":[{\"expiration\":600,\"id\":" + uuiGame + ",\"state\":\"active\",\"sandbox\":\"RETAIL\"}]}", encoding: Encoding.UTF8, "application/json");
            timer.Start();
            active = true;
            while (active)
            {
                if (!active) break;
                await client.PostAsync("https://presence-heartbeat.xboxlive.com/users/xuid(" + MainWindow.xuid + ")/devices/current", requestbody);
                Thread.Sleep(1000);
            }
            var i = 0;
            active = true;
            while (active)
            {
                if (i == 60)
                {
                    await client.PostAsync("https://presence-heartbeat.xboxlive.com/users/xuid(" + MainWindow.xuid + ")/devices/current", requestbody);
                    i = 0;
                }
                else
                {
                    if (!active)
                    {
                        break;
                    }
                    i++;
                }
                Thread.Sleep(1000);

            }
            BTN_Spoof.Invoke(new Action(() => BTN_Spoof.Enabled = true));
            BTN_SpoofStop.Invoke(new Action(() => BTN_SpoofStop.Enabled = false));
        }

        private void BTN_SpoofStop_Click(object sender, EventArgs e)
        {
            active = false;
            timer.Stop();
            timer.Reset();
            LBL_Timer.Text = "00:00:00";
        }

        private void SpoofingTime_Tick(object sender, EventArgs e)
        {
            LBL_Timer.Text = string.Format("{0:hh\\:mm\\:ss}", timer.Elapsed);
        }
        #endregion


    }
}
