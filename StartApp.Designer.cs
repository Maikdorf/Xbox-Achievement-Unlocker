namespace Xbox_Achievement_Unlocker
{
    partial class StartApp
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartApp));
            NTI_App = new System.Windows.Forms.NotifyIcon(components);
            BottomToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            TopToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            RightToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            ContentPanel = new System.Windows.Forms.ToolStripContentPanel();
            TABC_Header = new System.Windows.Forms.TabControl();
            TAB_Info = new System.Windows.Forms.TabPage();
            TAB_StartApp = new System.Windows.Forms.TabPage();
            BTN_ReloadXboxApp = new CustomControls.ButtomRadius();
            BTN_ExtracCredentials = new CustomControls.ButtomRadius();
            TAB_Misc = new System.Windows.Forms.TabPage();
            BTN_InjectGame = new CustomControls.ButtomRadius();
            BTN_SaveGameList = new CustomControls.ButtomRadius();
            BTN_SendInfo = new CustomControls.ButtomRadius();
            TAB_Profile = new System.Windows.Forms.TabPage();
            LBL_GameScore = new System.Windows.Forms.Label();
            LBL_GamerTag = new System.Windows.Forms.Label();
            BTN_XUID = new CustomControls.ButtomRadius();
            BTN_Token = new CustomControls.ButtomRadius();
            label1 = new System.Windows.Forms.Label();
            PNL_LEFT = new System.Windows.Forms.Panel();
            PNL_LEFT_HEADER = new System.Windows.Forms.Panel();
            panel4 = new System.Windows.Forms.Panel();
            panel6 = new System.Windows.Forms.Panel();
            panel5 = new System.Windows.Forms.Panel();
            PB_GamerPicDisplay = new CustomControls.CircularPictureBox();
            PNL_ContentAchievements = new System.Windows.Forms.Panel();
            panel1 = new System.Windows.Forms.Panel();
            panel10 = new System.Windows.Forms.Panel();
            TABC_Achievements = new System.Windows.Forms.TabControl();
            panel8 = new System.Windows.Forms.Panel();
            label3 = new System.Windows.Forms.Label();
            PNL_Spoofer = new System.Windows.Forms.Panel();
            panel9 = new System.Windows.Forms.Panel();
            label4 = new System.Windows.Forms.Label();
            panel2 = new System.Windows.Forms.Panel();
            GB_Spoofer = new System.Windows.Forms.GroupBox();
            label2 = new System.Windows.Forms.Label();
            CHB_Automatic = new CustomControls.ToggleButton();
            LBL_TimeSlapsed = new System.Windows.Forms.Label();
            LBL_TimeAchievements = new System.Windows.Forms.Label();
            gameImage = new System.Windows.Forms.PictureBox();
            panel3 = new System.Windows.Forms.Panel();
            LBL_Timer = new System.Windows.Forms.Label();
            BTN_SpoofStop = new System.Windows.Forms.Button();
            BTN_Spoof = new System.Windows.Forms.Button();
            panel7 = new System.Windows.Forms.Panel();
            lblLink_completationTime = new System.Windows.Forms.LinkLabel();
            SpoofingTime = new System.Windows.Forms.Timer(components);
            TABC_Header.SuspendLayout();
            TAB_StartApp.SuspendLayout();
            TAB_Misc.SuspendLayout();
            TAB_Profile.SuspendLayout();
            PNL_LEFT.SuspendLayout();
            PNL_LEFT_HEADER.SuspendLayout();
            panel4.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PB_GamerPicDisplay).BeginInit();
            PNL_ContentAchievements.SuspendLayout();
            panel1.SuspendLayout();
            panel10.SuspendLayout();
            panel8.SuspendLayout();
            PNL_Spoofer.SuspendLayout();
            panel9.SuspendLayout();
            panel2.SuspendLayout();
            GB_Spoofer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gameImage).BeginInit();
            panel3.SuspendLayout();
            panel7.SuspendLayout();
            SuspendLayout();
            // 
            // NTI_App
            // 
            NTI_App.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            NTI_App.Icon = (System.Drawing.Icon)resources.GetObject("NTI_App.Icon");
            NTI_App.Text = "Mira tu esta monda !!! ";
            NTI_App.Visible = true;
            // 
            // BottomToolStripPanel
            // 
            BottomToolStripPanel.Location = new System.Drawing.Point(0, 0);
            BottomToolStripPanel.Name = "BottomToolStripPanel";
            BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            BottomToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            BottomToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // TopToolStripPanel
            // 
            TopToolStripPanel.Location = new System.Drawing.Point(0, 0);
            TopToolStripPanel.Name = "TopToolStripPanel";
            TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            TopToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            TopToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // RightToolStripPanel
            // 
            RightToolStripPanel.Location = new System.Drawing.Point(0, 0);
            RightToolStripPanel.Name = "RightToolStripPanel";
            RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            RightToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            RightToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // ContentPanel
            // 
            ContentPanel.Size = new System.Drawing.Size(1039, 704);
            // 
            // TABC_Header
            // 
            TABC_Header.Controls.Add(TAB_Info);
            TABC_Header.Controls.Add(TAB_StartApp);
            TABC_Header.Controls.Add(TAB_Misc);
            TABC_Header.Controls.Add(TAB_Profile);
            TABC_Header.Dock = System.Windows.Forms.DockStyle.Fill;
            TABC_Header.Location = new System.Drawing.Point(0, 0);
            TABC_Header.Name = "TABC_Header";
            TABC_Header.SelectedIndex = 0;
            TABC_Header.Size = new System.Drawing.Size(1051, 140);
            TABC_Header.TabIndex = 0;
            // 
            // TAB_Info
            // 
            TAB_Info.Location = new System.Drawing.Point(4, 26);
            TAB_Info.Name = "TAB_Info";
            TAB_Info.Padding = new System.Windows.Forms.Padding(3);
            TAB_Info.Size = new System.Drawing.Size(1043, 110);
            TAB_Info.TabIndex = 0;
            TAB_Info.Text = "Info";
            TAB_Info.UseVisualStyleBackColor = true;
            // 
            // TAB_StartApp
            // 
            TAB_StartApp.Controls.Add(BTN_ReloadXboxApp);
            TAB_StartApp.Controls.Add(BTN_ExtracCredentials);
            TAB_StartApp.Location = new System.Drawing.Point(4, 24);
            TAB_StartApp.Name = "TAB_StartApp";
            TAB_StartApp.Padding = new System.Windows.Forms.Padding(3);
            TAB_StartApp.Size = new System.Drawing.Size(1043, 112);
            TAB_StartApp.TabIndex = 1;
            TAB_StartApp.Text = "Start App";
            TAB_StartApp.UseVisualStyleBackColor = true;
            // 
            // BTN_ReloadXboxApp
            // 
            BTN_ReloadXboxApp.BackColor = System.Drawing.SystemColors.Control;
            BTN_ReloadXboxApp.BackgroundColor = System.Drawing.SystemColors.Control;
            BTN_ReloadXboxApp.BorderColor = System.Drawing.Color.PaleVioletRed;
            BTN_ReloadXboxApp.BorderRadius = 20;
            BTN_ReloadXboxApp.BorderSize = 0;
            BTN_ReloadXboxApp.Cursor = System.Windows.Forms.Cursors.Hand;
            BTN_ReloadXboxApp.FlatAppearance.BorderSize = 0;
            BTN_ReloadXboxApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            BTN_ReloadXboxApp.ForeColor = System.Drawing.SystemColors.ControlText;
            BTN_ReloadXboxApp.IconChar = FontAwesome.Sharp.IconChar.Repeat;
            BTN_ReloadXboxApp.IconColor = System.Drawing.SystemColors.ControlText;
            BTN_ReloadXboxApp.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BTN_ReloadXboxApp.IconSize = 60;
            BTN_ReloadXboxApp.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            BTN_ReloadXboxApp.Location = new System.Drawing.Point(416, 15);
            BTN_ReloadXboxApp.Name = "BTN_ReloadXboxApp";
            BTN_ReloadXboxApp.Size = new System.Drawing.Size(171, 80);
            BTN_ReloadXboxApp.TabIndex = 20;
            BTN_ReloadXboxApp.Text = "Reload Xbox App";
            BTN_ReloadXboxApp.TextColor = System.Drawing.SystemColors.ControlText;
            BTN_ReloadXboxApp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            BTN_ReloadXboxApp.UseVisualStyleBackColor = false;
            BTN_ReloadXboxApp.Click += BTN_ReloadXboxApp_Click;
            // 
            // BTN_ExtracCredentials
            // 
            BTN_ExtracCredentials.BackColor = System.Drawing.SystemColors.Control;
            BTN_ExtracCredentials.BackgroundColor = System.Drawing.SystemColors.Control;
            BTN_ExtracCredentials.BorderColor = System.Drawing.Color.White;
            BTN_ExtracCredentials.BorderRadius = 20;
            BTN_ExtracCredentials.BorderSize = 0;
            BTN_ExtracCredentials.Cursor = System.Windows.Forms.Cursors.Hand;
            BTN_ExtracCredentials.Enabled = false;
            BTN_ExtracCredentials.FlatAppearance.BorderSize = 0;
            BTN_ExtracCredentials.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            BTN_ExtracCredentials.ForeColor = System.Drawing.SystemColors.ControlText;
            BTN_ExtracCredentials.IconChar = FontAwesome.Sharp.IconChar.Hammer;
            BTN_ExtracCredentials.IconColor = System.Drawing.SystemColors.ControlText;
            BTN_ExtracCredentials.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BTN_ExtracCredentials.IconSize = 60;
            BTN_ExtracCredentials.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            BTN_ExtracCredentials.Location = new System.Drawing.Point(215, 15);
            BTN_ExtracCredentials.Name = "BTN_ExtracCredentials";
            BTN_ExtracCredentials.Size = new System.Drawing.Size(171, 80);
            BTN_ExtracCredentials.TabIndex = 19;
            BTN_ExtracCredentials.Text = "Extract Token";
            BTN_ExtracCredentials.TextColor = System.Drawing.SystemColors.ControlText;
            BTN_ExtracCredentials.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            BTN_ExtracCredentials.UseVisualStyleBackColor = false;
            BTN_ExtracCredentials.Click += BTN_ExtracCredentials_Click;
            // 
            // TAB_Misc
            // 
            TAB_Misc.Controls.Add(BTN_InjectGame);
            TAB_Misc.Controls.Add(BTN_SaveGameList);
            TAB_Misc.Controls.Add(BTN_SendInfo);
            TAB_Misc.Location = new System.Drawing.Point(4, 24);
            TAB_Misc.Name = "TAB_Misc";
            TAB_Misc.Size = new System.Drawing.Size(1043, 112);
            TAB_Misc.TabIndex = 2;
            TAB_Misc.Text = "Miscellaneous";
            TAB_Misc.UseVisualStyleBackColor = true;
            // 
            // BTN_InjectGame
            // 
            BTN_InjectGame.BackColor = System.Drawing.SystemColors.Control;
            BTN_InjectGame.BackgroundColor = System.Drawing.SystemColors.Control;
            BTN_InjectGame.BorderColor = System.Drawing.Color.PaleVioletRed;
            BTN_InjectGame.BorderRadius = 20;
            BTN_InjectGame.BorderSize = 0;
            BTN_InjectGame.Cursor = System.Windows.Forms.Cursors.Hand;
            BTN_InjectGame.Enabled = false;
            BTN_InjectGame.FlatAppearance.BorderSize = 0;
            BTN_InjectGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            BTN_InjectGame.ForeColor = System.Drawing.SystemColors.ControlText;
            BTN_InjectGame.IconChar = FontAwesome.Sharp.IconChar.Syringe;
            BTN_InjectGame.IconColor = System.Drawing.SystemColors.ControlText;
            BTN_InjectGame.IconFont = FontAwesome.Sharp.IconFont.Solid;
            BTN_InjectGame.IconSize = 60;
            BTN_InjectGame.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            BTN_InjectGame.Location = new System.Drawing.Point(537, 16);
            BTN_InjectGame.Name = "BTN_InjectGame";
            BTN_InjectGame.Size = new System.Drawing.Size(171, 80);
            BTN_InjectGame.TabIndex = 23;
            BTN_InjectGame.Text = "Inject Game";
            BTN_InjectGame.TextColor = System.Drawing.SystemColors.ControlText;
            BTN_InjectGame.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            BTN_InjectGame.UseVisualStyleBackColor = false;
            // 
            // BTN_SaveGameList
            // 
            BTN_SaveGameList.BackColor = System.Drawing.SystemColors.Control;
            BTN_SaveGameList.BackgroundColor = System.Drawing.SystemColors.Control;
            BTN_SaveGameList.BorderColor = System.Drawing.Color.PaleVioletRed;
            BTN_SaveGameList.BorderRadius = 20;
            BTN_SaveGameList.BorderSize = 0;
            BTN_SaveGameList.Cursor = System.Windows.Forms.Cursors.Hand;
            BTN_SaveGameList.Enabled = false;
            BTN_SaveGameList.FlatAppearance.BorderSize = 0;
            BTN_SaveGameList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            BTN_SaveGameList.ForeColor = System.Drawing.SystemColors.ControlText;
            BTN_SaveGameList.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            BTN_SaveGameList.IconColor = System.Drawing.SystemColors.ControlText;
            BTN_SaveGameList.IconFont = FontAwesome.Sharp.IconFont.Solid;
            BTN_SaveGameList.IconSize = 60;
            BTN_SaveGameList.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            BTN_SaveGameList.Location = new System.Drawing.Point(138, 16);
            BTN_SaveGameList.Name = "BTN_SaveGameList";
            BTN_SaveGameList.Size = new System.Drawing.Size(171, 80);
            BTN_SaveGameList.TabIndex = 21;
            BTN_SaveGameList.Text = "Save Game List";
            BTN_SaveGameList.TextColor = System.Drawing.SystemColors.ControlText;
            BTN_SaveGameList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            BTN_SaveGameList.UseVisualStyleBackColor = false;
            // 
            // BTN_SendInfo
            // 
            BTN_SendInfo.BackColor = System.Drawing.SystemColors.Control;
            BTN_SendInfo.BackgroundColor = System.Drawing.SystemColors.Control;
            BTN_SendInfo.BorderColor = System.Drawing.Color.PaleVioletRed;
            BTN_SendInfo.BorderRadius = 20;
            BTN_SendInfo.BorderSize = 0;
            BTN_SendInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            BTN_SendInfo.Enabled = false;
            BTN_SendInfo.FlatAppearance.BorderSize = 0;
            BTN_SendInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            BTN_SendInfo.ForeColor = System.Drawing.SystemColors.ControlText;
            BTN_SendInfo.IconChar = FontAwesome.Sharp.IconChar.PaperPlane;
            BTN_SendInfo.IconColor = System.Drawing.SystemColors.ControlText;
            BTN_SendInfo.IconFont = FontAwesome.Sharp.IconFont.Solid;
            BTN_SendInfo.IconSize = 60;
            BTN_SendInfo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            BTN_SendInfo.Location = new System.Drawing.Point(339, 16);
            BTN_SendInfo.Name = "BTN_SendInfo";
            BTN_SendInfo.Size = new System.Drawing.Size(171, 80);
            BTN_SendInfo.TabIndex = 22;
            BTN_SendInfo.Text = "Share Titles";
            BTN_SendInfo.TextColor = System.Drawing.SystemColors.ControlText;
            BTN_SendInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            BTN_SendInfo.UseVisualStyleBackColor = false;
            // 
            // TAB_Profile
            // 
            TAB_Profile.Controls.Add(LBL_GameScore);
            TAB_Profile.Controls.Add(LBL_GamerTag);
            TAB_Profile.Controls.Add(BTN_XUID);
            TAB_Profile.Controls.Add(BTN_Token);
            TAB_Profile.Location = new System.Drawing.Point(4, 24);
            TAB_Profile.Name = "TAB_Profile";
            TAB_Profile.Size = new System.Drawing.Size(1043, 112);
            TAB_Profile.TabIndex = 3;
            TAB_Profile.Text = "Profile";
            TAB_Profile.UseVisualStyleBackColor = true;
            // 
            // LBL_GameScore
            // 
            LBL_GameScore.AutoSize = true;
            LBL_GameScore.BackColor = System.Drawing.Color.Transparent;
            LBL_GameScore.Location = new System.Drawing.Point(129, 39);
            LBL_GameScore.Name = "LBL_GameScore";
            LBL_GameScore.Size = new System.Drawing.Size(65, 17);
            LBL_GameScore.TabIndex = 25;
            LBL_GameScore.Text = "9.999.999";
            // 
            // LBL_GamerTag
            // 
            LBL_GamerTag.AutoSize = true;
            LBL_GamerTag.BackColor = System.Drawing.Color.Transparent;
            LBL_GamerTag.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            LBL_GamerTag.Location = new System.Drawing.Point(14, 16);
            LBL_GamerTag.Name = "LBL_GamerTag";
            LBL_GamerTag.Size = new System.Drawing.Size(180, 23);
            LBL_GamerTag.TabIndex = 24;
            LBL_GamerTag.Text = "ApachaiOpachai";
            // 
            // BTN_XUID
            // 
            BTN_XUID.BackColor = System.Drawing.SystemColors.Control;
            BTN_XUID.BackgroundColor = System.Drawing.SystemColors.Control;
            BTN_XUID.BorderColor = System.Drawing.Color.PaleVioletRed;
            BTN_XUID.BorderRadius = 20;
            BTN_XUID.BorderSize = 0;
            BTN_XUID.Cursor = System.Windows.Forms.Cursors.Hand;
            BTN_XUID.Enabled = false;
            BTN_XUID.FlatAppearance.BorderSize = 0;
            BTN_XUID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            BTN_XUID.ForeColor = System.Drawing.SystemColors.ControlText;
            BTN_XUID.IconChar = FontAwesome.Sharp.IconChar.Fingerprint;
            BTN_XUID.IconColor = System.Drawing.SystemColors.ControlText;
            BTN_XUID.IconFont = FontAwesome.Sharp.IconFont.Solid;
            BTN_XUID.IconSize = 60;
            BTN_XUID.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            BTN_XUID.Location = new System.Drawing.Point(421, 16);
            BTN_XUID.Name = "BTN_XUID";
            BTN_XUID.Size = new System.Drawing.Size(171, 80);
            BTN_XUID.TabIndex = 23;
            BTN_XUID.Text = "Xuid";
            BTN_XUID.TextColor = System.Drawing.SystemColors.ControlText;
            BTN_XUID.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            BTN_XUID.UseVisualStyleBackColor = false;
            BTN_XUID.Click += CopyInfoClipBoard;
            // 
            // BTN_Token
            // 
            BTN_Token.BackColor = System.Drawing.SystemColors.Control;
            BTN_Token.BackgroundColor = System.Drawing.SystemColors.Control;
            BTN_Token.BorderColor = System.Drawing.Color.PaleVioletRed;
            BTN_Token.BorderRadius = 20;
            BTN_Token.BorderSize = 0;
            BTN_Token.Cursor = System.Windows.Forms.Cursors.Hand;
            BTN_Token.Enabled = false;
            BTN_Token.FlatAppearance.BorderSize = 0;
            BTN_Token.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            BTN_Token.ForeColor = System.Drawing.SystemColors.ControlText;
            BTN_Token.IconChar = FontAwesome.Sharp.IconChar.Key;
            BTN_Token.IconColor = System.Drawing.SystemColors.ControlText;
            BTN_Token.IconFont = FontAwesome.Sharp.IconFont.Solid;
            BTN_Token.IconSize = 60;
            BTN_Token.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            BTN_Token.Location = new System.Drawing.Point(229, 16);
            BTN_Token.Name = "BTN_Token";
            BTN_Token.Size = new System.Drawing.Size(171, 80);
            BTN_Token.TabIndex = 22;
            BTN_Token.Text = "Token";
            BTN_Token.TextColor = System.Drawing.SystemColors.ControlText;
            BTN_Token.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            BTN_Token.UseVisualStyleBackColor = false;
            BTN_Token.Click += CopyInfoClipBoard;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = System.Windows.Forms.DockStyle.Left;
            label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(0, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(84, 19);
            label1.TabIndex = 0;
            label1.Text = "Game List";
            // 
            // PNL_LEFT
            // 
            PNL_LEFT.BackColor = System.Drawing.Color.White;
            PNL_LEFT.Controls.Add(PNL_LEFT_HEADER);
            PNL_LEFT.Dock = System.Windows.Forms.DockStyle.Left;
            PNL_LEFT.Location = new System.Drawing.Point(0, 0);
            PNL_LEFT.Name = "PNL_LEFT";
            PNL_LEFT.Size = new System.Drawing.Size(390, 569);
            PNL_LEFT.TabIndex = 4;
            // 
            // PNL_LEFT_HEADER
            // 
            PNL_LEFT_HEADER.Controls.Add(label1);
            PNL_LEFT_HEADER.Dock = System.Windows.Forms.DockStyle.Top;
            PNL_LEFT_HEADER.Location = new System.Drawing.Point(0, 0);
            PNL_LEFT_HEADER.Name = "PNL_LEFT_HEADER";
            PNL_LEFT_HEADER.Size = new System.Drawing.Size(390, 24);
            PNL_LEFT_HEADER.TabIndex = 4;
            // 
            // panel4
            // 
            panel4.Controls.Add(panel6);
            panel4.Controls.Add(panel5);
            panel4.Dock = System.Windows.Forms.DockStyle.Top;
            panel4.Location = new System.Drawing.Point(10, 10);
            panel4.Name = "panel4";
            panel4.Size = new System.Drawing.Size(1244, 140);
            panel4.TabIndex = 21;
            // 
            // panel6
            // 
            panel6.Controls.Add(TABC_Header);
            panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            panel6.Location = new System.Drawing.Point(193, 0);
            panel6.Name = "panel6";
            panel6.Size = new System.Drawing.Size(1051, 140);
            panel6.TabIndex = 1;
            // 
            // panel5
            // 
            panel5.Controls.Add(PB_GamerPicDisplay);
            panel5.Dock = System.Windows.Forms.DockStyle.Left;
            panel5.Location = new System.Drawing.Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new System.Drawing.Size(193, 140);
            panel5.TabIndex = 0;
            // 
            // PB_GamerPicDisplay
            // 
            PB_GamerPicDisplay.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            PB_GamerPicDisplay.BorderColor = System.Drawing.Color.RoyalBlue;
            PB_GamerPicDisplay.BorderColor2 = System.Drawing.Color.HotPink;
            PB_GamerPicDisplay.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            PB_GamerPicDisplay.BorderSize = 2;
            PB_GamerPicDisplay.GradientAngle = 50F;
            PB_GamerPicDisplay.ImageLocation = "";
            PB_GamerPicDisplay.Location = new System.Drawing.Point(38, 12);
            PB_GamerPicDisplay.Name = "PB_GamerPicDisplay";
            PB_GamerPicDisplay.Size = new System.Drawing.Size(110, 110);
            PB_GamerPicDisplay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            PB_GamerPicDisplay.TabIndex = 0;
            PB_GamerPicDisplay.TabStop = false;
            // 
            // PNL_ContentAchievements
            // 
            PNL_ContentAchievements.Controls.Add(panel1);
            PNL_ContentAchievements.Controls.Add(PNL_Spoofer);
            PNL_ContentAchievements.Controls.Add(PNL_LEFT);
            PNL_ContentAchievements.Dock = System.Windows.Forms.DockStyle.Fill;
            PNL_ContentAchievements.Location = new System.Drawing.Point(10, 150);
            PNL_ContentAchievements.Name = "PNL_ContentAchievements";
            PNL_ContentAchievements.Size = new System.Drawing.Size(1244, 569);
            PNL_ContentAchievements.TabIndex = 22;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel10);
            panel1.Controls.Add(panel8);
            panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            panel1.Location = new System.Drawing.Point(390, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(589, 569);
            panel1.TabIndex = 7;
            // 
            // panel10
            // 
            panel10.Controls.Add(TABC_Achievements);
            panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            panel10.Location = new System.Drawing.Point(0, 24);
            panel10.Name = "panel10";
            panel10.Size = new System.Drawing.Size(589, 545);
            panel10.TabIndex = 7;
            // 
            // TABC_Achievements
            // 
            TABC_Achievements.Dock = System.Windows.Forms.DockStyle.Fill;
            TABC_Achievements.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            TABC_Achievements.Location = new System.Drawing.Point(0, 0);
            TABC_Achievements.Name = "TABC_Achievements";
            TABC_Achievements.SelectedIndex = 0;
            TABC_Achievements.Size = new System.Drawing.Size(589, 545);
            TABC_Achievements.TabIndex = 5;
            TABC_Achievements.DrawItem += TABC_Achievements_DrawItem;
            // 
            // panel8
            // 
            panel8.Controls.Add(label3);
            panel8.Dock = System.Windows.Forms.DockStyle.Top;
            panel8.Location = new System.Drawing.Point(0, 0);
            panel8.Name = "panel8";
            panel8.Size = new System.Drawing.Size(589, 24);
            panel8.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = System.Windows.Forms.DockStyle.Left;
            label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(0, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(145, 19);
            label3.TabIndex = 0;
            label3.Text = "Achievements List";
            // 
            // PNL_Spoofer
            // 
            PNL_Spoofer.Controls.Add(panel9);
            PNL_Spoofer.Controls.Add(panel2);
            PNL_Spoofer.Dock = System.Windows.Forms.DockStyle.Right;
            PNL_Spoofer.Location = new System.Drawing.Point(979, 0);
            PNL_Spoofer.Name = "PNL_Spoofer";
            PNL_Spoofer.Size = new System.Drawing.Size(265, 569);
            PNL_Spoofer.TabIndex = 6;
            // 
            // panel9
            // 
            panel9.Controls.Add(label4);
            panel9.Dock = System.Windows.Forms.DockStyle.Top;
            panel9.Location = new System.Drawing.Point(0, 0);
            panel9.Name = "panel9";
            panel9.Size = new System.Drawing.Size(265, 24);
            panel9.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = System.Windows.Forms.DockStyle.Left;
            label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(0, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(121, 19);
            label4.TabIndex = 0;
            label4.Text = "Spoofer Game";
            // 
            // panel2
            // 
            panel2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            panel2.Controls.Add(GB_Spoofer);
            panel2.Controls.Add(panel7);
            panel2.Location = new System.Drawing.Point(0, 36);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(265, 488);
            panel2.TabIndex = 16;
            // 
            // GB_Spoofer
            // 
            GB_Spoofer.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom;
            GB_Spoofer.Controls.Add(label2);
            GB_Spoofer.Controls.Add(CHB_Automatic);
            GB_Spoofer.Controls.Add(LBL_TimeSlapsed);
            GB_Spoofer.Controls.Add(LBL_TimeAchievements);
            GB_Spoofer.Controls.Add(gameImage);
            GB_Spoofer.Controls.Add(panel3);
            GB_Spoofer.Controls.Add(BTN_SpoofStop);
            GB_Spoofer.Controls.Add(BTN_Spoof);
            GB_Spoofer.Location = new System.Drawing.Point(10, 17);
            GB_Spoofer.Name = "GB_Spoofer";
            GB_Spoofer.Size = new System.Drawing.Size(246, 385);
            GB_Spoofer.TabIndex = 11;
            GB_Spoofer.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(76, 309);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(137, 30);
            label2.TabIndex = 13;
            label2.Text = "Auto Unlock";
            // 
            // CHB_Automatic
            // 
            CHB_Automatic.AutoSize = true;
            CHB_Automatic.Location = new System.Drawing.Point(25, 309);
            CHB_Automatic.MinimumSize = new System.Drawing.Size(45, 22);
            CHB_Automatic.Name = "CHB_Automatic";
            CHB_Automatic.OffBackColor = System.Drawing.Color.Gray;
            CHB_Automatic.OffToggleColor = System.Drawing.Color.Gainsboro;
            CHB_Automatic.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            CHB_Automatic.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            CHB_Automatic.Size = new System.Drawing.Size(45, 22);
            CHB_Automatic.TabIndex = 12;
            CHB_Automatic.UseVisualStyleBackColor = true;
            // 
            // LBL_TimeSlapsed
            // 
            LBL_TimeSlapsed.AutoSize = true;
            LBL_TimeSlapsed.Dock = System.Windows.Forms.DockStyle.Bottom;
            LBL_TimeSlapsed.Location = new System.Drawing.Point(3, 365);
            LBL_TimeSlapsed.Name = "LBL_TimeSlapsed";
            LBL_TimeSlapsed.Size = new System.Drawing.Size(58, 17);
            LBL_TimeSlapsed.TabIndex = 11;
            LBL_TimeSlapsed.Text = "00:00:00";
            // 
            // LBL_TimeAchievements
            // 
            LBL_TimeAchievements.AutoSize = true;
            LBL_TimeAchievements.Location = new System.Drawing.Point(143, 339);
            LBL_TimeAchievements.Name = "LBL_TimeAchievements";
            LBL_TimeAchievements.Size = new System.Drawing.Size(74, 17);
            LBL_TimeAchievements.TabIndex = 10;
            LBL_TimeAchievements.Text = "99 Minutes";
            // 
            // gameImage
            // 
            gameImage.Location = new System.Drawing.Point(67, 22);
            gameImage.Name = "gameImage";
            gameImage.Size = new System.Drawing.Size(120, 120);
            gameImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            gameImage.TabIndex = 8;
            gameImage.TabStop = false;
            // 
            // panel3
            // 
            panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            panel3.Controls.Add(LBL_Timer);
            panel3.Location = new System.Drawing.Point(16, 152);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(215, 43);
            panel3.TabIndex = 7;
            // 
            // LBL_Timer
            // 
            LBL_Timer.AutoSize = true;
            LBL_Timer.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            LBL_Timer.Location = new System.Drawing.Point(12, -9);
            LBL_Timer.Name = "LBL_Timer";
            LBL_Timer.Size = new System.Drawing.Size(183, 54);
            LBL_Timer.TabIndex = 0;
            LBL_Timer.Text = "00:00:00";
            // 
            // BTN_SpoofStop
            // 
            BTN_SpoofStop.Location = new System.Drawing.Point(16, 251);
            BTN_SpoofStop.Name = "BTN_SpoofStop";
            BTN_SpoofStop.Size = new System.Drawing.Size(215, 43);
            BTN_SpoofStop.TabIndex = 5;
            BTN_SpoofStop.Text = "Stop";
            BTN_SpoofStop.UseVisualStyleBackColor = true;
            // 
            // BTN_Spoof
            // 
            BTN_Spoof.Location = new System.Drawing.Point(16, 202);
            BTN_Spoof.Name = "BTN_Spoof";
            BTN_Spoof.Size = new System.Drawing.Size(215, 43);
            BTN_Spoof.TabIndex = 3;
            BTN_Spoof.Text = "Start";
            BTN_Spoof.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            panel7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            panel7.Controls.Add(lblLink_completationTime);
            panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel7.Location = new System.Drawing.Point(0, 460);
            panel7.Name = "panel7";
            panel7.Size = new System.Drawing.Size(265, 28);
            panel7.TabIndex = 9;
            // 
            // lblLink_completationTime
            // 
            lblLink_completationTime.AutoSize = true;
            lblLink_completationTime.Location = new System.Drawing.Point(43, 2);
            lblLink_completationTime.Name = "lblLink_completationTime";
            lblLink_completationTime.Size = new System.Drawing.Size(175, 17);
            lblLink_completationTime.TabIndex = 8;
            lblLink_completationTime.TabStop = true;
            lblLink_completationTime.Text = "Completation Time: 4 - 6h";
            lblLink_completationTime.Visible = false;
            // 
            // SpoofingTime
            // 
            SpoofingTime.Interval = 1000;
            // 
            // StartApp
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(1264, 729);
            Controls.Add(PNL_ContentAchievements);
            Controls.Add(panel4);
            Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            MinimumSize = new System.Drawing.Size(1280, 768);
            Name = "StartApp";
            Padding = new System.Windows.Forms.Padding(10);
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "StartApp";
            Load += StartApp_Load;
            TABC_Header.ResumeLayout(false);
            TAB_StartApp.ResumeLayout(false);
            TAB_Misc.ResumeLayout(false);
            TAB_Profile.ResumeLayout(false);
            TAB_Profile.PerformLayout();
            PNL_LEFT.ResumeLayout(false);
            PNL_LEFT_HEADER.ResumeLayout(false);
            PNL_LEFT_HEADER.PerformLayout();
            panel4.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PB_GamerPicDisplay).EndInit();
            PNL_ContentAchievements.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            PNL_Spoofer.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel2.ResumeLayout(false);
            GB_Spoofer.ResumeLayout(false);
            GB_Spoofer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gameImage).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.NotifyIcon NTI_App;
        private System.Windows.Forms.ToolStripPanel BottomToolStripPanel;
        private System.Windows.Forms.ToolStripPanel TopToolStripPanel;
        private System.Windows.Forms.ToolStripPanel RightToolStripPanel;
        private System.Windows.Forms.ToolStripContentPanel ContentPanel;
        private System.Windows.Forms.TabControl TABC_Header;
        private System.Windows.Forms.TabPage TAB_Info;
        private System.Windows.Forms.TabPage TAB_StartApp;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel PNL_LEFT;
        private System.Windows.Forms.Panel PNL_LEFT_HEADER;
        private System.Windows.Forms.TabPage TAB_Misc;
        private System.Windows.Forms.TabPage TAB_Profile;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel PNL_ContentAchievements;
        private CustomControls.ButtomRadius BTN_ReloadXboxApp;
        private CustomControls.ButtomRadius BTN_ExtracCredentials;
        private CustomControls.ButtomRadius BTN_SendInfo;
        private CustomControls.ButtomRadius BTN_SaveGameList;
        private CustomControls.CircularPictureBox PB_GamerPicDisplay;
        private CustomControls.ButtomRadius BTN_Token;
        private CustomControls.ButtomRadius BTN_XUID;
        private System.Windows.Forms.Label LBL_GameScore;
        private System.Windows.Forms.Label LBL_GamerTag;
        private CustomControls.ButtomRadius BTN_InjectGame;
        public System.Windows.Forms.TabControl TABC_Achievements;
        private System.Windows.Forms.Panel PNL_Spoofer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox GB_Spoofer;
        private System.Windows.Forms.Label label2;
        private CustomControls.ToggleButton CHB_Automatic;
        private System.Windows.Forms.Label LBL_TimeSlapsed;
        private System.Windows.Forms.Label LBL_TimeAchievements;
        private System.Windows.Forms.PictureBox gameImage;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label LBL_Timer;
        private System.Windows.Forms.Button BTN_SpoofStop;
        private System.Windows.Forms.Button BTN_Spoof;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.LinkLabel lblLink_completationTime;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer SpoofingTime;
    }
}