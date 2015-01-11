namespace RITO
{
    partial class RITO
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
            this.textBoxSummoner = new System.Windows.Forms.TextBox();
            this.labelSummonerName = new System.Windows.Forms.Label();
            this.pictureBoxLeague = new System.Windows.Forms.PictureBox();
            this.buttonManualUpdate = new System.Windows.Forms.Button();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageRanked = new System.Windows.Forms.TabPage();
            this.labelAssistNum = new System.Windows.Forms.Label();
            this.labelAssists = new System.Windows.Forms.Label();
            this.labelSoloNum = new System.Windows.Forms.Label();
            this.labelSolo = new System.Windows.Forms.Label();
            this.labelPremadeNum = new System.Windows.Forms.Label();
            this.labelPremade = new System.Windows.Forms.Label();
            this.labelDeathNum = new System.Windows.Forms.Label();
            this.labelDeath = new System.Windows.Forms.Label();
            this.labelTimePlayedNum = new System.Windows.Forms.Label();
            this.labelTimePlayed = new System.Windows.Forms.Label();
            this.labelChampKillsNum = new System.Windows.Forms.Label();
            this.labelChampKills = new System.Windows.Forms.Label();
            this.tabPageNormal = new System.Windows.Forms.TabPage();
            this.tabPageDominion = new System.Windows.Forms.TabPage();
            this.progressBarUpdate = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLeague)).BeginInit();
            this.tabControlMain.SuspendLayout();
            this.tabPageRanked.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxSummoner
            // 
            this.textBoxSummoner.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSummoner.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxSummoner.Location = new System.Drawing.Point(106, 12);
            this.textBoxSummoner.Name = "textBoxSummoner";
            this.textBoxSummoner.Size = new System.Drawing.Size(141, 20);
            this.textBoxSummoner.TabIndex = 0;
            // 
            // labelSummonerName
            // 
            this.labelSummonerName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSummonerName.AutoSize = true;
            this.labelSummonerName.Location = new System.Drawing.Point(12, 15);
            this.labelSummonerName.Name = "labelSummonerName";
            this.labelSummonerName.Size = new System.Drawing.Size(91, 13);
            this.labelSummonerName.TabIndex = 1;
            this.labelSummonerName.Text = "Summoner Name:";
            // 
            // pictureBoxLeague
            // 
            this.pictureBoxLeague.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxLeague.Location = new System.Drawing.Point(382, 12);
            this.pictureBoxLeague.Name = "pictureBoxLeague";
            this.pictureBoxLeague.Size = new System.Drawing.Size(101, 92);
            this.pictureBoxLeague.TabIndex = 2;
            this.pictureBoxLeague.TabStop = false;
            // 
            // buttonManualUpdate
            // 
            this.buttonManualUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonManualUpdate.Location = new System.Drawing.Point(325, 313);
            this.buttonManualUpdate.Name = "buttonManualUpdate";
            this.buttonManualUpdate.Size = new System.Drawing.Size(158, 23);
            this.buttonManualUpdate.TabIndex = 3;
            this.buttonManualUpdate.Text = "Manual Update";
            this.buttonManualUpdate.UseVisualStyleBackColor = true;
            this.buttonManualUpdate.Click += new System.EventHandler(this.buttonManualUpdate_Click);
            // 
            // tabControlMain
            // 
            this.tabControlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlMain.Controls.Add(this.tabPageRanked);
            this.tabControlMain.Controls.Add(this.tabPageNormal);
            this.tabControlMain.Controls.Add(this.tabPageDominion);
            this.tabControlMain.Location = new System.Drawing.Point(15, 84);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(361, 223);
            this.tabControlMain.TabIndex = 5;
            // 
            // tabPageRanked
            // 
            this.tabPageRanked.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPageRanked.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPageRanked.Controls.Add(this.labelAssistNum);
            this.tabPageRanked.Controls.Add(this.labelAssists);
            this.tabPageRanked.Controls.Add(this.labelSoloNum);
            this.tabPageRanked.Controls.Add(this.labelSolo);
            this.tabPageRanked.Controls.Add(this.labelPremadeNum);
            this.tabPageRanked.Controls.Add(this.labelPremade);
            this.tabPageRanked.Controls.Add(this.labelDeathNum);
            this.tabPageRanked.Controls.Add(this.labelDeath);
            this.tabPageRanked.Controls.Add(this.labelTimePlayedNum);
            this.tabPageRanked.Controls.Add(this.labelTimePlayed);
            this.tabPageRanked.Controls.Add(this.labelChampKillsNum);
            this.tabPageRanked.Controls.Add(this.labelChampKills);
            this.tabPageRanked.Location = new System.Drawing.Point(4, 22);
            this.tabPageRanked.Name = "tabPageRanked";
            this.tabPageRanked.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRanked.Size = new System.Drawing.Size(353, 197);
            this.tabPageRanked.TabIndex = 0;
            this.tabPageRanked.Text = "Ranked";
            // 
            // labelAssistNum
            // 
            this.labelAssistNum.AutoSize = true;
            this.labelAssistNum.Location = new System.Drawing.Point(90, 42);
            this.labelAssistNum.Name = "labelAssistNum";
            this.labelAssistNum.Size = new System.Drawing.Size(13, 13);
            this.labelAssistNum.TabIndex = 11;
            this.labelAssistNum.Text = "0";
            // 
            // labelAssists
            // 
            this.labelAssists.AutoSize = true;
            this.labelAssists.Location = new System.Drawing.Point(6, 42);
            this.labelAssists.Name = "labelAssists";
            this.labelAssists.Size = new System.Drawing.Size(42, 13);
            this.labelAssists.TabIndex = 10;
            this.labelAssists.Text = "Assists:";
            // 
            // labelSoloNum
            // 
            this.labelSoloNum.AutoSize = true;
            this.labelSoloNum.Location = new System.Drawing.Point(90, 68);
            this.labelSoloNum.Name = "labelSoloNum";
            this.labelSoloNum.Size = new System.Drawing.Size(13, 13);
            this.labelSoloNum.TabIndex = 9;
            this.labelSoloNum.Text = "0";
            // 
            // labelSolo
            // 
            this.labelSolo.AutoSize = true;
            this.labelSolo.Location = new System.Drawing.Point(6, 68);
            this.labelSolo.Name = "labelSolo";
            this.labelSolo.Size = new System.Drawing.Size(67, 13);
            this.labelSolo.TabIndex = 8;
            this.labelSolo.Text = "Games Solo:";
            // 
            // labelPremadeNum
            // 
            this.labelPremadeNum.AutoSize = true;
            this.labelPremadeNum.Location = new System.Drawing.Point(90, 55);
            this.labelPremadeNum.Name = "labelPremadeNum";
            this.labelPremadeNum.Size = new System.Drawing.Size(13, 13);
            this.labelPremadeNum.TabIndex = 7;
            this.labelPremadeNum.Text = "0";
            // 
            // labelPremade
            // 
            this.labelPremade.AutoSize = true;
            this.labelPremade.Location = new System.Drawing.Point(6, 55);
            this.labelPremade.Name = "labelPremade";
            this.labelPremade.Size = new System.Drawing.Size(88, 13);
            this.labelPremade.TabIndex = 6;
            this.labelPremade.Text = "Games Premade:";
            // 
            // labelDeathNum
            // 
            this.labelDeathNum.AutoSize = true;
            this.labelDeathNum.Location = new System.Drawing.Point(90, 29);
            this.labelDeathNum.Name = "labelDeathNum";
            this.labelDeathNum.Size = new System.Drawing.Size(13, 13);
            this.labelDeathNum.TabIndex = 5;
            this.labelDeathNum.Text = "0";
            // 
            // labelDeath
            // 
            this.labelDeath.AutoSize = true;
            this.labelDeath.Location = new System.Drawing.Point(6, 29);
            this.labelDeath.Name = "labelDeath";
            this.labelDeath.Size = new System.Drawing.Size(44, 13);
            this.labelDeath.TabIndex = 4;
            this.labelDeath.Text = "Deaths:";
            // 
            // labelTimePlayedNum
            // 
            this.labelTimePlayedNum.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTimePlayedNum.AutoSize = true;
            this.labelTimePlayedNum.Location = new System.Drawing.Point(90, 3);
            this.labelTimePlayedNum.Name = "labelTimePlayedNum";
            this.labelTimePlayedNum.Size = new System.Drawing.Size(13, 13);
            this.labelTimePlayedNum.TabIndex = 3;
            this.labelTimePlayedNum.Text = "0";
            // 
            // labelTimePlayed
            // 
            this.labelTimePlayed.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTimePlayed.AutoSize = true;
            this.labelTimePlayed.Location = new System.Drawing.Point(6, 3);
            this.labelTimePlayed.Name = "labelTimePlayed";
            this.labelTimePlayed.Size = new System.Drawing.Size(68, 13);
            this.labelTimePlayed.TabIndex = 2;
            this.labelTimePlayed.Text = "Time Played:";
            // 
            // labelChampKillsNum
            // 
            this.labelChampKillsNum.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelChampKillsNum.AutoSize = true;
            this.labelChampKillsNum.Location = new System.Drawing.Point(90, 16);
            this.labelChampKillsNum.Name = "labelChampKillsNum";
            this.labelChampKillsNum.Size = new System.Drawing.Size(13, 13);
            this.labelChampKillsNum.TabIndex = 1;
            this.labelChampKillsNum.Text = "0";
            // 
            // labelChampKills
            // 
            this.labelChampKills.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelChampKills.AutoSize = true;
            this.labelChampKills.Location = new System.Drawing.Point(6, 16);
            this.labelChampKills.Name = "labelChampKills";
            this.labelChampKills.Size = new System.Drawing.Size(78, 13);
            this.labelChampKills.TabIndex = 0;
            this.labelChampKills.Text = "Champion Kills:";
            // 
            // tabPageNormal
            // 
            this.tabPageNormal.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPageNormal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPageNormal.Location = new System.Drawing.Point(4, 22);
            this.tabPageNormal.Name = "tabPageNormal";
            this.tabPageNormal.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageNormal.Size = new System.Drawing.Size(353, 197);
            this.tabPageNormal.TabIndex = 1;
            this.tabPageNormal.Text = "Normal";
            // 
            // tabPageDominion
            // 
            this.tabPageDominion.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPageDominion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPageDominion.Location = new System.Drawing.Point(4, 22);
            this.tabPageDominion.Name = "tabPageDominion";
            this.tabPageDominion.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDominion.Size = new System.Drawing.Size(353, 197);
            this.tabPageDominion.TabIndex = 2;
            this.tabPageDominion.Text = "Dominion";
            // 
            // progressBarUpdate
            // 
            this.progressBarUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBarUpdate.Location = new System.Drawing.Point(15, 313);
            this.progressBarUpdate.Name = "progressBarUpdate";
            this.progressBarUpdate.Size = new System.Drawing.Size(304, 23);
            this.progressBarUpdate.TabIndex = 6;
            // 
            // RITO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(495, 348);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.progressBarUpdate);
            this.Controls.Add(this.buttonManualUpdate);
            this.Controls.Add(this.pictureBoxLeague);
            this.Controls.Add(this.labelSummonerName);
            this.Controls.Add(this.textBoxSummoner);
            this.MaximumSize = new System.Drawing.Size(625, 444);
            this.MinimumSize = new System.Drawing.Size(511, 386);
            this.Name = "RITO";
            this.Text = "RITO";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLeague)).EndInit();
            this.tabControlMain.ResumeLayout(false);
            this.tabPageRanked.ResumeLayout(false);
            this.tabPageRanked.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSummoner;
        private System.Windows.Forms.Label labelSummonerName;
        private System.Windows.Forms.PictureBox pictureBoxLeague;
        private System.Windows.Forms.Button buttonManualUpdate;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageRanked;
        private System.Windows.Forms.TabPage tabPageNormal;
        private System.Windows.Forms.TabPage tabPageDominion;
        private System.Windows.Forms.ProgressBar progressBarUpdate;
        private System.Windows.Forms.Label labelTimePlayed;
        private System.Windows.Forms.Label labelChampKillsNum;
        private System.Windows.Forms.Label labelChampKills;
        private System.Windows.Forms.Label labelTimePlayedNum;
        private System.Windows.Forms.Label labelSoloNum;
        private System.Windows.Forms.Label labelSolo;
        private System.Windows.Forms.Label labelPremadeNum;
        private System.Windows.Forms.Label labelPremade;
        private System.Windows.Forms.Label labelDeathNum;
        private System.Windows.Forms.Label labelDeath;
        private System.Windows.Forms.Label labelAssistNum;
        private System.Windows.Forms.Label labelAssists;
    }
}

