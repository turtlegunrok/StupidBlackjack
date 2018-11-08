using StupidBlackjackSln.Code;
using StupidBlackjackSln.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StupidBlackjackSln
{

    public partial class FrmNewGame : Form
    {
        private Deck deck;
        private Player player1;
        private Player Bot1;
        private Player Bot2;
        private Player Bot3;
        private Player Bot4;
        private PictureBox[] picPlayerCards;
        public int currentCard;

        public FrmNewGame()
        {
            InitializeComponent();
            currentCard = 0;
            timer1.Interval = 10;
            timer1.Tick += new EventHandler(Timer_Tick);
            picPlayerCards = new PictureBox[5];
            for (int i = 0; i < 5; i++)
            {
                picPlayerCards[i] = Controls.Find("picPlayerCard" + (i + 1).ToString(), true)[0] as PictureBox;
            }
            timer1.Start();
        }
        void Timer_Tick(object sender, EventArgs e)
        {
            if (currentCard < 5)
            {
                int x = picPlayerCards[currentCard].Location.X;
                int y = picPlayerCards[currentCard].Location.Y;

                picPlayerCards[currentCard].Location = new Point(x, y + 10);

                if (y > 215)
                {
                    currentCard += 1;
                    timer1.Stop();
                }
                if (currentCard == 1)
                {
                    timer1.Start();
                }
            }

        }

        private void FrmNewGame_Load(object sender, EventArgs e)
        {
            deck = new Deck(FindBitmap);
            player1 = new BlackjackPlayer();
            player1.giveHand(new List<Card>() { deck.dealCard(), deck.dealCard() });
            showHand();
        }

        private void showHand()
        {
            for (int i = 0; i < player1.Hand.Count(); i++)
            {
                picPlayerCards[i].BackgroundImage = player1.Hand[i].Bitmap;
            }
            lblPlayerScore.Text = player1.Score.ToString();
        }

        private void FrmNewGame_FormClosed(object sender, FormClosedEventArgs e)
        {
            foreach (Form f in Application.OpenForms)
            {
                f.Close();
            }
        }

        private void btnHit_Click(object sender, EventArgs e)
        {
            if (player1.Hand.Count() >= 5)
            {
                freezeLabel.Visible = true;
            }
            else if (player1.Hand.Count() < 5)
            {
                if (player1.Score <= 21)
                {   
                    player1.giveCard(deck.dealCard());
                    timer1.Start();
                    showHand();
                    if (player1.Score > 21)
                    {
                        freezeLabel.Visible = true;
                    }
                }
                else if (player1.Score > 21)
                {
                    freezeLabel.Visible = true;
                }
            }
        }

        private void btnStand_Click(object sender, EventArgs e)
        {
            winLabel.Visible = true;
        }

        private Bitmap FindBitmap(string value, string suit)
        {
            string textName = "";
            int valueAsNum;
            if (int.TryParse(value, out valueAsNum))
            {
                textName += "_";
            }

            textName += value;
            textName += "_of_";
            textName += suit;

            return (Bitmap)Resources.ResourceManager.GetObject(textName);
        }

        private void lblPlayerScore_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Bets_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BetLabel_Click(object sender, EventArgs e)
        {

        }

        private void picPlayerCard4_Click(object sender, EventArgs e)
        {

        }
    }
}
