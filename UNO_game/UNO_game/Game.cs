using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace UNO_game
{
    public partial class Game : Form
    {
        private List<PictureBox> playerHand;
        private List<PictureBox> opponentHand;
        public Deck deck;
        public Opponent opp;
        public Player player;
        private bool TURN = false;
        private Card lastCard = null;
        private Dictionary<PictureBox, Card> playerCardMap;
        public Boja currentBoja;
        public Game()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            loadTable();
            player = new Player();
            opp = new Opponent();
            deck = new Deck();
            playerCardMap = new Dictionary<PictureBox, Card>();
            loadDeck();
            loadOpponentsCards();
            loadPlayerCards();
            unoButton.Visible = false;
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
            statusStrip1.BackgroundImage= Image.FromFile(Path.Combine(Application.StartupPath, "Table", "pozadina.jpg"));

        }

        private void loadDeck()
        {
            string[] cardFiles = Directory.GetFiles(Path.Combine(Application.StartupPath, "Images"), "*.png");
            foreach (string cardFile in cardFiles)
            {
                deck.addCard(CardFactory.createCard(cardFile));
            }
            turnStatusLabel.Text = String.Format("Turn: Player");
            DeckPictureBox.Enabled = false;
        }
        private void loadOpponentsCards()
        {
            opponentHand = new List<PictureBox>();
            addCards(6);
            TURN = true;
        }

        private void loadPlayerCards()
        {
            playerHand = new List<PictureBox>();
            addCards(6);
            TURN = false;
        }

        private void CardPictureBox_Click(object sender, EventArgs e)
        {
            PictureBox card = sender as PictureBox;
            Card c = playerCardMap[card];

            if (checkLogic(c))
            {

                CardTossPictureBox.Image = card.Image;
                lastCard = c;
                playerHand.Remove(card);
                playerCardsFlow.Controls.Remove(card);
                player.playerCards.Remove(c);
                TURN = !TURN;
                if (!TURN)
                {
                    turnStatusLabel.Text = String.Format("Turn: Player");
                    DeckPictureBox.Enabled = true;
                }
                else
                {
                    turnStatusLabel.Text = String.Format("Turn: BOT");
                    playerCardsFlow.Enabled = false;
                    DeckPictureBox.Enabled = false;
                }
                CheckStateOfGame();
                UNOcheck();
                changeSize();

            }
        }
        private bool checkLogic(Card c)
        {
            if (lastCard == null)
            {
                if (c.type == TYPE.NORMAL)
                {
                    ColorCard playerCard = c as ColorCard;
                    if (playerCard.picker)
                        addCards(2);
                    if (playerCard.skip || playerCard.reverse)
                        skipTurn();
                    currentBoja = playerCard.color;
                }
                else
                {
                    BlackCard playerCard = c as BlackCard;
                    if (playerCard.picker_and_change)
                        addCards(4);
                    Color_Picker color = new Color_Picker();
                    color.ShowDialog();
                    currentBoja = color.selectedColor;
                }
                colorStatusLabel.Text = String.Format("Current color: {0}", currentBoja.ToString());
                timer1.Start();
                return true;
            }

            if (lastCard.type == TYPE.NORMAL && c.type == TYPE.NORMAL)
            {
                ColorCard playerCard = c as ColorCard;
                ColorCard card = lastCard as ColorCard;
                if (card.color == playerCard.color)
                {
                    currentBoja = playerCard.color;
                    colorStatusLabel.Text = String.Format("Current color: {0}", currentBoja);
                    if (playerCard.picker)
                    {
                        addCards(2);
                        return true;
                    }
                    if (playerCard.skip)
                    {
                        skipTurn();
                        return true;
                    }
                    if (playerCard.reverse)
                    {
                        skipTurn();
                        return true;
                    }
                    return true;
                }

                if (playerCard.picker && card.picker)
                {
                    addCards(2);
                    currentBoja = playerCard.color;
                    colorStatusLabel.Text = String.Format("Current color: {0}", currentBoja);
                    return true;
                }
                if ((playerCard.skip && card.skip) || (playerCard.reverse && card.reverse))
                {
                    skipTurn();
                    currentBoja = playerCard.color;
                    colorStatusLabel.Text = String.Format("Current color: {0}", currentBoja);
                    return true;
                }

                if (card.number.Equals(playerCard.number) && card.number != -1)
                {
                    currentBoja = playerCard.color;
                    colorStatusLabel.Text = String.Format("Current color: {0}", currentBoja);
                    return true;
                }

                return false;
            }
            else if (lastCard.type == TYPE.WILDCARD && c.type == TYPE.NORMAL)
            {
                ColorCard playerCard = c as ColorCard;
                BlackCard card = lastCard as BlackCard;
                if (playerCard.color == currentBoja)
                {
                    if (playerCard.picker)
                        addCards(2);
                    if (playerCard.skip || playerCard.reverse)
                        skipTurn();
                    return true;
                }
            }
            else if (lastCard.type == TYPE.NORMAL && c.type == TYPE.WILDCARD)
            {
                BlackCard playerCard = c as BlackCard;

                if (!TURN)
                {
                    Color_Picker color = new Color_Picker();
                    color.ShowDialog();
                    currentBoja = color.selectedColor;
                }
                else
                {
                    currentBoja = opp.getBestColor();
                }
                colorStatusLabel.Text = String.Format("Current color: {0}", currentBoja);
                if (playerCard.picker_and_change)
                    addCards(4);
                return true;
            }
            else if (lastCard.type == TYPE.WILDCARD && c.type == TYPE.WILDCARD)
            {
                BlackCard playerCard = c as BlackCard;
                if (!TURN)
                {
                    Color_Picker color = new Color_Picker();
                    color.ShowDialog();
                    currentBoja = color.selectedColor;
                }
                else
                {
                    currentBoja = opp.getBestColor();
                }
                colorStatusLabel.Text = String.Format("Current color: {0}", currentBoja);
                if (playerCard.picker_and_change)
                {
                    addCards(4);
                }
                return true;
            }
            return false;
        }

        private void skipTurn()
        {
            if (!TURN)
            {
                TURN = true;
            }
            else
            {
                TURN = false;
                turnStatusLabel.Text = String.Format("Turn: BOT");
            }

        }

        private void addCards(int numOfCards)
        {
            Random random = new Random();
            if (!TURN)
            {
                string[] cardfile = Directory.GetFiles(Path.Combine(Application.StartupPath, "Back"), "*.png");

                for (int i = 0; i < numOfCards; i++)
                {
                    if (checkDeck())
                    {
                        return;
                    }
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
                changeSizeOpponent();
            }
            else
            {
                int broj = player.playerCards.Count;
                for (int i = 0; i < numOfCards; i++)
                {
                    if (checkDeck())
                    {
                        return;
                    }
                    int index = random.Next(deck.cards.Count - 1);
                    player.addCard(deck.cards[index]);
                    deck.removeCard(deck.cards[index]);
                }
                string[] cardFiles = Directory.GetFiles(Path.Combine(Application.StartupPath, "Images"), "*.png");
                for (int i = broj; i < player.playerCards.Count; i++)
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
                            playerCardMap[card] = player.playerCards[i];
                            card.Click += CardPictureBox_Click;
                            break;

                        }
                    }
                }

            }
        }

        private void DeckPictureBox_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            if(checkDeck())
            {
                return;
            }
            int index = random.Next(deck.cards.Count - 1);
            int test = deck.cards.Count;
            player.addCard(deck.cards[index]);
            Card c = deck.cards[index];
            TURN = true;
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
            playerCardMap[pb] = c;
            turnStatusLabel.Text = String.Format("Turn: BOT");
            DeckPictureBox.Enabled = false;
            changeSize();
        }

        private void changeSize()
        {
            int smallWidth = 70;
            int smallHeight = 122;
            int largeWidth = 130;
            int largeHeight = 182;

            if (playerHand.Count >= 10)
            {
                foreach (PictureBox pb in playerHand)
                {
                    pb.Width = smallWidth;
                    pb.Height = smallHeight;
                }
            }
            else
            {
                foreach (PictureBox pb in playerHand)
                {
                    pb.Width = largeWidth;
                    pb.Height = largeHeight;
                }
            }
        }
        private void changeSizeOpponent()
        {
            int smallWidth = 70;
            int smallHeight = 122;
            int largeWidth = 130;
            int largeHeight = 182;

            if (opponentHand.Count >= 8)
            {
                foreach (PictureBox pb in opponentHand)
                {
                    pb.Width = smallWidth;
                    pb.Height = smallHeight;
                }
            }
            else
            {
                foreach (PictureBox pb in opponentHand)
                {
                    pb.Width = largeWidth;
                    pb.Height = largeHeight;
                }
            }
        }
        private bool checkOpponent()
        {
            for (int i = 0; i < opp.oppCards.Count; i++)
            {
                Card c = opp.oppCards[i];
                if (checkLogic(c))
                {
                    opp.oppCards.Remove(c);
                    opponentCardsFlow.Controls.Remove(opponentHand[opponentHand.Count - 1]);
                    opponentHand.Remove(opponentHand[opponentHand.Count - 1]);
                    CardTossPictureBox.Image = Image.FromFile(c.path);
                    lastCard = c;
                    changeSizeOpponent();
                    return true;
                }
            }
            return false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (TURN)
            {
                
                if (!checkOpponent())
                {
                    if (checkDeck())
                    {
                        return;
                    }
                    opp.oppCards.Add(opponentFromDeck());
                    deck.cards.Remove(deck.cards[deck.cards.Count - 1]);
                    string[] cardfile = Directory.GetFiles(Path.Combine(Application.StartupPath, "Back"), "*.png");
                    PictureBox card = new PictureBox
                    {
                        Image = Image.FromFile(cardfile[0]),
                        Width = 130,
                        Height = 182,
                        SizeMode = PictureBoxSizeMode.StretchImage,
                        Margin = new Padding(5)
                    };
                    opponentHand.Add(card);
                    opponentCardsFlow.Controls.Add(card);
                    changeSizeOpponent();
                }

                CheckStateOfGame();
                TURN = !TURN;
                if (!TURN)
                {
                    turnStatusLabel.Text = String.Format("Turn: Player");
                    playerCardsFlow.Enabled = true;
                    DeckPictureBox.Enabled = true;
                }
                else
                {
                    DeckPictureBox.Enabled = false;
                    turnStatusLabel.Text = String.Format("Turn: BOT");
                }
            }
        }
        private bool checkDeck()
        {
            if (deck.cards.Count == 0)
            {
                DialogResult dr = MessageBox.Show("The deck is empty. Click YES if you want to exit the game, or NO if you want to restart the game.", "Game Over", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    this.Close();
                }
                else
                {
                    this.Close();
                    RestartGame();
                }
                return true;

            }
            return false;

        }

        private Card opponentFromDeck()
        {
          
            return deck.cards[deck.cards.Count - 1];
        }
        private void RestartGame()
        {

            this.Close();

            Game g = new Game();
            g.Show();
            

        }
        private void CheckStateOfGame()
        {

            if (player.playerCards.Count == 0)
            {
                timer1.Stop();
                DialogResult dr = MessageBox.Show("YOU WON!!! CONGRATULATIONS!\n"
                    + "Would you like to play another one?", "Game Over", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes) {
                    RestartGame();
                }
                else this.Close();
            }
            else if (opp.oppCards.Count == 0)
            {
                timer1.Stop();
                DialogResult dr = MessageBox.Show("You lost :(\n"
                    + "Would you like to play another one?", "Game Over", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    RestartGame();
                }
                else this.Close();
            }
        }
        
        private void UNOcheck()
        {
            if (player.playerCards.Count == 1)
            {
                TURN = false;
                unoButton.Visible = true;
                timer2.Start();

            }
        }
        private void unoButton_Click(object sender, EventArgs e)
        {
            timer2.Stop();
            unoButton.Visible = false;
            TURN = true;

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            TURN = true;
            unoButton.Visible=false;
            addCards(2);
            turnStatusLabel.Text = "Turn: BOT";
            timer2.Stop();
        }
    }
}
