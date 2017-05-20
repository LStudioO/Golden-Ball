namespace GoldenBall
{
    partial class MainForm
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
            this.tourDiagram = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabMethods = new System.Windows.Forms.TabControl();
            this.tabGB = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.tabGA = new System.Windows.Forms.TabPage();
            this.nudRandomSeed = new System.Windows.Forms.NumericUpDown();
            this.nudCityOdds = new System.Windows.Forms.NumericUpDown();
            this.nudNearbyCities = new System.Windows.Forms.NumericUpDown();
            this.nudMaxGeneration = new System.Windows.Forms.NumericUpDown();
            this.nudGroupSize = new System.Windows.Forms.NumericUpDown();
            this.nudMutation = new System.Windows.Forms.NumericUpDown();
            this.nudPopulationSize = new System.Windows.Forms.NumericUpDown();
            this.CloseCityOddsLabel = new System.Windows.Forms.Label();
            this.NumberCloseCitiesLabel = new System.Windows.Forms.Label();
            this.mutationLabel = new System.Windows.Forms.Label();
            this.randomSeedLabel = new System.Windows.Forms.Label();
            this.groupSizeLabel = new System.Windows.Forms.Label();
            this.maxGenerationLabel = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.PopulationSizeLabel = new System.Windows.Forms.Label();
            this.populationSizeTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tourDiagram)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.tabMethods.SuspendLayout();
            this.tabGB.SuspendLayout();
            this.tabGA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRandomSeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCityOdds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNearbyCities)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxGeneration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGroupSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMutation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPopulationSize)).BeginInit();
            this.SuspendLayout();
            // 
            // tourDiagram
            // 
            this.tourDiagram.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tourDiagram.BackColor = System.Drawing.Color.White;
            this.tourDiagram.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tourDiagram.Location = new System.Drawing.Point(12, 27);
            this.tourDiagram.Name = "tourDiagram";
            this.tourDiagram.Size = new System.Drawing.Size(534, 361);
            this.tourDiagram.TabIndex = 1;
            this.tourDiagram.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.generateToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(802, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // generateToolStripMenuItem
            // 
            this.generateToolStripMenuItem.Name = "generateToolStripMenuItem";
            this.generateToolStripMenuItem.Size = new System.Drawing.Size(138, 20);
            this.generateToolStripMenuItem.Text = "Generate random task ";
            this.generateToolStripMenuItem.Click += new System.EventHandler(this.generateToolStripMenuItem_Click);
            // 
            // tabMethods
            // 
            this.tabMethods.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabMethods.Controls.Add(this.tabGB);
            this.tabMethods.Controls.Add(this.tabGA);
            this.tabMethods.Location = new System.Drawing.Point(570, 27);
            this.tabMethods.Name = "tabMethods";
            this.tabMethods.SelectedIndex = 0;
            this.tabMethods.Size = new System.Drawing.Size(221, 363);
            this.tabMethods.TabIndex = 3;
            // 
            // tabGB
            // 
            this.tabGB.Controls.Add(this.button1);
            this.tabGB.Location = new System.Drawing.Point(4, 22);
            this.tabGB.Name = "tabGB";
            this.tabGB.Padding = new System.Windows.Forms.Padding(3);
            this.tabGB.Size = new System.Drawing.Size(213, 337);
            this.tabGB.TabIndex = 0;
            this.tabGB.Text = "Golden Ball";
            this.tabGB.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(6, 297);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(201, 34);
            this.button1.TabIndex = 35;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tabGA
            // 
            this.tabGA.Controls.Add(this.nudRandomSeed);
            this.tabGA.Controls.Add(this.nudCityOdds);
            this.tabGA.Controls.Add(this.nudNearbyCities);
            this.tabGA.Controls.Add(this.nudMaxGeneration);
            this.tabGA.Controls.Add(this.nudGroupSize);
            this.tabGA.Controls.Add(this.nudMutation);
            this.tabGA.Controls.Add(this.nudPopulationSize);
            this.tabGA.Controls.Add(this.CloseCityOddsLabel);
            this.tabGA.Controls.Add(this.NumberCloseCitiesLabel);
            this.tabGA.Controls.Add(this.mutationLabel);
            this.tabGA.Controls.Add(this.randomSeedLabel);
            this.tabGA.Controls.Add(this.groupSizeLabel);
            this.tabGA.Controls.Add(this.maxGenerationLabel);
            this.tabGA.Controls.Add(this.btnStart);
            this.tabGA.Controls.Add(this.PopulationSizeLabel);
            this.tabGA.Location = new System.Drawing.Point(4, 22);
            this.tabGA.Name = "tabGA";
            this.tabGA.Padding = new System.Windows.Forms.Padding(3);
            this.tabGA.Size = new System.Drawing.Size(213, 337);
            this.tabGA.TabIndex = 1;
            this.tabGA.Text = "Genetic Algorithm";
            this.tabGA.UseVisualStyleBackColor = true;
            // 
            // nudRandomSeed
            // 
            this.nudRandomSeed.Location = new System.Drawing.Point(9, 253);
            this.nudRandomSeed.Name = "nudRandomSeed";
            this.nudRandomSeed.Size = new System.Drawing.Size(198, 20);
            this.nudRandomSeed.TabIndex = 45;
            // 
            // nudCityOdds
            // 
            this.nudCityOdds.Location = new System.Drawing.Point(9, 209);
            this.nudCityOdds.Name = "nudCityOdds";
            this.nudCityOdds.Size = new System.Drawing.Size(198, 20);
            this.nudCityOdds.TabIndex = 44;
            // 
            // nudNearbyCities
            // 
            this.nudNearbyCities.Location = new System.Drawing.Point(9, 170);
            this.nudNearbyCities.Name = "nudNearbyCities";
            this.nudNearbyCities.Size = new System.Drawing.Size(198, 20);
            this.nudNearbyCities.TabIndex = 43;
            // 
            // nudMaxGeneration
            // 
            this.nudMaxGeneration.Location = new System.Drawing.Point(9, 133);
            this.nudMaxGeneration.Name = "nudMaxGeneration";
            this.nudMaxGeneration.Size = new System.Drawing.Size(198, 20);
            this.nudMaxGeneration.TabIndex = 42;
            // 
            // nudGroupSize
            // 
            this.nudGroupSize.Location = new System.Drawing.Point(9, 97);
            this.nudGroupSize.Name = "nudGroupSize";
            this.nudGroupSize.Size = new System.Drawing.Size(198, 20);
            this.nudGroupSize.TabIndex = 41;
            // 
            // nudMutation
            // 
            this.nudMutation.Location = new System.Drawing.Point(9, 61);
            this.nudMutation.Name = "nudMutation";
            this.nudMutation.Size = new System.Drawing.Size(198, 20);
            this.nudMutation.TabIndex = 40;
            // 
            // nudPopulationSize
            // 
            this.nudPopulationSize.Location = new System.Drawing.Point(9, 21);
            this.nudPopulationSize.Name = "nudPopulationSize";
            this.nudPopulationSize.Size = new System.Drawing.Size(198, 20);
            this.nudPopulationSize.TabIndex = 39;
            // 
            // CloseCityOddsLabel
            // 
            this.CloseCityOddsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseCityOddsLabel.AutoSize = true;
            this.CloseCityOddsLabel.Location = new System.Drawing.Point(6, 193);
            this.CloseCityOddsLabel.Name = "CloseCityOddsLabel";
            this.CloseCityOddsLabel.Size = new System.Drawing.Size(100, 13);
            this.CloseCityOddsLabel.TabIndex = 37;
            this.CloseCityOddsLabel.Text = "Nearby City Odds %";
            // 
            // NumberCloseCitiesLabel
            // 
            this.NumberCloseCitiesLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NumberCloseCitiesLabel.AutoSize = true;
            this.NumberCloseCitiesLabel.Location = new System.Drawing.Point(6, 153);
            this.NumberCloseCitiesLabel.Name = "NumberCloseCitiesLabel";
            this.NumberCloseCitiesLabel.Size = new System.Drawing.Size(79, 13);
            this.NumberCloseCitiesLabel.TabIndex = 35;
            this.NumberCloseCitiesLabel.Text = "# Nearby Cities";
            // 
            // mutationLabel
            // 
            this.mutationLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mutationLabel.AutoSize = true;
            this.mutationLabel.Location = new System.Drawing.Point(6, 45);
            this.mutationLabel.Name = "mutationLabel";
            this.mutationLabel.Size = new System.Drawing.Size(59, 13);
            this.mutationLabel.TabIndex = 33;
            this.mutationLabel.Text = "Mutation %";
            // 
            // randomSeedLabel
            // 
            this.randomSeedLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.randomSeedLabel.AutoSize = true;
            this.randomSeedLabel.Location = new System.Drawing.Point(6, 233);
            this.randomSeedLabel.Name = "randomSeedLabel";
            this.randomSeedLabel.Size = new System.Drawing.Size(75, 13);
            this.randomSeedLabel.TabIndex = 22;
            this.randomSeedLabel.Text = "Random Seed";
            // 
            // groupSizeLabel
            // 
            this.groupSizeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupSizeLabel.AutoSize = true;
            this.groupSizeLabel.Location = new System.Drawing.Point(6, 81);
            this.groupSizeLabel.Name = "groupSizeLabel";
            this.groupSizeLabel.Size = new System.Drawing.Size(59, 13);
            this.groupSizeLabel.TabIndex = 21;
            this.groupSizeLabel.Text = "Group Size";
            // 
            // maxGenerationLabel
            // 
            this.maxGenerationLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maxGenerationLabel.AutoSize = true;
            this.maxGenerationLabel.Location = new System.Drawing.Point(6, 117);
            this.maxGenerationLabel.Name = "maxGenerationLabel";
            this.maxGenerationLabel.Size = new System.Drawing.Size(111, 13);
            this.maxGenerationLabel.TabIndex = 20;
            this.maxGenerationLabel.Text = "Maximum Generations";
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.Location = new System.Drawing.Point(6, 289);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(201, 34);
            this.btnStart.TabIndex = 34;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // PopulationSizeLabel
            // 
            this.PopulationSizeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PopulationSizeLabel.AutoSize = true;
            this.PopulationSizeLabel.Location = new System.Drawing.Point(6, 5);
            this.PopulationSizeLabel.Name = "PopulationSizeLabel";
            this.PopulationSizeLabel.Size = new System.Drawing.Size(80, 13);
            this.PopulationSizeLabel.TabIndex = 23;
            this.PopulationSizeLabel.Text = "Population Size";
            // 
            // populationSizeTextBox
            // 
            this.populationSizeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.populationSizeTextBox.Location = new System.Drawing.Point(479, 118);
            this.populationSizeTextBox.Name = "populationSizeTextBox";
            this.populationSizeTextBox.Size = new System.Drawing.Size(201, 20);
            this.populationSizeTextBox.TabIndex = 24;
            this.populationSizeTextBox.Text = "10000";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 433);
            this.Controls.Add(this.tabMethods);
            this.Controls.Add(this.tourDiagram);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.populationSizeTextBox);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(771, 471);
            this.Name = "MainForm";
            this.Text = "Course Work : TSP Solver using GB Algorithm";
            ((System.ComponentModel.ISupportInitialize)(this.tourDiagram)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabMethods.ResumeLayout(false);
            this.tabGB.ResumeLayout(false);
            this.tabGA.ResumeLayout(false);
            this.tabGA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRandomSeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCityOdds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNearbyCities)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxGeneration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGroupSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMutation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPopulationSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox tourDiagram;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.TabControl tabMethods;
        private System.Windows.Forms.TabPage tabGB;
        private System.Windows.Forms.TabPage tabGA;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox populationSizeTextBox;
        private System.Windows.Forms.ToolStripMenuItem generateToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown nudRandomSeed;
        private System.Windows.Forms.NumericUpDown nudCityOdds;
        private System.Windows.Forms.NumericUpDown nudNearbyCities;
        private System.Windows.Forms.NumericUpDown nudMaxGeneration;
        private System.Windows.Forms.NumericUpDown nudGroupSize;
        private System.Windows.Forms.NumericUpDown nudMutation;
        private System.Windows.Forms.NumericUpDown nudPopulationSize;
        private System.Windows.Forms.Label CloseCityOddsLabel;
        private System.Windows.Forms.Label NumberCloseCitiesLabel;
        private System.Windows.Forms.Label mutationLabel;
        private System.Windows.Forms.Label randomSeedLabel;
        private System.Windows.Forms.Label groupSizeLabel;
        private System.Windows.Forms.Label maxGenerationLabel;
        private System.Windows.Forms.Label PopulationSizeLabel;
    }
}

