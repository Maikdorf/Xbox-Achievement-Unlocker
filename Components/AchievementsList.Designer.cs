namespace Xbox_Achievement_Unlocker.Components
{
    partial class AchievementsList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            panel2 = new System.Windows.Forms.Panel();
            panel7 = new System.Windows.Forms.Panel();
            DGV_AchievementList = new System.Windows.Forms.DataGridView();
            panel1 = new System.Windows.Forms.Panel();
            LBL_TimeAchievements = new CustomControls.ButtomRadius();
            LBL_TimeSlapsed = new CustomControls.ButtomRadius();
            lblLink_completationTime = new CustomControls.ButtomRadius();
            PB_AchievementsList = new CustomControls.CircularPictureBox();
            LBL_TID_UIXD = new System.Windows.Forms.Label();
            LBL_TID = new System.Windows.Forms.Label();
            panel4 = new System.Windows.Forms.Panel();
            BTN_Refresh = new CustomControls.ButtomRadius();
            BTN_Unlock = new CustomControls.ButtomRadius();
            BTN_LaunchSpoof = new CustomControls.ButtomRadius();
            CL_Check = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            CL_Rarity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            CL_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            CL_Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            CL_Score = new System.Windows.Forms.DataGridViewTextBoxColumn();
            CL_Stats = new System.Windows.Forms.DataGridViewTextBoxColumn();
            CL_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            panel2.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGV_AchievementList).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PB_AchievementsList).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(panel7);
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(panel4);
            panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            panel2.Location = new System.Drawing.Point(10, 10);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(968, 627);
            panel2.TabIndex = 18;
            // 
            // panel7
            // 
            panel7.Controls.Add(DGV_AchievementList);
            panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            panel7.Location = new System.Drawing.Point(0, 98);
            panel7.Name = "panel7";
            panel7.Size = new System.Drawing.Size(968, 476);
            panel7.TabIndex = 17;
            // 
            // DGV_AchievementList
            // 
            DGV_AchievementList.AllowUserToAddRows = false;
            DGV_AchievementList.AllowUserToDeleteRows = false;
            DGV_AchievementList.AllowUserToResizeRows = false;
            DGV_AchievementList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            DGV_AchievementList.BackgroundColor = System.Drawing.SystemColors.Control;
            DGV_AchievementList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            DGV_AchievementList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            DGV_AchievementList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            DGV_AchievementList.ColumnHeadersHeight = 30;
            DGV_AchievementList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { CL_Check, CL_Rarity, CL_Name, CL_Description, CL_Score, CL_Stats, CL_ID });
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            DGV_AchievementList.DefaultCellStyle = dataGridViewCellStyle1;
            DGV_AchievementList.Dock = System.Windows.Forms.DockStyle.Fill;
            DGV_AchievementList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            DGV_AchievementList.GridColor = System.Drawing.SystemColors.MenuHighlight;
            DGV_AchievementList.Location = new System.Drawing.Point(0, 0);
            DGV_AchievementList.Name = "DGV_AchievementList";
            DGV_AchievementList.ReadOnly = true;
            DGV_AchievementList.RowHeadersVisible = false;
            DGV_AchievementList.RowHeadersWidth = 51;
            DGV_AchievementList.RowTemplate.Height = 25;
            DGV_AchievementList.RowTemplate.ReadOnly = true;
            DGV_AchievementList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            DGV_AchievementList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            DGV_AchievementList.ShowCellErrors = false;
            DGV_AchievementList.ShowCellToolTips = false;
            DGV_AchievementList.ShowEditingIcon = false;
            DGV_AchievementList.ShowRowErrors = false;
            DGV_AchievementList.Size = new System.Drawing.Size(968, 476);
            DGV_AchievementList.TabIndex = 1;
            DGV_AchievementList.CellClick += DGV_AchievementList_CellClick;
            // 
            // panel1
            // 
            panel1.Controls.Add(LBL_TimeAchievements);
            panel1.Controls.Add(LBL_TimeSlapsed);
            panel1.Controls.Add(lblLink_completationTime);
            panel1.Controls.Add(PB_AchievementsList);
            panel1.Controls.Add(LBL_TID_UIXD);
            panel1.Controls.Add(LBL_TID);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(968, 98);
            panel1.TabIndex = 14;
            // 
            // LBL_TimeAchievements
            // 
            LBL_TimeAchievements.BackColor = System.Drawing.Color.FromArgb(0, 111, 219);
            LBL_TimeAchievements.BackgroundColor = System.Drawing.Color.FromArgb(0, 111, 219);
            LBL_TimeAchievements.BorderColor = System.Drawing.Color.PaleVioletRed;
            LBL_TimeAchievements.BorderRadius = 10;
            LBL_TimeAchievements.BorderSize = 0;
            LBL_TimeAchievements.Cursor = System.Windows.Forms.Cursors.Hand;
            LBL_TimeAchievements.FlatAppearance.BorderSize = 0;
            LBL_TimeAchievements.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            LBL_TimeAchievements.ForeColor = System.Drawing.Color.White;
            LBL_TimeAchievements.IconChar = FontAwesome.Sharp.IconChar.Stopwatch;
            LBL_TimeAchievements.IconColor = System.Drawing.Color.White;
            LBL_TimeAchievements.IconFont = FontAwesome.Sharp.IconFont.Auto;
            LBL_TimeAchievements.IconSize = 20;
            LBL_TimeAchievements.Location = new System.Drawing.Point(112, 63);
            LBL_TimeAchievements.Name = "LBL_TimeAchievements";
            LBL_TimeAchievements.Size = new System.Drawing.Size(216, 26);
            LBL_TimeAchievements.TabIndex = 32;
            LBL_TimeAchievements.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            LBL_TimeAchievements.TextColor = System.Drawing.Color.White;
            LBL_TimeAchievements.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            LBL_TimeAchievements.UseVisualStyleBackColor = false;
            // 
            // LBL_TimeSlapsed
            // 
            LBL_TimeSlapsed.BackColor = System.Drawing.Color.FromArgb(0, 111, 219);
            LBL_TimeSlapsed.BackgroundColor = System.Drawing.Color.FromArgb(0, 111, 219);
            LBL_TimeSlapsed.BorderColor = System.Drawing.Color.PaleVioletRed;
            LBL_TimeSlapsed.BorderRadius = 10;
            LBL_TimeSlapsed.BorderSize = 0;
            LBL_TimeSlapsed.Cursor = System.Windows.Forms.Cursors.Hand;
            LBL_TimeSlapsed.FlatAppearance.BorderSize = 0;
            LBL_TimeSlapsed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            LBL_TimeSlapsed.ForeColor = System.Drawing.Color.White;
            LBL_TimeSlapsed.IconChar = FontAwesome.Sharp.IconChar.Stopwatch;
            LBL_TimeSlapsed.IconColor = System.Drawing.Color.White;
            LBL_TimeSlapsed.IconFont = FontAwesome.Sharp.IconFont.Auto;
            LBL_TimeSlapsed.IconSize = 20;
            LBL_TimeSlapsed.Location = new System.Drawing.Point(334, 37);
            LBL_TimeSlapsed.Name = "LBL_TimeSlapsed";
            LBL_TimeSlapsed.Size = new System.Drawing.Size(216, 26);
            LBL_TimeSlapsed.TabIndex = 31;
            LBL_TimeSlapsed.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            LBL_TimeSlapsed.TextColor = System.Drawing.Color.White;
            LBL_TimeSlapsed.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            LBL_TimeSlapsed.UseVisualStyleBackColor = false;
            // 
            // lblLink_completationTime
            // 
            lblLink_completationTime.BackColor = System.Drawing.Color.FromArgb(0, 111, 219);
            lblLink_completationTime.BackgroundColor = System.Drawing.Color.FromArgb(0, 111, 219);
            lblLink_completationTime.BorderColor = System.Drawing.Color.PaleVioletRed;
            lblLink_completationTime.BorderRadius = 10;
            lblLink_completationTime.BorderSize = 0;
            lblLink_completationTime.Cursor = System.Windows.Forms.Cursors.Hand;
            lblLink_completationTime.FlatAppearance.BorderSize = 0;
            lblLink_completationTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            lblLink_completationTime.ForeColor = System.Drawing.Color.White;
            lblLink_completationTime.IconChar = FontAwesome.Sharp.IconChar.Stopwatch;
            lblLink_completationTime.IconColor = System.Drawing.Color.White;
            lblLink_completationTime.IconFont = FontAwesome.Sharp.IconFont.Auto;
            lblLink_completationTime.IconSize = 20;
            lblLink_completationTime.Location = new System.Drawing.Point(112, 37);
            lblLink_completationTime.Name = "lblLink_completationTime";
            lblLink_completationTime.Size = new System.Drawing.Size(216, 26);
            lblLink_completationTime.TabIndex = 30;
            lblLink_completationTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            lblLink_completationTime.TextColor = System.Drawing.Color.White;
            lblLink_completationTime.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            lblLink_completationTime.UseVisualStyleBackColor = false;
            // 
            // PB_AchievementsList
            // 
            PB_AchievementsList.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            PB_AchievementsList.BorderColor = System.Drawing.Color.RoyalBlue;
            PB_AchievementsList.BorderColor2 = System.Drawing.Color.HotPink;
            PB_AchievementsList.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            PB_AchievementsList.BorderSize = 2;
            PB_AchievementsList.GradientAngle = 50F;
            PB_AchievementsList.Location = new System.Drawing.Point(17, 4);
            PB_AchievementsList.Name = "PB_AchievementsList";
            PB_AchievementsList.Size = new System.Drawing.Size(89, 89);
            PB_AchievementsList.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            PB_AchievementsList.TabIndex = 2;
            PB_AchievementsList.TabStop = false;
            // 
            // LBL_TID_UIXD
            // 
            LBL_TID_UIXD.Anchor = System.Windows.Forms.AnchorStyles.Right;
            LBL_TID_UIXD.AutoSize = true;
            LBL_TID_UIXD.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            LBL_TID_UIXD.Location = new System.Drawing.Point(1387, -264);
            LBL_TID_UIXD.Name = "LBL_TID_UIXD";
            LBL_TID_UIXD.Size = new System.Drawing.Size(157, 30);
            LBL_TID_UIXD.TabIndex = 1;
            LBL_TID_UIXD.Text = "123493827832";
            // 
            // LBL_TID
            // 
            LBL_TID.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            LBL_TID.Location = new System.Drawing.Point(112, 4);
            LBL_TID.Name = "LBL_TID";
            LBL_TID.Size = new System.Drawing.Size(710, 30);
            LBL_TID.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Controls.Add(BTN_Refresh);
            panel4.Controls.Add(BTN_Unlock);
            panel4.Controls.Add(BTN_LaunchSpoof);
            panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel4.Location = new System.Drawing.Point(0, 574);
            panel4.Name = "panel4";
            panel4.Size = new System.Drawing.Size(968, 53);
            panel4.TabIndex = 0;
            // 
            // BTN_Refresh
            // 
            BTN_Refresh.Anchor = System.Windows.Forms.AnchorStyles.None;
            BTN_Refresh.BackColor = System.Drawing.Color.Black;
            BTN_Refresh.BackgroundColor = System.Drawing.Color.Black;
            BTN_Refresh.BorderColor = System.Drawing.Color.PaleVioletRed;
            BTN_Refresh.BorderRadius = 20;
            BTN_Refresh.BorderSize = 0;
            BTN_Refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            BTN_Refresh.FlatAppearance.BorderSize = 0;
            BTN_Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            BTN_Refresh.ForeColor = System.Drawing.Color.White;
            BTN_Refresh.IconChar = FontAwesome.Sharp.IconChar.Key;
            BTN_Refresh.IconColor = System.Drawing.Color.White;
            BTN_Refresh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BTN_Refresh.IconSize = 32;
            BTN_Refresh.Location = new System.Drawing.Point(432, 6);
            BTN_Refresh.Name = "BTN_Refresh";
            BTN_Refresh.Size = new System.Drawing.Size(134, 39);
            BTN_Refresh.TabIndex = 26;
            BTN_Refresh.Text = "Refresh";
            BTN_Refresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            BTN_Refresh.TextColor = System.Drawing.Color.White;
            BTN_Refresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            BTN_Refresh.UseVisualStyleBackColor = false;
            BTN_Refresh.Click += BTN_Refresh_Click;
            // 
            // BTN_Unlock
            // 
            BTN_Unlock.BackColor = System.Drawing.Color.Black;
            BTN_Unlock.BackgroundColor = System.Drawing.Color.Black;
            BTN_Unlock.BorderColor = System.Drawing.Color.PaleVioletRed;
            BTN_Unlock.BorderRadius = 20;
            BTN_Unlock.BorderSize = 0;
            BTN_Unlock.Cursor = System.Windows.Forms.Cursors.Hand;
            BTN_Unlock.FlatAppearance.BorderSize = 0;
            BTN_Unlock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            BTN_Unlock.ForeColor = System.Drawing.Color.White;
            BTN_Unlock.IconChar = FontAwesome.Sharp.IconChar.Key;
            BTN_Unlock.IconColor = System.Drawing.Color.White;
            BTN_Unlock.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BTN_Unlock.IconSize = 32;
            BTN_Unlock.Location = new System.Drawing.Point(17, 6);
            BTN_Unlock.Name = "BTN_Unlock";
            BTN_Unlock.Size = new System.Drawing.Size(134, 39);
            BTN_Unlock.TabIndex = 25;
            BTN_Unlock.Text = "Unlock Selected";
            BTN_Unlock.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            BTN_Unlock.TextColor = System.Drawing.Color.White;
            BTN_Unlock.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            BTN_Unlock.UseVisualStyleBackColor = false;
            BTN_Unlock.Click += BTN_Unlock_Click;
            // 
            // BTN_LaunchSpoof
            // 
            BTN_LaunchSpoof.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            BTN_LaunchSpoof.BackColor = System.Drawing.Color.Black;
            BTN_LaunchSpoof.BackgroundColor = System.Drawing.Color.Black;
            BTN_LaunchSpoof.BorderColor = System.Drawing.Color.PaleVioletRed;
            BTN_LaunchSpoof.BorderRadius = 20;
            BTN_LaunchSpoof.BorderSize = 0;
            BTN_LaunchSpoof.Cursor = System.Windows.Forms.Cursors.Hand;
            BTN_LaunchSpoof.FlatAppearance.BorderSize = 0;
            BTN_LaunchSpoof.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            BTN_LaunchSpoof.ForeColor = System.Drawing.Color.White;
            BTN_LaunchSpoof.IconChar = FontAwesome.Sharp.IconChar.HourglassHalf;
            BTN_LaunchSpoof.IconColor = System.Drawing.Color.White;
            BTN_LaunchSpoof.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BTN_LaunchSpoof.IconSize = 25;
            BTN_LaunchSpoof.Location = new System.Drawing.Point(818, 6);
            BTN_LaunchSpoof.Name = "BTN_LaunchSpoof";
            BTN_LaunchSpoof.Size = new System.Drawing.Size(134, 39);
            BTN_LaunchSpoof.TabIndex = 27;
            BTN_LaunchSpoof.Text = "Game Spoofer";
            BTN_LaunchSpoof.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            BTN_LaunchSpoof.TextColor = System.Drawing.Color.White;
            BTN_LaunchSpoof.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            BTN_LaunchSpoof.UseVisualStyleBackColor = false;
            BTN_LaunchSpoof.Click += BTN_LaunchSpoof_Click;
            // 
            // CL_Check
            // 
            CL_Check.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            CL_Check.FalseValue = "0";
            CL_Check.FillWeight = 50F;
            CL_Check.HeaderText = "";
            CL_Check.IndeterminateValue = "2";
            CL_Check.MinimumWidth = 30;
            CL_Check.Name = "CL_Check";
            CL_Check.ReadOnly = true;
            CL_Check.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            CL_Check.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            CL_Check.TrueValue = "1";
            CL_Check.Width = 50;
            // 
            // CL_Rarity
            // 
            CL_Rarity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            CL_Rarity.FillWeight = 50F;
            CL_Rarity.HeaderText = "%";
            CL_Rarity.MinimumWidth = 50;
            CL_Rarity.Name = "CL_Rarity";
            CL_Rarity.ReadOnly = true;
            CL_Rarity.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            CL_Rarity.Width = 50;
            // 
            // CL_Name
            // 
            CL_Name.FillWeight = 150F;
            CL_Name.HeaderText = "Name";
            CL_Name.MinimumWidth = 80;
            CL_Name.Name = "CL_Name";
            CL_Name.ReadOnly = true;
            CL_Name.Width = 80;
            // 
            // CL_Description
            // 
            CL_Description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            CL_Description.FillWeight = 300F;
            CL_Description.HeaderText = "Description";
            CL_Description.MinimumWidth = 100;
            CL_Description.Name = "CL_Description";
            CL_Description.ReadOnly = true;
            // 
            // CL_Score
            // 
            CL_Score.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            CL_Score.FillWeight = 50F;
            CL_Score.HeaderText = "Score";
            CL_Score.MinimumWidth = 50;
            CL_Score.Name = "CL_Score";
            CL_Score.ReadOnly = true;
            CL_Score.Width = 50;
            // 
            // CL_Stats
            // 
            CL_Stats.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            CL_Stats.FillWeight = 300F;
            CL_Stats.HeaderText = "Unlock Time";
            CL_Stats.MinimumWidth = 100;
            CL_Stats.Name = "CL_Stats";
            CL_Stats.ReadOnly = true;
            CL_Stats.Width = 150;
            // 
            // CL_ID
            // 
            CL_ID.FillWeight = 40F;
            CL_ID.HeaderText = "ID";
            CL_ID.MinimumWidth = 6;
            CL_ID.Name = "CL_ID";
            CL_ID.ReadOnly = true;
            CL_ID.Visible = false;
            CL_ID.Width = 20;
            // 
            // AchievementsList
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(panel2);
            Name = "AchievementsList";
            Padding = new System.Windows.Forms.Padding(10);
            Size = new System.Drawing.Size(988, 647);
            Load += AchievementsList_Load;
            panel2.ResumeLayout(false);
            panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DGV_AchievementList).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PB_AchievementsList).EndInit();
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel7;
        public System.Windows.Forms.DataGridView DGV_AchievementList;
        private System.Windows.Forms.Panel panel1;
        private CustomControls.CircularPictureBox PB_AchievementsList;
        private System.Windows.Forms.Label LBL_TID_UIXD;
        private System.Windows.Forms.Label LBL_TID;
        private System.Windows.Forms.Panel panel4;
        private CustomControls.ButtomRadius BTN_Unlock;
        private CustomControls.ButtomRadius BTN_Refresh;
        private CustomControls.ButtomRadius BTN_LaunchSpoof;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CL_Check;
        private System.Windows.Forms.DataGridViewTextBoxColumn CL_Rarity;
        private System.Windows.Forms.DataGridViewTextBoxColumn CL_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn CL_Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn CL_Score;
        private System.Windows.Forms.DataGridViewTextBoxColumn CL_Stats;
        private System.Windows.Forms.DataGridViewTextBoxColumn CL_ID;
        private CustomControls.ButtomRadius lblLink_completationTime;
        private CustomControls.ButtomRadius LBL_TimeSlapsed;
        private CustomControls.ButtomRadius LBL_TimeAchievements;
    }
}
