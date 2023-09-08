using Memory;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Timers;
using System.Windows.Forms;
using Xbox_Achievement_Unlocker.Class.Helpers;
using Xbox_Achievement_Unlocker.Class.Objects;
using Xbox_Achievement_Unlocker.Components;
using Xbox_Achievement_Unlocker.Properties;

namespace Xbox_Achievement_Unlocker
{
    public partial class StartApp : Form
    {
        #region Var
        private Mem m = new Mem();
        private static GamerProfile _gamerProfile = new();
        private static Dictionary<string, Game> _games = new();
        private static Game _spoofGame = null;

        #endregion Var


        #region Potting
        internal static GamerProfile GamerProfile { get => _gamerProfile; set => _gamerProfile = value; }
        internal static Dictionary<string, Game> Games { get => _games; set => _games = value; }
        internal static Game SpoofGame { get => _spoofGame; set => _spoofGame = value; }
        #endregion Potting
        public StartApp()
        {
            InitializeComponent();
            double height = Screen.PrimaryScreen.Bounds.Height;
            double width = Screen.PrimaryScreen.Bounds.Width;
            height -= (height * 0.25);
            width -= (width * 0.25);
            this.Size = new Size((int)width, (int)height);
        }

        private void StartApp_Load(object sender, EventArgs e)
        {
            if (m.OpenProcess("XboxPcApp"))
            {
                BTN_ExtracCredentials.Enabled = true;
                BTN_ExtracCredentials_Click(null, null);
            }
        }
        public void Send_Notify()
        {
            NTI_App.Text = "Trex";
            NTI_App.BalloonTipTitle = "Titulo";
            NTI_App.BalloonTipText = "OK";
            NTI_App.BalloonTipIcon = ToolTipIcon.Info;

            NTI_App.Visible = true;
            NTI_App.ShowBalloonTip(30000);
        }

        private async void BTN_ExtracCredentials_Click(object sender, EventArgs e)
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
            Dictionary<string, int> frequency = new Dictionary<string, int>();
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
                BTN_ExtracCredentials_Click(null, null);
            }
            else
            {
                try
                {
                    StartApp.GamerProfile.XAuthToken = mostCommon;
                }
                catch
                {
                    MessageBox.Show("Couldnt find xauth. Go click the FuckyWucky Fixer button until this doesnt happen.");
                    return;
                }
            }
            GetProfileData();
        }

        private async void GetProfileData()
        {
            RequestXbox requestXbox = new();
            await requestXbox.Get_Data("profile", StartApp.GamerProfile.XAuthToken);
            if (requestXbox.JsonResponse != null)
            {
                string PicRaw = requestXbox.JsonResponse.profileUsers[0].settings[2].value;
                string[] split = PicRaw.Split('&');
                StartApp.GamerProfile.XUID = requestXbox.JsonResponse.profileUsers[0].id;
                StartApp.GamerProfile.GamerTag = requestXbox.JsonResponse.profileUsers[0].settings[0].value;
                StartApp.GamerProfile.GamerScore = requestXbox.JsonResponse.profileUsers[0].settings[1].value;
                StartApp.GamerProfile.GameDisplayPicRaw = (split[0] != "" && split[0] != null) ? split[0] : requestXbox.JsonResponse.profileUsers[0].settings[2].value;


                LBL_GamerTag.Text = StartApp.GamerProfile.GamerTag;
                LBL_GameScore.Text = StartApp.GamerProfile.GamerScore;
                PB_GamerPicDisplay.ImageLocation = StartApp.GamerProfile.GameDisplayPicRaw;

                BTN_SaveGameList.Enabled = true;
                BTN_Token.Enabled = true;
                BTN_SaveGameList.BackColor = Program.PrimaryDarkColor;
                BTN_Token.BackColor = Program.PrimaryDarkColor;
                ShowPanelTitle();
            }
        }
        private void ShowPanelTitle()
        {
            PanelTitles panelTitles = new(GamerProfile.XAuthToken, GamerProfile.XUID) { Dock = DockStyle.Fill };
            PNL_LEFT.Controls.Add(panelTitles);
        }

        public static void ShowAchievements(string TitleID, string ImageLocation)
        {

            TabPage NewTabPage = new(Games[TitleID].Name) { Dock = DockStyle.Fill };
            AchievementsList achievementsList = new(
                GamerProfile.XAuthToken, GamerProfile.XUID,
                TitleID, ImageLocation,
                Program.startApp.TABC_Achievements.TabCount)
            { Dock = DockStyle.Fill };

            NewTabPage.Controls.Add(achievementsList);
            Program.startApp.TABC_Achievements.TabPages.Add(NewTabPage);

            Program.startApp.TABC_Achievements.SelectedTab = Program.startApp.TABC_Achievements.TabPages[Program.startApp.TABC_Achievements.TabCount - 1];
            Program.startApp.TABC_Achievements.SelectedTab.Show();

        }

        public static void SendSpooferGame(ref DataGridView DGV_AchievementList)
        {
            // DGV_AchievementList.Sort
        }

        #region Spoofer

        public Stopwatch timer = new Stopwatch();
        private bool spoofActive = false;
        public bool SpoofActive { get => spoofActive; set => spoofActive = value; }
        async void BTN_Spoof_Click(object sender, EventArgs e)
        {

            if (SpoofGame.TitleId == null || SpoofGame.TitleId == "")
            {
                MessageBox.Show("You must select a game.\n Do you want to cause a bug?", "Game not selected", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return;
            }

            BTN_Spoof.Enabled = false;
            BTN_SpoofStop.Enabled = true;
            CHB_Automatic.Enabled = false;
            SpoofingTime.Enabled = true;
            SpoofActive = true;
            timer.Start();
        }

        private void SpoofingTime_Tick(object sender, EventArgs e)
        {

            /*
            LBL_Timer.Text = string.Format("{0:hh\\:mm\\:ss}", timer.Elapsed);
            //LBL_TimeAchievements.Text = Convert.ToString( Math.Truncate((((decimal)timeAchivements * 60) - timerLeft)/60)) + " Minutes"; //Tiempo restante
            if (CHB_Automatic.Checked && timerLeft == (timeAchivements * 60))
            {
                ShortByPercent();
                BTN_Unlock_Click(new object(), new EventArgs());
                timerLeft = 0;
            }

            if (timerSendSpoof == 60)
            {
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Add("x-xbl-contract-version", "3");
                client.DefaultRequestHeaders.Add("accept", "application/json");
                client.DefaultRequestHeaders.Add("Authorization", MainWindow.xauthtoken);

                StringContent requestbody = new StringContent("{\"titles\":[{\"expiration\":600,\"id\":" + TitleID + ",\"state\":\"active\",\"sandbox\":\"RETAIL\"}]}", encoding: Encoding.UTF8, "application/json");
                client.PostAsync("https://presence-heartbeat.xboxlive.com/users/xuid(" + MainWindow.xuid + ")/devices/current", requestbody);
                timerSendSpoof = 0;
            }

            timerLeft++;
            timerSendSpoof++;
            */
        }
        private void BTN_SpoofStop_Click(object sender, EventArgs e)
        {

            SpoofingTime.Enabled = false;
            SpoofActive = false;
            timer.Stop();
            timer.Reset();
            BTN_SpoofStop.Enabled = false;
            BTN_Spoof.Enabled = true;
            CHB_Automatic.Enabled = true;
            LBL_Timer.Text = "00:00:00";
        }

        #endregion Spoofer
        private void BTN_ReloadXboxApp_Click(object sender, EventArgs e)
        {
            BTN_ExtracCredentials.BackColor = Program.PrimaryLigthColor;
            BTN_ExtracCredentials.Enabled = true;

            Process[] processes = Process.GetProcessesByName("XboxPcApp");
            foreach (Process process in processes)
                process.Kill();

            Thread.Sleep(5000);
            //open the uwp xbox app
            ProcessStartInfo startInfo = new()
            {
                UseShellExecute = true,
                FileName = @"shell:appsFolder\Microsoft.GamingApp_8wekyb3d8bbwe!Microsoft.Xbox.App"
            };

            Process p = new() { StartInfo = startInfo };
            p.Start();

            Thread.Sleep(5000);
            StartApp_Load(sender, e);
        }

        private void CopyInfoClipBoard(object sender, EventArgs e)
        {
            Button button = sender as Button;
            string text = (button.Text == "Token") ? StartApp.GamerProfile.XAuthToken : StartApp.GamerProfile.XUID;
            Clipboard.SetText(text);
        }

        private void TABC_Achievements_DrawItem(object sender, DrawItemEventArgs e)
        {
            Image closeImage;
            Size mysize = new Size(15, 15); // co anh chen vao
            Bitmap bt = new Bitmap(Resources.Close);
            // anh nay ban dau minh da them vao
            Bitmap btm = new Bitmap(bt, mysize);
            closeImage = btm;
            Rectangle rect = TABC_Achievements.GetTabRect(e.Index);
            Rectangle imagerec = new Rectangle(
                rect.Right - closeImage.Width,
                rect.Top + (rect.Height - closeImage.Width) / 2,
                closeImage.Width, closeImage.Height);
            rect.Size = new Size(rect.Width + 40, 20);
            Font f = new Font("Century Gothic", 9, FontStyle.Regular);
            Brush br = Brushes.Black;
            StringFormat strF = new StringFormat(StringFormat.GenericDefault);
            e.Graphics.DrawImage(closeImage, imagerec);
            e.Graphics.DrawString(TABC_Achievements.TabPages[e.Index].Text, f, br, rect, strF);
        }

        private void TABC_Achievements_MouseClick(object sender, MouseEventArgs e)
        {
            TABC_Achievements.TabPages.Remove(TABC_Achievements.SelectedTab);
            /*for (int i = 0; i < TABC_Achievements.TabCount; i++)
            {
                // giong o DrawItem
                Rectangle rect = TABC_Achievements.GetTabRect(i);
                Rectangle imageRec = new Rectangle(rect.Right - TABC_Achievements.Width,
                    rect.Top + (rect.Height - TABC_Achievements.Height) / 2,
                    TABC_Achievements.Width, TABC_Achievements.Height);

                if (imageRec.Contains(e.Location))
            }*/
        }

        public static void ChangeEnableControl(object Ctrl, bool ChangeStatus)
        {
            //Ctrl.Enable = ChangeStatus;
        }
    }
}
