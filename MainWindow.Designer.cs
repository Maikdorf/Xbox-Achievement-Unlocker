﻿
namespace Xbox_Achievement_Unlocker
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            BGWorker = new System.ComponentModel.BackgroundWorker();
            LBL_Attached = new System.Windows.Forms.Label();
            LBL_Xauth = new System.Windows.Forms.TextBox();
            BTN_GrabXauth = new System.Windows.Forms.Button();
            LBL_Gamertag = new System.Windows.Forms.Label();
            LBL_Gamerscore = new System.Windows.Forms.Label();
            Panel_Compatible = new System.Windows.Forms.Panel();
            BTN_SpoofGame = new System.Windows.Forms.Button();
            TXT_Xuid = new System.Windows.Forms.TextBox();
            BTN_SaveToFile = new System.Windows.Forms.Button();
            LST_GameFilterType = new System.Windows.Forms.ComboBox();
            label1 = new System.Windows.Forms.Label();
            Skidbox = new System.Windows.Forms.RichTextBox();
            BTN_fixer = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            TXT_GameFilterTitle = new System.Windows.Forms.TextBox();
            BTN_StatsEditor = new System.Windows.Forms.Button();
            tabControl_Global = new System.Windows.Forms.TabControl();
            tab_compatible = new System.Windows.Forms.TabPage();
            tab_incompatible = new System.Windows.Forms.TabPage();
            Panel_inCompatible = new System.Windows.Forms.Panel();
            tab_others = new System.Windows.Forms.TabPage();
            statusStrip1 = new System.Windows.Forms.StatusStrip();
            TS_progressBar = new System.Windows.Forms.ToolStripStatusLabel();
            PB_loading = new System.Windows.Forms.ToolStripProgressBar();
            tabControl_Global.SuspendLayout();
            tab_compatible.SuspendLayout();
            tab_incompatible.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // BGWorker
            // 
            BGWorker.WorkerReportsProgress = true;
            BGWorker.DoWork += BGWorker_DoWork;
            BGWorker.ProgressChanged += BGWorker_ProgressChanged;
            BGWorker.RunWorkerCompleted += BGWorker_RunWorkerCompleted;
            // 
            // LBL_Attached
            // 
            LBL_Attached.AutoSize = true;
            LBL_Attached.ForeColor = System.Drawing.Color.Red;
            LBL_Attached.Location = new System.Drawing.Point(12, 9);
            LBL_Attached.Name = "LBL_Attached";
            LBL_Attached.Size = new System.Drawing.Size(145, 15);
            LBL_Attached.TabIndex = 0;
            LBL_Attached.Text = "Not attached to Xbox App";
            // 
            // LBL_Xauth
            // 
            LBL_Xauth.BackColor = System.Drawing.SystemColors.Control;
            LBL_Xauth.BorderStyle = System.Windows.Forms.BorderStyle.None;
            LBL_Xauth.Location = new System.Drawing.Point(12, 102);
            LBL_Xauth.Name = "LBL_Xauth";
            LBL_Xauth.Size = new System.Drawing.Size(37, 16);
            LBL_Xauth.TabIndex = 16;
            LBL_Xauth.Text = "xauth:";
            // 
            // BTN_GrabXauth
            // 
            BTN_GrabXauth.Enabled = false;
            BTN_GrabXauth.Location = new System.Drawing.Point(12, 124);
            BTN_GrabXauth.Name = "BTN_GrabXauth";
            BTN_GrabXauth.Size = new System.Drawing.Size(158, 46);
            BTN_GrabXauth.TabIndex = 2;
            BTN_GrabXauth.Text = "Grab All";
            BTN_GrabXauth.UseVisualStyleBackColor = true;
            BTN_GrabXauth.Click += BTN_GrabXauth_Click;
            // 
            // LBL_Gamertag
            // 
            LBL_Gamertag.AutoSize = true;
            LBL_Gamertag.Location = new System.Drawing.Point(173, 121);
            LBL_Gamertag.Name = "LBL_Gamertag";
            LBL_Gamertag.Size = new System.Drawing.Size(65, 15);
            LBL_Gamertag.TabIndex = 6;
            LBL_Gamertag.Text = "Gamertag: ";
            LBL_Gamertag.Visible = false;
            // 
            // LBL_Gamerscore
            // 
            LBL_Gamerscore.AutoSize = true;
            LBL_Gamerscore.Location = new System.Drawing.Point(173, 137);
            LBL_Gamerscore.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            LBL_Gamerscore.Name = "LBL_Gamerscore";
            LBL_Gamerscore.Size = new System.Drawing.Size(76, 15);
            LBL_Gamerscore.TabIndex = 7;
            LBL_Gamerscore.Text = "Gamerscore: ";
            LBL_Gamerscore.Visible = false;
            // 
            // Panel_Compatible
            // 
            Panel_Compatible.AutoScroll = true;
            Panel_Compatible.Dock = System.Windows.Forms.DockStyle.Fill;
            Panel_Compatible.Location = new System.Drawing.Point(3, 3);
            Panel_Compatible.Name = "Panel_Compatible";
            Panel_Compatible.Size = new System.Drawing.Size(798, 361);
            Panel_Compatible.TabIndex = 8;
            // 
            // BTN_SpoofGame
            // 
            BTN_SpoofGame.Enabled = false;
            BTN_SpoofGame.Location = new System.Drawing.Point(687, 161);
            BTN_SpoofGame.Name = "BTN_SpoofGame";
            BTN_SpoofGame.Size = new System.Drawing.Size(122, 23);
            BTN_SpoofGame.TabIndex = 5;
            BTN_SpoofGame.Text = "Open Game Spoofer";
            BTN_SpoofGame.UseVisualStyleBackColor = true;
            BTN_SpoofGame.Click += BTN_SpoofGame_Click;
            // 
            // TXT_Xuid
            // 
            TXT_Xuid.BackColor = System.Drawing.SystemColors.Control;
            TXT_Xuid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            TXT_Xuid.Location = new System.Drawing.Point(177, 154);
            TXT_Xuid.Name = "TXT_Xuid";
            TXT_Xuid.Size = new System.Drawing.Size(158, 16);
            TXT_Xuid.TabIndex = 10;
            TXT_Xuid.Text = "XUID:";
            // 
            // BTN_SaveToFile
            // 
            BTN_SaveToFile.Enabled = false;
            BTN_SaveToFile.Location = new System.Drawing.Point(687, 86);
            BTN_SaveToFile.Name = "BTN_SaveToFile";
            BTN_SaveToFile.Size = new System.Drawing.Size(122, 46);
            BTN_SaveToFile.TabIndex = 4;
            BTN_SaveToFile.Text = "Save games list to file";
            BTN_SaveToFile.UseVisualStyleBackColor = true;
            BTN_SaveToFile.Click += BTN_SaveToFile_Click;
            // 
            // LST_GameFilterType
            // 
            LST_GameFilterType.FormattingEnabled = true;
            LST_GameFilterType.Items.AddRange(new object[] { "All", "Console Only", "New Gen", "Win32" });
            LST_GameFilterType.Location = new System.Drawing.Point(542, 134);
            LST_GameFilterType.Name = "LST_GameFilterType";
            LST_GameFilterType.Size = new System.Drawing.Size(99, 23);
            LST_GameFilterType.TabIndex = 3;
            LST_GameFilterType.SelectedIndexChanged += LST_GameFilter_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(422, 137);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(85, 15);
            label1.TabIndex = 13;
            label1.Text = "Filter Platform:";
            // 
            // Skidbox
            // 
            Skidbox.BackColor = System.Drawing.SystemColors.Control;
            Skidbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            Skidbox.Location = new System.Drawing.Point(163, 6);
            Skidbox.Name = "Skidbox";
            Skidbox.ReadOnly = true;
            Skidbox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            Skidbox.Size = new System.Drawing.Size(625, 96);
            Skidbox.TabIndex = 14;
            Skidbox.Text = resources.GetString("Skidbox.Text");
            Skidbox.LinkClicked += Skidbox_LinkClicked;
            // 
            // BTN_fixer
            // 
            BTN_fixer.Location = new System.Drawing.Point(12, 27);
            BTN_fixer.Name = "BTN_fixer";
            BTN_fixer.Size = new System.Drawing.Size(145, 69);
            BTN_fixer.TabIndex = 1;
            BTN_fixer.Text = "FuckyWucky \r\nFixer";
            BTN_fixer.UseVisualStyleBackColor = true;
            BTN_fixer.Click += BTN_fixer_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(422, 161);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(109, 15);
            label2.TabIndex = 17;
            label2.Text = "Filter Name/TitleID:";
            // 
            // TXT_GameFilterTitle
            // 
            TXT_GameFilterTitle.Location = new System.Drawing.Point(542, 158);
            TXT_GameFilterTitle.Name = "TXT_GameFilterTitle";
            TXT_GameFilterTitle.Size = new System.Drawing.Size(99, 23);
            TXT_GameFilterTitle.TabIndex = 18;
            // 
            // BTN_StatsEditor
            // 
            BTN_StatsEditor.Enabled = false;
            BTN_StatsEditor.Location = new System.Drawing.Point(686, 136);
            BTN_StatsEditor.Name = "BTN_StatsEditor";
            BTN_StatsEditor.Size = new System.Drawing.Size(122, 23);
            BTN_StatsEditor.TabIndex = 20;
            BTN_StatsEditor.Text = "Open Stats Editor";
            BTN_StatsEditor.UseVisualStyleBackColor = true;
            BTN_StatsEditor.Click += BTN_StatsEditor_Click;
            // 
            // tabControl_Global
            // 
            tabControl_Global.Controls.Add(tab_compatible);
            tabControl_Global.Controls.Add(tab_incompatible);
            tabControl_Global.Controls.Add(tab_others);
            tabControl_Global.Location = new System.Drawing.Point(4, 185);
            tabControl_Global.Name = "tabControl_Global";
            tabControl_Global.SelectedIndex = 0;
            tabControl_Global.Size = new System.Drawing.Size(812, 395);
            tabControl_Global.TabIndex = 21;
            // 
            // tab_compatible
            // 
            tab_compatible.Controls.Add(Panel_Compatible);
            tab_compatible.Location = new System.Drawing.Point(4, 24);
            tab_compatible.Name = "tab_compatible";
            tab_compatible.Padding = new System.Windows.Forms.Padding(3);
            tab_compatible.Size = new System.Drawing.Size(804, 367);
            tab_compatible.TabIndex = 0;
            tab_compatible.Text = "Compatible";
            tab_compatible.UseVisualStyleBackColor = true;
            // 
            // tab_incompatible
            // 
            tab_incompatible.Controls.Add(Panel_inCompatible);
            tab_incompatible.Location = new System.Drawing.Point(4, 24);
            tab_incompatible.Name = "tab_incompatible";
            tab_incompatible.Padding = new System.Windows.Forms.Padding(3);
            tab_incompatible.Size = new System.Drawing.Size(804, 367);
            tab_incompatible.TabIndex = 1;
            tab_incompatible.Text = "Incompatible";
            tab_incompatible.UseVisualStyleBackColor = true;
            // 
            // Panel_inCompatible
            // 
            Panel_inCompatible.AutoScroll = true;
            Panel_inCompatible.Dock = System.Windows.Forms.DockStyle.Fill;
            Panel_inCompatible.Location = new System.Drawing.Point(3, 3);
            Panel_inCompatible.Name = "Panel_inCompatible";
            Panel_inCompatible.Size = new System.Drawing.Size(798, 361);
            Panel_inCompatible.TabIndex = 9;
            // 
            // tab_others
            // 
            tab_others.Location = new System.Drawing.Point(4, 24);
            tab_others.Name = "tab_others";
            tab_others.Size = new System.Drawing.Size(804, 367);
            tab_others.TabIndex = 2;
            tab_others.Text = "Others";
            tab_others.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { TS_progressBar, PB_loading });
            statusStrip1.Location = new System.Drawing.Point(0, 579);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new System.Drawing.Size(828, 22);
            statusStrip1.TabIndex = 22;
            statusStrip1.Text = "statusStrip1";
            // 
            // TS_progressBar
            // 
            TS_progressBar.Name = "TS_progressBar";
            TS_progressBar.Size = new System.Drawing.Size(59, 17);
            TS_progressBar.Text = "Loading...";
            // 
            // PB_loading
            // 
            PB_loading.Name = "PB_loading";
            PB_loading.Size = new System.Drawing.Size(100, 16);
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(828, 601);
            Controls.Add(statusStrip1);
            Controls.Add(tabControl_Global);
            Controls.Add(BTN_StatsEditor);
            Controls.Add(TXT_GameFilterTitle);
            Controls.Add(label2);
            Controls.Add(BTN_fixer);
            Controls.Add(label1);
            Controls.Add(LST_GameFilterType);
            Controls.Add(BTN_SaveToFile);
            Controls.Add(BTN_SpoofGame);
            Controls.Add(TXT_Xuid);
            Controls.Add(LBL_Gamerscore);
            Controls.Add(LBL_Gamertag);
            Controls.Add(BTN_GrabXauth);
            Controls.Add(LBL_Xauth);
            Controls.Add(Skidbox);
            Controls.Add(LBL_Attached);
            Name = "MainWindow";
            Text = "MainWindow";
            Shown += MainWindow_Shown;
            tabControl_Global.ResumeLayout(false);
            tab_compatible.ResumeLayout(false);
            tab_incompatible.ResumeLayout(false);
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.ComponentModel.BackgroundWorker BGWorker;
        private System.Windows.Forms.Label LBL_Attached;
        private System.Windows.Forms.TextBox LBL_Xauth;
        private System.Windows.Forms.Button BTN_GrabXauth;
        private System.Windows.Forms.Label LBL_Gamertag;
        private System.Windows.Forms.Label LBL_Gamerscore;
        private System.Windows.Forms.Panel Panel_Compatible;
        private System.Windows.Forms.Button BTN_SpoofGame;
        private System.Windows.Forms.TextBox TXT_Xuid;
        private System.Windows.Forms.Button BTN_SaveToFile;
        private System.Windows.Forms.ComboBox LST_GameFilterType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox Skidbox;
        private System.Windows.Forms.Button BTN_fixer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TXT_GameFilterTitle;
        private System.Windows.Forms.Button BTN_StatsEditor;
        private System.Windows.Forms.TabControl tabControl_Global;
        private System.Windows.Forms.TabPage tab_compatible;
        private System.Windows.Forms.TabPage tab_incompatible;
        private System.Windows.Forms.TabPage tab_others;
        private System.Windows.Forms.Panel Panel_inCompatible;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar PB_loading;
        private System.Windows.Forms.ToolStripStatusLabel TS_progressBar;
    }
}

