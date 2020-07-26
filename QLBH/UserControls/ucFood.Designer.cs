namespace QLBH.UserControls
{
    partial class ucFood
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbFoodImage = new System.Windows.Forms.PictureBox();
            this.lbFoodName = new System.Windows.Forms.Label();
            this.nmCount = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoodImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmCount)).BeginInit();
            this.SuspendLayout();
            // 
            // pbFoodImage
            // 
            this.pbFoodImage.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbFoodImage.Location = new System.Drawing.Point(0, 0);
            this.pbFoodImage.Name = "pbFoodImage";
            this.pbFoodImage.Size = new System.Drawing.Size(220, 153);
            this.pbFoodImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFoodImage.TabIndex = 0;
            this.pbFoodImage.TabStop = false;
            // 
            // lbFoodName
            // 
            this.lbFoodName.AutoSize = true;
            this.lbFoodName.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbFoodName.Location = new System.Drawing.Point(12, 164);
            this.lbFoodName.Name = "lbFoodName";
            this.lbFoodName.Size = new System.Drawing.Size(46, 17);
            this.lbFoodName.TabIndex = 1;
            this.lbFoodName.Text = "label1";
            // 
            // nmCount
            // 
            this.nmCount.Location = new System.Drawing.Point(165, 162);
            this.nmCount.Name = "nmCount";
            this.nmCount.Size = new System.Drawing.Size(43, 22);
            this.nmCount.TabIndex = 2;
            this.nmCount.ValueChanged += new System.EventHandler(this.nmCount_ValueChanged);
            // 
            // ucFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.nmCount);
            this.Controls.Add(this.lbFoodName);
            this.Controls.Add(this.pbFoodImage);
            this.Name = "ucFood";
            this.Size = new System.Drawing.Size(220, 200);
            ((System.ComponentModel.ISupportInitialize)(this.pbFoodImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbFoodImage;
        private System.Windows.Forms.Label lbFoodName;
        private System.Windows.Forms.NumericUpDown nmCount;
    }
}
