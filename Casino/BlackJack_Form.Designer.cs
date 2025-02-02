namespace Casino
{
    partial class BlackJack_Form
    {
        private System.ComponentModel.IContainer components = null;

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
            titleLabel = new Label();
            DealerValueLabel = new Label();
            PlayerValueLabel = new Label();
            AmountMoneyLabel = new Label();
            betLabel = new Label();
            betAmountBox = new TextBox();
            hitButton = new Button();
            standButton = new Button();
            dealButton = new Button();
            backButton = new Button();
            dealerScoreLabel = new Label();
            playerScoreLabel = new Label();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            titleLabel.ForeColor = Color.White;
            titleLabel.Location = new Point(400, 20);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(190, 37);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "♠️ BlackJack ♥️";
            // 
            // DealerValueLabel
            // 
            DealerValueLabel.AutoSize = true;
            DealerValueLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            DealerValueLabel.ForeColor = Color.White;
            DealerValueLabel.Location = new Point(450, 80);
            DealerValueLabel.Name = "DealerValueLabel";
            DealerValueLabel.Size = new Size(136, 25);
            DealerValueLabel.TabIndex = 1;
            DealerValueLabel.Text = "Dealer's Hand";
            // 
            // PlayerValueLabel
            // 
            PlayerValueLabel.AutoSize = true;
            PlayerValueLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            PlayerValueLabel.ForeColor = Color.White;
            PlayerValueLabel.Location = new Point(450, 350);
            PlayerValueLabel.Name = "PlayerValueLabel";
            PlayerValueLabel.Size = new Size(134, 25);
            PlayerValueLabel.TabIndex = 3;
            PlayerValueLabel.Text = "Player's Hand";
            // 
            // AmountMoneyLabel
            // 
            AmountMoneyLabel.AutoSize = true;
            AmountMoneyLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            AmountMoneyLabel.ForeColor = Color.White;
            AmountMoneyLabel.Location = new Point(20, 20);
            AmountMoneyLabel.Name = "AmountMoneyLabel";
            AmountMoneyLabel.Size = new Size(123, 21);
            AmountMoneyLabel.TabIndex = 5;
            AmountMoneyLabel.Text = "Balance: $1000";
            // 
            // betLabel
            // 
            betLabel.AutoSize = true;
            betLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            betLabel.ForeColor = Color.White;
            betLabel.Location = new Point(20, 60);
            betLabel.Name = "betLabel";
            betLabel.Size = new Size(105, 21);
            betLabel.TabIndex = 6;
            betLabel.Text = "Bet Amount:";
            // 
            // betAmountBox
            // 
            betAmountBox.BackColor = Color.White;
            betAmountBox.Font = new Font("Segoe UI", 12F);
            betAmountBox.ForeColor = Color.Black;
            betAmountBox.Location = new Point(130, 60);
            betAmountBox.Name = "betAmountBox";
            betAmountBox.Size = new Size(100, 29);
            betAmountBox.TabIndex = 7;
            // 
            // hitButton
            // 
            hitButton.BackColor = Color.Red;
            hitButton.Cursor = Cursors.Hand;
            hitButton.Enabled = false;
            hitButton.FlatAppearance.BorderSize = 0;
            hitButton.FlatStyle = FlatStyle.Flat;
            hitButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            hitButton.ForeColor = Color.White;
            hitButton.Location = new Point(350, 500);
            hitButton.Name = "hitButton";
            hitButton.Size = new Size(100, 40);
            hitButton.TabIndex = 8;
            hitButton.Text = "Hit";
            hitButton.UseVisualStyleBackColor = false;
            // 
            // standButton
            // 
            standButton.BackColor = Color.Black;
            standButton.Cursor = Cursors.Hand;
            standButton.Enabled = false;
            standButton.FlatAppearance.BorderSize = 0;
            standButton.FlatStyle = FlatStyle.Flat;
            standButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            standButton.ForeColor = Color.White;
            standButton.Location = new Point(460, 500);
            standButton.Name = "standButton";
            standButton.Size = new Size(100, 40);
            standButton.TabIndex = 9;
            standButton.Text = "Stand";
            standButton.UseVisualStyleBackColor = false;
            // 
            // dealButton
            // 
            dealButton.BackColor = Color.FromArgb(0, 100, 0);
            dealButton.Cursor = Cursors.Hand;
            dealButton.FlatAppearance.BorderSize = 0;
            dealButton.FlatStyle = FlatStyle.Flat;
            dealButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dealButton.ForeColor = Color.White;
            dealButton.Location = new Point(570, 500);
            dealButton.Name = "dealButton";
            dealButton.Size = new Size(100, 40);
            dealButton.TabIndex = 10;
            dealButton.Text = "Deal";
            dealButton.UseVisualStyleBackColor = false;
            // 
            // backButton
            // 
            backButton.BackColor = Color.Gray;
            backButton.Cursor = Cursors.Hand;
            backButton.FlatAppearance.BorderSize = 0;
            backButton.FlatStyle = FlatStyle.Flat;
            backButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            backButton.ForeColor = Color.White;
            backButton.Location = new Point(20, 500);
            backButton.Name = "backButton";
            backButton.Size = new Size(100, 40);
            backButton.TabIndex = 11;
            backButton.Text = "← Back";
            backButton.UseVisualStyleBackColor = false;
            // 
            // dealerScoreLabel
            // 
            dealerScoreLabel.AutoSize = true;
            dealerScoreLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dealerScoreLabel.ForeColor = Color.White;
            dealerScoreLabel.Location = new Point(465, 110);
            dealerScoreLabel.Name = "dealerScoreLabel";
            dealerScoreLabel.Size = new Size(69, 21);
            dealerScoreLabel.TabIndex = 2;
            dealerScoreLabel.Text = "Score: 0";
            // 
            // playerScoreLabel
            // 
            playerScoreLabel.AutoSize = true;
            playerScoreLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            playerScoreLabel.ForeColor = Color.White;
            playerScoreLabel.Location = new Point(465, 380);
            playerScoreLabel.Name = "playerScoreLabel";
            playerScoreLabel.Size = new Size(69, 21);
            playerScoreLabel.TabIndex = 4;
            playerScoreLabel.Text = "Score: 0";
            // 
            // BlackJack_Form
            // 
            BackColor = Color.DarkGreen;
            ClientSize = new Size(1000, 600);
            Controls.Add(titleLabel);
            Controls.Add(DealerValueLabel);
            Controls.Add(dealerScoreLabel);
            Controls.Add(PlayerValueLabel);
            Controls.Add(playerScoreLabel);
            Controls.Add(AmountMoneyLabel);
            Controls.Add(betLabel);
            Controls.Add(betAmountBox);
            Controls.Add(hitButton);
            Controls.Add(standButton);
            Controls.Add(dealButton);
            Controls.Add(backButton);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "BlackJack_Form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BlackJack";
            ResumeLayout(false);
            PerformLayout();
        }

        private Label titleLabel;
        private Label DealerValueLabel;
        private Label PlayerValueLabel;
        private Label AmountMoneyLabel;
        private Label betLabel;
        private TextBox betAmountBox;
        private Button hitButton;
        private Button standButton;
        private Button dealButton;
        private Button backButton;
        private Label dealerScoreLabel;
        private Label playerScoreLabel;
    }
}