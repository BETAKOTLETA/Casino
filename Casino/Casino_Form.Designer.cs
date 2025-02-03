namespace Casino
{
    partial class Casino_Form
    {
        private System.ComponentModel.IContainer components = null;

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
            ToBlackJackbutton = new Button();
            Rocket = new Button();
            button3 = new Button();
            UserName_label = new Label();
            AmountMoneyLabel = new Label();
            button1 = new Button();
            RouletteButton = new Button();
            SuspendLayout();
            // 
            // ToBlackJackbutton
            // 
            ToBlackJackbutton.BackColor = Color.Red;
            ToBlackJackbutton.FlatAppearance.BorderSize = 0;
            ToBlackJackbutton.FlatStyle = FlatStyle.Flat;
            ToBlackJackbutton.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            ToBlackJackbutton.ForeColor = Color.White;
            ToBlackJackbutton.Location = new Point(100, 100);
            ToBlackJackbutton.Name = "ToBlackJackbutton";
            ToBlackJackbutton.Size = new Size(200, 50);
            ToBlackJackbutton.TabIndex = 0;
            ToBlackJackbutton.Text = "♠️ ♥️ BlackJack";
            ToBlackJackbutton.UseVisualStyleBackColor = false;
            ToBlackJackbutton.Click += ToBlackJackbutton_Click;
            // 
            // Rocket
            // 
            Rocket.BackColor = Color.Black;
            Rocket.FlatAppearance.BorderSize = 0;
            Rocket.FlatStyle = FlatStyle.Flat;
            Rocket.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            Rocket.ForeColor = Color.White;
            Rocket.Location = new Point(100, 170);
            Rocket.Name = "Rocket";
            Rocket.Size = new Size(200, 50);
            Rocket.TabIndex = 1;
            Rocket.Text = "🚀 Rocket";
            Rocket.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Black;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button3.ForeColor = Color.White;
            button3.Location = new Point(350, 100);
            button3.Name = "button3";
            button3.Size = new Size(200, 50);
            button3.TabIndex = 2;
            button3.Text = "🎰 Slots (Coming Soon)";
            button3.UseVisualStyleBackColor = false;
            // 
            // UserName_label
            // 
            UserName_label.AutoSize = true;
            UserName_label.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            UserName_label.ForeColor = Color.Black;
            UserName_label.Location = new Point(20, 15);
            UserName_label.Name = "UserName_label";
            UserName_label.Size = new Size(146, 19);
            UserName_label.TabIndex = 3;

            // 
            // AmountMoneyLabel
            // 
            AmountMoneyLabel.AutoSize = true;
            AmountMoneyLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            AmountMoneyLabel.ForeColor = Color.Black;
            AmountMoneyLabel.Location = new Point(140, 15);
            AmountMoneyLabel.Name = "AmountMoneyLabel";
            AmountMoneyLabel.Size = new Size(113, 19);
            AmountMoneyLabel.TabIndex = 4;

            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(225, 250);
            button1.Name = "button1";
            button1.Size = new Size(200, 50);
            button1.TabIndex = 5;
            button1.Text = "Exit";
            button1.UseVisualStyleBackColor = false;
            // 
            // RouletteButton
            // 
            RouletteButton.BackColor = Color.Black;
            RouletteButton.FlatAppearance.BorderSize = 0;
            RouletteButton.FlatStyle = FlatStyle.Flat;
            RouletteButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            RouletteButton.ForeColor = Color.White;
            RouletteButton.Location = new Point(350, 170);
            RouletteButton.Name = "RouletteButton";
            RouletteButton.Size = new Size(200, 50);
            RouletteButton.TabIndex = 6;
            RouletteButton.Text = "🎲 Roulette (Coming Soon)";
            RouletteButton.UseVisualStyleBackColor = false;
            // 
            // Casino_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(RouletteButton);
            Controls.Add(AmountMoneyLabel);
            Controls.Add(UserName_label);
            Controls.Add(button3);
            Controls.Add(Rocket);
            Controls.Add(ToBlackJackbutton);
            Font = new Font("Segoe UI", 10F);
            Name = "Casino_Form";
            Text = "🎰 Casino Games 🎲";
            Load += Casino_Form_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private Button ToBlackJackbutton;
        private Button Rocket;
        private Button button3;
        private Button RouletteButton;
        private Label UserName_label;
        private Label AmountMoneyLabel;
        private Button button1;
    }
}
