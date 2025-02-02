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
            titleLabel = new Label();
            UserName_label = new Label();
            AmountMoneyLabel = new Label();
            ToBlackJackbutton = new Button();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            titleLabel.ForeColor = Color.Black;
            titleLabel.Location = new Point(300, 20);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(23, 30);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "s";
            // 
            // UserName_label
            // 
            UserName_label.AutoSize = true;
            UserName_label.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            UserName_label.ForeColor = Color.Black;
            UserName_label.Location = new Point(20, 20);
            UserName_label.Name = "UserName_label";
            UserName_label.Size = new Size(15, 19);
            UserName_label.TabIndex = 1;
            UserName_label.Text = "s";
            // 
            // AmountMoneyLabel
            // 
            AmountMoneyLabel.AutoSize = true;
            AmountMoneyLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            AmountMoneyLabel.ForeColor = Color.Black;
            AmountMoneyLabel.Location = new Point(20, 50);
            AmountMoneyLabel.Name = "AmountMoneyLabel";
            AmountMoneyLabel.Size = new Size(17, 21);
            AmountMoneyLabel.TabIndex = 2;
            AmountMoneyLabel.Text = "s";
            // 
            // ToBlackJackbutton
            // 
            ToBlackJackbutton.BackColor = Color.Red;
            ToBlackJackbutton.Cursor = Cursors.Hand;
            ToBlackJackbutton.FlatAppearance.BorderSize = 0;
            ToBlackJackbutton.FlatStyle = FlatStyle.Flat;
            ToBlackJackbutton.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            ToBlackJackbutton.ForeColor = Color.White;
            ToBlackJackbutton.Location = new Point(100, 150);
            ToBlackJackbutton.Name = "ToBlackJackbutton";
            ToBlackJackbutton.Size = new Size(180, 40);
            ToBlackJackbutton.TabIndex = 3;
            ToBlackJackbutton.Text = "s";
            ToBlackJackbutton.UseVisualStyleBackColor = false;
            ToBlackJackbutton.Click += button1_Click;
            // 
            // Casino_Form
            // 
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(titleLabel);
            Controls.Add(UserName_label);
            Controls.Add(AmountMoneyLabel);
            Controls.Add(ToBlackJackbutton);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Casino_Form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Casino";
            Load += Casino_Form_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private Button ToBlackJackbutton;
        private Button button2;
        private Button button3;
        private Label UserName_label;
        private Label AmountMoneyLabel;
        private Label titleLabel;
    }
}