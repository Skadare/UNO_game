﻿namespace UNO_game
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
            this.components = new System.ComponentModel.Container();
            this.Table = new System.Windows.Forms.TableLayoutPanel();
            this.playerCardsFlow = new System.Windows.Forms.FlowLayoutPanel();
            this.opponentCardsFlow = new System.Windows.Forms.FlowLayoutPanel();
            this.DeckAndTossFlow = new System.Windows.Forms.FlowLayoutPanel();
            this.DeckPictureBox = new System.Windows.Forms.PictureBox();
            this.CardTossPictureBox = new System.Windows.Forms.PictureBox();
            this.unoButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.colorStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.turnStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.Table.SuspendLayout();
            this.DeckAndTossFlow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DeckPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CardTossPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.statusStrip1.SuspendLayout();
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
            this.Table.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Table.Name = "Table";
            this.Table.RowCount = 5;
            this.Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 353F));
            this.Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 353F));
            this.Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 353F));
            this.Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.Table.Size = new System.Drawing.Size(1579, 1055);
            this.Table.TabIndex = 0;
            // 
            // playerCardsFlow
            // 
            this.playerCardsFlow.Location = new System.Drawing.Point(40, 743);
            this.playerCardsFlow.Margin = new System.Windows.Forms.Padding(40, 37, 40, 37);
            this.playerCardsFlow.Name = "playerCardsFlow";
            this.playerCardsFlow.Size = new System.Drawing.Size(1499, 279);
            this.playerCardsFlow.TabIndex = 0;
            // 
            // opponentCardsFlow
            // 
            this.opponentCardsFlow.Location = new System.Drawing.Point(40, 37);
            this.opponentCardsFlow.Margin = new System.Windows.Forms.Padding(40, 37, 40, 37);
            this.opponentCardsFlow.Name = "opponentCardsFlow";
            this.opponentCardsFlow.Size = new System.Drawing.Size(1499, 279);
            this.opponentCardsFlow.TabIndex = 1;
            // 
            // DeckAndTossFlow
            // 
            this.DeckAndTossFlow.Controls.Add(this.DeckPictureBox);
            this.DeckAndTossFlow.Controls.Add(this.CardTossPictureBox);
            this.DeckAndTossFlow.Controls.Add(this.unoButton);
            this.DeckAndTossFlow.Location = new System.Drawing.Point(40, 371);
            this.DeckAndTossFlow.Margin = new System.Windows.Forms.Padding(40, 18, 40, 18);
            this.DeckAndTossFlow.Name = "DeckAndTossFlow";
            this.DeckAndTossFlow.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.DeckAndTossFlow.Size = new System.Drawing.Size(1499, 316);
            this.DeckAndTossFlow.TabIndex = 2;
            // 
            // DeckPictureBox
            // 
            this.DeckPictureBox.Location = new System.Drawing.Point(11, 10);
            this.DeckPictureBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DeckPictureBox.Name = "DeckPictureBox";
            this.DeckPictureBox.Padding = new System.Windows.Forms.Padding(20, 18, 20, 18);
            this.DeckPictureBox.Size = new System.Drawing.Size(343, 306);
            this.DeckPictureBox.TabIndex = 0;
            this.DeckPictureBox.TabStop = false;
            this.DeckPictureBox.Click += new System.EventHandler(this.DeckPictureBox_Click);
            // 
            // CardTossPictureBox
            // 
            this.CardTossPictureBox.Location = new System.Drawing.Point(725, 24);
            this.CardTossPictureBox.Margin = new System.Windows.Forms.Padding(367, 18, 4, 4);
            this.CardTossPictureBox.Name = "CardTossPictureBox";
            this.CardTossPictureBox.Size = new System.Drawing.Size(197, 263);
            this.CardTossPictureBox.TabIndex = 1;
            this.CardTossPictureBox.TabStop = false;
            // 
            // unoButton
            // 
            this.unoButton.Location = new System.Drawing.Point(1153, 129);
            this.unoButton.Margin = new System.Windows.Forms.Padding(227, 123, 200, 156);
            this.unoButton.Name = "unoButton";
            this.unoButton.Size = new System.Drawing.Size(139, 71);
            this.unoButton.TabIndex = 2;
            this.unoButton.Text = "UNO!";
            this.unoButton.UseVisualStyleBackColor = true;
            this.unoButton.Click += new System.EventHandler(this.unoButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(4, 1063);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 17);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorStatusLabel,
            this.turnStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 1029);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1579, 26);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // colorStatusLabel
            // 
            this.colorStatusLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.colorStatusLabel.Name = "colorStatusLabel";
            this.colorStatusLabel.Size = new System.Drawing.Size(102, 20);
            this.colorStatusLabel.Text = "Current color: ";
            // 
            // turnStatusLabel
            // 
            this.turnStatusLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.turnStatusLabel.Name = "turnStatusLabel";
            this.turnStatusLabel.Size = new System.Drawing.Size(41, 20);
            this.turnStatusLabel.Text = "Turn:";
            // 
            // timer2
            // 
            this.timer2.Interval = 1500;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1579, 1055);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.Table);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Game";
            this.Text = "Game";
            this.Load += new System.EventHandler(this.Game_Load);
            this.Table.ResumeLayout(false);
            this.DeckAndTossFlow.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DeckPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CardTossPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel Table;
        private System.Windows.Forms.FlowLayoutPanel playerCardsFlow;
        private System.Windows.Forms.FlowLayoutPanel opponentCardsFlow;
        private System.Windows.Forms.FlowLayoutPanel DeckAndTossFlow;
        private System.Windows.Forms.PictureBox DeckPictureBox;
        private System.Windows.Forms.PictureBox CardTossPictureBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel colorStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel turnStatusLabel;
        private System.Windows.Forms.Button unoButton;
        private System.Windows.Forms.Timer timer2;
    }
}