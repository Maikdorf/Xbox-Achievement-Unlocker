using Memory;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using Xbox_Achievement_Unlocker.Class.Helpers;

namespace Xbox_Achievement_Unlocker.Components
{
    public partial class PanelProfile : UserControl
    {
        private string _xuid = "hola";
        private string _token = "hola mindo";
        public Mem m = new Mem();
        static bool _loadFirst = false;
        public PanelProfile()
        {
            InitializeComponent();
        }


        public string Xuid { get => _xuid; set => _xuid = value; }
        public string Token { get => _token; set => _token = value; }
        public static bool LoadFirst { get => _loadFirst; set => _loadFirst = value; }

        private void CopyInfoClipBoard(object sender, EventArgs e)
        {
            Button button = sender as Button;
            string text = (button.Text == "Token") ? Token : Xuid;
            Clipboard.SetText(text);

            //Convert Method
            LBL_Copied.Visible = true;
            Thread.Sleep(1000);
            LBL_Copied.Visible = false;
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
                    Token = mostCommon;
                    GetProfileData();
                }
                catch
                {
                    MessageBox.Show("Couldnt find xauth. Go click the FuckyWucky Fixer button until this doesnt happen.");
                }
            }
        }

        private async void GetProfileData()
        {
            RequestXbox requestXbox = new();
            await requestXbox.Get_Data("profile", Token);
            string PicRaw = requestXbox.JsonResponse.profileUsers[0].settings[2].value;
            string[] split = PicRaw.Split('&');

            Main.GamerProfile.XAuthToken = Token;
            Main.GamerProfile.XUID = requestXbox.JsonResponse.profileUsers[0].id;
            Main.GamerProfile.GamerTag = requestXbox.JsonResponse.profileUsers[0].settings[0].value;
            Main.GamerProfile.GamerScore = requestXbox.JsonResponse.profileUsers[0].settings[1].value;
            Main.GamerProfile.GameDisplayPicRaw = (split[1] != "" && split[1] != null) ? split[1] : string.Empty;


            LBL_GamerTag.Text = Main.GamerProfile.GamerTag;
            LBL_GameScore.Text = Main.GamerProfile.GamerScore;
            PB_GamerPic.Text = Main.GamerProfile.GameDisplayPicRaw;

            LoadFirst = true;
            BTN_SaveGameList.Enabled = true;
            BTN_Token.Enabled = true;
            BTN_SaveGameList.BackColor = Program.PrimaryDarkColor;
            BTN_Token.BackColor = Program.PrimaryDarkColor;
        }

        private void PanelProfile_Load(object sender, EventArgs e)
        {
            if (m.OpenProcess("XboxPcApp"))
            {
                BTN_ExtracCredentials.BackColor = Program.PrimaryDarkColor;
                BTN_ExtracCredentials.Enabled = true;
            }
        }

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
            PanelProfile_Load(sender, e);
        }

        private void BTN_SaveGameList_Click(object sender, EventArgs e)
        {

        }
    }
}
