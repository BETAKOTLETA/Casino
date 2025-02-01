namespace Casino
{
    partial class Login_Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            Login_account_button = new Button();
            LoginName_TextBox = new TextBox();
            LoginPassword_TextBox = new TextBox();
            Create_account_button = new Button();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(320, 29);
            label1.Name = "label1";
            label1.Size = new Size(110, 15);
            label1.TabIndex = 0;
            label1.Text = "Welcome to Casino";
            // 
            // Login_account_button
            // 
            Login_account_button.Location = new Point(387, 250);
            Login_account_button.Name = "Login_account_button";
            Login_account_button.Size = new Size(75, 23);
            Login_account_button.TabIndex = 1;
            Login_account_button.Text = "Login";
            Login_account_button.UseVisualStyleBackColor = true;
            Login_account_button.Click += Login_account_button_Click;
            // 
            // LoginName_TextBox
            // 
            LoginName_TextBox.Location = new Point(330, 114);
            LoginName_TextBox.Name = "LoginName_TextBox";
            LoginName_TextBox.Size = new Size(100, 23);
            LoginName_TextBox.TabIndex = 2;
            // 
            // LoginPassword_TextBox
            // 
            LoginPassword_TextBox.Location = new Point(330, 187);
            LoginPassword_TextBox.Name = "LoginPassword_TextBox";
            LoginPassword_TextBox.Size = new Size(100, 23);
            LoginPassword_TextBox.TabIndex = 3;
            // 
            // Create_account_button
            // 
            Create_account_button.Location = new Point(282, 250);
            Create_account_button.Name = "Create_account_button";
            Create_account_button.Size = new Size(75, 23);
            Create_account_button.TabIndex = 4;
            Create_account_button.Text = "Create";
            Create_account_button.UseVisualStyleBackColor = true;
            Create_account_button.Click += Create_account_button_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(330, 81);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 5;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(330, 158);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 6;
            label3.Text = "Password";
            // 
            // Login_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Create_account_button);
            Controls.Add(LoginPassword_TextBox);
            Controls.Add(LoginName_TextBox);
            Controls.Add(Login_account_button);
            Controls.Add(label1);
            Name = "Login_Form";
            Text = "Form1";
            Load += Login_Form_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button Login_account_button;
        private TextBox LoginName_TextBox;
        private TextBox LoginPassword_TextBox;
        private Button Create_account_button;
        private Label label2;
        private Label label3;
    }
}
