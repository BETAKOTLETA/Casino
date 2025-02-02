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
        private int bet = 50;

        public BlackJack_Form(User loggedInUser)
        {
            InitializeComponent();
            LoggedInUser = loggedInUser;
            InitializeGame();
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
            PlayerValueLabel.Text = string.Join(", ", _playerHand.Select(c => c.ToString()));
            PlayerValueLabel.Text = CalculateHandValue(_playerHand).ToString();

            DealerValueLabel.Text = "Hidden, " + string.Join(", ", _dealerHand.Skip(1).Select(c => c.ToString()));
            DealerValueLabel.Text = CalculateHandValue(_dealerHand.Skip(1).ToList()).ToString();

            AmountMoneyLabel.Text = LoggedInUser.Money.ToString("C");
        }

        private int CalculateHandValue(List<Card> hand)
        {
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
                InitializeGame();
            }
        }

        private void StandButton_Click(object sender, EventArgs e)
        {
            while (CalculateHandValue(_dealerHand) < 17)
            {
                _dealerHand.Add(_deck.DrawCard());
            }

            int playerValue = CalculateHandValue(_playerHand);
            int dealerValue = CalculateHandValue(_dealerHand);

            DealerValueLabel.Text = string.Join(", ", _dealerHand.Select(c => c.ToString()));
            DealerValueLabel.Text = dealerValue.ToString();

            if (dealerValue > 21 || playerValue > dealerValue)
            {
                MessageBox.Show("You win!");
                LoggedInUser.UpdateToDataBaseMoney(bet);
            }
            else
            {
                MessageBox.Show("Dealer wins!");
                LoggedInUser.UpdateToDataBaseMoney(-bet);
            }

            InitializeGame();
        }

        private void BlackJack_Form_Load(object sender, EventArgs e)
        {
            if (LoggedInUser != null)
            {
                AmountMoneyLabel.Text = LoggedInUser.Username;
                AmountMoneyLabel.Text = LoggedInUser.Money.ToString("C");

            }
        }

        private void DealerCardsLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
