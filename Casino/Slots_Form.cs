using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using Casino.Models;

namespace Casino
{
    public partial class Slots_Form : Form
    {
        private User _currentUser;
        //private bool _cashedOut;
        public User LoggedInUser { get; set; }
        Bet bet;


        public Slots_Form(User loggedInUser)
        {
            LoggedInUser = loggedInUser;
            InitializeComponent();
            _currentUser = loggedInUser;

            AmountMoneyLabel.Text = $"Balance: {_currentUser.Money:C}";
            UserName_label.Text = _currentUser.Username;
        }

        private void Slots_Form_Load(object sender, EventArgs e)
        {
            bet = new Bet(0, LoggedInUser);

            InitializeSymbols();
            InitializePayTable();


            UpdateLabels();
        }

        private enum Symbol
        {
            Heart,
            Purple,
            Green,
            Blue,
            Apple,
            Plum,
            Watermelon,
            Grapes,
            Banana,
            Lollipop
        }

        private Dictionary<Symbol, Image> symbolImages = new Dictionary<Symbol, Image>();


        private Dictionary<Symbol, Dictionary<int, decimal>> payTable =
            new Dictionary<Symbol, Dictionary<int, decimal>>();

        private Random rand = new Random();


        private const int SlotCount = 6;



        public Slots_Form()
        {
            InitializeComponent();
        }


        private void btnStart_Click(object sender, EventArgs e)
        {
            UpdateLabels();

        }

        private void btnSpin_Click(object sender, EventArgs e)
        {
            bet.ChangeBet(nudBet.Value, lblBet);

            LoggedInUser.UpdateToDataBaseMoney(-bet.Amount);
            AmountMoneyLabel.Text = LoggedInUser.Money.ToString("C");


            Symbol[] spinResult = new Symbol[SlotCount];
            for (int i = 0; i < SlotCount; i++)
            {
                spinResult[i] = GetRandomSymbol();
            }

            pbSlot1.Image = symbolImages[spinResult[0]];
            pbSlot2.Image = symbolImages[spinResult[1]];
            pbSlot3.Image = symbolImages[spinResult[2]];
            pbSlot4.Image = symbolImages[spinResult[3]];
            pbSlot5.Image = symbolImages[spinResult[4]];
            pbSlot6.Image = symbolImages[spinResult[5]];

            decimal winAmount = CalculateWin(spinResult);
            _currentUser.UpdateToDataBaseMoney(winAmount);

            AmountMoneyLabel.Text = $"Balance: {_currentUser.Money:C}";
            UserName_label.Text = _currentUser.Username;

            UpdateLabels();

            if (winAmount > 0)
            {
                MessageBox.Show($"You win: ${winAmount:F2}");
            }
            bet.Reset();
        }

        private void InitializeSymbols()
        {
            symbolImages[Symbol.Heart] = Image.FromFile("Images/heart.png");
            symbolImages[Symbol.Purple] = Image.FromFile("Images/purple.png");
            symbolImages[Symbol.Green] = Image.FromFile("Images/green.png");
            symbolImages[Symbol.Blue] = Image.FromFile("Images/blue.png");
            symbolImages[Symbol.Apple] = Image.FromFile("Images/apple.png");
            symbolImages[Symbol.Plum] = Image.FromFile("Images/plum.png");
            symbolImages[Symbol.Watermelon] = Image.FromFile("Images/watermelon.png");
            symbolImages[Symbol.Grapes] = Image.FromFile("Images/grapes.png");
            symbolImages[Symbol.Banana] = Image.FromFile("Images/banana.png");
            symbolImages[Symbol.Lollipop] = Image.FromFile("Images/lollipop_scatter.png");
        }

        private void InitializePayTable()
        {
            payTable[Symbol.Heart] = new Dictionary<int, decimal>
    {
        {3, 5m}, {4, 10m}, {5, 20m}, {6, 50m}
    };
            payTable[Symbol.Purple] = new Dictionary<int, decimal>
    {
        {3, 3m}, {4, 7m}, {5, 15m}, {6, 30m}
    };
            payTable[Symbol.Green] = new Dictionary<int, decimal>
    {
        {3, 2m}, {4, 5m}, {5, 10m}, {6, 20m}
    };
            payTable[Symbol.Blue] = new Dictionary<int, decimal>
    {
        {3, 1m}, {4, 3m}, {5, 7m}, {6, 15m}
    };
            payTable[Symbol.Apple] = new Dictionary<int, decimal>
    {
        {3, 0.5m}, {4, 2m}, {5, 5m}, {6, 10m}
    };
            payTable[Symbol.Plum] = new Dictionary<int, decimal>
    {
        {3, 0.5m}, {4, 2m}, {5, 5m}, {6, 10m}
    };
            payTable[Symbol.Watermelon] = new Dictionary<int, decimal>
    {
        {3, 0.5m}, {4, 1.5m}, {5, 4m}, {6, 8m}
    };
            payTable[Symbol.Grapes] = new Dictionary<int, decimal>
    {
        {3, 0.5m}, {4, 1m}, {5, 3m}, {6, 6m}
    };
            payTable[Symbol.Banana] = new Dictionary<int, decimal>
    {
        {3, 0.3m}, {4, 0.7m}, {5, 2m}, {6, 4m}
    };
            payTable[Symbol.Lollipop] = new Dictionary<int, decimal>
    {
        {3, 10m}, {4, 50m}, {5, 100m}, {6, 200m}
    };
        }
        private int[][] paylines = new int[][]{
        new int[] {0, 1, 2, 3, 4, 5},

        };

        private Symbol GetRandomSymbol()
        {
            Array symbols = Enum.GetValues(typeof(Symbol));
            return (Symbol)symbols.GetValue(rand.Next(symbols.Length));
        }


        private decimal CalculateWin(Symbol[] spinResult)
        {
            decimal totalWin = 0m;

            // Loop over each payline to check for winning symbols
            foreach (var line in paylines)
            {
                for (int startIndex = 0; startIndex < line.Length; startIndex++)
                {
                    Symbol lineSymbol = spinResult[line[startIndex]];
                    int consecutive = 1;

                    // Check for consecutive symbols from the startIndex
                    for (int i = startIndex + 1; i < line.Length; i++)
                    {
                        if (spinResult[line[i]] == lineSymbol)
                            consecutive++;
                        else
                            break;
                    }

                    // Check if the consecutive count is enough to pay out
                    if (payTable.TryGetValue(lineSymbol, out var symbolPays))
                    {
                        foreach (var count in symbolPays.Keys.OrderByDescending(k => k))
                        {
                            if (consecutive >= count)
                            {
                                totalWin += bet.Amount * symbolPays[count];
                                break;
                            }
                        }
                    }
                }
            }

            // Handle scatter symbols (Lollipop)
            int scatterCount = spinResult.Count(s => s == Symbol.Lollipop);
            if (payTable.ContainsKey(Symbol.Lollipop) && payTable[Symbol.Lollipop].TryGetValue(scatterCount, out decimal scatterPayout))
            {
                totalWin += bet.Amount * scatterPayout;
            }

            return totalWin;
        }
        private void UpdateLabels()
        {
            lblBet.Text = $"Bet: €{nudBet.Value:F2}";
        }

        private void pbSlot4_Click(object sender, EventArgs e)
        {

        }

        private void pbSlot2_Click(object sender, EventArgs e)
        {

        }

        private void pbSlot6_Click(object sender, EventArgs e)
        {

        }

        private void pbSlot3_Click(object sender, EventArgs e)
        {

        }
    }
}