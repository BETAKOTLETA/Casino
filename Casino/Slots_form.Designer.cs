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
            ((System.ComponentModel.ISupportInitialize)nudBet).BeginInit();
            SuspendLayout();
            // 
            // lblBet
            // 
            lblBet.Location = new Point(1167, 442);
            lblBet.Name = "lblBet";
            lblBet.Size = new Size(97, 15);
            lblBet.TabIndex = 16;
            lblBet.Text = "PlayerCardsLabel";
            // 
            // pbSlot1
            // 
            pbSlot1.Location = new Point(12, 53);
            pbSlot1.Name = "pbSlot1";
            pbSlot1.Size = new Size(250, 250);
            pbSlot1.TabIndex = 17;
            pbSlot1.Text = "1";
            // 
            // pbSlot2
            // 
            pbSlot2.Location = new Point(241, 53);
            pbSlot2.Name = "pbSlot2";
            pbSlot2.Size = new Size(250, 250);
            pbSlot2.TabIndex = 18;
            pbSlot2.Text = "2";
            pbSlot2.Click += pbSlot2_Click;
            // 
            // pbSlot3
            // 
            pbSlot3.Location = new Point(482, 53);
            pbSlot3.Name = "pbSlot3";
            pbSlot3.Size = new Size(250, 250);
            pbSlot3.TabIndex = 19;
            pbSlot3.Text = "3";
            pbSlot3.Click += pbSlot3_Click;
            // 
            // pbSlot4
            // 
            pbSlot4.Location = new Point(685, 53);
            pbSlot4.Name = "pbSlot4";
            pbSlot4.Size = new Size(250, 250);
            pbSlot4.TabIndex = 20;
            pbSlot4.Text = "4";
            pbSlot4.Click += pbSlot4_Click;
            // 
            // pbSlot5
            // 
            pbSlot5.Location = new Point(919, 53);
            pbSlot5.Name = "pbSlot5";
            pbSlot5.Size = new Size(250, 250);
            pbSlot5.TabIndex = 21;
            pbSlot5.Text = "5";
            // 
            // pbSlot6
            // 
            pbSlot6.Location = new Point(1175, 53);
            pbSlot6.Name = "pbSlot6";
            pbSlot6.Size = new Size(250, 250);
            pbSlot6.TabIndex = 22;
            pbSlot6.Text = "6";
            pbSlot6.Click += pbSlot6_Click;
            // 
            // nudBet
            // 
            nudBet.Location = new Point(1167, 473);
            nudBet.Name = "nudBet";
            nudBet.Size = new Size(103, 23);
            nudBet.TabIndex = 25;
            // 
            // btnSpin
            // 
            btnSpin.DialogResult = DialogResult.Yes;
            btnSpin.Location = new Point(1167, 502);
            btnSpin.Name = "btnSpin";
            btnSpin.Size = new Size(103, 59);
            btnSpin.TabIndex = 26;
            btnSpin.Text = "Spin";
            btnSpin.UseVisualStyleBackColor = true;
            btnSpin.Click += btnSpin_Click;
            // 
            // BackToCasinoButton
            // 
            BackToCasinoButton.Location = new Point(12, 27);
            BackToCasinoButton.Name = "BackToCasinoButton";
            BackToCasinoButton.Size = new Size(75, 23);
            BackToCasinoButton.TabIndex = 29;
            BackToCasinoButton.Text = "Back";
            BackToCasinoButton.UseVisualStyleBackColor = true;
            BackToCasinoButton.Click += BackToCasinoButton_Click;
            // 
            // AmountMoneyLabel
            // 
            AmountMoneyLabel.AutoSize = true;
            AmountMoneyLabel.Location = new Point(80, 9);
            AmountMoneyLabel.Name = "AmountMoneyLabel";
            AmountMoneyLabel.Size = new Size(116, 15);
            AmountMoneyLabel.TabIndex = 28;
            AmountMoneyLabel.Text = "AmountMoneyLabel";
            // 
            // UserName_label
            // 
            UserName_label.AutoSize = true;
            UserName_label.Location = new Point(12, 9);
            UserName_label.Name = "UserName_label";
            UserName_label.Size = new Size(62, 15);
            UserName_label.TabIndex = 27;
            UserName_label.Text = "UserName";
            // 
            // Slots_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1501, 564);
            Controls.Add(BackToCasinoButton);
            Controls.Add(AmountMoneyLabel);
            Controls.Add(UserName_label);
            Controls.Add(btnSpin);
            Controls.Add(nudBet);
            Controls.Add(pbSlot6);
            Controls.Add(pbSlot5);
            Controls.Add(pbSlot4);
            Controls.Add(pbSlot3);
            Controls.Add(pbSlot2);
            Controls.Add(pbSlot1);
            Controls.Add(lblBet);
            Name = "Slots_Form";
            Text = "Slots_Form";
            Load += Slots_Form_Load;
            ((System.ComponentModel.ISupportInitialize)nudBet).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
    }
}