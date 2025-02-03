using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Casino.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Casino
{
    public partial class Casino_Form : Form
    {
        public User LoggedInUser { get; set; }

        public Casino_Form()
        {
            InitializeComponent();
        }

        private void Casino_Form_Load(object sender, EventArgs e)
        {
            if (LoggedInUser != null)
            {
                UserName_label.Text = LoggedInUser.Username;
                AmountMoneyLabel.Text = LoggedInUser.Money.ToString("C");

                AmountMoneyLabel.Text = $"Balance: {LoggedInUser.Money:C}";
                UserName_label.Text = LoggedInUser.Username;

                if (LoggedInUser.IsAdmin)
                {
                    UserName_label.ForeColor = Color.Gold;
                }
                else
                {
                    UserName_label.ForeColor = SystemColors.ControlText;
                }
            }
        }

        private void ToBlackJackbutton_Click(object sender, EventArgs e)
        {
            BlackJack_Form form = new BlackJack_Form(LoggedInUser);

            form.LoggedInUser = LoggedInUser;
            form.Show();
            this.Hide();
        }

        private void ToRocketkbutton_MouseClick(object sender, MouseEventArgs e)
        {
            Rocket_Form form = new Rocket_Form(LoggedInUser);

            form.LoggedInUser = LoggedInUser;
            form.Show();
            this.Hide();
        }

        private void ToSlotskbutton_Click(object sender, EventArgs e)
        {
            Slots_Form form = new Slots_Form(LoggedInUser);

            form.LoggedInUser = LoggedInUser;
            form.Show();
            this.Hide();
        }

        private void RouletteButton_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login_Form form = new Login_Form();

            form.Show();
            this.Hide();
        }
    }
}
