namespace GoldenBall.Forms
{
    partial class GenerationParams
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
            this.CitiesCountValue = new System.Windows.Forms.NumericUpDown();
            this.lblCitiesCount = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.rbPlaceCircle = new System.Windows.Forms.RadioButton();
            this.rbPlaceRect = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.CitiesCountValue)).BeginInit();
            this.SuspendLayout();
            // 
            // CitiesCountValue
            // 
            this.CitiesCountValue.Location = new System.Drawing.Point(109, 12);
            this.CitiesCountValue.Name = "CitiesCountValue";
            this.CitiesCountValue.Size = new System.Drawing.Size(120, 20);
            this.CitiesCountValue.TabIndex = 26;
            // 
            // lblCitiesCount
            // 
            this.lblCitiesCount.AutoSize = true;
            this.lblCitiesCount.Location = new System.Drawing.Point(12, 14);
            this.lblCitiesCount.Name = "lblCitiesCount";
            this.lblCitiesCount.Size = new System.Drawing.Size(66, 13);
            this.lblCitiesCount.TabIndex = 27;
            this.lblCitiesCount.Text = "Cities Count:";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(154, 79);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 28;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // rbPlaceCircle
            // 
            this.rbPlaceCircle.AutoSize = true;
            this.rbPlaceCircle.Location = new System.Drawing.Point(12, 42);
            this.rbPlaceCircle.Name = "rbPlaceCircle";
            this.rbPlaceCircle.Size = new System.Drawing.Size(104, 17);
            this.rbPlaceCircle.TabIndex = 29;
            this.rbPlaceCircle.TabStop = true;
            this.rbPlaceCircle.Text = "Place on a circle";
            this.rbPlaceCircle.UseVisualStyleBackColor = true;
            // 
            // rbPlaceRect
            // 
            this.rbPlaceRect.AutoSize = true;
            this.rbPlaceRect.Location = new System.Drawing.Point(12, 65);
            this.rbPlaceRect.Name = "rbPlaceRect";
            this.rbPlaceRect.Size = new System.Drawing.Size(123, 17);
            this.rbPlaceRect.TabIndex = 30;
            this.rbPlaceRect.TabStop = true;
            this.rbPlaceRect.Text = "Place on a rectangle";
            this.rbPlaceRect.UseVisualStyleBackColor = true;
            // 
            // GenerationParams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 114);
            this.Controls.Add(this.rbPlaceRect);
            this.Controls.Add(this.rbPlaceCircle);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblCitiesCount);
            this.Controls.Add(this.CitiesCountValue);
            this.Name = "GenerationParams";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GenerationParams";
            ((System.ComponentModel.ISupportInitialize)(this.CitiesCountValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown CitiesCountValue;
        private System.Windows.Forms.Label lblCitiesCount;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.RadioButton rbPlaceCircle;
        private System.Windows.Forms.RadioButton rbPlaceRect;
    }
}