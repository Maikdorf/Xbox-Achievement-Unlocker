namespace Xbox_Achievement_Unlocker.Components
{
    partial class UserControl1
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
            PNL_Body = new System.Windows.Forms.Panel();
            BTN_SendInfo = new CustomControls.ButtomRadius();
            BTN_SaveGameList = new CustomControls.ButtomRadius();
            BTN_ReloadXboxApp = new CustomControls.ButtomRadius();
            BTN_ExtracCredentials = new CustomControls.ButtomRadius();
            label1 = new System.Windows.Forms.Label();
            PNL_Body.SuspendLayout();
            SuspendLayout();
            // 
            // PNL_Body
            // 
            PNL_Body.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            PNL_Body.BackColor = System.Drawing.Color.FromArgb(0, 111, 219);
            PNL_Body.Controls.Add(BTN_SendInfo);
            PNL_Body.Controls.Add(BTN_SaveGameList);
            PNL_Body.Controls.Add(BTN_ReloadXboxApp);
            PNL_Body.Controls.Add(BTN_ExtracCredentials);
            PNL_Body.Controls.Add(label1);
            PNL_Body.Location = new System.Drawing.Point(-33, 149);
            PNL_Body.Name = "PNL_Body";
            PNL_Body.Size = new System.Drawing.Size(1005, 259);
            PNL_Body.TabIndex = 2;
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
            // UserControl1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(PNL_Body);
            Name = "UserControl1";
            Size = new System.Drawing.Size(940, 558);
            PNL_Body.ResumeLayout(false);
            PNL_Body.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel PNL_Body;
        private CustomControls.ButtomRadius BTN_SendInfo;
        private CustomControls.ButtomRadius BTN_SaveGameList;
        private CustomControls.ButtomRadius BTN_ReloadXboxApp;
        private CustomControls.ButtomRadius BTN_ExtracCredentials;
        private System.Windows.Forms.Label label1;
    }
}
