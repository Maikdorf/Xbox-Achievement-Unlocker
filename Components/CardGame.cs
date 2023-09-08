using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Xbox_Achievement_Unlocker.Components
{
    public partial class CardGame : UserControl
    {
        public CardGame()
        {
            InitializeComponent();
        }

        private int _progressPercentage = 0;
        private string _titleGame = string.Empty;
        private string _imageLocationGame = string.Empty;
        private string _titleID = string.Empty;
        private string _countAchievements = string.Empty;
        private string _currentGameScore = string.Empty;

        [Category("Custom Props")]
        public string TittleGame { get => _titleGame; set { _titleGame = value; LBL_TitleName.Text = value; } }

        [Category("Custom Props")]
        public string ImageLocationGame { get => _imageLocationGame; set { _imageLocationGame = value; PB_GamePic.ImageLocation = value; } }

        [Category("Custom Props")]
        public int ProgressPercentage { get => _progressPercentage; set { _progressPercentage = value; PBAR_Complete.Value = value; } }

        [Category("Custom Props")]
        public string TitleID { get => _titleID; set { _titleID = value; BTN_CopyTitleId.Text = value; } }

        [Category("Custom Props")]
        public string CountAchievements { get => _countAchievements; set { _countAchievements = value; LBL_CountAchievements.Text = value; } }

        [Category("Custom Props")]
        public string CurrentGameScore { get => _currentGameScore; set { _currentGameScore = value; LBL_Current_GameScore.Text = value; } }

        private void BTN_CopyTitleId_Click(object sender, EventArgs e)
        {
            Button titleId = sender as Button;
            Clipboard.SetText(titleId.Text);
        }

        private void ShowAchievementsGame(object sender, EventArgs e)
        {
            StartApp.ShowAchievements(TitleID, ImageLocationGame);
        }
    }
}
