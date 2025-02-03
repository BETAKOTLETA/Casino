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
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)rocketPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // betTextBox
            // 
            betTextBox.Location = new Point(-1, 85);
            betTextBox.Margin = new Padding(4, 3, 4, 3);
            betTextBox.Name = "betTextBox";
            betTextBox.Size = new Size(116, 23);
            betTextBox.TabIndex = 0;
            // 
            // betLabel
            // 
            betLabel.AutoSize = true;
            betLabel.Location = new Point(37, 53);
            betLabel.Margin = new Padding(4, 0, 4, 0);
            betLabel.Name = "betLabel";
            betLabel.Size = new Size(24, 15);
            betLabel.TabIndex = 1;
            betLabel.Text = "bet";
            // 
            // startButton
            // 
            startButton.Location = new Point(257, 27);
            startButton.Margin = new Padding(4, 3, 4, 3);
            startButton.Name = "startButton";
            startButton.Size = new Size(88, 27);
            startButton.TabIndex = 2;
            startButton.Text = "Start";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += startButton_Click;
            // 
            // cashOutButton
            // 
            cashOutButton.Enabled = false;
            cashOutButton.Location = new Point(257, 53);
            cashOutButton.Margin = new Padding(4, 3, 4, 3);
            cashOutButton.Name = "cashOutButton";
            cashOutButton.Size = new Size(202, 95);
            cashOutButton.TabIndex = 3;
            cashOutButton.Text = "Take";
            cashOutButton.UseVisualStyleBackColor = true;
            cashOutButton.Click += cashOutButton_Click;
            // 
            // coefficientLabel
            // 
            coefficientLabel.AutoSize = true;
            coefficientLabel.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Bold, GraphicsUnit.Point, 204);
            coefficientLabel.Location = new Point(343, 227);
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
            BackToCasinoButton.Location = new Point(-1, 27);
            BackToCasinoButton.Name = "BackToCasinoButton";
            BackToCasinoButton.Size = new Size(75, 23);
            BackToCasinoButton.TabIndex = 22;
            BackToCasinoButton.Text = "Back";
            BackToCasinoButton.UseVisualStyleBackColor = true;
            BackToCasinoButton.Click += BackToCasinoButton_Click;
            // 
            // AmountMoneyLabel
            // 
            AmountMoneyLabel.AutoSize = true;
            AmountMoneyLabel.Location = new Point(67, 9);
            AmountMoneyLabel.Name = "AmountMoneyLabel";
            AmountMoneyLabel.Size = new Size(116, 15);
            AmountMoneyLabel.TabIndex = 21;
            AmountMoneyLabel.Text = "AmountMoneyLabel";
            // 
            // UserName_label
            // 
            UserName_label.AutoSize = true;
            UserName_label.Location = new Point(-1, 9);
            UserName_label.Name = "UserName_label";
            UserName_label.Size = new Size(62, 15);
            UserName_label.TabIndex = 20;
            UserName_label.Text = "UserName";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(213, 177);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 179);
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // Rocket_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(583, 462);
            Controls.Add(pictureBox1);
            Controls.Add(BackToCasinoButton);
            Controls.Add(AmountMoneyLabel);
            Controls.Add(UserName_label);
            Controls.Add(resultLabel);
            Controls.Add(rocketPictureBox);
            Controls.Add(coefficientLabel);
            Controls.Add(cashOutButton);
            Controls.Add(startButton);
            Controls.Add(betLabel);
            Controls.Add(betTextBox);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Rocket_Form";
            Text = "Cash Or Crash";
            Load += Rocket_Form_Load;
            ((System.ComponentModel.ISupportInitialize)rocketPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private PictureBox pictureBox1;
    }
}