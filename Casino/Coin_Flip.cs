using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using Casino.Models;

namespace Casino
{
    public partial class CoinFlipForm : Form
    {
        private readonly Random _random = new Random();
        private decimal _currentBet;
        public User LoggedInUser { get; set; }
        private bool _isFlipping = false;
        private const int ANIMATION_FLIPS = 15;
        private const int ANIMATION_SPEED = 40;

        // Coin images - add these to your resources
        private readonly Image[] _coinImages =
        {
            Properties.Resources.Heads,  // Heads image
            Properties.Resources.Tails   // Tails image
        };

        // Controls
        private PictureBox CoinPictureBox;
        private Label BalanceLabel;
        private NumericUpDown BetNumeric;
        private Button btnHeads;
        private Button btnTails;
        private Label ResultLabel;
        private Button btnReset;
        private Label UserNameLabel;

        public CoinFlipForm(User loggedInUser)
        {
            InitializeComponent();
            LoggedInUser = loggedInUser;
            InitializeComponents();
            InitializeGame();
        }

        private void InitializeComponents()
        {
            // Form setup
            this.Text = "Coin Flip Game";
            this.ClientSize = new Size(450, 350);
            this.BackColor = Color.FromArgb(240, 240, 240);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;

            // User Info
            UserNameLabel = new Label
            {
                Text = LoggedInUser.Username,
                Location = new Point(20, 20),
                Font = new Font("Arial", 12, FontStyle.Bold),
                AutoSize = true
            };

            BalanceLabel = new Label
            {
                Text = LoggedInUser.Money.ToString("C"),
                Location = new Point(20, 50),
                Font = new Font("Arial", 12),
                AutoSize = true
            };

            // Bet Controls
            BetNumeric = new NumericUpDown
            {
                Location = new Point(20, 90),
                Size = new Size(120, 20),
                Minimum = 1,
                Maximum = 10000,
                DecimalPlaces = 2,
                Value = 50
            };

            // Buttons
            btnHeads = new Button
            {
                Text = "Bet on Heads",
                Location = new Point(20, 130),
                Size = new Size(120, 40),
                BackColor = Color.Gold,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Arial", 10, FontStyle.Bold)
            };
            btnHeads.Click += (s, e) => FlipCoin(0);

            btnTails = new Button
            {
                Text = "Bet on Tails",
                Location = new Point(150, 130),
                Size = new Size(120, 40),
                BackColor = Color.Silver,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Arial", 10, FontStyle.Bold)
            };
            btnTails.Click += (s, e) => FlipCoin(1);

            btnReset = new Button
            {
                Text = "Reset Game",
                Location = new Point(20, 180),
                Size = new Size(120, 30),
                BackColor = Color.LightGray,
                FlatStyle = FlatStyle.Flat
            };
            btnReset.Click += BtnReset_Click;

            // Coin Display
            CoinPictureBox = new PictureBox
            {
                Location = new Point(250, 50),
                Size = new Size(150, 150),
                SizeMode = PictureBoxSizeMode.StretchImage,
                Image = _coinImages[0],
                BorderStyle = BorderStyle.FixedSingle
            };

            // Result Display
            ResultLabel = new Label
            {
                Location = new Point(20, 220),
                Size = new Size(300, 40),
                Font = new Font("Arial", 12, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter
            };

            // Add Controls
            this.Controls.AddRange(new Control[] {
                UserNameLabel, BalanceLabel, BetNumeric,
                btnHeads, btnTails, btnReset,
                CoinPictureBox, ResultLabel
            });
        }

        private void InitializeGame()
        {
            UpdateUI();
            CoinPictureBox.Image = _coinImages[0];
            ResultLabel.Text = "Place your bet and choose!";
        }

        private void UpdateUI()
        {
            BalanceLabel.Text = LoggedInUser.Money.ToString("C");
            BetNumeric.Maximum = LoggedInUser.Money;
        }

        private async void FlipCoin(int playerChoice)
        {
            if (_isFlipping || BetNumeric.Value == 0) return;

            _isFlipping = true;
            _currentBet = BetNumeric.Value;
            LoggedInUser.Money -= _currentBet;
            UpdateUI();
            DisableControls();

            // Animated coin flip
            for (int i = 0; i < ANIMATION_FLIPS; i++)
            {
                CoinPictureBox.Image = _coinImages[_random.Next(2)];
                await Task.Delay(ANIMATION_SPEED);
            }

            int result = _random.Next(2);
            CoinPictureBox.Image = _coinImages[result];

            if (result == playerChoice)
            {
                LoggedInUser.Money += _currentBet * 2;
                ShowResult("YOU WIN!", Color.Green);
            }
            else
            {
                ShowResult("YOU LOSE!", Color.Red);
            }

            LoggedInUser.UpdateToDataBaseMoney(result == playerChoice ? _currentBet : -_currentBet);
            UpdateUI();
            EnableControls();
            _isFlipping = false;

            if (LoggedInUser.Money <= 0)
            {
                MessageBox.Show("Game Over! You're out of funds.",
                              "Bankrupt", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnReset.PerformClick();
            }
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Reset balance to $1000?", "Reset Game",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                LoggedInUser.Money = 1000m;
                LoggedInUser.UpdateToDataBaseMoney(1000m);
                InitializeGame();
            }
        }

        private void ShowResult(string message, Color color)
        {
            ResultLabel.Text = message;
            ResultLabel.ForeColor = color;
        }

        private void DisableControls()
        {
            BetNumeric.Enabled = false;
            btnHeads.Enabled = false;
            btnTails.Enabled = false;
            btnReset.Enabled = false;
        }

        private void EnableControls()
        {
            BetNumeric.Enabled = true;
            btnHeads.Enabled = true;
            btnTails.Enabled = true;
            btnReset.Enabled = true;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            LoggedInUser.UpdateToDataBaseMoney(0); // Force balance sync
        }
    }
}