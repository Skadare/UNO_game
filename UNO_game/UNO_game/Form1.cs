﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UNO_game
{
    public partial class Form1 : Form
    {
        private List<PictureBox> playerHand;
        private List<PictureBox> opponentHand;
        private PictureBox selectedCard;
       public  Deck deck;

        public Form1()
        {
            InitializeComponent();
            loadTable();
            deck = new Deck();
            loadDeck();
            loadOpponentsCards();
            loadPlayerCards();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void loadTable()
        {
      
            Table.BackgroundImage = Image.FromFile(Path.Combine(Application.StartupPath, "Table", "pozadina.jpg"));
        }
        public void loadDeck() {
            //Card.CardFactory(data)
            string[] cardFiles = Directory.GetFiles(Path.Combine(Application.StartupPath, "Images"), "*.png");
            foreach (string cardFile in cardFiles)
            {
               deck.addCard(CardFactory.createCard(cardFile));
            }

        }
        public void loadOpponentsCards() { 
           opponentHand = new List<PictureBox>();
            Opponent opp = new Opponent();
            Random random = new Random();
            string[] cardfile = Directory.GetFiles(Path.Combine(Application.StartupPath, "Back"), "*.png");

            for (int i = 0; i < 6; i++)
            {
                int index = random.Next(deck.cards.Count - 1);
                opp.addCard(deck.cards[index]);
                deck.removeCard(deck.cards[index]);

                PictureBox card = new PictureBox
                {
                    Image = Image.FromFile(cardfile[0]),
                    Width = 100,
                    Height = 150,
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Margin = new Padding(5)
                };
                opponentCardsFlow.Controls.Add(card);
                opponentHand.Add(card);

            }
            opponentCardsFlow.BackgroundImage = Image.FromFile(Path.Combine(Application.StartupPath, "Table", "pozadina.jpg"));


        }
        public void loadPlayerCards() {
            playerHand = new List<PictureBox>();
            Player player = new Player();
            Random random = new Random();
            for (int i = 0; i < 6; i++)
            {
                int index = random.Next(deck.cards.Count-1);
                player.addCard(deck.cards[index]);
                deck.removeCard(deck.cards[index]);
            }
            string[] cardFiles = Directory.GetFiles(Path.Combine(Application.StartupPath, "Images"), "*.png");
            for(int i = 0; i < player.playerCards.Count; i++)
            {
                foreach(String cardfile in cardFiles)
                {
                    if (cardfile.Equals(player.playerCards[i].path))
                    {
                        PictureBox card = new PictureBox
                        {
                            Image = Image.FromFile(cardfile),
                            Width = 100,
                            Height = 150,
                            SizeMode = PictureBoxSizeMode.StretchImage,
                            Margin = new Padding(5)
                        };
                        playerCardsFlow.Controls.Add(card);
                        playerHand.Add(card);
                        break;
                    }
                }
            }

            playerCardsFlow.BackgroundImage = Image.FromFile(Path.Combine(Application.StartupPath, "Table", "pozadina.jpg"));
            DeckAndTossFlow.BackgroundImage = Image.FromFile(Path.Combine(Application.StartupPath, "Table", "pozadina.jpg"));
        }

        private void Table_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
