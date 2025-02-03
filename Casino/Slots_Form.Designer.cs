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
            lblCredit = new Label();
            lblBet = new Label();
            pbSlot1 = new Label();
            pbSlot2 = new Label();
            pbSlot3 = new Label();
            pbSlot4 = new Label();
            pbSlot5 = new Label();
            pbSlot6 = new Label();
            btnStart = new Button();
            nudBet = new NumericUpDown();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)nudBet).BeginInit();
            SuspendLayout();
            // 
            // lblCredit
            // 
            lblCredit.AutoSize = true;
            lblCredit.Location = new Point(33, 344);
            lblCredit.Name = "lblCredit";
            lblCredit.Size = new Size(97, 15);
            lblCredit.TabIndex = 15;
            lblCredit.Text = "PlayerCardsLabel";
            // 
            // lblBet
            // 
            lblBet.AutoSize = true;
            lblBet.Location = new Point(33, 382);
            lblBet.Name = "lblBet";
            lblBet.Size = new Size(97, 15);
            lblBet.TabIndex = 16;
            lblBet.Text = "PlayerCardsLabel";
            // 
            // pbSlot1
            // 
            pbSlot1.AutoSize = true;
            pbSlot1.Location = new Point(145, 85);
            pbSlot1.Name = "pbSlot1";
            pbSlot1.Size = new Size(97, 15);
            pbSlot1.TabIndex = 17;
            pbSlot1.Text = "PlayerCardsLabel";
            // 
            // pbSlot2
            // 
            pbSlot2.AutoSize = true;
            pbSlot2.Location = new Point(248, 85);
            pbSlot2.Name = "pbSlot2";
            pbSlot2.Size = new Size(97, 15);
            pbSlot2.TabIndex = 18;
            pbSlot2.Text = "PlayerCardsLabel";
            // 
            // pbSlot3
            // 
            pbSlot3.AutoSize = true;
            pbSlot3.Location = new Point(351, 85);
            pbSlot3.Name = "pbSlot3";
            pbSlot3.Size = new Size(97, 15);
            pbSlot3.TabIndex = 19;
            pbSlot3.Text = "PlayerCardsLabel";
            // 
            // pbSlot4
            // 
            pbSlot4.AutoSize = true;
            pbSlot4.Location = new Point(454, 85);
            pbSlot4.Name = "pbSlot4";
            pbSlot4.Size = new Size(97, 15);
            pbSlot4.TabIndex = 20;
            pbSlot4.Text = "PlayerCardsLabel";
            // 
            // pbSlot5
            // 
            pbSlot5.AutoSize = true;
            pbSlot5.Location = new Point(557, 85);
            pbSlot5.Name = "pbSlot5";
            pbSlot5.Size = new Size(97, 15);
            pbSlot5.TabIndex = 21;
            pbSlot5.Text = "PlayerCardsLabel";
            // 
            // pbSlot6
            // 
            pbSlot6.AutoSize = true;
            pbSlot6.Location = new Point(660, 85);
            pbSlot6.Name = "pbSlot6";
            pbSlot6.Size = new Size(97, 15);
            pbSlot6.TabIndex = 22;
            pbSlot6.Text = "PlayerCardsLabel";
            // 
            // btnStart
            // 
            btnStart.Location = new Point(567, 380);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(75, 23);
            btnStart.TabIndex = 24;
            btnStart.Text = "button2";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            btnStart.Enabled = true;
            // 
            // nudBet
            // 
            nudBet.Location = new Point(427, 380);
            nudBet.Name = "nudBet";
            nudBet.Size = new Size(120, 23);
            nudBet.TabIndex = 25;
            // 
            // button1
            // 
            button1.Location = new Point(657, 380);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 26;
            button1.Text = "button2";
            button1.UseVisualStyleBackColor = true;
            // 
            // Slots_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(nudBet);
            Controls.Add(btnStart);
            Controls.Add(pbSlot6);
            Controls.Add(pbSlot5);
            Controls.Add(pbSlot4);
            Controls.Add(pbSlot3);
            Controls.Add(pbSlot2);
            Controls.Add(pbSlot1);
            Controls.Add(lblBet);
            Controls.Add(lblCredit);
            Name = "Slots_Form";
            Text = "Slots_Form";
            Load += Slots_Form_Load;
            ((System.ComponentModel.ISupportInitialize)nudBet).EndInit();   
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCredit;
        private Label lblBet;
        private Label pbSlot1;
        private Label pbSlot2;
        private Label pbSlot3;
        private Label pbSlot4;
        private Label pbSlot5;
        private Label pbSlot6;
        private Button button1;
        private Button btnStart;
        private NumericUpDown nudBet;
    }
}