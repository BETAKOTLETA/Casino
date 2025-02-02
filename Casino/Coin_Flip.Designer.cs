namespace Casino
{
    partial class CoinFlipForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.Label BalanceLabel;
        private System.Windows.Forms.NumericUpDown BetNumeric;
        private System.Windows.Forms.Button btnHeads;
        private System.Windows.Forms.Button btnTails;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.PictureBox CoinPictureBox;
        private System.Windows.Forms.Label ResultLabel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();

            // UserNameLabel
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.UserNameLabel.Location = new System.Drawing.Point(20, 20);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(124, 19);
            this.UserNameLabel.TabIndex = 0;

            // BalanceLabel
            this.BalanceLabel = new System.Windows.Forms.Label();
            this.BalanceLabel.AutoSize = true;
            this.BalanceLabel.Font = new System.Drawing.Font("Arial", 12F);
            this.BalanceLabel.Location = new System.Drawing.Point(20, 50);
            this.BalanceLabel.Name = "BalanceLabel";
            this.BalanceLabel.Size = new System.Drawing.Size(73, 18);
            this.BalanceLabel.TabIndex = 1;

            // BetNumeric
            this.BetNumeric = new System.Windows.Forms.NumericUpDown();
            this.BetNumeric.DecimalPlaces = 2;
            this.BetNumeric.Location = new System.Drawing.Point(20, 90);
            this.BetNumeric.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.BetNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.BetNumeric.Name = "BetNumeric";
            this.BetNumeric.Size = new System.Drawing.Size(120, 20);
            this.BetNumeric.TabIndex = 2;
            this.BetNumeric.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});

            // btnHeads
            this.btnHeads = new System.Windows.Forms.Button();
            this.btnHeads.BackColor = System.Drawing.Color.Gold;
            this.btnHeads.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHeads.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnHeads.Location = new System.Drawing.Point(20, 130);
            this.btnHeads.Name = "btnHeads";
            this.btnHeads.Size = new System.Drawing.Size(120, 40);
            this.btnHeads.TabIndex = 3;
            this.btnHeads.Text = "Bet on Heads";
            this.btnHeads.UseVisualStyleBackColor = false;

            // btnTails
            this.btnTails = new System.Windows.Forms.Button();
            this.btnTails.BackColor = System.Drawing.Color.Silver;
            this.btnTails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTails.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnTails.Location = new System.Drawing.Point(150, 130);
            this.btnTails.Name = "btnTails";
            this.btnTails.Size = new System.Drawing.Size(120, 40);
            this.btnTails.TabIndex = 4;
            this.btnTails.Text = "Bet on Tails";
            this.btnTails.UseVisualStyleBackColor = false;

            // btnReset
            this.btnReset = new System.Windows.Forms.Button();
            this.btnReset.BackColor = System.Drawing.Color.LightGray;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Location = new System.Drawing.Point(20, 180);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(120, 30);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Reset Game";
            this.btnReset.UseVisualStyleBackColor = false;

            // CoinPictureBox
            this.CoinPictureBox = new System.Windows.Forms.PictureBox();
            this.CoinPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CoinPictureBox.Location = new System.Drawing.Point(250, 50);
            this.CoinPictureBox.Name = "CoinPictureBox";
            this.CoinPictureBox.Size = new System.Drawing.Size(150, 150);
            this.CoinPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CoinPictureBox.TabIndex = 6;
            this.CoinPictureBox.TabStop = false;

            // ResultLabel
            this.ResultLabel = new System.Windows.Forms.Label();
            this.ResultLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.ResultLabel.Location = new System.Drawing.Point(20, 220);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(300, 40);
            this.ResultLabel.TabIndex = 7;
            this.ResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // CoinFlipForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(450, 350);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.CoinPictureBox);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnTails);
            this.Controls.Add(this.btnHeads);
            this.Controls.Add(this.BetNumeric);
            this.Controls.Add(this.BalanceLabel);
            this.Controls.Add(this.UserNameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "CoinFlipForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Coin Flip Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}