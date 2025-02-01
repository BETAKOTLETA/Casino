using System;
using Microsoft.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Casino
{
    public partial class Login_Form : Form
    {
        private readonly string connectionString = "Server=DESKTOP-C7TE4MK;Database=UserApp3;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=true";

        public Login_Form()
        {
            InitializeComponent();
        }

        private void Login_Form_Load(object sender, EventArgs e)
        {
<<<<<<< HEAD
=======
            string connectionString = "Server=IP;Database=casinodatabase;User ID=root;Password=123123;";

>>>>>>> 565f671068e87606d3ea1621207ddeaebe8a92e3
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    MessageBox.Show("Connection to SQL Server established.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection error: " + ex.Message);
            }
        }

        private void Create_account_button_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            string userName = LoginName_TextBox.Text.Trim();
            string userPassword = LoginPassword_TextBox.Text.Trim();
=======
            string connectionString = "Server=IP;Database=casinodatabase;User ID=root;Password=123123;";
>>>>>>> 565f671068e87606d3ea1621207ddeaebe8a92e3

            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(userPassword))
            {
                MessageBox.Show("Please enter a username and password.");
                return;
            }

            string hashedPassword = HashPassword(userPassword);

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "INSERT INTO Users (UserName, PasswordHash, Money) VALUES (@UserName, @PasswordHash, @Money)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.Add(new SqlParameter("@UserName", System.Data.SqlDbType.NVarChar, 50)).Value = userName;
                        command.Parameters.Add(new SqlParameter("@PasswordHash", System.Data.SqlDbType.NVarChar, 256)).Value = hashedPassword;
                        command.Parameters.Add(new SqlParameter("@Money", System.Data.SqlDbType.Int)).Value = 2000;

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Account created successfully!");
                        }
                        else
                        {
                            MessageBox.Show("Failed to create account. Try again.");
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627) // Unique constraint violation
                {
                    MessageBox.Show("Username already exists. Please choose a different one.");
                }
                else
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void Login_account_button_Click(object sender, EventArgs e)
        {
            string userName = LoginName_TextBox.Text.Trim();
            string userPassword = LoginPassword_TextBox.Text.Trim();

            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(userPassword))
            {
                MessageBox.Show("Please enter your username and password.");
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string sqlQuery = "SELECT PasswordHash FROM Users WHERE UserName = @UserName";

                    using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                    {
                        command.Parameters.Add(new SqlParameter("@UserName", System.Data.SqlDbType.NVarChar, 50)).Value = userName;

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string storedHash = reader["PasswordHash"].ToString();

                                if (VerifyPassword(storedHash, userPassword))
                                {
                                    MessageBox.Show("Login Successful!");

                                    Casino_Form form = new Casino_Form();
                                    form.Show();
                                    this.Hide();
                                }
                                else
                                {
                                    MessageBox.Show("Invalid password.");
                                }
                            }
                            else
                            {
                                MessageBox.Show("User not found.");
                            }
                        }
                    }
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
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        private bool VerifyPassword(string storedHash, string inputPassword)
        {
            string inputHash = HashPassword(inputPassword);
            return storedHash.Equals(inputHash, StringComparison.OrdinalIgnoreCase);
        }
    }
}
