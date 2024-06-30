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
    public partial class Game : Form
    {
        private List<PictureBox> playerHand;
        private List<PictureBox> opponentHand;
        private PictureBox selectedCard;
        public Deck deck;
        public Opponent opp;
        public Player player;
        public Game()
        {
            InitializeComponent();
            loadTable();
            player = new Player();
            opp = new Opponent();
            deck = new Deck();
            loadDeck();
            loadOpponentsCards();
            loadPlayerCards();
            this.DoubleBuffered = true;
        }

        private void Game_Load(object sender, EventArgs e)
        {

        }
        private void loadTable()
        {
            Image img = Image.FromFile(Path.Combine(Application.StartupPath, "Table", "pozadina.jpg"));
            Table.BackgroundImage = img;
            CardTossPictureBox.BackgroundImage = img;
            DeckPictureBox.BackgroundImage = img;
            DeckPictureBox.Image = Image.FromFile(Path.Combine(Application.StartupPath, "Deck", "deck.png"));
            opponentCardsFlow.BackgroundImage = img;
            playerCardsFlow.BackgroundImage = img;
            DeckAndTossFlow.BackgroundImage = img;

        }

        private void loadDeck()
        {
            string[] cardFiles = Directory.GetFiles(Path.Combine(Application.StartupPath, "Images"), "*.png");
            foreach (string cardFile in cardFiles)
            {
                deck.addCard(CardFactory.createCard(cardFile));
            }
        }
        private void loadOpponentsCards()
        {
            opponentHand = new List<PictureBox>();
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
                    Width = 130,
                    Height = 182,
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Margin = new Padding(5)
                };
                opponentCardsFlow.Controls.Add(card);
                opponentHand.Add(card);

            }
         }

        private void loadPlayerCards()
        {
            playerHand = new List<PictureBox>();
            Random random = new Random();
            for (int i = 0; i < 6; i++)
            {
                int index = random.Next(deck.cards.Count - 1);
                player.addCard(deck.cards[index]);
                deck.removeCard(deck.cards[index]);
            }
            string[] cardFiles = Directory.GetFiles(Path.Combine(Application.StartupPath, "Images"), "*.png");
            for (int i = 0; i < player.playerCards.Count; i++)
            {
                foreach (String cardfile in cardFiles)
                {
                    if (cardfile.Equals(player.playerCards[i].path))
                    {
                        PictureBox card = new PictureBox
                        {
                            Image = Image.FromFile(cardfile),
                            Width = 130,
                            Height = 182,
                            SizeMode = PictureBoxSizeMode.StretchImage,
                            Margin = new Padding(5)
                        };
                        playerCardsFlow.Controls.Add(card);
                        playerHand.Add(card);
                        card.Click += CardPictureBox_Click;
                        break;
                    }
                }
            }
        }

        private void CardPictureBox_Click(object sender, EventArgs e)
        {
            PictureBox card = sender as PictureBox;

            if (card != null)
            {
                playerHand.Remove(card);
                playerCardsFlow.Controls.Remove(card);
            }
            Card c = sender as Card;
            if (c != null)
            {
                player.playerCards.Remove(c);
            }
            CardTossPictureBox.Image = card.Image;
        }

        private void DeckPictureBox_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int index = random.Next(deck.cards.Count - 1);
            int test = deck.cards.Count;
            player.addCard(deck.cards[index]);
            Card c = deck.cards[index];

            PictureBox pb = new PictureBox
            {
                Image = Image.FromFile(c.path),
                Width = 130,
                Height = 182,
                SizeMode = PictureBoxSizeMode.StretchImage,
                Margin = new Padding(5)
            };
            pb.Click += CardPictureBox_Click;
            deck.removeCard(c);
            playerHand.Add(pb);
            playerCardsFlow.Controls.Add(pb);
            checkHandSize();
        }

        private void checkHandSize()
        {
            int golemina = 0;
            foreach(PictureBox pb in playerHand)
            {
                golemina+= pb.Width;
            }
            if(golemina >= playerCardsFlow.Width)
            {
                foreach (PictureBox pb in playerHand)
                {
                    pb.Width -= 50;
                    pb.Height -= 50;
                }
            }
        }
    }
}
