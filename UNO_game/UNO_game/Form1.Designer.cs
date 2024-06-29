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
            this.DeckAndTossFlow = new System.Windows.Forms.FlowLayoutPanel();
            this.DeckPictureBox = new System.Windows.Forms.PictureBox();
            this.CardTossPictureBox = new System.Windows.Forms.PictureBox();
            this.Table.SuspendLayout();
            this.DeckAndTossFlow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DeckPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CardTossPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Table
            // 
            this.Table.ColumnCount = 1;
            this.Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Table.Controls.Add(this.opponentCardsFlow, 0, 0);
            this.Table.Controls.Add(this.playerCardsFlow, 0, 2);
            this.Table.Controls.Add(this.DeckAndTossFlow, 0, 1);
            this.Table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Table.Location = new System.Drawing.Point(0, 0);
            this.Table.Margin = new System.Windows.Forms.Padding(25, 75, 25, 75);
            this.Table.Name = "Table";
            this.Table.RowCount = 3;
            this.Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.51163F));
            this.Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.48837F));
            this.Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 210F));
            this.Table.Size = new System.Drawing.Size(1363, 755);
            this.Table.TabIndex = 0;
            this.Table.Paint += new System.Windows.Forms.PaintEventHandler(this.Table_Paint);
            // 
            // opponentCardsFlow
            // 
            this.opponentCardsFlow.Location = new System.Drawing.Point(130, 10);
            this.opponentCardsFlow.Margin = new System.Windows.Forms.Padding(130, 10, 130, 10);
            this.opponentCardsFlow.Name = "opponentCardsFlow";
            this.opponentCardsFlow.Size = new System.Drawing.Size(1103, 233);
            this.opponentCardsFlow.TabIndex = 0;
            // 
            // playerCardsFlow
            // 
            this.playerCardsFlow.Location = new System.Drawing.Point(130, 549);
            this.playerCardsFlow.Margin = new System.Windows.Forms.Padding(130, 5, 130, 5);
            this.playerCardsFlow.Name = "playerCardsFlow";
            this.playerCardsFlow.Size = new System.Drawing.Size(1103, 201);
            this.playerCardsFlow.TabIndex = 1;
            // 
            // DeckAndTossFlow
            // 
            this.DeckAndTossFlow.Controls.Add(this.DeckPictureBox);
            this.DeckAndTossFlow.Controls.Add(this.CardTossPictureBox);
            this.DeckAndTossFlow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DeckAndTossFlow.Location = new System.Drawing.Point(10, 263);
            this.DeckAndTossFlow.Margin = new System.Windows.Forms.Padding(10);
            this.DeckAndTossFlow.Name = "DeckAndTossFlow";
            this.DeckAndTossFlow.Size = new System.Drawing.Size(1343, 271);
            this.DeckAndTossFlow.TabIndex = 2;
            // 
            // DeckPictureBox
            // 
            this.DeckPictureBox.Location = new System.Drawing.Point(25, 25);
            this.DeckPictureBox.Margin = new System.Windows.Forms.Padding(25);
            this.DeckPictureBox.Name = "DeckPictureBox";
            this.DeckPictureBox.Size = new System.Drawing.Size(262, 216);
            this.DeckPictureBox.TabIndex = 1;
            this.DeckPictureBox.TabStop = false;
            this.DeckPictureBox.Click += new System.EventHandler(this.DeckPictureBox_Click);
            // 
            // CardTossPictureBox
            // 
            this.CardTossPictureBox.Location = new System.Drawing.Point(587, 15);
            this.CardTossPictureBox.Margin = new System.Windows.Forms.Padding(275, 15, 50, 15);
            this.CardTossPictureBox.Name = "CardTossPictureBox";
            this.CardTossPictureBox.Size = new System.Drawing.Size(210, 241);
            this.CardTossPictureBox.TabIndex = 0;
            this.CardTossPictureBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1363, 755);
            this.Controls.Add(this.Table);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Table.ResumeLayout(false);
            this.DeckAndTossFlow.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DeckPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CardTossPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel Table;
        private System.Windows.Forms.FlowLayoutPanel opponentCardsFlow;
        private System.Windows.Forms.FlowLayoutPanel playerCardsFlow;
        private System.Windows.Forms.FlowLayoutPanel DeckAndTossFlow;
        private System.Windows.Forms.PictureBox DeckPictureBox;
        private System.Windows.Forms.PictureBox CardTossPictureBox;
    }
}

