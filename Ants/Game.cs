using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ants
{
    public partial class Game : Form
    {
        /// the initial values of builders, bricks, soldiers, weapons, magicians, crystals, castle, wall
        private static readonly int[] initUnits = { 2, 5, 2, 5, 2, 5, 30, 10 };
        private IPlayer Player1 { get; set; }
        private IPlayer Player2 { get; set; }
        private bool Singleplayer { get; set; }
        private bool player1Turn = true;

        public Game()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StartNewGame();
        }

        public void StartNewGame()
        {
            NewGame newGame = new NewGame();
            if (newGame.ShowDialog() != DialogResult.OK) Application.Exit();

            Singleplayer = newGame.Singleplayer;
            Player1 = new Player(newGame.Player1Name, (int[])initUnits.Clone(), InitCards());
            Player2 = Singleplayer ? new Bot(newGame.Player2Name, (int[])initUnits.Clone(), InitCards())
                                   : new Player(newGame.Player2Name, (int[])initUnits.Clone(), InitCards());

            player1Turn = true;
            namePlayer1.Text = Player1.Name;
            namePlayer2.Text = Player2.Name;
            cardSelected.Image = Properties.Resources._60;
            UpdateUI();
            Player1.CheckCardsAvailability();
            ShowCards();
        }

        private void ChangePlayer()
        {
            player1Turn = !player1Turn;
        }

        private IPlayer GetCurrentPlayer()
        {
            return player1Turn ? Player1 : Player2;
        }

        private IPlayer GetSecondPlayer()
        {
            return player1Turn ? Player2 : Player1;
        }

        private Card NewCard()
        {
            Random rnd = new Random();
            return CardDeck.GetCard(rnd.Next(CardDeck.Size));
        }

        private Card[] InitCards()
        {
            Random rnd = new Random();
            Card[] cards = new Card[8];
            for (int i = 0; i < 8; i++)
            {
                cards[i] = CardDeck.GetCard(rnd.Next(CardDeck.Size));
                Thread.Sleep(1);
            }
            return cards;
        }

        private void PlayCard(int index)
        {
            if (!GetCurrentPlayer().PlayCard(index, GetSecondPlayer())) return;

            cardSelected.Image = GetCardImage(GetCurrentPlayer().GetCard(index).Id);
            UpdateUI();
            GetCurrentPlayer().SetCard(index, NewCard());
            ShowCards();

            if (GetCurrentPlayer().GetUnitValue(Unit.Castle) >= 100 || GetSecondPlayer().GetUnitValue(Unit.Castle) <= 0)
            {
                Winner();
            }

            NextRound();
            if (Singleplayer) BotPlay();
        }

        private void DiscardCard(int index)
        {
            GetCurrentPlayer().SetCard(index, NewCard());
            ShowCards();
            NextRound();
            if (Singleplayer) BotPlay();
        }

        private void NextRound()
        {
            ChangePlayer();
            if (player1Turn) IncreaseUnits();
            UpdateUI();
            GetCurrentPlayer().CheckCardsAvailability();
            ShowCards();
        }

        private void BotPlay()
        {
            bool discard = false;
            int index = Player2.ChooseCard(ref discard);
            if (!discard)
            {
                Player2.PlayCard(index, Player1);
                UpdateUI();
                cardSelected.Image = GetCardImage(GetCurrentPlayer().GetCard(index).Id);
            }
            Player2.SetCard(index, NewCard());

            if (Player2.GetUnitValue(Unit.Castle) >= 100 || Player1.GetUnitValue(Unit.Castle) <= 0)
            {
                Winner();
            }
            else
            {
                NextRound();
            }
        }

        private void Winner()
        {
            Winner winner = new Winner();
            winner.WinnerName = GetCurrentPlayer().Name;
            if (winner.ShowDialog() == DialogResult.OK)
            {
                StartNewGame();
            }
            else
            {
                Application.Exit();
            }
        }

        /// <summary>
        /// Increases bricks, weapons and crystals depending on player's number of builders, soldiers and magicians.
        /// </summary>
        private void IncreaseUnits()
        {
            Player1.SetUnitValue(Unit.Bricks, Player1.GetUnitValue(Unit.Builders));
            Player1.SetUnitValue(Unit.Weapons, Player1.GetUnitValue(Unit.Soldiers));
            Player1.SetUnitValue(Unit.Crystals, Player1.GetUnitValue(Unit.Magicians));

            Player2.SetUnitValue(Unit.Bricks, Player2.GetUnitValue(Unit.Builders));
            Player2.SetUnitValue(Unit.Weapons, Player2.GetUnitValue(Unit.Soldiers));
            Player2.SetUnitValue(Unit.Crystals, Player2.GetUnitValue(Unit.Magicians));
        }

        public void UpdateUI()
        {
            if (player1Turn)
            {
                activePanelPlayer1.BackColor = Color.Cyan;
                activePanelPlayer2.BackColor = Color.Black;
            }
            else
            {
                activePanelPlayer1.BackColor = Color.Black;
                activePanelPlayer2.BackColor = Color.Cyan;
            }

            stavitelePlayer1.Text = Player1.GetUnitValue(Unit.Builders).ToString();
            cihlyPlayer1.Text = Player1.GetUnitValue(Unit.Bricks).ToString();
            vojaciPlayer1.Text = Player1.GetUnitValue(Unit.Soldiers).ToString();
            zbranePlayer1.Text = Player1.GetUnitValue(Unit.Weapons).ToString();
            magovePlayer1.Text = Player1.GetUnitValue(Unit.Magicians).ToString();
            krystalyPlayer1.Text = Player1.GetUnitValue(Unit.Crystals).ToString();
            hradPlayer1.Text = Player1.GetUnitValue(Unit.Castle).ToString();
            hradbaPlayer1.Text = Player1.GetUnitValue(Unit.Wall).ToString();

            stavitelePlayer2.Text = Player2.GetUnitValue(Unit.Builders).ToString();
            cihlyPlayer2.Text = Player2.GetUnitValue(Unit.Bricks).ToString();
            vojaciPlayer2.Text = Player2.GetUnitValue(Unit.Soldiers).ToString();
            zbranePlayer2.Text = Player2.GetUnitValue(Unit.Weapons).ToString();
            magovePlayer2.Text = Player2.GetUnitValue(Unit.Magicians).ToString();
            krystalyPlayer2.Text = Player2.GetUnitValue(Unit.Crystals).ToString();
            hradPlayer2.Text = Player2.GetUnitValue(Unit.Castle).ToString();
            hradbaPlayer2.Text = Player2.GetUnitValue(Unit.Wall).ToString();
        }

        public void ShowCards()
        {
            IPlayer player = GetCurrentPlayer();
            Card card;
            int[] ids = new int[8];
            for (int i = 0; i < 8; i++)
            {
                card = player.GetCard(i);
                ids[i] = card.Available ? card.Id : card.Id + 30;
            }

            card0.Image = GetCardImage(ids[0]);
            card1.Image = GetCardImage(ids[1]);
            card2.Image = GetCardImage(ids[2]);
            card3.Image = GetCardImage(ids[3]);
            card4.Image = GetCardImage(ids[4]);
            card5.Image = GetCardImage(ids[5]);
            card6.Image = GetCardImage(ids[6]);
            card7.Image = GetCardImage(ids[7]);
        }

        public Image GetCardImage(int id)
        {
            return (Image) Properties.Resources.ResourceManager.GetObject(id.ToString());
        }

        private void ValidateCardClick(int index, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs) e;
            if (me.Button == MouseButtons.Left) PlayCard(index);
            if (me.Button == MouseButtons.Right) DiscardCard(index);
        }

        private void card0_Click(object sender, EventArgs e)
        {
            ValidateCardClick(0, e);
        }

        private void card1_Click(object sender, EventArgs e)
        {
            ValidateCardClick(1, e);
        }

        private void card2_Click(object sender, EventArgs e)
        {
            ValidateCardClick(2, e);
        }

        private void card3_Click(object sender, EventArgs e)
        {
            ValidateCardClick(3, e);
        }

        private void card4_Click(object sender, EventArgs e)
        {
            ValidateCardClick(4, e);
        }

        private void card5_Click(object sender, EventArgs e)
        {
            ValidateCardClick(5, e);
        }

        private void card6_Click(object sender, EventArgs e)
        {
            ValidateCardClick(6, e);
        }

        private void card7_Click(object sender, EventArgs e)
        {
            ValidateCardClick(7, e);
        }

        private void nováToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StartNewGame();
        }

        private void konecToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void nápovědaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help help = new Help();
            help.ShowDialog();
        }
    }
}
