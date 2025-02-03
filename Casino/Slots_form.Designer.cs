namespace Casino
{
    partial class Slots_Form
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
            lblBet = new Label();
            pbSlot1 = new Label();
            pbSlot2 = new Label();
            pbSlot3 = new Label();
            pbSlot4 = new Label();
            pbSlot5 = new Label();
            pbSlot6 = new Label();
            nudBet = new NumericUpDown();
            btnSpin = new Button();
            BackToCasinoButton = new Button();
            AmountMoneyLabel = new Label();
            UserName_label = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)nudBet).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // lblBet
            // 
            lblBet.ForeColor = Color.Black;
            lblBet.Location = new Point(33, 80);
            lblBet.Name = "lblBet";
            lblBet.Size = new Size(97, 23);
            lblBet.TabIndex = 16;
            lblBet.Text = "PlayerCardsLabel";
            // 
            // pbSlot1
            // 
            pbSlot1.Location = new Point(21, 23);
            pbSlot1.Name = "pbSlot1";
            pbSlot1.Size = new Size(235, 220);
            pbSlot1.TabIndex = 17;
            pbSlot1.Text = "1";
            // 
            // pbSlot2
            // 
            pbSlot2.Location = new Point(262, 23);
            pbSlot2.Name = "pbSlot2";
            pbSlot2.Size = new Size(240, 220);
            pbSlot2.TabIndex = 18;
            pbSlot2.Text = "2";
            pbSlot2.Click += pbSlot2_Click;
            // 
            // pbSlot3
            // 
            pbSlot3.Location = new Point(508, 23);
            pbSlot3.Name = "pbSlot3";
            pbSlot3.Size = new Size(225, 220);
            pbSlot3.TabIndex = 19;
            pbSlot3.Text = "3";
            pbSlot3.Click += pbSlot3_Click;
            // 
            // pbSlot4
            // 
            pbSlot4.Location = new Point(739, 23);
            pbSlot4.Name = "pbSlot4";
            pbSlot4.Size = new Size(227, 220);
            pbSlot4.TabIndex = 20;
            pbSlot4.Text = "4";
            pbSlot4.Click += pbSlot4_Click;
            // 
            // pbSlot5
            // 
            pbSlot5.Location = new Point(972, 23);
            pbSlot5.Name = "pbSlot5";
            pbSlot5.Size = new Size(216, 220);
            pbSlot5.TabIndex = 21;
            pbSlot5.Text = "5";
            // 
            // pbSlot6
            // 
            pbSlot6.Location = new Point(1194, 23);
            pbSlot6.Name = "pbSlot6";
            pbSlot6.Size = new Size(226, 220);
            pbSlot6.TabIndex = 22;
            pbSlot6.Text = "6";
            pbSlot6.Click += pbSlot6_Click;
            // 
            // nudBet
            // 
            nudBet.Location = new Point(33, 36);
            nudBet.Name = "nudBet";
            nudBet.Size = new Size(103, 27);
            nudBet.TabIndex = 25;
            // 
            // btnSpin
            // 
            btnSpin.BackColor = Color.Black;
            btnSpin.DialogResult = DialogResult.Yes;
            btnSpin.FlatStyle = FlatStyle.Flat;
            btnSpin.ForeColor = Color.White;
            btnSpin.Location = new Point(175, 36);
            btnSpin.Name = "btnSpin";
            btnSpin.Size = new Size(103, 59);
            btnSpin.TabIndex = 26;
            btnSpin.Text = "Spin";
            btnSpin.UseVisualStyleBackColor = false;
            btnSpin.Click += btnSpin_Click;
            // 
            // BackToCasinoButton
            // 
            BackToCasinoButton.BackColor = Color.Red;
            BackToCasinoButton.FlatStyle = FlatStyle.Flat;
            BackToCasinoButton.ForeColor = Color.White;
            BackToCasinoButton.Location = new Point(21, 32);
            BackToCasinoButton.Name = "BackToCasinoButton";
            BackToCasinoButton.Size = new Size(84, 31);
            BackToCasinoButton.TabIndex = 29;
            BackToCasinoButton.Text = "Back";
            BackToCasinoButton.UseVisualStyleBackColor = false;
            BackToCasinoButton.Click += BackToCasinoButton_Click;
            // 
            // AmountMoneyLabel
            // 
            AmountMoneyLabel.AutoSize = true;
            AmountMoneyLabel.ForeColor = Color.Black;
            AmountMoneyLabel.Location = new Point(232, 37);
            AmountMoneyLabel.Name = "AmountMoneyLabel";
            AmountMoneyLabel.Size = new Size(152, 20);
            AmountMoneyLabel.TabIndex = 28;
            AmountMoneyLabel.Text = "AmountMoneyLabel";
            // 
            // UserName_label
            // 
            UserName_label.AutoSize = true;
            UserName_label.ForeColor = Color.Black;
            UserName_label.Location = new Point(126, 37);
            UserName_label.Name = "UserName_label";
            UserName_label.Size = new Size(83, 20);
            UserName_label.TabIndex = 27;
            UserName_label.Text = "UserName";
            //UserName_label.Click += UserName_label_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(BackToCasinoButton);
            groupBox1.Controls.Add(UserName_label);
            groupBox1.Controls.Add(AmountMoneyLabel);
            groupBox1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            groupBox1.ForeColor = Color.Red;
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(465, 95);
            groupBox1.TabIndex = 30;
            groupBox1.TabStop = false;
            groupBox1.Text = "Player Info";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblBet);
            groupBox2.Controls.Add(nudBet);
            groupBox2.Controls.Add(btnSpin);
            groupBox2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            groupBox2.ForeColor = Color.Red;
            groupBox2.Location = new Point(12, 413);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(443, 129);
            groupBox2.TabIndex = 16;
            groupBox2.TabStop = false;
            groupBox2.Text = "Bet Controls";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(pbSlot1);
            groupBox3.Controls.Add(pbSlot2);
            groupBox3.Controls.Add(pbSlot3);
            groupBox3.Controls.Add(pbSlot4);
            groupBox3.Controls.Add(pbSlot5);
            groupBox3.Controls.Add(pbSlot6);
            groupBox3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            groupBox3.ForeColor = Color.Red;
            groupBox3.Location = new Point(12, 135);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1450, 262);
            groupBox3.TabIndex = 16;
            groupBox3.TabStop = false;
            groupBox3.Text = "Game Area";
            // 
            // Slots_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1501, 564);
            Controls.Add(groupBox2);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Name = "Slots_Form";
            Text = "Slots_Form";
            Load += Slots_Form_Load;
            ((System.ComponentModel.ISupportInitialize)nudBet).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Label lblBet;
        private Label pbSlot1;
        private Label pbSlot2;
        private Label pbSlot3;
        private Label pbSlot4;
        private Label pbSlot5;
        private Label pbSlot6;
        private Button btnSpin;
        private NumericUpDown nudBet;
        private Button BackToCasinoButton;
        private Label AmountMoneyLabel;
        private Label UserName_label;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
    }
}