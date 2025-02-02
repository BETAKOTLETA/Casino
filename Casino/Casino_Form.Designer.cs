namespace Casino
{
    partial class Casino_Form
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
            ToBlackJackbutton = new Button();
            Rocket = new Button();
            button3 = new Button();
            UserName_label = new Label();
            AmountMoneyLabel = new Label();
            SuspendLayout();
            // 
            // ToBlackJackbutton
            // 
            ToBlackJackbutton.Location = new Point(355, 91);
            ToBlackJackbutton.Name = "ToBlackJackbutton";
            ToBlackJackbutton.Size = new Size(75, 23);
            ToBlackJackbutton.TabIndex = 0;
            ToBlackJackbutton.Text = "BlackJack";
            ToBlackJackbutton.UseVisualStyleBackColor = true;
            ToBlackJackbutton.Click += button1_Click;
            // 
            // Rocket
            // 
            Rocket.Location = new Point(438, 186);
            Rocket.Name = "Rocket";
            Rocket.Size = new Size(75, 23);
            Rocket.TabIndex = 1;
            Rocket.Text = "ToRocketbutton";
            Rocket.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(355, 269);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 2;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // UserName_label
            // 
            UserName_label.AutoSize = true;
            UserName_label.Location = new Point(22, 15);
            UserName_label.Name = "UserName_label";
            UserName_label.Size = new Size(62, 15);
            UserName_label.TabIndex = 3;
            UserName_label.Text = "UserName";
            // 
            // AmountMoneyLabel
            // 
            AmountMoneyLabel.AutoSize = true;
            AmountMoneyLabel.Location = new Point(90, 15);
            AmountMoneyLabel.Name = "AmountMoneyLabel";
            AmountMoneyLabel.Size = new Size(116, 15);
            AmountMoneyLabel.TabIndex = 4;
            AmountMoneyLabel.Text = "AmountMoneyLabel";
            // 
            // Casino_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(AmountMoneyLabel);
            Controls.Add(UserName_label);
            Controls.Add(button3);
            Controls.Add(Rocket);
            Controls.Add(ToBlackJackbutton);
            Name = "Casino_Form";
            Text = "Casino_Form";
            Load += Casino_Form_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ToBlackJackbutton;
        private Button Rocket;
        private Button button3;
        private Label UserName_label;
        private Label AmountMoneyLabel;
    }
}