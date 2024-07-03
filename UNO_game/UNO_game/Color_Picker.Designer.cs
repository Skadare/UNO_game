namespace UNO_game
{
    partial class Color_Picker
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
            this.cardPB = new System.Windows.Forms.PictureBox();
            this.redPB = new System.Windows.Forms.PictureBox();
            this.greenPB = new System.Windows.Forms.PictureBox();
            this.yellowPB = new System.Windows.Forms.PictureBox();
            this.bluePB = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.cardPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bluePB)).BeginInit();
            this.SuspendLayout();
            // 
            // cardPB
            // 
            this.cardPB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardPB.Location = new System.Drawing.Point(0, 0);
            this.cardPB.Margin = new System.Windows.Forms.Padding(2);
            this.cardPB.Name = "cardPB";
            this.cardPB.Size = new System.Drawing.Size(271, 382);
            this.cardPB.TabIndex = 0;
            this.cardPB.TabStop = false;
            this.cardPB.Click += new System.EventHandler(this.cardPB_Click);
            // 
            // redPB
            // 
            this.redPB.Location = new System.Drawing.Point(102, 62);
            this.redPB.Name = "redPB";
            this.redPB.Size = new System.Drawing.Size(70, 85);
            this.redPB.TabIndex = 1;
            this.redPB.TabStop = false;
            this.redPB.Click += new System.EventHandler(this.redPB_Click_1);
            // 
            // greenPB
            // 
            this.greenPB.Location = new System.Drawing.Point(102, 227);
            this.greenPB.Name = "greenPB";
            this.greenPB.Size = new System.Drawing.Size(70, 85);
            this.greenPB.TabIndex = 2;
            this.greenPB.TabStop = false;
            this.greenPB.Click += new System.EventHandler(this.greenPB_Click);
            // 
            // yellowPB
            // 
            this.yellowPB.Location = new System.Drawing.Point(174, 154);
            this.yellowPB.Name = "yellowPB";
            this.yellowPB.Size = new System.Drawing.Size(85, 70);
            this.yellowPB.TabIndex = 3;
            this.yellowPB.TabStop = false;
            this.yellowPB.Click += new System.EventHandler(this.yellowPB_Click);
            // 
            // bluePB
            // 
            this.bluePB.Location = new System.Drawing.Point(12, 154);
            this.bluePB.Name = "bluePB";
            this.bluePB.Size = new System.Drawing.Size(85, 70);
            this.bluePB.TabIndex = 4;
            this.bluePB.TabStop = false;
            this.bluePB.Click += new System.EventHandler(this.bluePB_Click);
            // 
            // Color_Picker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 382);
            this.Controls.Add(this.bluePB);
            this.Controls.Add(this.yellowPB);
            this.Controls.Add(this.greenPB);
            this.Controls.Add(this.redPB);
            this.Controls.Add(this.cardPB);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Color_Picker";
            this.Text = "Click on a color!";
            this.Load += new System.EventHandler(this.Color_Picker_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cardPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bluePB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox cardPB;
        private System.Windows.Forms.PictureBox redPB;
        private System.Windows.Forms.PictureBox greenPB;
        private System.Windows.Forms.PictureBox yellowPB;
        private System.Windows.Forms.PictureBox bluePB;
    }
}