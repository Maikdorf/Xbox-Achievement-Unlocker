using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xbox_Achievement_Unlocker.Class.Helpers;
using Xbox_Achievement_Unlocker.Class.Objects;

namespace Xbox_Achievement_Unlocker.Components
{
    public partial class AchievementsList : UserControl
    {
        private string _token;
        private string _xuid;
        private string _titleID;
        private string _imageLocation;
        private int _tabPanelParent;
        private bool _spoofActive = false;
        private string _scid;

        private List<string> AchievementIDs = new List<string>();

        private Dictionary<string, int> CountAchievementsTypes = new Dictionary<string, int>() {
            {"timeAchivements" , 0 },
            {"countAchivements" , 0 },
            {"CountAchived" , 0 },
            {"CountNoAchived" , 0 }
        };
        public int timerLeft, TimeSlapsed,
             numRowChecked = -1, timerSendSpoof = 60;
        public AchievementsList(string Token, string Xuid, string TitleID, string ImageLocation, int TabPanelParent)
        {
            _tabPanelParent = TabPanelParent;
            _token = Token;
            _xuid = Xuid;
            _titleID = TitleID;
            _imageLocation = ImageLocation;
            InitializeComponent();
        }

        public string Token { get => _token; set => _token = value; }
        public string Xuid { get => _xuid; set => _xuid = value; }
        public string TitleID { get => _titleID; set => _titleID = value; }
        public string ImageLocation { get => _imageLocation; set => _imageLocation = value; }
        public int TabPanelParent { get => _tabPanelParent; set => _tabPanelParent = value; }
        public bool SpoofActive { get => _spoofActive; set => _spoofActive = value; }
        public string Scid { get => _scid; set => _scid = value; }

        private async void AchievementsList_Load(object sender, EventArgs e)
        {
            RequestXbox rqXbox = new();
            await rqXbox.Get_Data("achievements", Token, Xuid, TitleID);
            if (rqXbox.JsonResponse != null)
            {
                if (rqXbox.JsonResponse.achievements.Count == 0)
                {
                    //TODO::: MARCAR EL GAME COMO INCOMPATIBLE
                    MessageBox.Show("this game has no achivements", "fucky wucky");
                }
                else
                {
                    /*gameImage.ImageLocation = (ImageLocation != "") ? ImageLocation : "";
                    TitleName = rqXbox.JsonResponse.achievements[0].titleAssociations[0].name.ToString();
                    TitleID = rqXbox.JsonResponse.achievements[0].titleAssociations[0].id.ToString();
                    this.Text = rqXbox.JsonResponse;
                    LBL_TID_UIXD.Text = TitleID;*/

                    //SCID = rqXbox.JsonResponse.achievements[0].serviceConfigId.ToString();
                    Scid = rqXbox.JsonResponse.achievements[0].serviceConfigId.ToString();
                    PB_AchievementsList.ImageLocation = ImageLocation;
                    LBL_TID.Text = rqXbox.JsonResponse.achievements[0].titleAssociations[0].name.ToString();
                    int achieved;
                    //lblLink_completationTime.Visible = true;

                    for (int i = 0; i < rqXbox.JsonResponse.achievements.Count; i++)
                    {
                        if (rqXbox.JsonResponse.achievements[i].progression.requirements.Count != 0 &&
                            rqXbox.JsonResponse.achievements[i].progression.requirements[0].id != "00000000-0000-0000-0000-000000000000")
                        {
                            MessageBox.Show("THIS GAME USES EVENT BASED ACHIVEMENTS.\nTHIS TOOL WILL CURRENTLY NOT WORK", "Warning");
                            break;
                        }

                        if (rqXbox.JsonResponse.achievements[i].progressState.ToString() == "Achieved")
                        {
                            CountAchievementsTypes["CountAchived"]++;
                            achieved = 1;
                        }
                        else achieved = 0;

                        try
                        {
                            DGV_AchievementList.Rows.Add(
                                achieved,
                                Convert.ToDecimal(rqXbox.JsonResponse.achievements[i].rarity.currentPercentage.ToString()),
                                rqXbox.JsonResponse.achievements[i].name.ToString(),
                                rqXbox.JsonResponse.achievements[i].description.ToString(),
                                rqXbox.JsonResponse.achievements[i].rewards[0].value.ToString(),
                                rqXbox.JsonResponse.achievements[i].progression.timeUnlocked.ToString(),
                                Convert.ToInt32(rqXbox.JsonResponse.achievements[i].id)
                            );
                        }
                        catch
                        {
                            DGV_AchievementList.Rows.Add(0,
                                rqXbox.JsonResponse.achievements[i].name.ToString(),
                                rqXbox.JsonResponse.achievements[i].description.ToString(),
                                "There was a problem grabbing stats for this achievement.\n\n\n\n\n",
                                Convert.ToInt32(rqXbox.JsonResponse.achievements[i].id)
                            );
                        }
                    }
                    CountAchievementsTypes["countAchivements"] = rqXbox.JsonResponse.achievements.Count;
                    string timeTrueAchiv = statsTrueAchivements(rqXbox.JsonResponse.achievements[0].titleAssociations[0].name.ToString());
                    if (timeTrueAchiv != "No Data!" && timeTrueAchiv != "Error Data!" && timeTrueAchiv != "" && timeTrueAchiv != null)
                        calculateTimeAchievements(timeTrueAchiv);
                    lblLink_completationTime.Text = "Completion Time:    " + timeTrueAchiv;
                }
            }
        }

        public string statsTrueAchivements(string nameGame)
        {
            try
            {
                string[] scapeCharacter = { "'", "®", "™", "’", ":", "(", ")", "-", "!" };
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
                return "Error Data!";
                throw;
            }
        }

        public void calculateTimeAchievements(string timeTrueAchiv)
        {
            string[] time = timeTrueAchiv.Replace(" hours", "").Replace(" hour", "").Split("-");
            time[1] = (time[1] != null && time[1] != "") ? time[1].Replace(".", ",") : "1";
            double min = Double.Parse(time[1]) * 60;
            CountAchievementsTypes["timeAchivements"] = (int)Math.Truncate((min / CountAchievementsTypes["countAchivements"]) + 1);
            timerLeft = CountAchievementsTypes["timeAchivements"];
            TimeSlapsed = CountAchievementsTypes["CountAchived"] * CountAchievementsTypes["timeAchivements"];
            int hours = ((TimeSlapsed - TimeSlapsed % 60) / 60);
            string hoursText = (hours < 10) ? "0" + Convert.ToString(hours) : Convert.ToString(hours);
            string minutesText = ((TimeSlapsed - hours * 60) < 10) ? "0" + Convert.ToString((TimeSlapsed - hours * 60)) : Convert.ToString((TimeSlapsed - hours * 60));
            LBL_TimeSlapsed.Text = "Time Lapsed Aprox: " + hoursText + ":" + minutesText + ":00";
            LBL_TimeAchievements.Text = "Every " + Convert.ToString(CountAchievementsTypes["timeAchivements"]) + " min a unlock";
        }

        private void BTN_LaunchSpoof_Click(object sender, EventArgs e)
        {
            StartApp.SpoofGame.Scid = Scid;
            StartApp.SpoofGame.TitleId = TitleID;
            StartApp.SendSpooferGame(ref DGV_AchievementList);
        }

        private void BTN_Unlock_Click(object sender, EventArgs e)
        {
            if (AchievementIDs.Count == 0)
                MessageBox.Show("Select Achivements");
            else
            {
                string BodyString = string.Empty;
                foreach (string id in AchievementIDs)
                    BodyString += "{\"id\":\"" + id + "\",\"percentComplete\":\"100\"},";


                RequestXbox rqXbox = new();
                rqXbox.Set_Data("unlock", StartApp.GamerProfile.XAuthToken, BodyString, StartApp.GamerProfile.XUID, TitleID, Scid);
                AchievementIDs.Clear();
            }
        }

        private void DGV_AchievementList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            if ((int)DGV_AchievementList.Rows[e.RowIndex].Cells[0].Value == 0)
            {
                DGV_AchievementList.Rows[e.RowIndex].Cells[0].Value = 1;
                AchievementIDs.Add(DGV_AchievementList.Rows[e.RowIndex].Cells["CL_ID"].Value.ToString());
            }
            else if ((int)DGV_AchievementList.Rows[e.RowIndex].Cells[0].Value == 1)
            {
                DGV_AchievementList.Rows[e.RowIndex].Cells[0].Value = 0;
                AchievementIDs.Remove(DGV_AchievementList.Rows[e.RowIndex].Cells["CL_ID"].Value.ToString());
            }
        }

        private void BTN_Refresh_Click(object sender, EventArgs e)
        {
            DGV_AchievementList.Rows.Clear();
            AchievementsList_Load(null, null);
        }
    }
}
