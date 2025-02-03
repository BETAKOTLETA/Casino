namespace Casino
{
    partial class Login_Form
    {
        private System.ComponentModel.IContainer components = null;
        private Label label1;
        private Button Login_account_button;
        private TextBox LoginName_TextBox;
        private TextBox LoginPassword_TextBox;
        private Button Create_account_button;
        private Label label2;
        private Label label3;

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
            BackColor = Color.White;
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);

            label1 = new Label();
            Login_account_button = new Button();
            LoginName_TextBox = new TextBox();
            LoginPassword_TextBox = new TextBox();
            Create_account_button = new Button();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();

            // Welcome Label
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(280, 30);
            label1.Text = "🎰 Welcome to Casino 🎲";

            // Username Label
            label2.AutoSize = true;
            label2.Location = new Point(310, 100);
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.ForeColor = Color.Black;
            label2.Text = "Username";

            // Username TextBox
            LoginName_TextBox.Location = new Point(310, 125);
            LoginName_TextBox.Size = new Size(180, 30);
            LoginName_TextBox.Font = new Font("Segoe UI", 10F);
            LoginName_TextBox.BackColor = Color.White;
            LoginName_TextBox.ForeColor = Color.Black;
            LoginName_TextBox.BorderStyle = BorderStyle.FixedSingle;

            // Password Label
            label3.AutoSize = true;
            label3.Location = new Point(310, 170);
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label3.ForeColor = Color.Black;
            label3.Text = "Password";

            // Password TextBox
            LoginPassword_TextBox.Location = new Point(310, 195);
            LoginPassword_TextBox.Size = new Size(180, 30);
            LoginPassword_TextBox.Font = new Font("Segoe UI", 10F);
            LoginPassword_TextBox.BackColor = Color.White;
            LoginPassword_TextBox.ForeColor = Color.Black;
            LoginPassword_TextBox.BorderStyle = BorderStyle.FixedSingle;
            LoginPassword_TextBox.PasswordChar = '*';

            // Login Button (Red Theme)
            Login_account_button.Location = new Point(410, 260);
            Login_account_button.Size = new Size(80, 35);
            Login_account_button.Text = "Login";
            Login_account_button.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            Login_account_button.ForeColor = Color.White;
            Login_account_button.BackColor = Color.Red;
            Login_account_button.FlatStyle = FlatStyle.Flat;
            Login_account_button.FlatAppearance.BorderSize = 0;
            Login_account_button.Cursor = Cursors.Hand;
            Login_account_button.Click += Login_account_button_Click;

            // Create Account Button (Black Theme)
            Create_account_button.Location = new Point(310, 260);
            Create_account_button.Size = new Size(80, 35);
            Create_account_button.Text = "Create";
            Create_account_button.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            Create_account_button.ForeColor = Color.White;
            Create_account_button.BackColor = Color.Black;
            Create_account_button.FlatStyle = FlatStyle.Flat;
            Create_account_button.FlatAppearance.BorderSize = 0;
            Create_account_button.Cursor = Cursors.Hand;
            Create_account_button.Click += Create_account_button_Click;

            // Login_Form Settings
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 400);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(LoginName_TextBox);
            Controls.Add(label3);
            Controls.Add(LoginPassword_TextBox);
            Controls.Add(Login_account_button);
            Controls.Add(Create_account_button);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            StartPosition = FormStartPosition.CenterScreen;
            Name = "Login_Form";
            Text = "Casino Login";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
