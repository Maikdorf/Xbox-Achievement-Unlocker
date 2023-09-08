namespace Xbox_Achievement_Unlocker
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            PNL_Main_L = new System.Windows.Forms.Panel();
            BTN_Resize = new FontAwesome.Sharp.IconButton();
            PNL_Move = new System.Windows.Forms.Panel();
            iconButton3 = new FontAwesome.Sharp.IconButton();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            PB_Splash = new System.Windows.Forms.PictureBox();
            PB_GamerPic = new CustomControls.CircularPictureBox();
            LBL_GameScore = new System.Windows.Forms.Label();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            LBL_GamerTag = new System.Windows.Forms.Label();
            BTN_Menu_Games = new CustomControls.ButtomRadius();
            BTN_Menu_About = new CustomControls.ButtomRadius();
            BTN_Menu_Achivements = new CustomControls.ButtomRadius();
            BTN_Menu_Profile = new CustomControls.ButtomRadius();
            EC_FRM_Main = new CustomControls.ElipsePropControl();
            EC_PNL_Content = new CustomControls.ElipsePropControl();
            PNL_Content = new System.Windows.Forms.Panel();
            PNL_Main_L.SuspendLayout();
            PNL_Move.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PB_Splash).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PB_GamerPic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // PNL_Main_L
            // 
            PNL_Main_L.BackColor = System.Drawing.Color.FromArgb(0, 111, 219);
            PNL_Main_L.Controls.Add(PNL_Move);
            PNL_Main_L.Controls.Add(PB_Splash);
            PNL_Main_L.Controls.Add(PB_GamerPic);
            PNL_Main_L.Controls.Add(LBL_GameScore);
            PNL_Main_L.Controls.Add(iconPictureBox1);
            PNL_Main_L.Controls.Add(LBL_GamerTag);
            PNL_Main_L.Controls.Add(BTN_Menu_Games);
            PNL_Main_L.Controls.Add(BTN_Menu_About);
            PNL_Main_L.Controls.Add(BTN_Menu_Achivements);
            PNL_Main_L.Controls.Add(BTN_Menu_Profile);
            resources.ApplyResources(PNL_Main_L, "PNL_Main_L");
            PNL_Main_L.Name = "PNL_Main_L";
            // 
            // BTN_Resize
            // 
            BTN_Resize.IconChar = FontAwesome.Sharp.IconChar.PaintBrush;
            BTN_Resize.IconColor = System.Drawing.Color.Red;
            BTN_Resize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BTN_Resize.IconSize = 10;
            resources.ApplyResources(BTN_Resize, "BTN_Resize");
            BTN_Resize.Name = "BTN_Resize";
            BTN_Resize.UseVisualStyleBackColor = true;
            BTN_Resize.MouseDown += BTN_Resize_MouseDown;
            BTN_Resize.MouseMove += BTN_Resize_MouseMove;
            // 
            // PNL_Move
            // 
            PNL_Move.Controls.Add(BTN_Resize);
            PNL_Move.Controls.Add(iconButton3);
            PNL_Move.Controls.Add(iconButton2);
            PNL_Move.Controls.Add(iconButton1);
            resources.ApplyResources(PNL_Move, "PNL_Move");
            PNL_Move.Name = "PNL_Move";
            PNL_Move.MouseDown += PNL_Move_MouseDown;
            PNL_Move.MouseMove += PNL_Move_MouseMove;
            // 
            // iconButton3
            // 
            iconButton3.IconChar = FontAwesome.Sharp.IconChar.PaintBrush;
            iconButton3.IconColor = System.Drawing.Color.Red;
            iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton3.IconSize = 10;
            resources.ApplyResources(iconButton3, "iconButton3");
            iconButton3.Name = "iconButton3";
            iconButton3.UseVisualStyleBackColor = true;
            // 
            // iconButton2
            // 
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.PaintBrush;
            iconButton2.IconColor = System.Drawing.Color.Red;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.IconSize = 10;
            resources.ApplyResources(iconButton2, "iconButton2");
            iconButton2.Name = "iconButton2";
            iconButton2.UseVisualStyleBackColor = true;
            // 
            // iconButton1
            // 
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.PaintBrush;
            iconButton1.IconColor = System.Drawing.Color.Red;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 10;
            resources.ApplyResources(iconButton1, "iconButton1");
            iconButton1.Name = "iconButton1";
            iconButton1.UseVisualStyleBackColor = true;
            // 
            // PB_Splash
            // 
            resources.ApplyResources(PB_Splash, "PB_Splash");
            PB_Splash.Name = "PB_Splash";
            PB_Splash.TabStop = false;
            // 
            // PB_GamerPic
            // 
            PB_GamerPic.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            PB_GamerPic.BorderColor = System.Drawing.Color.White;
            PB_GamerPic.BorderColor2 = System.Drawing.Color.HotPink;
            PB_GamerPic.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            PB_GamerPic.BorderSize = 2;
            PB_GamerPic.GradientAngle = 50F;
            resources.ApplyResources(PB_GamerPic, "PB_GamerPic");
            PB_GamerPic.Name = "PB_GamerPic";
            PB_GamerPic.TabStop = false;
            // 
            // LBL_GameScore
            // 
            resources.ApplyResources(LBL_GameScore, "LBL_GameScore");
            LBL_GameScore.ForeColor = System.Drawing.Color.White;
            LBL_GameScore.Name = "LBL_GameScore";
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(0, 111, 219);
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Gratipay;
            iconPictureBox1.IconColor = System.Drawing.Color.White;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            resources.ApplyResources(iconPictureBox1, "iconPictureBox1");
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.TabStop = false;
            // 
            // LBL_GamerTag
            // 
            resources.ApplyResources(LBL_GamerTag, "LBL_GamerTag");
            LBL_GamerTag.ForeColor = System.Drawing.Color.White;
            LBL_GamerTag.Name = "LBL_GamerTag";
            // 
            // BTN_Menu_Games
            // 
            BTN_Menu_Games.BackColor = System.Drawing.Color.White;
            BTN_Menu_Games.BackgroundColor = System.Drawing.Color.White;
            BTN_Menu_Games.BorderColor = System.Drawing.Color.FromArgb(0, 111, 219);
            BTN_Menu_Games.BorderRadius = 20;
            BTN_Menu_Games.BorderSize = 0;
            BTN_Menu_Games.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(BTN_Menu_Games, "BTN_Menu_Games");
            BTN_Menu_Games.ForeColor = System.Drawing.Color.FromArgb(0, 111, 219);
            BTN_Menu_Games.IconChar = FontAwesome.Sharp.IconChar.Gamepad;
            BTN_Menu_Games.IconColor = System.Drawing.Color.FromArgb(0, 56, 110);
            BTN_Menu_Games.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BTN_Menu_Games.IconSize = 30;
            BTN_Menu_Games.Name = "BTN_Menu_Games";
            BTN_Menu_Games.TextColor = System.Drawing.Color.FromArgb(0, 111, 219);
            BTN_Menu_Games.UseVisualStyleBackColor = false;
            BTN_Menu_Games.Click += MenuSelected;
            // 
            // BTN_Menu_About
            // 
            BTN_Menu_About.BackColor = System.Drawing.Color.White;
            BTN_Menu_About.BackgroundColor = System.Drawing.Color.White;
            BTN_Menu_About.BorderColor = System.Drawing.Color.FromArgb(0, 111, 219);
            BTN_Menu_About.BorderRadius = 20;
            BTN_Menu_About.BorderSize = 0;
            BTN_Menu_About.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(BTN_Menu_About, "BTN_Menu_About");
            BTN_Menu_About.ForeColor = System.Drawing.Color.FromArgb(0, 111, 219);
            BTN_Menu_About.IconChar = FontAwesome.Sharp.IconChar.Angellist;
            BTN_Menu_About.IconColor = System.Drawing.Color.FromArgb(0, 56, 110);
            BTN_Menu_About.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BTN_Menu_About.IconSize = 30;
            BTN_Menu_About.Name = "BTN_Menu_About";
            BTN_Menu_About.TextColor = System.Drawing.Color.FromArgb(0, 111, 219);
            BTN_Menu_About.UseVisualStyleBackColor = false;
            BTN_Menu_About.Click += MenuSelected;
            // 
            // BTN_Menu_Achivements
            // 
            BTN_Menu_Achivements.BackColor = System.Drawing.Color.White;
            BTN_Menu_Achivements.BackgroundColor = System.Drawing.Color.White;
            BTN_Menu_Achivements.BorderColor = System.Drawing.Color.White;
            BTN_Menu_Achivements.BorderRadius = 20;
            BTN_Menu_Achivements.BorderSize = 0;
            BTN_Menu_Achivements.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(BTN_Menu_Achivements, "BTN_Menu_Achivements");
            BTN_Menu_Achivements.ForeColor = System.Drawing.Color.FromArgb(0, 111, 219);
            BTN_Menu_Achivements.IconChar = FontAwesome.Sharp.IconChar.Trophy;
            BTN_Menu_Achivements.IconColor = System.Drawing.Color.FromArgb(0, 56, 110);
            BTN_Menu_Achivements.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BTN_Menu_Achivements.IconSize = 30;
            BTN_Menu_Achivements.Name = "BTN_Menu_Achivements";
            BTN_Menu_Achivements.TextColor = System.Drawing.Color.FromArgb(0, 111, 219);
            BTN_Menu_Achivements.UseVisualStyleBackColor = false;
            BTN_Menu_Achivements.Click += MenuSelected;
            // 
            // BTN_Menu_Profile
            // 
            BTN_Menu_Profile.BackColor = System.Drawing.Color.White;
            BTN_Menu_Profile.BackgroundColor = System.Drawing.Color.White;
            BTN_Menu_Profile.BorderColor = System.Drawing.Color.FromArgb(0, 111, 219);
            BTN_Menu_Profile.BorderRadius = 20;
            BTN_Menu_Profile.BorderSize = 0;
            BTN_Menu_Profile.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(BTN_Menu_Profile, "BTN_Menu_Profile");
            BTN_Menu_Profile.ForeColor = System.Drawing.Color.FromArgb(0, 111, 219);
            BTN_Menu_Profile.IconChar = FontAwesome.Sharp.IconChar.UserNinja;
            BTN_Menu_Profile.IconColor = System.Drawing.Color.FromArgb(0, 56, 110);
            BTN_Menu_Profile.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BTN_Menu_Profile.IconSize = 30;
            BTN_Menu_Profile.Name = "BTN_Menu_Profile";
            BTN_Menu_Profile.TextColor = System.Drawing.Color.FromArgb(0, 111, 219);
            BTN_Menu_Profile.UseVisualStyleBackColor = false;
            BTN_Menu_Profile.Click += MenuSelected;
            // 
            // EC_FRM_Main
            // 
            EC_FRM_Main.CornerRadius = 30;
            EC_FRM_Main.TargetControl = this;
            // 
            // EC_PNL_Content
            // 
            EC_PNL_Content.CornerRadius = 25;
            EC_PNL_Content.TargetControl = PNL_Content;
            // 
            // PNL_Content
            // 
            resources.ApplyResources(PNL_Content, "PNL_Content");
            PNL_Content.BackColor = System.Drawing.Color.White;
            PNL_Content.Name = "PNL_Content";
            // 
            // Main
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(0, 111, 219);
            ControlBox = false;
            Controls.Add(PNL_Main_L);
            Controls.Add(PNL_Content);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "Main";
            Load += Main_Load;
            PNL_Main_L.ResumeLayout(false);
            PNL_Main_L.PerformLayout();
            PNL_Move.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PB_Splash).EndInit();
            ((System.ComponentModel.ISupportInitialize)PB_GamerPic).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel PNL_Main_L;
        private CustomControls.ElipsePropControl EC_FRM_Main;
        private CustomControls.ButtomRadius BTN_Menu_Profile;
        private CustomControls.ButtomRadius BTN_Menu_About;
        private CustomControls.ButtomRadius BTN_Menu_Achivements;
        private CustomControls.ButtomRadius BTN_Menu_Games;
        private CustomControls.ElipsePropControl EC_PNL_Content;
        private System.Windows.Forms.PictureBox PB_Splash;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Panel PNL_Content;
        public System.Windows.Forms.Label LBL_GamerTag;
        public System.Windows.Forms.Label LBL_GameScore;
        public CustomControls.CircularPictureBox PB_GamerPic;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Panel PNL_Move;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton BTN_Resize;
    }
}