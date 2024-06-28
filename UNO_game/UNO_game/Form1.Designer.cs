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
            this.Table = new System.Windows.Forms.TableLayoutPanel();
            this.opponentCardsFlow = new System.Windows.Forms.FlowLayoutPanel();
            this.playerCardsFlow = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Table.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Table
            // 
            this.Table.ColumnCount = 1;
            this.Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Table.Controls.Add(this.opponentCardsFlow, 0, 0);
            this.Table.Controls.Add(this.pictureBox1, 0, 2);
            this.Table.Controls.Add(this.playerCardsFlow, 0, 1);
            this.Table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Table.Location = new System.Drawing.Point(0, 0);
            this.Table.Name = "Table";
            this.Table.RowCount = 3;
            this.Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.61963F));
            this.Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.38037F));
            this.Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.Table.Size = new System.Drawing.Size(1200, 652);
            this.Table.TabIndex = 0;
            // 
            // opponentCardsFlow
            // 
            this.opponentCardsFlow.Location = new System.Drawing.Point(75, 75);
            this.opponentCardsFlow.Margin = new System.Windows.Forms.Padding(75);
            this.opponentCardsFlow.Name = "opponentCardsFlow";
            this.opponentCardsFlow.Size = new System.Drawing.Size(985, 157);
            this.opponentCardsFlow.TabIndex = 0;
            // 
            // playerCardsFlow
            // 
            this.playerCardsFlow.Location = new System.Drawing.Point(75, 382);
            this.playerCardsFlow.Margin = new System.Windows.Forms.Padding(75);
            this.playerCardsFlow.Name = "playerCardsFlow";
            this.playerCardsFlow.Size = new System.Drawing.Size(985, 174);
            this.playerCardsFlow.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 634);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 15);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 652);
            this.Controls.Add(this.Table);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Table.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel Table;
        private System.Windows.Forms.FlowLayoutPanel opponentCardsFlow;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FlowLayoutPanel playerCardsFlow;
    }
}

