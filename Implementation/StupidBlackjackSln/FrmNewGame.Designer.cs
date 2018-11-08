namespace StupidBlackjackSln
{
  partial class FrmNewGame
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
      this.picPlayerCard1 = new System.Windows.Forms.PictureBox();
      this.picPlayerCard2 = new System.Windows.Forms.PictureBox();
      this.picPlayerCard3 = new System.Windows.Forms.PictureBox();
      this.picPlayerCard4 = new System.Windows.Forms.PictureBox();
      this.picPlayerCard5 = new System.Windows.Forms.PictureBox();
      this.btnHit = new System.Windows.Forms.Button();
      this.btnStand = new System.Windows.Forms.Button();
      this.freezeLabel = new System.Windows.Forms.Label();
      this.winLabel = new System.Windows.Forms.Label();
      this.lblPlayerScore = new System.Windows.Forms.Label();
      this.Bets = new System.Windows.Forms.ComboBox();
      this.BetLabel = new System.Windows.Forms.Label();
      this.CurrentBetLabel = new System.Windows.Forms.Label();
      this.BetAmountLabel = new System.Windows.Forms.Label();
      this.timer1 = new System.Windows.Forms.Timer(this.components);
      ((System.ComponentModel.ISupportInitialize)(this.picPlayerCard1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.picPlayerCard2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.picPlayerCard3)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.picPlayerCard4)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.picPlayerCard5)).BeginInit();
      this.SuspendLayout();
      // 
      // picPlayerCard1
      // 
      this.picPlayerCard1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.picPlayerCard1.Location = new System.Drawing.Point(112, 0);
      this.picPlayerCard1.Name = "picPlayerCard1";
      this.picPlayerCard1.Size = new System.Drawing.Size(84, 128);
      this.picPlayerCard1.TabIndex = 0;
      this.picPlayerCard1.TabStop = false;
      // 
      // picPlayerCard2
      // 
      this.picPlayerCard2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.picPlayerCard2.Location = new System.Drawing.Point(245, 0);
      this.picPlayerCard2.Name = "picPlayerCard2";
      this.picPlayerCard2.Size = new System.Drawing.Size(84, 128);
      this.picPlayerCard2.TabIndex = 1;
      this.picPlayerCard2.TabStop = false;
      // 
      // picPlayerCard3
      // 
      this.picPlayerCard3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.picPlayerCard3.Location = new System.Drawing.Point(386, 0);
      this.picPlayerCard3.Name = "picPlayerCard3";
      this.picPlayerCard3.Size = new System.Drawing.Size(84, 128);
      this.picPlayerCard3.TabIndex = 2;
      this.picPlayerCard3.TabStop = false;
      // 
      // picPlayerCard4
      // 
      this.picPlayerCard4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.picPlayerCard4.Location = new System.Drawing.Point(528, 0);
      this.picPlayerCard4.Name = "picPlayerCard4";
      this.picPlayerCard4.Size = new System.Drawing.Size(84, 128);
      this.picPlayerCard4.TabIndex = 3;
      this.picPlayerCard4.TabStop = false;
      this.picPlayerCard4.Click += new System.EventHandler(this.picPlayerCard4_Click);
      // 
      // picPlayerCard5
      // 
      this.picPlayerCard5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.picPlayerCard5.Location = new System.Drawing.Point(670, 0);
      this.picPlayerCard5.Name = "picPlayerCard5";
      this.picPlayerCard5.Size = new System.Drawing.Size(84, 128);
      this.picPlayerCard5.TabIndex = 4;
      this.picPlayerCard5.TabStop = false;
      // 
      // btnHit
      // 
      this.btnHit.AutoSize = true;
      this.btnHit.Location = new System.Drawing.Point(128, 185);
      this.btnHit.Name = "btnHit";
      this.btnHit.Size = new System.Drawing.Size(30, 23);
      this.btnHit.TabIndex = 5;
      this.btnHit.Text = "Hit";
      this.btnHit.UseVisualStyleBackColor = true;
      this.btnHit.Click += new System.EventHandler(this.btnHit_Click);
      // 
      // btnStand
      // 
      this.btnStand.AutoSize = true;
      this.btnStand.Location = new System.Drawing.Point(212, 185);
      this.btnStand.Name = "btnStand";
      this.btnStand.Size = new System.Drawing.Size(53, 23);
      this.btnStand.TabIndex = 6;
      this.btnStand.Text = "Stand";
      this.btnStand.UseVisualStyleBackColor = true;
      this.btnStand.Click += new System.EventHandler(this.btnStand_Click);
      // 
      // freezeLabel
      // 
      this.freezeLabel.AutoSize = true;
      this.freezeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.freezeLabel.ForeColor = System.Drawing.Color.DarkRed;
      this.freezeLabel.Location = new System.Drawing.Point(631, 162);
      this.freezeLabel.Name = "freezeLabel";
      this.freezeLabel.Size = new System.Drawing.Size(155, 33);
      this.freezeLabel.TabIndex = 28;
      this.freezeLabel.Text = "You Lose!";
      this.freezeLabel.Visible = false;
      // 
      // winLabel
      // 
      this.winLabel.AutoSize = true;
      this.winLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.winLabel.ForeColor = System.Drawing.Color.Green;
      this.winLabel.Location = new System.Drawing.Point(638, 162);
      this.winLabel.Name = "winLabel";
      this.winLabel.Size = new System.Drawing.Size(141, 33);
      this.winLabel.TabIndex = 29;
      this.winLabel.Text = "You Win!";
      this.winLabel.Visible = false;
      // 
      // lblPlayerScore
      // 
      this.lblPlayerScore.AutoSize = true;
      this.lblPlayerScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblPlayerScore.Location = new System.Drawing.Point(435, 162);
      this.lblPlayerScore.Name = "lblPlayerScore";
      this.lblPlayerScore.Size = new System.Drawing.Size(105, 37);
      this.lblPlayerScore.TabIndex = 7;
      this.lblPlayerScore.Text = "Score";
      this.lblPlayerScore.Click += new System.EventHandler(this.lblPlayerScore_Click);
      // 
      // Bets
      // 
      this.Bets.FormattingEnabled = true;
      this.Bets.Items.AddRange(new object[] {
            "1",
            "5",
            "25",
            "50",
            "100",
            "500"});
      this.Bets.Location = new System.Drawing.Point(128, 117);
      this.Bets.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.Bets.Name = "Bets";
      this.Bets.Size = new System.Drawing.Size(92, 21);
      this.Bets.TabIndex = 31;
      this.Bets.SelectedIndexChanged += new System.EventHandler(this.Bets_SelectedIndexChanged);
      // 
      // BetLabel
      // 
      this.BetLabel.AutoSize = true;
      this.BetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.BetLabel.Location = new System.Drawing.Point(122, 60);
      this.BetLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.BetLabel.Name = "BetLabel";
      this.BetLabel.Size = new System.Drawing.Size(80, 37);
      this.BetLabel.TabIndex = 32;
      this.BetLabel.Text = "Bets";
      this.BetLabel.Click += new System.EventHandler(this.BetLabel_Click);
      // 
      // CurrentBetLabel
      // 
      this.CurrentBetLabel.AutoSize = true;
      this.CurrentBetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.CurrentBetLabel.Location = new System.Drawing.Point(271, 60);
      this.CurrentBetLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.CurrentBetLabel.Name = "CurrentBetLabel";
      this.CurrentBetLabel.Size = new System.Drawing.Size(166, 36);
      this.CurrentBetLabel.TabIndex = 33;
      this.CurrentBetLabel.Text = "Current Bet";
      // 
      // BetAmountLabel
      // 
      this.BetAmountLabel.AutoSize = true;
      this.BetAmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.BetAmountLabel.Location = new System.Drawing.Point(271, 117);
      this.BetAmountLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.BetAmountLabel.Name = "BetAmountLabel";
      this.BetAmountLabel.Size = new System.Drawing.Size(170, 36);
      this.BetAmountLabel.TabIndex = 34;
      this.BetAmountLabel.Text = "Bet Amount";
      this.BetAmountLabel.Click += new System.EventHandler(this.label2_Click);
      // 
      // FrmNewGame
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(903, 434);
      this.Controls.Add(this.BetAmountLabel);
      this.Controls.Add(this.CurrentBetLabel);
      this.Controls.Add(this.BetLabel);
      this.Controls.Add(this.Bets);
      this.Controls.Add(this.winLabel);
      this.Controls.Add(this.lblPlayerScore);
      this.Controls.Add(this.btnStand);
      this.Controls.Add(this.btnHit);
      this.Controls.Add(this.picPlayerCard5);
      this.Controls.Add(this.picPlayerCard4);
      this.Controls.Add(this.picPlayerCard3);
      this.Controls.Add(this.picPlayerCard2);
      this.Controls.Add(this.picPlayerCard1);
      this.Controls.Add(this.freezeLabel);
      this.Name = "FrmNewGame";
      this.Text = "FrmNewGame";
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmNewGame_FormClosed);
      this.Load += new System.EventHandler(this.FrmNewGame_Load);
      ((System.ComponentModel.ISupportInitialize)(this.picPlayerCard1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.picPlayerCard2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.picPlayerCard3)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.picPlayerCard4)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.picPlayerCard5)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.PictureBox picPlayerCard1;
    private System.Windows.Forms.PictureBox picPlayerCard2;
    private System.Windows.Forms.PictureBox picPlayerCard3;
    private System.Windows.Forms.PictureBox picPlayerCard4;
    private System.Windows.Forms.PictureBox picPlayerCard5;
    private System.Windows.Forms.Button btnHit;
    private System.Windows.Forms.Button btnStand;
    private System.Windows.Forms.Label freezeLabel;
    private System.Windows.Forms.Label winLabel;
    private System.Windows.Forms.Label lblPlayerScore;
    private System.Windows.Forms.ComboBox Bets;
    private System.Windows.Forms.Label BetLabel;
    private System.Windows.Forms.Label CurrentBetLabel;
    private System.Windows.Forms.Label BetAmountLabel;
    private System.Windows.Forms.Timer timer1;
  }
}