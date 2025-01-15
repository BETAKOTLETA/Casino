using MySql.Data.MySqlClient;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Security.Cryptography;

namespace Casino
{
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }

        private void Login_Form_Load(object sender, EventArgs e)
        {
            string connectionString = "Server=IP;Database=casinodatabase;User ID=root;Password=123123;";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    MessageBox.Show("Connection to server established.");

                    string createTableQuery = @"
                    CREATE TABLE IF NOT EXISTS Users (
                        Id INT AUTO_INCREMENT PRIMARY KEY,
                        Username VARCHAR(255) NOT NULL,
                        PasswordHash VARCHAR(255) NOT NULL
                    );";
                    using (MySqlCommand command = new MySqlCommand(createTableQuery, connection))
                    {
                        command.ExecuteNonQuery();
                        MessageBox.Show("Table Users created or already exists.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection error: " + ex.Message);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Create_account_button_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=IP;Database=casinodatabase;User ID=root;Password=123123;";

            string userName = LoginName_TextBox.Text;
            string userPassword = HashPassword(LoginPassword_TextBox.Text);

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "INSERT INTO Users (Username, PasswordHash) VALUES (@Username, @PasswordHash)";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", userName);
                        command.Parameters.AddWithValue("@PasswordHash", userPassword);
                        command.Parameters.AddWithValue("@Money", 2000);

                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Account created successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }
        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return Convert.ToBase64String(hashBytes);
            }
        }

        private void Login_account_button_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Database=casinodatabase;User ID=root;Password=123123;";
            string userName = LoginName_TextBox.Text;
            string userPassword = HashPassword(LoginPassword_TextBox.Text);
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT COUNT(*) FROM Users WHERE UserName = @UserName AND PasswordHash = @PasswordHash";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserName", userName);
                        command.Parameters.AddWithValue("@PasswordHash", userPassword);

                        int userCount = Convert.ToInt32(command.ExecuteScalar());

                        if (userCount > 0)
                        {
                            MessageBox.Show("Login successful!");
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


    }
}
