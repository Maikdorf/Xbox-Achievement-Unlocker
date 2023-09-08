using System;
using System.Windows.Forms;
using Xbox_Achievement_Unlocker.Class.Helpers;
using Xbox_Achievement_Unlocker.Class.Objects;

namespace Xbox_Achievement_Unlocker.Components
{
    public partial class PanelTitles : UserControl
    {
        private string _token;
        private string _xuid;
        public PanelTitles(string Token, string Xuid)
        {
            _token = Token;
            _xuid = Xuid;
            InitializeComponent();
        }

        public string Token { get => _token; set => _token = value; }
        public string Xuid { get => _xuid; set => _xuid = value; }

        private async void PanelTitles_Load(object sender, EventArgs e)
        {
            RequestXbox requestXbox = new();
            await requestXbox.Get_Data("titles", Token, Xuid);
            for (int i = 0; i < requestXbox.JsonResponse.titles.Count; i++)
            {
                Game newGame = new()
                {
                    Name = requestXbox.JsonResponse.titles[i].name.ToString(),
                    DisplayImage = requestXbox.JsonResponse.titles[i].displayImage.ToString(),
                    TitleId = requestXbox.JsonResponse.titles[i].titleId.ToString(),
                    ModernTitleId = requestXbox.JsonResponse.titles[i].modernTitleId.ToString(),
                    ProgressPercentage = Int32.Parse(requestXbox.JsonResponse.titles[i].achievement.progressPercentage.ToString()),
                    TotalGamerscore = requestXbox.JsonResponse.titles[i].achievement.totalGamerscore.ToString(),
                    CurrentAchievements = requestXbox.JsonResponse.titles[i].achievement.currentAchievements.ToString()
                };
                CardGame newCardGame = new()
                {
                    TittleGame = newGame.Name,
                    ImageLocationGame = newGame.DisplayImage,
                    ProgressPercentage = newGame.ProgressPercentage,
                    TitleID = newGame.TitleId,
                    CurrentGameScore = " / " + newGame.TotalGamerscore,
                    CountAchievements = "12"
                };

                FLP_ListGames.Controls.Add(newCardGame);
                if (!StartApp.Games.ContainsKey(newGame.TitleId))
                {
                    StartApp.Games.Add(newGame.TitleId, newGame);
                }
                if (i == 20) break;
            }
            FLP_ListGames.BackColor = Program.PrimaryLigthColor;
        }

        private void TAB_TitlesGames_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(sender.ToString());
        }
    }
}
