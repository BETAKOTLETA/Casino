using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Casino.Models;

namespace Casino
{
    public partial class BlackJack_Form : Form
    {
        private Deck _deck;
        private List<Card> _playerHand;
        private List<Card> _dealerHand;
        public User LoggedInUser { get; set; }

        Bet bet;

        Game game = new Game();

        public BlackJack_Form(User loggedInUser)
        {
            InitializeComponent();
            LoggedInUser = loggedInUser;
            bet = new Bet(0, LoggedInUser);

        }

        private void InitializeGame()
        {
            _deck = new Deck();
            _playerHand = new List<Card>();
            _dealerHand = new List<Card>();

            _playerHand.Add(_deck.DrawCard());
            _dealerHand.Add(_deck.DrawCard());
            _playerHand.Add(_deck.DrawCard());
            _dealerHand.Add(_deck.DrawCard());

            UpdateUI();
        }

        private void UpdateUI()
        {
            PlayerCardsLabel.Text = "Player cards: " + string.Join(", ", _playerHand.Select(c => c.ToString()));
            PlayerValueLabel.Text = "Value: " + CalculateHandValue(_playerHand).ToString();

            DealerCardsLabel.Text = "Dealer cards: Hidden, " + string.Join(", ", _dealerHand.Skip(1).Select(c => c.ToString()));
            DealerValueLabel.Text = "Value: " + CalculateHandValue(_dealerHand.Skip(1).ToList()).ToString();

            AmountMoneyLabel.Text = LoggedInUser.Money.ToString("C");
        }

        private int CalculateHandValue(List<Card> hand)
        {
            if (hand == null)
            {
                throw new ArgumentNullException(nameof(hand), "Hand cannot be null.");
            }

            int value = hand.Sum(c => c.Value);
            int aceCount = hand.Count(c => c.Rank == "Ace");

            while (value > 21 && aceCount > 0)
            {
                value -= 10;
                aceCount--;
            }
            return value;
        }

        private void HitButton_Click(object sender, EventArgs e)
        {
            _playerHand.Add(_deck.DrawCard());
            UpdateUI();

            if (CalculateHandValue(_playerHand) > 21)
            {
                MessageBox.Show("Bust! You lose.");

                bet.Reset();
                TotalBetLabel.Text = "0";

                ShowBetButtons();

                HitButton.Visible = false;
                StandButton.Visible = false;

                Dealbutton.Visible = true;

                DontShowPlayerandDealer();

            }
        }

        private async void StandButton_Click(object sender, EventArgs e)
        {
            while (CalculateHandValue(_dealerHand) < 17)
            {
                _dealerHand.Add(_deck.DrawCard());
            }

            int playerValue = CalculateHandValue(_playerHand);
            int dealerValue = CalculateHandValue(_dealerHand);

            DealerCardsLabel.Text = string.Join(", ", _dealerHand.Select(c => c.ToString()));
            DealerValueLabel.Text = dealerValue.ToString();

            AmountMoneyLabel.Text = LoggedInUser.Money.ToString("C");

            if (dealerValue > 21 || playerValue > dealerValue)
            {
                MessageBox.Show("You win!");

                game.WinBet(bet, LoggedInUser);
            }
            else if (playerValue == dealerValue)
            {
                MessageBox.Show("Draw!");
            }
            else
            {
                MessageBox.Show("Dealer wins!");
                game.LoseBet(bet, LoggedInUser);
            }

            AmountMoneyLabel.Text = LoggedInUser.Money.ToString("C");

            bet.Reset();
            TotalBetLabel.Text = "0";

            ShowBetButtons();

            HitButton.Visible = false;
            StandButton.Visible = false;

            Dealbutton.Visible = true;

            DontShowPlayerandDealer();
        }

        private void BlackJack_Form_Load(object sender, EventArgs e)
        {
            if (LoggedInUser != null)
            {
                UserName_label.Text = LoggedInUser.Username;
                AmountMoneyLabel.Text = LoggedInUser.Money.ToString("C");
                HitButton.Visible = false;
                StandButton.Visible = false;
                if (LoggedInUser.IsAdmin)
                {
                    UserName_label.ForeColor = Color.Gold;
                }
                else
                {
                    UserName_label.ForeColor = SystemColors.ControlText;
                }
                DontShowPlayerandDealer();
            }

        }

        private void DealerCardsLabel_Click(object sender, EventArgs e)
        {

        }

        private void onedollarbetbutton_Click(object sender, EventArgs e)
        {
            bet.ChangeBet(1, TotalBetLabel);

            AmountMoneyLabel.Text = LoggedInUser.Money.ToString("C");
        }

        private void fivedollarbetbutton_Click(object sender, EventArgs e)
        {
            bet.ChangeBet(5, TotalBetLabel);

            AmountMoneyLabel.Text = LoggedInUser.Money.ToString("C");
        }

        private void tendollarbetbutton_Click(object sender, EventArgs e)
        {
            bet.ChangeBet(10, TotalBetLabel);

            AmountMoneyLabel.Text = LoggedInUser.Money.ToString("C");
        }

        private void twofivedollarbetbutton_Click(object sender, EventArgs e)
        {
            bet.ChangeBet(25, TotalBetLabel);

            AmountMoneyLabel.Text = LoggedInUser.Money.ToString("C");
        }

        private void fivezerodollarbetbutton_Click(object sender, EventArgs e)
        {
            bet.ChangeBet(50, TotalBetLabel);

            AmountMoneyLabel.Text = LoggedInUser.Money.ToString("C");
        }

        private void onehudreddollarbetbutton_Click(object sender, EventArgs e)
        {
            bet.ChangeBet(100, TotalBetLabel);

            AmountMoneyLabel.Text = LoggedInUser.Money.ToString("C");
        }

        private void Dealbutton_Click(object sender, EventArgs e)
        {
            if (bet.Amount > LoggedInUser.Money)
            {
                MessageBox.Show("You don't have enough money to place this bet!");
                return;
            }
            if (bet.Amount == 0)
            {
                MessageBox.Show("You need to place a bet first!");
                return;
            }

            LoggedInUser.UpdateToDataBaseMoney(-bet.Amount);
            AmountMoneyLabel.Text = LoggedInUser.Money.ToString("C");

            InitializeGame();

            HitButton.Visible = true;
            StandButton.Visible = true;

            Dealbutton.Visible = false;

            Clearbetbutton.Visible = false;
            BackToCasinoButton.Visible = false;

            onedollarbetbutton.Visible = false;
            fivedollarbetbutton.Visible = false;
            tendollarbetbutton.Visible = false;
            twofivedollarbetbutton.Visible = false;
            fivezerodollarbetbutton.Visible = false;
            onehudreddollarbetbutton.Visible = false;

            PlayerCardsLabel.Visible = true;
            PlayerValueLabel.Visible = true;
            DealerCardsLabel.Visible = true;
            DealerValueLabel.Visible = true;



            AmountMoneyLabel.Text = LoggedInUser.Money.ToString("C");
            TotalBetLabel.Text = bet.Amount.ToString("C");
        }
        private void ShowBetButtons()
        {
            onedollarbetbutton.Visible = true;
            fivedollarbetbutton.Visible = true;
            tendollarbetbutton.Visible = true;
            twofivedollarbetbutton.Visible = true;
            fivezerodollarbetbutton.Visible = true;
            onehudreddollarbetbutton.Visible = true;

            BackToCasinoButton.Visible = true;
            Clearbetbutton.Visible = true;
        }
        private void DontShowPlayerandDealer()
        {
            PlayerCardsLabel.Visible = false;
            PlayerValueLabel.Visible = false;
            DealerCardsLabel.Visible = false;
            DealerValueLabel.Visible = false;
        }

        private void Clearbetbutton_Click(object sender, EventArgs e)
        {
            bet.Reset();
            TotalBetLabel.Text = "0";
        }

        private void BackToCasinoButton_Click(object sender, EventArgs e)
        {

            Casino_Form form = new Casino_Form();
            form.LoggedInUser = LoggedInUser;
            form.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }

}
