namespace Xbox_Achievement_Unlocker.Components
{
    partial class PanelProfile
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            EC_PNL_Header = new CustomControls.ElipsePropControl();
            FLN_HEADER = new System.Windows.Forms.FlowLayoutPanel();
            PB_GamerPic = new CustomControls.CircularPictureBox();
            flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            LBL_GamerTag = new System.Windows.Forms.Label();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            LBL_GameScore = new System.Windows.Forms.Label();
            BTN_Token = new CustomControls.ButtomRadius();
            BTN_XUID = new CustomControls.ButtomRadius();
            LBL_Copied = new System.Windows.Forms.Label();
            EC_PNL_Body = new CustomControls.ElipsePropControl();
            PNL_Body = new System.Windows.Forms.Panel();
            BTN_SendInfo = new CustomControls.ButtomRadius();
            BTN_SaveGameList = new CustomControls.ButtomRadius();
            BTN_ReloadXboxApp = new CustomControls.ButtomRadius();
            BTN_ExtracCredentials = new CustomControls.ButtomRadius();
            label1 = new System.Windows.Forms.Label();
            FLN_HEADER.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PB_GamerPic).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            PNL_Body.SuspendLayout();
            SuspendLayout();
            // 
            // EC_PNL_Header
            // 
            EC_PNL_Header.CornerRadius = 25;
            EC_PNL_Header.TargetControl = FLN_HEADER;
            // 
            // FLN_HEADER
            // 
            FLN_HEADER.BackColor = System.Drawing.Color.FromArgb(0, 111, 219);
            FLN_HEADER.Controls.Add(PB_GamerPic);
            FLN_HEADER.Controls.Add(flowLayoutPanel1);
            FLN_HEADER.Controls.Add(BTN_Token);
            FLN_HEADER.Controls.Add(BTN_XUID);
            FLN_HEADER.Controls.Add(LBL_Copied);
            FLN_HEADER.Dock = System.Windows.Forms.DockStyle.Top;
            FLN_HEADER.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            FLN_HEADER.Location = new System.Drawing.Point(0, 0);
            FLN_HEADER.Name = "FLN_HEADER";
            FLN_HEADER.Size = new System.Drawing.Size(782, 171);
            FLN_HEADER.TabIndex = 4;
            // 
            // PB_GamerPic
            // 
            PB_GamerPic.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            PB_GamerPic.BorderColor = System.Drawing.Color.White;
            PB_GamerPic.BorderColor2 = System.Drawing.Color.HotPink;
            PB_GamerPic.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            PB_GamerPic.BorderSize = 2;
            PB_GamerPic.Dock = System.Windows.Forms.DockStyle.Left;
            PB_GamerPic.GradientAngle = 50F;
            PB_GamerPic.ImageLocation = "";
            PB_GamerPic.Location = new System.Drawing.Point(3, 3);
            PB_GamerPic.Name = "PB_GamerPic";
            PB_GamerPic.Size = new System.Drawing.Size(116, 116);
            PB_GamerPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            PB_GamerPic.TabIndex = 0;
            PB_GamerPic.TabStop = false;
            PB_GamerPic.WaitOnLoad = true;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(LBL_GamerTag);
            flowLayoutPanel1.Controls.Add(iconPictureBox1);
            flowLayoutPanel1.Controls.Add(LBL_GameScore);
            flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            flowLayoutPanel1.Location = new System.Drawing.Point(125, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(5, 10, 5, 10);
            flowLayoutPanel1.Size = new System.Drawing.Size(141, 116);
            flowLayoutPanel1.TabIndex = 14;
            // 
            // LBL_GamerTag
            // 
            LBL_GamerTag.AutoSize = true;
            LBL_GamerTag.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            LBL_GamerTag.ForeColor = System.Drawing.Color.White;
            LBL_GamerTag.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            LBL_GamerTag.Location = new System.Drawing.Point(8, 10);
            LBL_GamerTag.Name = "LBL_GamerTag";
            LBL_GamerTag.Size = new System.Drawing.Size(110, 25);
            LBL_GamerTag.TabIndex = 9;
            LBL_GamerTag.Text = "XXXXXXX";
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(0, 111, 219);
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Gratipay;
            iconPictureBox1.IconColor = System.Drawing.Color.White;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            iconPictureBox1.Location = new System.Drawing.Point(8, 38);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new System.Drawing.Size(32, 32);
            iconPictureBox1.TabIndex = 10;
            iconPictureBox1.TabStop = false;
            // 
            // LBL_GameScore
            // 
            LBL_GameScore.AutoSize = true;
            LBL_GameScore.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            LBL_GameScore.ForeColor = System.Drawing.Color.White;
            LBL_GameScore.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            LBL_GameScore.Location = new System.Drawing.Point(46, 35);
            LBL_GameScore.Name = "LBL_GameScore";
            LBL_GameScore.Size = new System.Drawing.Size(84, 25);
            LBL_GameScore.TabIndex = 11;
            LBL_GameScore.Text = "000000";
            // 
            // BTN_Token
            // 
            BTN_Token.BackColor = System.Drawing.Color.FromArgb(64, 147, 228);
            BTN_Token.BackgroundColor = System.Drawing.Color.FromArgb(64, 147, 228);
            BTN_Token.BorderColor = System.Drawing.Color.PaleVioletRed;
            BTN_Token.BorderRadius = 20;
            BTN_Token.BorderSize = 0;
            BTN_Token.Cursor = System.Windows.Forms.Cursors.Hand;
            BTN_Token.Enabled = false;
            BTN_Token.FlatAppearance.BorderSize = 0;
            BTN_Token.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            BTN_Token.ForeColor = System.Drawing.Color.White;
            BTN_Token.IconChar = FontAwesome.Sharp.IconChar.Key;
            BTN_Token.IconColor = System.Drawing.Color.White;
            BTN_Token.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BTN_Token.IconSize = 32;
            BTN_Token.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            BTN_Token.Location = new System.Drawing.Point(125, 125);
            BTN_Token.Name = "BTN_Token";
            BTN_Token.Size = new System.Drawing.Size(87, 39);
            BTN_Token.TabIndex = 0;
            BTN_Token.Text = "Token";
            BTN_Token.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            BTN_Token.TextColor = System.Drawing.Color.White;
            BTN_Token.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            BTN_Token.UseVisualStyleBackColor = false;
            BTN_Token.Click += CopyInfoClipBoard;
            // 
            // BTN_XUID
            // 
            BTN_XUID.BackColor = System.Drawing.Color.FromArgb(64, 147, 228);
            BTN_XUID.BackgroundColor = System.Drawing.Color.FromArgb(64, 147, 228);
            BTN_XUID.BorderColor = System.Drawing.Color.PaleVioletRed;
            BTN_XUID.BorderRadius = 20;
            BTN_XUID.BorderSize = 0;
            BTN_XUID.Cursor = System.Windows.Forms.Cursors.Hand;
            BTN_XUID.Enabled = false;
            BTN_XUID.FlatAppearance.BorderSize = 0;
            BTN_XUID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            BTN_XUID.ForeColor = System.Drawing.Color.White;
            BTN_XUID.IconChar = FontAwesome.Sharp.IconChar.Fingerprint;
            BTN_XUID.IconColor = System.Drawing.Color.White;
            BTN_XUID.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BTN_XUID.IconSize = 32;
            BTN_XUID.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            BTN_XUID.Location = new System.Drawing.Point(272, 3);
            BTN_XUID.Name = "BTN_XUID";
            BTN_XUID.Size = new System.Drawing.Size(87, 39);
            BTN_XUID.TabIndex = 12;
            BTN_XUID.Text = "Xuid";
            BTN_XUID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            BTN_XUID.TextColor = System.Drawing.Color.White;
            BTN_XUID.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            BTN_XUID.UseVisualStyleBackColor = false;
            BTN_XUID.Click += CopyInfoClipBoard;
            // 
            // LBL_Copied
            // 
            LBL_Copied.AutoSize = true;
            LBL_Copied.BackColor = System.Drawing.Color.Transparent;
            LBL_Copied.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            LBL_Copied.ForeColor = System.Drawing.Color.White;
            LBL_Copied.Location = new System.Drawing.Point(272, 45);
            LBL_Copied.Name = "LBL_Copied";
            LBL_Copied.Size = new System.Drawing.Size(65, 19);
            LBL_Copied.TabIndex = 13;
            LBL_Copied.Text = "Copied!";
            LBL_Copied.Visible = false;
            // 
            // EC_PNL_Body
            // 
            EC_PNL_Body.CornerRadius = 25;
            EC_PNL_Body.TargetControl = PNL_Body;
            // 
            // PNL_Body
            // 
            PNL_Body.BackColor = System.Drawing.Color.FromArgb(0, 111, 219);
            PNL_Body.Controls.Add(BTN_SendInfo);
            PNL_Body.Controls.Add(BTN_SaveGameList);
            PNL_Body.Controls.Add(BTN_ReloadXboxApp);
            PNL_Body.Controls.Add(BTN_ExtracCredentials);
            PNL_Body.Controls.Add(label1);
            PNL_Body.Dock = System.Windows.Forms.DockStyle.Bottom;
            PNL_Body.Location = new System.Drawing.Point(0, 177);
            PNL_Body.Name = "PNL_Body";
            PNL_Body.Size = new System.Drawing.Size(782, 288);
            PNL_Body.TabIndex = 3;
            // 
            // BTN_SendInfo
            // 
            BTN_SendInfo.BackColor = System.Drawing.Color.FromArgb(64, 147, 228);
            BTN_SendInfo.BackgroundColor = System.Drawing.Color.FromArgb(64, 147, 228);
            BTN_SendInfo.BorderColor = System.Drawing.Color.PaleVioletRed;
            BTN_SendInfo.BorderRadius = 20;
            BTN_SendInfo.BorderSize = 0;
            BTN_SendInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            BTN_SendInfo.Enabled = false;
            BTN_SendInfo.FlatAppearance.BorderSize = 0;
            BTN_SendInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            BTN_SendInfo.ForeColor = System.Drawing.Color.White;
            BTN_SendInfo.IconChar = FontAwesome.Sharp.IconChar.PaperPlane;
            BTN_SendInfo.IconColor = System.Drawing.Color.White;
            BTN_SendInfo.IconFont = FontAwesome.Sharp.IconFont.Solid;
            BTN_SendInfo.IconSize = 60;
            BTN_SendInfo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            BTN_SendInfo.Location = new System.Drawing.Point(595, 145);
            BTN_SendInfo.Name = "BTN_SendInfo";
            BTN_SendInfo.Size = new System.Drawing.Size(150, 90);
            BTN_SendInfo.TabIndex = 17;
            BTN_SendInfo.Text = "Share Titles";
            BTN_SendInfo.TextColor = System.Drawing.Color.White;
            BTN_SendInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            BTN_SendInfo.UseVisualStyleBackColor = false;
            // 
            // BTN_SaveGameList
            // 
            BTN_SaveGameList.BackColor = System.Drawing.Color.FromArgb(64, 147, 228);
            BTN_SaveGameList.BackgroundColor = System.Drawing.Color.FromArgb(64, 147, 228);
            BTN_SaveGameList.BorderColor = System.Drawing.Color.PaleVioletRed;
            BTN_SaveGameList.BorderRadius = 20;
            BTN_SaveGameList.BorderSize = 0;
            BTN_SaveGameList.Cursor = System.Windows.Forms.Cursors.Hand;
            BTN_SaveGameList.Enabled = false;
            BTN_SaveGameList.FlatAppearance.BorderSize = 0;
            BTN_SaveGameList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            BTN_SaveGameList.ForeColor = System.Drawing.Color.White;
            BTN_SaveGameList.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            BTN_SaveGameList.IconColor = System.Drawing.Color.White;
            BTN_SaveGameList.IconFont = FontAwesome.Sharp.IconFont.Solid;
            BTN_SaveGameList.IconSize = 60;
            BTN_SaveGameList.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            BTN_SaveGameList.Location = new System.Drawing.Point(411, 145);
            BTN_SaveGameList.Name = "BTN_SaveGameList";
            BTN_SaveGameList.Size = new System.Drawing.Size(150, 90);
            BTN_SaveGameList.TabIndex = 16;
            BTN_SaveGameList.Text = "Save Game List";
            BTN_SaveGameList.TextColor = System.Drawing.Color.White;
            BTN_SaveGameList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            BTN_SaveGameList.UseVisualStyleBackColor = false;
            BTN_SaveGameList.Click += BTN_SaveGameList_Click;
            // 
            // BTN_ReloadXboxApp
            // 
            BTN_ReloadXboxApp.BackColor = System.Drawing.Color.FromArgb(0, 56, 110);
            BTN_ReloadXboxApp.BackgroundColor = System.Drawing.Color.FromArgb(0, 56, 110);
            BTN_ReloadXboxApp.BorderColor = System.Drawing.Color.PaleVioletRed;
            BTN_ReloadXboxApp.BorderRadius = 20;
            BTN_ReloadXboxApp.BorderSize = 0;
            BTN_ReloadXboxApp.Cursor = System.Windows.Forms.Cursors.Hand;
            BTN_ReloadXboxApp.FlatAppearance.BorderSize = 0;
            BTN_ReloadXboxApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            BTN_ReloadXboxApp.ForeColor = System.Drawing.Color.White;
            BTN_ReloadXboxApp.IconChar = FontAwesome.Sharp.IconChar.Repeat;
            BTN_ReloadXboxApp.IconColor = System.Drawing.Color.White;
            BTN_ReloadXboxApp.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BTN_ReloadXboxApp.IconSize = 60;
            BTN_ReloadXboxApp.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            BTN_ReloadXboxApp.Location = new System.Drawing.Point(230, 145);
            BTN_ReloadXboxApp.Name = "BTN_ReloadXboxApp";
            BTN_ReloadXboxApp.Size = new System.Drawing.Size(150, 90);
            BTN_ReloadXboxApp.TabIndex = 15;
            BTN_ReloadXboxApp.Text = "Reload Xbox App";
            BTN_ReloadXboxApp.TextColor = System.Drawing.Color.White;
            BTN_ReloadXboxApp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            BTN_ReloadXboxApp.UseVisualStyleBackColor = false;
            BTN_ReloadXboxApp.Click += BTN_ReloadXboxApp_Click;
            // 
            // BTN_ExtracCredentials
            // 
            BTN_ExtracCredentials.BackColor = System.Drawing.Color.FromArgb(64, 147, 228);
            BTN_ExtracCredentials.BackgroundColor = System.Drawing.Color.FromArgb(64, 147, 228);
            BTN_ExtracCredentials.BorderColor = System.Drawing.Color.White;
            BTN_ExtracCredentials.BorderRadius = 20;
            BTN_ExtracCredentials.BorderSize = 0;
            BTN_ExtracCredentials.Cursor = System.Windows.Forms.Cursors.Hand;
            BTN_ExtracCredentials.Enabled = false;
            BTN_ExtracCredentials.FlatAppearance.BorderSize = 0;
            BTN_ExtracCredentials.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            BTN_ExtracCredentials.ForeColor = System.Drawing.Color.White;
            BTN_ExtracCredentials.IconChar = FontAwesome.Sharp.IconChar.Hammer;
            BTN_ExtracCredentials.IconColor = System.Drawing.Color.White;
            BTN_ExtracCredentials.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BTN_ExtracCredentials.IconSize = 60;
            BTN_ExtracCredentials.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            BTN_ExtracCredentials.Location = new System.Drawing.Point(53, 145);
            BTN_ExtracCredentials.Name = "BTN_ExtracCredentials";
            BTN_ExtracCredentials.Size = new System.Drawing.Size(150, 90);
            BTN_ExtracCredentials.TabIndex = 14;
            BTN_ExtracCredentials.Text = "Extract Token";
            BTN_ExtracCredentials.TextColor = System.Drawing.Color.White;
            BTN_ExtracCredentials.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            BTN_ExtracCredentials.UseVisualStyleBackColor = false;
            BTN_ExtracCredentials.Click += BTN_ExtracCredentials_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.White;
            label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label1.Location = new System.Drawing.Point(36, 56);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(101, 32);
            label1.TabIndex = 10;
            label1.Text = "Utilities";
            // 
            // PanelProfile
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            BackColor = System.Drawing.Color.White;
            Controls.Add(PNL_Body);
            Controls.Add(FLN_HEADER);
            Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Name = "PanelProfile";
            Size = new System.Drawing.Size(782, 465);
            Load += PanelProfile_Load;
            FLN_HEADER.ResumeLayout(false);
            FLN_HEADER.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PB_GamerPic).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            PNL_Body.ResumeLayout(false);
            PNL_Body.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private CustomControls.ElipsePropControl EC_PNL_Header;
        private CustomControls.ElipsePropControl EC_PNL_Body;
        private System.Windows.Forms.Panel PNL_Body;
        private CustomControls.ButtomRadius BTN_SendInfo;
        private CustomControls.ButtomRadius BTN_SaveGameList;
        private CustomControls.ButtomRadius BTN_ReloadXboxApp;
        private CustomControls.ButtomRadius BTN_ExtracCredentials;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel FLN_HEADER;
        private CustomControls.CircularPictureBox PB_GamerPic;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label LBL_GamerTag;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Label LBL_GameScore;
        private CustomControls.ButtomRadius BTN_Token;
        private CustomControls.ButtomRadius BTN_XUID;
        private System.Windows.Forms.Label LBL_Copied;
    }
}
