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
        private readonly string connectionString = "Server=DESKTOP-C7TE4MK;Database=UserApp3;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=true";

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
        public async Task AsyncMoney(int userId, decimal Money)
        {
            if (Money <= 0) throw new InvalidOperationException("Amount must be greater than 0!");

            using (var connection = new SqlConnection(connectionString))
            {
                await connection.OpenAsync();
                string query = "UPDATE Users SET Money = @Money WHERE Id = @Id";

                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Money", Money);
                    command.Parameters.AddWithValue("@Id", userId);

                    await command.ExecuteNonQueryAsync();
                }
            }
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
