namespace Casino
{
    partial class BlackJack_Form
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
            Dealbutton = new Button();
            HitButton = new Button();
            Stand = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            AmountMoneyLabel = new Label();
            UserName_label = new Label();
            imageList1 = new ImageList(components);
            DealerValueLabel = new Label();
            PlayerCardsLabel = new Label();
            DealerCardsLabel = new Label();
            PlayerValueLabel = new Label();
            SuspendLayout();
            // 
            // Dealbutton
            // 
            Dealbutton.Location = new Point(356, 385);
            Dealbutton.Name = "Dealbutton";
            Dealbutton.Size = new Size(75, 23);
            Dealbutton.TabIndex = 0;
            Dealbutton.Text = "Dealbutton";
            Dealbutton.UseVisualStyleBackColor = true;
            // 
            // HitButton
            // 
            HitButton.Location = new Point(298, 337);
            HitButton.Name = "HitButton";
            HitButton.Size = new Size(75, 23);
            HitButton.TabIndex = 1;
            HitButton.Text = "Hit";
            HitButton.UseVisualStyleBackColor = true;
            HitButton.Click += HitButton_Click;
            // 
            // Stand
            // 
            Stand.Location = new Point(408, 337);
            Stand.Name = "Stand";
            Stand.Size = new Size(75, 23);
            Stand.TabIndex = 2;
            Stand.Text = "Stand";
            Stand.UseVisualStyleBackColor = true;
            Stand.Click += StandButton_Click;
            // 
            // button4
            // 
            button4.Location = new Point(713, 245);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 3;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(641, 280);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 4;
            button5.Text = "button5";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(82, 280);
            button6.Name = "button6";
            button6.Size = new Size(75, 23);
            button6.TabIndex = 5;
            button6.Text = "button6";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(12, 245);
            button7.Name = "button7";
            button7.Size = new Size(75, 23);
            button7.TabIndex = 6;
            button7.Text = "button7";
            button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Location = new Point(161, 314);
            button8.Name = "button8";
            button8.Size = new Size(75, 23);
            button8.TabIndex = 7;
            button8.Text = "button8";
            button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Location = new Point(569, 314);
            button9.Name = "button9";
            button9.Size = new Size(75, 23);
            button9.TabIndex = 8;
            button9.Text = "button9";
            button9.UseVisualStyleBackColor = true;
            // 
            // AmountMoneyLabel
            // 
            AmountMoneyLabel.AutoSize = true;
            AmountMoneyLabel.Location = new Point(67, -2);
            AmountMoneyLabel.Name = "AmountMoneyLabel";
            AmountMoneyLabel.Size = new Size(116, 15);
            AmountMoneyLabel.TabIndex = 10;
            AmountMoneyLabel.Text = "AmountMoneyLabel";
            // 
            // UserName_label
            // 
            UserName_label.AutoSize = true;
            UserName_label.Location = new Point(-1, -2);
            UserName_label.Name = "UserName_label";
            UserName_label.Size = new Size(62, 15);
            UserName_label.TabIndex = 9;
            UserName_label.Text = "UserName";
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // DealerValueLabel
            // 
            DealerValueLabel.AutoSize = true;
            DealerValueLabel.Location = new Point(606, 48);
            DealerValueLabel.Name = "DealerValueLabel";
            DealerValueLabel.Size = new Size(96, 15);
            DealerValueLabel.TabIndex = 13;
            DealerValueLabel.Text = "DealerValueLabel";
            // 
            // PlayerCardsLabel
            // 
            PlayerCardsLabel.AutoSize = true;
            PlayerCardsLabel.Location = new Point(161, 131);
            PlayerCardsLabel.Name = "PlayerCardsLabel";
            PlayerCardsLabel.Size = new Size(97, 15);
            PlayerCardsLabel.TabIndex = 14;
            PlayerCardsLabel.Text = "PlayerCardsLabel";
            // 
            // DealerCardsLabel
            // 
            DealerCardsLabel.AutoSize = true;
            DealerCardsLabel.Location = new Point(161, 48);
            DealerCardsLabel.Name = "DealerCardsLabel";
            DealerCardsLabel.Size = new Size(98, 15);
            DealerCardsLabel.TabIndex = 15;
            DealerCardsLabel.Text = "DealerCardsLabel";
            DealerCardsLabel.Click += DealerCardsLabel_Click;
            // 
            // PlayerValueLabel
            // 
            PlayerValueLabel.AutoSize = true;
            PlayerValueLabel.Location = new Point(606, 131);
            PlayerValueLabel.Name = "PlayerValueLabel";
            PlayerValueLabel.Size = new Size(95, 15);
            PlayerValueLabel.TabIndex = 16;
            PlayerValueLabel.Text = "PlayerValueLabel";
            // 
            // BlackJack_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(PlayerValueLabel);
            Controls.Add(DealerCardsLabel);
            Controls.Add(PlayerCardsLabel);
            Controls.Add(DealerValueLabel);
            Controls.Add(AmountMoneyLabel);
            Controls.Add(UserName_label);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(Stand);
            Controls.Add(HitButton);
            Controls.Add(Dealbutton);
            Name = "BlackJack_Form";
            Text = "BlackJack_Form";
            Load += BlackJack_Form_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Dealbutton;
        private Button HitButton;
        private Button Stand;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Label AmountMoneyLabel;
        private Label UserName_label;
        private ImageList imageList1;
        private Label DealerValueLabel;
        private Label PlayerCardsLabel;
        private Label DealerCardsLabel;
        private Label PlayerValueLabel;
    }
}