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
            ToRocketkbutton = new Button();
            ToSlotskbutton = new Button();
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
            // ToRocketkbutton
            // 
            ToRocketkbutton.BackColor = Color.Black;
            ToRocketkbutton.FlatAppearance.BorderSize = 0;
            ToRocketkbutton.FlatStyle = FlatStyle.Flat;
            ToRocketkbutton.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            ToRocketkbutton.ForeColor = Color.White;
            ToRocketkbutton.Location = new Point(100, 170);
            ToRocketkbutton.Name = "ToRocketkbutton";
            ToRocketkbutton.Size = new Size(200, 50);
            ToRocketkbutton.TabIndex = 1;
            ToRocketkbutton.Text = "🚀 Cash Or Crash";
            ToRocketkbutton.UseVisualStyleBackColor = false;
            ToRocketkbutton.MouseClick += ToRocketkbutton_MouseClick;
            // 
            // ToSlotskbutton
            // 
            ToSlotskbutton.BackColor = Color.Black;
            ToSlotskbutton.FlatAppearance.BorderSize = 0;
            ToSlotskbutton.FlatStyle = FlatStyle.Flat;
            ToSlotskbutton.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            ToSlotskbutton.ForeColor = Color.White;
            ToSlotskbutton.Location = new Point(350, 100);
            ToSlotskbutton.Name = "ToSlotskbutton";
            ToSlotskbutton.Size = new Size(200, 50);
            ToSlotskbutton.TabIndex = 2;
            ToSlotskbutton.Text = "🎰 Slots";
            ToSlotskbutton.UseVisualStyleBackColor = false;
            ToSlotskbutton.Click += ToSlotskbutton_Click;
            // 
            // UserName_label
            // 
            UserName_label.AutoSize = true;
            UserName_label.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            UserName_label.ForeColor = Color.Black;
            UserName_label.Location = new Point(20, 15);
            UserName_label.Name = "UserName_label";
            UserName_label.Size = new Size(0, 19);
            UserName_label.TabIndex = 3;
            // 
            // AmountMoneyLabel
            // 
            AmountMoneyLabel.AutoSize = true;
            AmountMoneyLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            AmountMoneyLabel.ForeColor = Color.Black;
            AmountMoneyLabel.Location = new Point(140, 15);
            AmountMoneyLabel.Name = "AmountMoneyLabel";
            AmountMoneyLabel.Size = new Size(0, 19);
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
            button1.Text = "Log out";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // RouletteButton
            // 
            RouletteButton.BackColor = Color.Red;
            RouletteButton.FlatAppearance.BorderSize = 0;
            RouletteButton.FlatStyle = FlatStyle.Flat;
            RouletteButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            RouletteButton.ForeColor = Color.White;
            RouletteButton.Location = new Point(350, 170);
            RouletteButton.Name = "RouletteButton";
            RouletteButton.Size = new Size(200, 50);
            RouletteButton.TabIndex = 6;
            RouletteButton.Text = "Chat ( Comming soon)";
            RouletteButton.UseVisualStyleBackColor = false;
            RouletteButton.Click += RouletteButton_Click;
            // 
            // Casino_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(665, 430);
            Controls.Add(button1);
            Controls.Add(RouletteButton);
            Controls.Add(AmountMoneyLabel);
            Controls.Add(UserName_label);
            Controls.Add(ToSlotskbutton);
            Controls.Add(ToRocketkbutton);
            Controls.Add(ToBlackJackbutton);
            Font = new Font("Segoe UI", 10F);
            Name = "Casino_Form";
            Text = "🎰 Casino Games 🎲";
            Load += Casino_Form_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private Button ToBlackJackbutton;
        private Button ToRocketkbutton;
        private Button ToSlotskbutton;
        private Button RouletteButton;
        private Label UserName_label;
        private Label AmountMoneyLabel;
        private Button button1;
    }
}
