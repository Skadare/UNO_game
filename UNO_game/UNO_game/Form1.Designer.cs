namespace UNO_game
{
    partial class Form1
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
            this.MenuPictureBox = new System.Windows.Forms.PictureBox();
            this.startButton = new System.Windows.Forms.Button();
            this.htpButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.pbStart = new System.Windows.Forms.PictureBox();
            this.pbHTP = new System.Windows.Forms.PictureBox();
            this.pbExit = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.MenuPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHTP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuPictureBox
            // 
            this.MenuPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MenuPictureBox.Location = new System.Drawing.Point(0, 0);
            this.MenuPictureBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MenuPictureBox.Name = "MenuPictureBox";
            this.MenuPictureBox.Size = new System.Drawing.Size(979, 494);
            this.MenuPictureBox.TabIndex = 0;
            this.MenuPictureBox.TabStop = false;
            // 
            // startButton
            // 
            this.startButton.AllowDrop = true;
            this.startButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startButton.Location = new System.Drawing.Point(847, 64);
            this.startButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(103, 36);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Start Game";
            this.startButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // htpButton
            // 
            this.htpButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.htpButton.Location = new System.Drawing.Point(847, 228);
            this.htpButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.htpButton.Name = "htpButton";
            this.htpButton.Size = new System.Drawing.Size(116, 34);
            this.htpButton.TabIndex = 2;
            this.htpButton.Text = "How To Play";
            this.htpButton.UseVisualStyleBackColor = true;
            this.htpButton.Click += new System.EventHandler(this.htpButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitButton.Location = new System.Drawing.Point(847, 390);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(103, 33);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // pbStart
            // 
            this.pbStart.Location = new System.Drawing.Point(793, 15);
            this.pbStart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbStart.Name = "pbStart";
            this.pbStart.Size = new System.Drawing.Size(227, 140);
            this.pbStart.TabIndex = 4;
            this.pbStart.TabStop = false;
            // 
            // pbHTP
            // 
            this.pbHTP.Location = new System.Drawing.Point(793, 174);
            this.pbHTP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbHTP.Name = "pbHTP";
            this.pbHTP.Size = new System.Drawing.Size(227, 140);
            this.pbHTP.TabIndex = 5;
            this.pbHTP.TabStop = false;
            // 
            // pbExit
            // 
            this.pbExit.Location = new System.Drawing.Point(793, 338);
            this.pbExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbExit.Name = "pbExit";
            this.pbExit.Size = new System.Drawing.Size(227, 140);
            this.pbExit.TabIndex = 6;
            this.pbExit.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 494);
            this.Controls.Add(this.pbExit);
            this.Controls.Add(this.pbHTP);
            this.Controls.Add(this.pbStart);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.htpButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.MenuPictureBox);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MenuPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHTP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox MenuPictureBox;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button htpButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.PictureBox pbStart;
        private System.Windows.Forms.PictureBox pbHTP;
        private System.Windows.Forms.PictureBox pbExit;
    }
}

