namespace StupidBlackjackSln {
  partial class FrmNewGame {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.picPlayerCard1 = new System.Windows.Forms.PictureBox();
            this.picPlayerCard2 = new System.Windows.Forms.PictureBox();
            this.picPlayerCard3 = new System.Windows.Forms.PictureBox();
            this.picPlayerCard4 = new System.Windows.Forms.PictureBox();
            this.picPlayerCard5 = new System.Windows.Forms.PictureBox();
            this.btnHit = new System.Windows.Forms.Button();
            this.btnStand = new System.Windows.Forms.Button();
            this.lblPlayerScore = new System.Windows.Forms.Label();
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
            this.picPlayerCard1.Location = new System.Drawing.Point(60, 1);
            this.picPlayerCard1.Name = "picPlayerCard1";
            this.picPlayerCard1.Size = new System.Drawing.Size(106, 144);
            this.picPlayerCard1.TabIndex = 0;
            this.picPlayerCard1.TabStop = false;
            // 
            // picPlayerCard2
            // 
            this.picPlayerCard2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picPlayerCard2.Location = new System.Drawing.Point(210, 1);
            this.picPlayerCard2.Name = "picPlayerCard2";
            this.picPlayerCard2.Size = new System.Drawing.Size(106, 144);
            this.picPlayerCard2.TabIndex = 1;
            this.picPlayerCard2.TabStop = false;
            // 
            // picPlayerCard3
            // 
            this.picPlayerCard3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picPlayerCard3.Location = new System.Drawing.Point(360, 1);
            this.picPlayerCard3.Name = "picPlayerCard3";
            this.picPlayerCard3.Size = new System.Drawing.Size(106, 144);
            this.picPlayerCard3.TabIndex = 2;
            this.picPlayerCard3.TabStop = false;
            this.picPlayerCard3.Click += new System.EventHandler(this.picPlayerCard3_Click);
            // 
            // picPlayerCard4
            // 
            this.picPlayerCard4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picPlayerCard4.Location = new System.Drawing.Point(510, 1);
            this.picPlayerCard4.Name = "picPlayerCard4";
            this.picPlayerCard4.Size = new System.Drawing.Size(106, 144);
            this.picPlayerCard4.TabIndex = 3;
            this.picPlayerCard4.TabStop = false;
            // 
            // picPlayerCard5
            // 
            this.picPlayerCard5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picPlayerCard5.Location = new System.Drawing.Point(660, 1);
            this.picPlayerCard5.Name = "picPlayerCard5";
            this.picPlayerCard5.Size = new System.Drawing.Size(106, 144);
            this.picPlayerCard5.TabIndex = 4;
            this.picPlayerCard5.TabStop = false;
            // 
            // btnHit
            // 
            this.btnHit.AutoSize = true;
            this.btnHit.Location = new System.Drawing.Point(343, 175);
            this.btnHit.Name = "btnHit";
            this.btnHit.Size = new System.Drawing.Size(44, 29);
            this.btnHit.TabIndex = 5;
            this.btnHit.Text = "Hit";
            this.btnHit.UseVisualStyleBackColor = true;
            this.btnHit.Click += new System.EventHandler(this.btnHit_Click);
            // 
            // btnStand
            // 
            this.btnStand.AutoSize = true;
            this.btnStand.Location = new System.Drawing.Point(442, 175);
            this.btnStand.Name = "btnStand";
            this.btnStand.Size = new System.Drawing.Size(57, 29);
            this.btnStand.TabIndex = 6;
            this.btnStand.Text = "Stand";
            this.btnStand.UseVisualStyleBackColor = true;
            // 
            // lblPlayerScore
            // 
            this.lblPlayerScore.AutoSize = true;
            this.lblPlayerScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerScore.Location = new System.Drawing.Point(384, 93);
            this.lblPlayerScore.Name = "lblPlayerScore";
            this.lblPlayerScore.Size = new System.Drawing.Size(106, 37);
            this.lblPlayerScore.TabIndex = 7;
            this.lblPlayerScore.Text = "label1";
            this.lblPlayerScore.Click += new System.EventHandler(this.lblPlayerScore_Click);
            // 
            // FrmNewGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPlayerScore);
            this.Controls.Add(this.btnStand);
            this.Controls.Add(this.btnHit);
            this.Controls.Add(this.picPlayerCard5);
            this.Controls.Add(this.picPlayerCard4);
            this.Controls.Add(this.picPlayerCard3);
            this.Controls.Add(this.picPlayerCard2);
            this.Controls.Add(this.picPlayerCard1);
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
    private System.Windows.Forms.Label lblPlayerScore;
        private System.Windows.Forms.Timer timer1;
    }
}