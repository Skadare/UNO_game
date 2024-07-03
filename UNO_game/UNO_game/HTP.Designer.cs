namespace UNO_game
{
    partial class HTP
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
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.pbBack = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).BeginInit();
            this.SuspendLayout();
            // 
            // pb1
            // 
            this.pb1.Location = new System.Drawing.Point(0, 0);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(717, 406);
            this.pb1.TabIndex = 0;
            this.pb1.TabStop = false;
            this.pb1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pbBack
            // 
            this.pbBack.Location = new System.Drawing.Point(8, 8);
            this.pbBack.Name = "pbBack";
            this.pbBack.Size = new System.Drawing.Size(77, 50);
            this.pbBack.TabIndex = 1;
            this.pbBack.TabStop = false;
            this.pbBack.Click += new System.EventHandler(this.pbBack_Click);
            // 
            // HTP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 406);
            this.Controls.Add(this.pbBack);
            this.Controls.Add(this.pb1);
            this.Name = "HTP";
            this.Text = "HTP";
            this.Load += new System.EventHandler(this.HTP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.PictureBox pbBack;
    }
}