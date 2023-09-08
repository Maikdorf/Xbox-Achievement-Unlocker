namespace Xbox_Achievement_Unlocker.Components
{
    partial class CardGame
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
            LBL_TitleName = new System.Windows.Forms.Label();
            EC_Game = new CustomControls.ElipsePropControl();
            PBAR_Complete = new System.Windows.Forms.ProgressBar();
            PB_GamePic = new CustomControls.CircularPictureBox();
            BTN_CopyTitleId = new CustomControls.ButtomRadius();
            LBL_CountAchievements = new CustomControls.ButtomRadius();
            LBL_Current_GameScore = new CustomControls.ButtomRadius();
            ((System.ComponentModel.ISupportInitialize)PB_GamePic).BeginInit();
            SuspendLayout();
            // 
            // LBL_TitleName
            // 
            LBL_TitleName.AutoSize = true;
            LBL_TitleName.Cursor = System.Windows.Forms.Cursors.Hand;
            LBL_TitleName.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            LBL_TitleName.Location = new System.Drawing.Point(95, 15);
            LBL_TitleName.Margin = new System.Windows.Forms.Padding(0);
            LBL_TitleName.Name = "LBL_TitleName";
            LBL_TitleName.Size = new System.Drawing.Size(245, 17);
            LBL_TitleName.TabIndex = 1;
            LBL_TitleName.Text = "Marvel's Avenger - Definitve Edition";
            LBL_TitleName.Click += ShowAchievementsGame;
            // 
            // EC_Game
            // 
            EC_Game.CornerRadius = 5;
            EC_Game.TargetControl = this;
            // 
            // PBAR_Complete
            // 
            PBAR_Complete.Location = new System.Drawing.Point(0, 96);
            PBAR_Complete.Name = "PBAR_Complete";
            PBAR_Complete.Size = new System.Drawing.Size(345, 3);
            PBAR_Complete.TabIndex = 11;
            // 
            // PB_GamePic
            // 
            PB_GamePic.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            PB_GamePic.BorderColor = System.Drawing.Color.IndianRed;
            PB_GamePic.BorderColor2 = System.Drawing.Color.FromArgb(0, 111, 219);
            PB_GamePic.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            PB_GamePic.BorderSize = 2;
            PB_GamePic.Cursor = System.Windows.Forms.Cursors.Hand;
            PB_GamePic.GradientAngle = 50F;
            PB_GamePic.ImageLocation = "https://images-eds-ssl.xboxlive.com/image?url=27S1DHqE.cHkmFg4nspsdzRQL3QTblFqXPb0IRmhikcfRKOAu__V0DcHqVknY2qv9pOqbRwqDVVhE_o0BooP9Ld0i4pZbO16XUrQSK8A1f7zp1fQl3o7nm9dO25V35EvP4sPz1iiHNGHOMi2hbLUkQ--";
            PB_GamePic.Location = new System.Drawing.Point(3, 3);
            PB_GamePic.Name = "PB_GamePic";
            PB_GamePic.Size = new System.Drawing.Size(90, 90);
            PB_GamePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            PB_GamePic.TabIndex = 12;
            PB_GamePic.TabStop = false;
            PB_GamePic.Click += ShowAchievementsGame;
            // 
            // BTN_CopyTitleId
            // 
            BTN_CopyTitleId.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            BTN_CopyTitleId.BackColor = System.Drawing.Color.FromArgb(0, 111, 219);
            BTN_CopyTitleId.BackgroundColor = System.Drawing.Color.FromArgb(0, 111, 219);
            BTN_CopyTitleId.BorderColor = System.Drawing.Color.PaleVioletRed;
            BTN_CopyTitleId.BorderRadius = 15;
            BTN_CopyTitleId.BorderSize = 0;
            BTN_CopyTitleId.Cursor = System.Windows.Forms.Cursors.Hand;
            BTN_CopyTitleId.FlatAppearance.BorderSize = 0;
            BTN_CopyTitleId.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            BTN_CopyTitleId.ForeColor = System.Drawing.Color.White;
            BTN_CopyTitleId.IconChar = FontAwesome.Sharp.IconChar.Fingerprint;
            BTN_CopyTitleId.IconColor = System.Drawing.Color.White;
            BTN_CopyTitleId.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BTN_CopyTitleId.IconSize = 20;
            BTN_CopyTitleId.Location = new System.Drawing.Point(213, 39);
            BTN_CopyTitleId.Name = "BTN_CopyTitleId";
            BTN_CopyTitleId.Size = new System.Drawing.Size(108, 26);
            BTN_CopyTitleId.TabIndex = 28;
            BTN_CopyTitleId.Text = "Title ID";
            BTN_CopyTitleId.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            BTN_CopyTitleId.TextColor = System.Drawing.Color.White;
            BTN_CopyTitleId.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            BTN_CopyTitleId.UseVisualStyleBackColor = false;
            // 
            // LBL_CountAchievements
            // 
            LBL_CountAchievements.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            LBL_CountAchievements.BackColor = System.Drawing.Color.FromArgb(0, 111, 219);
            LBL_CountAchievements.BackgroundColor = System.Drawing.Color.FromArgb(0, 111, 219);
            LBL_CountAchievements.BorderColor = System.Drawing.Color.PaleVioletRed;
            LBL_CountAchievements.BorderRadius = 15;
            LBL_CountAchievements.BorderSize = 0;
            LBL_CountAchievements.Cursor = System.Windows.Forms.Cursors.Hand;
            LBL_CountAchievements.FlatAppearance.BorderSize = 0;
            LBL_CountAchievements.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            LBL_CountAchievements.ForeColor = System.Drawing.Color.White;
            LBL_CountAchievements.IconChar = FontAwesome.Sharp.IconChar.Trophy;
            LBL_CountAchievements.IconColor = System.Drawing.Color.White;
            LBL_CountAchievements.IconFont = FontAwesome.Sharp.IconFont.Auto;
            LBL_CountAchievements.IconSize = 20;
            LBL_CountAchievements.Location = new System.Drawing.Point(99, 39);
            LBL_CountAchievements.Name = "LBL_CountAchievements";
            LBL_CountAchievements.Size = new System.Drawing.Size(108, 26);
            LBL_CountAchievements.TabIndex = 29;
            LBL_CountAchievements.Text = "999 / 999";
            LBL_CountAchievements.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            LBL_CountAchievements.TextColor = System.Drawing.Color.White;
            LBL_CountAchievements.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            LBL_CountAchievements.UseVisualStyleBackColor = false;
            LBL_CountAchievements.Click += ShowAchievementsGame;
            // 
            // LBL_Current_GameScore
            // 
            LBL_Current_GameScore.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            LBL_Current_GameScore.BackColor = System.Drawing.Color.FromArgb(0, 111, 219);
            LBL_Current_GameScore.BackgroundColor = System.Drawing.Color.FromArgb(0, 111, 219);
            LBL_Current_GameScore.BorderColor = System.Drawing.Color.PaleVioletRed;
            LBL_Current_GameScore.BorderRadius = 15;
            LBL_Current_GameScore.BorderSize = 0;
            LBL_Current_GameScore.Cursor = System.Windows.Forms.Cursors.Hand;
            LBL_Current_GameScore.FlatAppearance.BorderSize = 0;
            LBL_Current_GameScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            LBL_Current_GameScore.ForeColor = System.Drawing.Color.White;
            LBL_Current_GameScore.IconChar = FontAwesome.Sharp.IconChar.Gofore;
            LBL_Current_GameScore.IconColor = System.Drawing.Color.White;
            LBL_Current_GameScore.IconFont = FontAwesome.Sharp.IconFont.Auto;
            LBL_Current_GameScore.IconSize = 19;
            LBL_Current_GameScore.Location = new System.Drawing.Point(99, 67);
            LBL_Current_GameScore.Name = "LBL_Current_GameScore";
            LBL_Current_GameScore.Size = new System.Drawing.Size(108, 26);
            LBL_Current_GameScore.TabIndex = 30;
            LBL_Current_GameScore.Text = "9999 / 9999";
            LBL_Current_GameScore.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            LBL_Current_GameScore.TextColor = System.Drawing.Color.White;
            LBL_Current_GameScore.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            LBL_Current_GameScore.UseVisualStyleBackColor = false;
            LBL_Current_GameScore.Click += ShowAchievementsGame;
            // 
            // CardGame
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.WhiteSmoke;
            Controls.Add(LBL_Current_GameScore);
            Controls.Add(LBL_CountAchievements);
            Controls.Add(BTN_CopyTitleId);
            Controls.Add(PB_GamePic);
            Controls.Add(PBAR_Complete);
            Controls.Add(LBL_TitleName);
            Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Name = "CardGame";
            Size = new System.Drawing.Size(350, 100);
            ((System.ComponentModel.ISupportInitialize)PB_GamePic).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label LBL_TitleName;
        private CustomControls.ElipsePropControl EC_Game;
        private System.Windows.Forms.ProgressBar PBAR_Complete;
        private CustomControls.CircularPictureBox PB_GamePic;
        private CustomControls.ButtomRadius BTN_CopyTitleId;
        private CustomControls.ButtomRadius LBL_Current_GameScore;
        private CustomControls.ButtomRadius LBL_CountAchievements;
    }
}
