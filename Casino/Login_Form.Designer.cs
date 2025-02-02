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
            components = new System.ComponentModel.Container();

            
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            LoginName_TextBox = new TextBox();
            LoginPassword_TextBox = new TextBox();
            Login_account_button = new Button();
            Create_account_button = new Button();

            SuspendLayout();

            
            this.BackColor = Color.White;
            this.ClientSize = new Size(800, 400);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Name = "Login_Form";
            this.Text = "Casino Login";

            
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(280, 30);
            label1.Text = "💻 Welcome to Casino 🎲";

            
            label2.AutoSize = true;
            label2.Location = new Point(310, 100);
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.ForeColor = Color.Black;
            label2.Text = "Username";

            
            LoginName_TextBox.Location = new Point(310, 125);
            LoginName_TextBox.Size = new Size(180, 30);
            LoginName_TextBox.BorderStyle = BorderStyle.FixedSingle;

            
            label3.AutoSize = true;
            label3.Location = new Point(310, 170);
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label3.ForeColor = Color.Black;
            label3.Text = "Password";

            
            LoginPassword_TextBox.Location = new Point(310, 195);
            LoginPassword_TextBox.Size = new Size(180, 30);
            LoginPassword_TextBox.BorderStyle = BorderStyle.FixedSingle;
            LoginPassword_TextBox.PasswordChar = '*';

            
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

          
            this.Controls.Add(label1);
            this.Controls.Add(label2);
            this.Controls.Add(label3);
            this.Controls.Add(LoginName_TextBox);
            this.Controls.Add(LoginPassword_TextBox);
            this.Controls.Add(Create_account_button);
            this.Controls.Add(Login_account_button);

            ResumeLayout(false);
            PerformLayout();
        }
    }
}