using Memory;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using Xbox_Achievement_Unlocker.Class.Objects;
using Xbox_Achievement_Unlocker.Components;
using Xbox_Achievement_Unlocker.CustomControls;

namespace Xbox_Achievement_Unlocker
{
    public partial class Main : Form
    {
        public Point MouseLocation;
        public Mem m = new();
        private PanelProfile _pnl_Profile = new();
        private static GamerProfile _gamerProfile = new();
        private static Dictionary<string, Game> _games = new();



        internal static GamerProfile GamerProfile { get => _gamerProfile; set => _gamerProfile = value; }
        internal static Dictionary<string, Game> Games { get => _games; set => _games = value; }
        public PanelProfile PNL_Profile { get => _pnl_Profile; set => _pnl_Profile = value; }
        public Main()
        {
            InitializeComponent();
        }


        public void MenuSelected(object sender, EventArgs e)
        {
            ButtomRadius Me = sender as ButtomRadius;
            BTN_Menu_Profile.Location = new Point(11, BTN_Menu_Profile.Location.Y);
            BTN_Menu_Games.Location = new Point(11, BTN_Menu_Games.Location.Y); ;
            BTN_Menu_Achivements.Location = new Point(11, BTN_Menu_Achivements.Location.Y); ;
            BTN_Menu_About.Location = new Point(11, BTN_Menu_About.Location.Y);

            Me.Location = new Point(20, Me.Location.Y);
            PB_Splash.Location = new Point(150, Me.Location.Y - 13);


            //Add Panel Control
            switch (Me.Text)
            {
                case "Profile":
                    PNL_Profile.Visible = true;
                    break;
                case "Games":
                    PNL_Profile.Visible = false;
                    if (PanelProfile.LoadFirst)
                    {
                        PanelTitles _pnl_Titles = new(GamerProfile.XAuthToken,GamerProfile.XUID);
                        _pnl_Titles.Dock = DockStyle.Fill;
                        PNL_Content.Controls.Add(_pnl_Titles);
                    }
                    break;
                default:
                    //PNL_Content.Controls.add
                    break;
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            LBL_GamerTag.Text = GamerProfile.GamerTag;
            LBL_GameScore.Text = GamerProfile.GamerScore;
            PB_GamerPic.ImageLocation = GamerProfile.GameDisplayPicRaw;

            PNL_Profile.Dock = DockStyle.Fill;
            PNL_Profile.BackColor = Color.Red;
            PNL_Content.Controls.Add(PNL_Profile);
        }

        private void PNL_Move_MouseDown(object sender, MouseEventArgs e)
        {
            MouseLocation = new Point(e.X, e.Y);
        }

        private void PNL_Move_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(MouseLocation.X, MouseLocation.Y);
                Location = mousePose;
            }
        }

        private void BTN_Resize_MouseDown(object sender, MouseEventArgs e)
        {
            MouseLocation = new Point(e.X, e.Y);
        }

        private void BTN_Resize_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                this.Size = new Size(this.Size.Width + MouseLocation.X, this.Size.Height + MouseLocation.Y);
            //Location = mousePose;
        }

        private void BTN_Resize_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.SizeNWSE;
        }
    }
}
