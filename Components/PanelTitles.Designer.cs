namespace Xbox_Achievement_Unlocker.Components
{
    partial class PanelTitles
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
            FLP_ListGames = new System.Windows.Forms.FlowLayoutPanel();
            TAB_TitlesGames = new System.Windows.Forms.TabControl();
            TAB_Compatible = new System.Windows.Forms.TabPage();
            TAB_Incompatible = new System.Windows.Forms.TabPage();
            TAB_All = new System.Windows.Forms.TabPage();
            TAB_TitlesGames.SuspendLayout();
            TAB_Compatible.SuspendLayout();
            SuspendLayout();
            // 
            // FLP_ListGames
            // 
            FLP_ListGames.AutoScroll = true;
            FLP_ListGames.BackColor = System.Drawing.SystemColors.Control;
            FLP_ListGames.Dock = System.Windows.Forms.DockStyle.Fill;
            FLP_ListGames.Location = new System.Drawing.Point(3, 3);
            FLP_ListGames.Name = "FLP_ListGames";
            FLP_ListGames.Size = new System.Drawing.Size(278, 528);
            FLP_ListGames.TabIndex = 0;
            // 
            // TAB_TitlesGames
            // 
            TAB_TitlesGames.Controls.Add(TAB_Compatible);
            TAB_TitlesGames.Controls.Add(TAB_Incompatible);
            TAB_TitlesGames.Controls.Add(TAB_All);
            TAB_TitlesGames.Dock = System.Windows.Forms.DockStyle.Fill;
            TAB_TitlesGames.Location = new System.Drawing.Point(0, 30);
            TAB_TitlesGames.Name = "TAB_TitlesGames";
            TAB_TitlesGames.SelectedIndex = 0;
            TAB_TitlesGames.Size = new System.Drawing.Size(292, 562);
            TAB_TitlesGames.TabIndex = 1;
            TAB_TitlesGames.SelectedIndexChanged += TAB_TitlesGames_SelectedIndexChanged;
            // 
            // TAB_Compatible
            // 
            TAB_Compatible.Controls.Add(FLP_ListGames);
            TAB_Compatible.Location = new System.Drawing.Point(4, 24);
            TAB_Compatible.Name = "TAB_Compatible";
            TAB_Compatible.Padding = new System.Windows.Forms.Padding(3);
            TAB_Compatible.Size = new System.Drawing.Size(284, 534);
            TAB_Compatible.TabIndex = 0;
            TAB_Compatible.Text = "Compatible";
            TAB_Compatible.UseVisualStyleBackColor = true;
            // 
            // TAB_Incompatible
            // 
            TAB_Incompatible.Location = new System.Drawing.Point(4, 24);
            TAB_Incompatible.Name = "TAB_Incompatible";
            TAB_Incompatible.Padding = new System.Windows.Forms.Padding(3);
            TAB_Incompatible.Size = new System.Drawing.Size(284, 534);
            TAB_Incompatible.TabIndex = 1;
            TAB_Incompatible.Text = "Incompatible";
            TAB_Incompatible.UseVisualStyleBackColor = true;
            // 
            // TAB_All
            // 
            TAB_All.Location = new System.Drawing.Point(4, 24);
            TAB_All.Name = "TAB_All";
            TAB_All.Size = new System.Drawing.Size(284, 534);
            TAB_All.TabIndex = 2;
            TAB_All.Text = "All";
            TAB_All.UseVisualStyleBackColor = true;
            // 
            // PanelTitles
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            Controls.Add(TAB_TitlesGames);
            Name = "PanelTitles";
            Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            Size = new System.Drawing.Size(292, 592);
            Load += PanelTitles_Load;
            TAB_TitlesGames.ResumeLayout(false);
            TAB_Compatible.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel FLP_ListGames;
        private System.Windows.Forms.TabControl TAB_TitlesGames;
        private System.Windows.Forms.TabPage TAB_Compatible;
        private System.Windows.Forms.TabPage TAB_Incompatible;
        private System.Windows.Forms.TabPage TAB_All;
    }
}
