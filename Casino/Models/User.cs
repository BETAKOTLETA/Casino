using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public decimal Money { get; set; }
        public bool IsAdmin { get; set; }
        private readonly string connectionString = "Server=tcp:servernotcool.database.windows.net,1433;Initial Catalog=Databasecool;Persist Security Info=False;User ID=Adminviktor;Password=c1c224b03cd9bc7b6a86d77f5dace40191766c485cd55dc48caf9ac873335d6f_;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";



        public User(int id, string username, decimal money, bool isAdmin = false)
        {
            Id = id;
            Username = username;
            Money = money;
            IsAdmin = isAdmin;
        }
        public void UpdateToDataBaseMoney(decimal amount)
        {
            Money += amount;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE Users SET Money = @Money WHERE Username = @Username";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Money", Money);
                    command.Parameters.AddWithValue("@Username", Username);
                    command.ExecuteNonQuery();
                }
            }
        }
        public async Task AsyncMoney(int userId, Label TotalBetLabelAmountMoneyLabel)
        {
            decimal money = 0;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                await connection.OpenAsync();
                string query = "SELECT Money FROM Users WHERE Id = @UserId";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserId", userId);

                    var result = await command.ExecuteScalarAsync();

                    if (result != null)
                    {
                        money = Convert.ToDecimal(result);
                    }
                }
            }

            TotalBetLabelAmountMoneyLabel.Text = money.ToString("C");
        }
    }
    public class Bet
    {
        private const decimal MinBet = 0;
        private const decimal MaxBet = 100000;
        public decimal Amount { get; private set; }
        private User _user;

        public Bet(decimal amount, User user)
        {
            if (amount < MinBet || amount > MaxBet)
                throw new ArgumentOutOfRangeException(nameof(amount), $"Bet must be between {MinBet} and {MaxBet}.");
            Amount = amount;
            _user = user;
        }

        public void ChangeBet(decimal value, Label totalBetLabel)
        {
            decimal newAmount = Amount + value;
            if (newAmount > _user.Money)
            {
                MessageBox.Show($"not enough money");
            }
            if (newAmount > MaxBet)
            {
                MessageBox.Show($"Maximum bet is {MaxBet}.");
                newAmount = MaxBet;
            }
            else if (newAmount < MinBet)
            {
                newAmount = MinBet;
            }
            Amount = newAmount;
            totalBetLabel.Text = Amount.ToString("C");
        }

        public void Reset()
        {
            Amount = 0;
        }
        internal void SetAmount(decimal amount)
        {
            Amount = amount;
        }
    }
    public class Game
    {
        public void WinBet(Bet bet, User user)
        {
            decimal payout = bet.Amount * 2;
            user.UpdateToDataBaseMoney(payout);
            bet.SetAmount(0); 
        }
        public void LoseBet(Bet bet, User user)
        {
            bet.SetAmount(0);
        }
    }
    

    public class Card
    {
        public string Suit { get; set; }
        public string Rank { get; set; }
        public int Value { get; set; }

        public Card(string suit, string rank, int value)
        {
            Suit = suit;
            Rank = rank;
            Value = value;
        }

        public override string ToString()
        {
            return $"{Rank} of {Suit}";
        }
    }

    public class Deck
    {
        public List<Card> Cards { get; private set; }

        public Deck()
        {
            InitializeDeck();
            Shuffle();
        }

        private void InitializeDeck()
        {
            Cards = new List<Card>();
            string[] suits = { "Hearts", "Diamonds", "Clubs", "Spades" };
            string[] ranks = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace" };

            foreach (var suit in suits)
            {
                for (int i = 0; i < ranks.Length; i++)
                {
                    int value = (i >= 9) ? 10 : i + 2; 
                    if (ranks[i] == "Ace") value = 11;
                    Cards.Add(new Card(suit, ranks[i], value));
                }
            }
        }

        public void Shuffle()
        {
            Random rng = new Random();
            Cards = Cards.OrderBy(c => rng.Next()).ToList();
        }

        public Card DrawCard()
        {
            if (Cards.Count == 0) throw new InvalidOperationException("Deck is empty!");
            Card drawnCard = Cards[0];
            Cards.RemoveAt(0);
            return drawnCard;
        }
    }
}
