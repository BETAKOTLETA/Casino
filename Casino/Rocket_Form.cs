using System;
using System.Windows.Forms;
using Casino.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Casino
{
    public partial class Rocket_Form : Form
    {
        private Rocket _rocket;
        private User _currentUser;
        private bool _cashedOut;
        public User LoggedInUser { get; set; }

        Bet bet;

        public Rocket_Form(User loggedInUser)
        {
            LoggedInUser = loggedInUser;
            InitializeComponent();
            _currentUser = loggedInUser;
            _rocket = new Rocket(bet, this);
            _rocket.OnCoefficientUpdate += UpdateUI;
            AmountMoneyLabel.Text = $"Balance: {_currentUser.Money:C}";
            UserName_label.Text = _currentUser.Username;
        }

        private void startButton_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(betTextBox.Text) || !decimal.TryParse(betTextBox.Text, out decimal betAmount) || betAmount <= 0)
            {
                MessageBox.Show("Please enter a valid, positive bet amount!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bet.ChangeBet(betAmount, betLabel);

            AmountMoneyLabel.Text = LoggedInUser.Money.ToString("C");

            _currentUser.Money -= bet.Amount;
            AmountMoneyLabel.Text = $"Balance: {_currentUser.Money:C}";
            cashOutButton.Enabled = true;
            BackToCasinoButton.Enabled = false;
            startButton.Enabled = false;
            _cashedOut = false;
            resultLabel.Text = "";

            _rocket.StartGame(bet, _currentUser);
        }

        private void cashOutButton_Click(object sender, EventArgs e)
        {
            if (!_cashedOut)
            {
                decimal winnings = bet.Amount * (decimal)_rocket.CurrentCoefficient;
                _currentUser.UpdateToDataBaseMoney(winnings);
                AmountMoneyLabel.Text = $"Balance: {_currentUser.Money:C}";
                resultLabel.Text = $"You cashed out at x{_rocket.CurrentCoefficient:F2}!";
                _cashedOut = true;
                cashOutButton.Enabled = false;
                _rocket.StopGame();
                bet.Reset();
                bet.ChangeBet(bet.Amount, betLabel);

            }
            BackToCasinoButton.Enabled = true;
            startButton.Enabled = true;
        }

        private void UpdateUI(double coefficient)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<double>(UpdateUI), coefficient);
                return;
            }

            coefficientLabel.Text = $"{coefficient:F2}x";
        }

        private void BackToCasinoButton_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void Rocket_Form_Load(object sender, EventArgs e)
        {
            if (LoggedInUser != null)
            {
                bet = new Bet(0, LoggedInUser);
                UserName_label.Text = LoggedInUser.Username;
                AmountMoneyLabel.Text = LoggedInUser.Money.ToString("C");


            }
        }

        private void coefficientLabel_Click(object sender, EventArgs e)
        {

        }
    }
} 
