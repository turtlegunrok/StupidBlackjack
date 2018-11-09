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
    private Bot dealer;
    private Bot Bot1;
    private Bot Bot2;
    private Bot Bot3;
    private Bot Bot4;
    private PictureBox[] picPlayerCards;
    private PictureBox[] picDealerCards;
    public int currentCard;
    public int currentRound;

    public FrmNewGame()
    {
      InitializeComponent();
      currentCard = 0;
      currentRound = 1;
      timer1.Interval = 10;
      timer1.Tick += new EventHandler(Timer_Tick);
      picPlayerCards = new PictureBox[5];

      picDealerCards = new PictureBox[5];
      picDealerCards[0] = Controls.Find("picPlayerCard" + (6).ToString(), true)[0] as PictureBox;
      picDealerCards[1] = Controls.Find("picPlayerCard" + (7).ToString(), true)[0] as PictureBox;
      picDealerCards[2] = Controls.Find("picPlayerCard" + (8).ToString(), true)[0] as PictureBox;
      picDealerCards[3] = Controls.Find("picPlayerCard" + (9).ToString(), true)[0] as PictureBox;
      picDealerCards[4] = Controls.Find("picPlayerCard" + (10).ToString(), true)[0] as PictureBox;

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
        picPlayerCards[currentCard].Visible = true;
        picDealerCards[currentCard].Visible = true;
                int x = picPlayerCards[currentCard].Location.X;
        int y = picPlayerCards[currentCard].Location.Y;

        if (y < 215)
        {
          picPlayerCards[currentCard].Location = new Point(x, y + 10);
        }

        if (y > 215)
        {
          for (int i = 0; i < player1.Hand.Count(); i++)
          {
            picPlayerCards[i].BackgroundImage = player1.Hand[i].Bitmap;

          }
                    currentCard += 1;
                    timer1.Stop();
                   
                    lblPlayerScore.Text = player1.Score.ToString();
        }
                if (currentCard == 1)
                {
                    timer1.Start();
                }
            }
    }

    private void FrmNewGame_FormClosed(object sender, FormClosedEventArgs e)
    {
      foreach (Form f in Application.OpenForms)
      {
        f.Close();
      }
    }


    private void FrmNewGame_Load(object sender, EventArgs e)
    {
      currentCard = 0;
      deck = new Deck(FindBitmap);
      dealer = new BlackjackBot();
      Bot1 = new BlackjackBot();
      Bot2 = new BlackjackBot();
      Bot3 = new BlackjackBot();
      Bot4 = new BlackjackBot();
      player1 = new BlackjackPlayer();
      dealer.giveHand(new List<Card>() { deck.dealCard(), deck.dealCard() });
      player1.giveHand(new List<Card>() { deck.dealCard(), deck.dealCard() });
      showHand_Dealer();
      showHand();
    }
    private void showHand_Dealer()
    {
      for (int i = 0; i < dealer.Hand.Count(); i++)
      {
        picDealerCards[i].BackgroundImage = dealer.Hand[i].Bitmap;
      }
      labelDealerScore.Text = dealer.Score.ToString();
    }
    private void showHand()
    {
      for (int i = 0; i < player1.Hand.Count(); i++)
      {
        picPlayerCards[i].BackgroundImage = player1.Hand[i].Bitmap;
      }
      lblPlayerScore.Text = player1.Score.ToString();
    }

    private void btnHit_Click(object sender, EventArgs e)
    {
      if (player1.Hand.Count() >= 5)
      {
        freezeLabel.Visible = true;
        nextRoundButton.Visible = true;
      }
      else if (player1.Hand.Count() < 5)
      {
        if (player1.Score <= 21)
        {
          player1.giveCard(deck.dealCard());
          dealer.giveCard(deck.dealCard());
          timer1.Start();
          showHand_Dealer();
          showHand();
          if (player1.Score > 21)
          {
            freezeLabel.Visible = true;
            nextRoundButton.Visible = true;

          }
        }
        else if (player1.Score > 21)
        {
          freezeLabel.Visible = true;
          nextRoundButton.Visible = true;
        }
      }
    }
    private void NextRound()
    {

      currentRound += 1;
      label2.Text = "Round:" + currentRound.ToString();
      nextRoundButton.Visible = false;
      currentCard = 0;
            picPlayerCards = null;
      deck = new Deck(FindBitmap);
            dealer = new BlackjackBot();

            player1 = new BlackjackPlayer();
            dealer.giveHand(new List<Card>() { deck.dealCard(), deck.dealCard() });
            player1.giveHand(new List<Card>() { deck.dealCard(), deck.dealCard() });
      picPlayerCards = new PictureBox[5];
            picDealerCards = new PictureBox[5];
            picDealerCards[0] = Controls.Find("picPlayerCard" + (6).ToString(), true)[0] as PictureBox;
            picDealerCards[1] = Controls.Find("picPlayerCard" + (7).ToString(), true)[0] as PictureBox;
            picDealerCards[2] = Controls.Find("picPlayerCard" + (8).ToString(), true)[0] as PictureBox;
            picDealerCards[3] = Controls.Find("picPlayerCard" + (9).ToString(), true)[0] as PictureBox;
            picDealerCards[4] = Controls.Find("picPlayerCard" + (10).ToString(), true)[0] as PictureBox;


            for (int i = 0; i < 5; i++)
      {
                picPlayerCards[i] = Controls.Find("picPlayerCard" + (i + 1).ToString(), true)[0] as PictureBox;
        picPlayerCards[i].Location = new Point(picPlayerCards[i].Location.X, 0);
        picPlayerCards[i].Visible = false;
                picDealerCards[i].Visible = false;
      }
      showHand();
            showHand_Dealer();
            timer1.Start();


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

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void label2_Click_1(object sender, EventArgs e)
    {

    }

    private void winLabel_Click(object sender, EventArgs e)
    {

    }

    private void picPlayerCard5_Click(object sender, EventArgs e)
    {

    }

    private void nextRoundButton_Click(object sender, EventArgs e)
    {
      NextRound();
    }

    private void labelDealerScore_Click(object sender, EventArgs e)
    {

    }
  }
}
