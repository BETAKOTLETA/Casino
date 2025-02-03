namespace Casino
{
    partial class Rocket_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            betTextBox = new TextBox();
            betLabel = new Label();
            startButton = new Button();
            cashOutButton = new Button();
            coefficientLabel = new Label();
            rocketPictureBox = new PictureBox();
            gameTimer = new System.Windows.Forms.Timer(components);
            resultLabel = new Label();
            BackToCasinoButton = new Button();
            AmountMoneyLabel = new Label();
            UserName_label = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)rocketPictureBox).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // betTextBox
            // 
            betTextBox.Location = new Point(120, 39);
            betTextBox.Margin = new Padding(4, 3, 4, 3);
            betTextBox.Name = "betTextBox";
            betTextBox.Size = new Size(116, 27);
            betTextBox.TabIndex = 0;
            // 
            // betLabel
            // 
            betLabel.AutoSize = true;
            betLabel.Location = new Point(17, 42);
            betLabel.Margin = new Padding(4, 0, 4, 0);
            betLabel.Name = "betLabel";
            betLabel.Size = new Size(32, 20);
            betLabel.TabIndex = 1;
            betLabel.Text = "bet";
            // 
            // startButton
            // 
            startButton.BackColor = Color.Black;
            startButton.FlatStyle = FlatStyle.Flat;
            startButton.ForeColor = Color.White;
            startButton.Location = new Point(11, 93);
            startButton.Margin = new Padding(4, 3, 4, 3);
            startButton.Name = "startButton";
            startButton.Size = new Size(88, 33);
            startButton.TabIndex = 2;
            startButton.Text = "Start";
            startButton.UseVisualStyleBackColor = false;
            startButton.Click += startButton_Click;
            // 
            // cashOutButton
            // 
            cashOutButton.BackColor = Color.Black;
            cashOutButton.Enabled = false;
            cashOutButton.FlatStyle = FlatStyle.Flat;
            cashOutButton.ForeColor = Color.White;
            cashOutButton.Location = new Point(132, 93);
            cashOutButton.Margin = new Padding(4, 3, 4, 3);
            cashOutButton.Name = "cashOutButton";
            cashOutButton.Size = new Size(88, 33);
            cashOutButton.TabIndex = 3;
            cashOutButton.Text = "Take";
            cashOutButton.UseVisualStyleBackColor = false;
            cashOutButton.Click += cashOutButton_Click;
            // 
            // coefficientLabel
            // 
            coefficientLabel.AutoSize = true;
            coefficientLabel.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Bold, GraphicsUnit.Point, 204);
            coefficientLabel.Location = new Point(57, 101);
            coefficientLabel.Margin = new Padding(4, 0, 4, 0);
            coefficientLabel.Name = "coefficientLabel";
            coefficientLabel.Size = new Size(85, 31);
            coefficientLabel.TabIndex = 4;
            coefficientLabel.Text = "1.00x";
            coefficientLabel.Click += coefficientLabel_Click;
            // 
            // rocketPictureBox
            // 
            rocketPictureBox.Location = new Point(-1, 458);
            rocketPictureBox.Margin = new Padding(4, 3, 4, 3);
            rocketPictureBox.Name = "rocketPictureBox";
            rocketPictureBox.Size = new Size(10, 10);
            rocketPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            rocketPictureBox.TabIndex = 5;
            rocketPictureBox.TabStop = false;
            // 
            // resultLabel
            // 
            resultLabel.AutoSize = true;
            resultLabel.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, 204);
            resultLabel.Location = new Point(23, 404);
            resultLabel.Margin = new Padding(4, 0, 4, 0);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(0, 25);
            resultLabel.TabIndex = 6;
            // 
            // BackToCasinoButton
            // 
            BackToCasinoButton.BackColor = Color.Red;
            BackToCasinoButton.FlatStyle = FlatStyle.Flat;
            BackToCasinoButton.ForeColor = Color.White;
            BackToCasinoButton.Location = new Point(11, 26);
            BackToCasinoButton.Name = "BackToCasinoButton";
            BackToCasinoButton.Size = new Size(75, 32);
            BackToCasinoButton.TabIndex = 22;
            BackToCasinoButton.Text = "Back";
            BackToCasinoButton.UseVisualStyleBackColor = false;
            BackToCasinoButton.Click += BackToCasinoButton_Click;
            // 
            // AmountMoneyLabel
            // 
            AmountMoneyLabel.AutoSize = true;
            AmountMoneyLabel.ForeColor = Color.Black;
            AmountMoneyLabel.Location = new Point(120, 78);
            AmountMoneyLabel.Name = "AmountMoneyLabel";
            AmountMoneyLabel.Size = new Size(152, 20);
            AmountMoneyLabel.TabIndex = 21;
            AmountMoneyLabel.Text = "AmountMoneyLabel";
            // 
            // UserName_label
            // 
            UserName_label.AutoSize = true;
            UserName_label.ForeColor = Color.Black;
            UserName_label.Location = new Point(11, 78);
            UserName_label.Name = "UserName_label";
            UserName_label.Size = new Size(83, 20);
            UserName_label.TabIndex = 20;
            UserName_label.Text = "UserName";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(UserName_label);
            groupBox1.Controls.Add(BackToCasinoButton);
            groupBox1.Controls.Add(AmountMoneyLabel);
            groupBox1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            groupBox1.ForeColor = Color.Red;
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(299, 120);
            groupBox1.TabIndex = 24;
            groupBox1.TabStop = false;
            groupBox1.Text = "Player Info";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(coefficientLabel);
            groupBox2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            groupBox2.Location = new Point(353, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 393);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Game Area";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(betTextBox);
            groupBox3.Controls.Add(betLabel);
            groupBox3.Controls.Add(cashOutButton);
            groupBox3.Controls.Add(startButton);
            groupBox3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            groupBox3.ForeColor = Color.Red;
            groupBox3.Location = new Point(12, 138);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(299, 267);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Bets Control";
            // 
            // Rocket_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(583, 462);
            Controls.Add(groupBox2);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Controls.Add(resultLabel);
            Controls.Add(rocketPictureBox);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Rocket_Form";
            Text = "Cash Or Crash";
            Load += Rocket_Form_Load;
            ((System.ComponentModel.ISupportInitialize)rocketPictureBox).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox betTextBox;
        private System.Windows.Forms.Label betLabel;
        public System.Windows.Forms.Button startButton;
        public System.Windows.Forms.Button cashOutButton;
        private System.Windows.Forms.Label coefficientLabel;
        private System.Windows.Forms.PictureBox rocketPictureBox;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label resultLabel;
        public Button BackToCasinoButton;
        private Label AmountMoneyLabel;
        private Label UserName_label;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
    }
}