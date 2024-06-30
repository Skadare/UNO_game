namespace UNO_game
{
    partial class Game
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
            this.playerCardsFlow = new System.Windows.Forms.FlowLayoutPanel();
            this.opponentCardsFlow = new System.Windows.Forms.FlowLayoutPanel();
            this.DeckAndTossFlow = new System.Windows.Forms.FlowLayoutPanel();
            this.DeckPictureBox = new System.Windows.Forms.PictureBox();
            this.CardTossPictureBox = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Table.SuspendLayout();
            this.DeckAndTossFlow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DeckPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CardTossPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Table
            // 
            this.Table.ColumnCount = 1;
            this.Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Table.Controls.Add(this.playerCardsFlow, 0, 2);
            this.Table.Controls.Add(this.opponentCardsFlow, 0, 0);
            this.Table.Controls.Add(this.DeckAndTossFlow, 0, 1);
            this.Table.Controls.Add(this.pictureBox1, 0, 3);
            this.Table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Table.Location = new System.Drawing.Point(0, 0);
            this.Table.Name = "Table";
            this.Table.RowCount = 4;
            this.Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 287F));
            this.Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 287F));
            this.Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 287F));
            this.Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.Table.Size = new System.Drawing.Size(1184, 861);
            this.Table.TabIndex = 0;
            // 
            // playerCardsFlow
            // 
            this.playerCardsFlow.Location = new System.Drawing.Point(30, 604);
            this.playerCardsFlow.Margin = new System.Windows.Forms.Padding(30);
            this.playerCardsFlow.Name = "playerCardsFlow";
            this.playerCardsFlow.Size = new System.Drawing.Size(1124, 227);
            this.playerCardsFlow.TabIndex = 0;
            // 
            // opponentCardsFlow
            // 
            this.opponentCardsFlow.Location = new System.Drawing.Point(30, 30);
            this.opponentCardsFlow.Margin = new System.Windows.Forms.Padding(30);
            this.opponentCardsFlow.Name = "opponentCardsFlow";
            this.opponentCardsFlow.Size = new System.Drawing.Size(1124, 227);
            this.opponentCardsFlow.TabIndex = 1;
            // 
            // DeckAndTossFlow
            // 
            this.DeckAndTossFlow.Controls.Add(this.DeckPictureBox);
            this.DeckAndTossFlow.Controls.Add(this.CardTossPictureBox);
            this.DeckAndTossFlow.Location = new System.Drawing.Point(30, 302);
            this.DeckAndTossFlow.Margin = new System.Windows.Forms.Padding(30, 15, 30, 15);
            this.DeckAndTossFlow.Name = "DeckAndTossFlow";
            this.DeckAndTossFlow.Padding = new System.Windows.Forms.Padding(5);
            this.DeckAndTossFlow.Size = new System.Drawing.Size(1124, 257);
            this.DeckAndTossFlow.TabIndex = 2;
            // 
            // DeckPictureBox
            // 
            this.DeckPictureBox.Location = new System.Drawing.Point(8, 8);
            this.DeckPictureBox.Name = "DeckPictureBox";
            this.DeckPictureBox.Padding = new System.Windows.Forms.Padding(15);
            this.DeckPictureBox.Size = new System.Drawing.Size(257, 249);
            this.DeckPictureBox.TabIndex = 0;
            this.DeckPictureBox.TabStop = false;
            this.DeckPictureBox.Click += new System.EventHandler(this.DeckPictureBox_Click);
            // 
            // CardTossPictureBox
            // 
            this.CardTossPictureBox.Location = new System.Drawing.Point(543, 20);
            this.CardTossPictureBox.Margin = new System.Windows.Forms.Padding(275, 15, 3, 3);
            this.CardTossPictureBox.Name = "CardTossPictureBox";
            this.CardTossPictureBox.Size = new System.Drawing.Size(148, 214);
            this.CardTossPictureBox.TabIndex = 1;
            this.CardTossPictureBox.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 864);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 14);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 861);
            this.Controls.Add(this.Table);
            this.Name = "Game";
            this.Text = "Game";
            this.Load += new System.EventHandler(this.Game_Load);
            this.Table.ResumeLayout(false);
            this.DeckAndTossFlow.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DeckPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CardTossPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel Table;
        private System.Windows.Forms.FlowLayoutPanel playerCardsFlow;
        private System.Windows.Forms.FlowLayoutPanel opponentCardsFlow;
        private System.Windows.Forms.FlowLayoutPanel DeckAndTossFlow;
        private System.Windows.Forms.PictureBox DeckPictureBox;
        private System.Windows.Forms.PictureBox CardTossPictureBox;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}