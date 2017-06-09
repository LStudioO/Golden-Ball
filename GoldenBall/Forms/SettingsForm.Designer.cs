namespace GoldenBall.Forms
{
    partial class SettingsForm
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
            this.btnOK = new System.Windows.Forms.Button();
            this.lblPlayer = new System.Windows.Forms.Label();
            this.nudPlayersCount = new System.Windows.Forms.NumericUpDown();
            this.lblTeam = new System.Windows.Forms.Label();
            this.nudTeamsCount = new System.Windows.Forms.NumericUpDown();
            this.chkUnique = new System.Windows.Forms.CheckBox();
            this.chkInterim = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudPlayersCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTeamsCount)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(94, 123);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 28;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lblPlayer
            // 
            this.lblPlayer.AutoSize = true;
            this.lblPlayer.Location = new System.Drawing.Point(12, 43);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(74, 13);
            this.lblPlayer.TabIndex = 32;
            this.lblPlayer.Text = "Players count:";
            // 
            // nudPlayersCount
            // 
            this.nudPlayersCount.Location = new System.Drawing.Point(109, 41);
            this.nudPlayersCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPlayersCount.Name = "nudPlayersCount";
            this.nudPlayersCount.Size = new System.Drawing.Size(60, 20);
            this.nudPlayersCount.TabIndex = 31;
            this.nudPlayersCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblTeam
            // 
            this.lblTeam.AutoSize = true;
            this.lblTeam.Location = new System.Drawing.Point(12, 14);
            this.lblTeam.Name = "lblTeam";
            this.lblTeam.Size = new System.Drawing.Size(72, 13);
            this.lblTeam.TabIndex = 34;
            this.lblTeam.Text = "Teams count:";
            // 
            // nudTeamsCount
            // 
            this.nudTeamsCount.Location = new System.Drawing.Point(109, 12);
            this.nudTeamsCount.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudTeamsCount.Name = "nudTeamsCount";
            this.nudTeamsCount.Size = new System.Drawing.Size(60, 20);
            this.nudTeamsCount.TabIndex = 33;
            this.nudTeamsCount.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // chkUnique
            // 
            this.chkUnique.AutoSize = true;
            this.chkUnique.Location = new System.Drawing.Point(15, 74);
            this.chkUnique.Name = "chkUnique";
            this.chkUnique.Size = new System.Drawing.Size(118, 17);
            this.chkUnique.TabIndex = 35;
            this.chkUnique.Text = "Only unique players";
            this.chkUnique.UseVisualStyleBackColor = true;
            // 
            // chkInterim
            // 
            this.chkInterim.AutoSize = true;
            this.chkInterim.Location = new System.Drawing.Point(15, 97);
            this.chkInterim.Name = "chkInterim";
            this.chkInterim.Size = new System.Drawing.Size(113, 17);
            this.chkInterim.TabIndex = 36;
            this.chkInterim.Text = "Print interim results";
            this.chkInterim.UseVisualStyleBackColor = true;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(188, 154);
            this.Controls.Add(this.chkInterim);
            this.Controls.Add(this.chkUnique);
            this.Controls.Add(this.lblTeam);
            this.Controls.Add(this.nudTeamsCount);
            this.Controls.Add(this.lblPlayer);
            this.Controls.Add(this.nudPlayersCount);
            this.Controls.Add(this.btnOK);
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.GenerationParams_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudPlayersCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTeamsCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lblPlayer;
        private System.Windows.Forms.NumericUpDown nudPlayersCount;
        private System.Windows.Forms.Label lblTeam;
        private System.Windows.Forms.NumericUpDown nudTeamsCount;
        private System.Windows.Forms.CheckBox chkUnique;
        private System.Windows.Forms.CheckBox chkInterim;
    }
}