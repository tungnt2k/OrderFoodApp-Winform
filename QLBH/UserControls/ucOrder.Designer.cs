namespace QLBH.UserControls
{
    partial class ucOrder
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
            this.lbFoodName = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.lbCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbFoodName
            // 
            this.lbFoodName.AutoSize = true;
            this.lbFoodName.Location = new System.Drawing.Point(17, 26);
            this.lbFoodName.Name = "lbFoodName";
            this.lbFoodName.Size = new System.Drawing.Size(46, 17);
            this.lbFoodName.TabIndex = 0;
            this.lbFoodName.Text = "label1";
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Location = new System.Drawing.Point(242, 26);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(46, 17);
            this.lbPrice.TabIndex = 1;
            this.lbPrice.Text = "label2";
            // 
            // lbCount
            // 
            this.lbCount.AutoSize = true;
            this.lbCount.Location = new System.Drawing.Point(348, 26);
            this.lbCount.Name = "lbCount";
            this.lbCount.Size = new System.Drawing.Size(46, 17);
            this.lbCount.TabIndex = 2;
            this.lbCount.Text = "label3";
            // 
            // ucOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lbCount);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.lbFoodName);
            this.Name = "ucOrder";
            this.Size = new System.Drawing.Size(415, 70);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbFoodName;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label lbCount;
    }
}
