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
            button2 = new Button();
            button3 = new Button();
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
            // button2
            // 
            button2.Location = new Point(389, 169);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 1;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
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
            // Casino_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(ToBlackJackbutton);
            Name = "Casino_Form";
            Text = "Casino_Form";
            ResumeLayout(false);
        }

        #endregion

        private Button ToBlackJackbutton;
        private Button button2;
        private Button button3;
    }
}