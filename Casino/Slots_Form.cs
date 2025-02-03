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

namespace Casino
{
    public partial class Slots_Form : Form
    {


        private void Slots_Form_Load(object sender, EventArgs e)
        {  // Ініціалізуємо зображення і таблицю виплат
            InitializeSymbols();
            InitializePayTable();

            // Спочатку Spin вимкнений — активуємо після натискання "Start"
            btnStart.Enabled = false;
            UpdateLabels();
        }
        // Демонстраційні символи (можна додати більше)
        private enum Symbol
        {
            Heart,      // Умовно "червоне сердечко"
            Purple,     // Умовно "фіолетова карамель"
            Green,      // Зелений льодяник
            Blue,       // Синій льодяник
            Apple,      // Яблуко
            Plum,       // Слива
            Watermelon, // Кавун
            Grapes,     // Виноград
            Banana,     // Банан
            Lollipop    // Скаттер (льодяник на паличці)
        }

        // Словник для зображень
        private Dictionary<Symbol, Image> symbolImages = new Dictionary<Symbol, Image>();

        // Таблиця виплат
        private Dictionary<Symbol, Dictionary<int, decimal>> payTable =
            new Dictionary<Symbol, Dictionary<int, decimal>>();

        private Random rand = new Random();

        // Кількість слотів (PictureBox) у грі
        private const int SlotCount = 6;

        // Баланс і ставка
        private decimal credit = 1000m;   // Початково 0, встановлюватимемо при Start
        private decimal bet = 2.5m;    // Буде братись із nudBet.Value

        public Slots_Form()
        {
            InitializeComponent();
        }
 
        // Кнопка "Start": встановлюємо початковий баланс, розблокуємо Spin
        private void btnStart_Click(object sender, EventArgs e)
        {
            credit = 1000m;      // Наприклад, даємо 1000 на старт
            btnStart.Enabled = true;
            UpdateLabels();
            MessageBox.Show("Гру розпочато! Оберіть ставку та натисніть Spin.");
        }

        // Кнопка "Spin"
        private void btnSpin_Click(object sender, EventArgs e)
        {
            // Зчитуємо ставку з NumericUpDown
            bet = nudBet.Value;

            // Перевіряємо, чи вистачає коштів
            if (credit < bet)
            {
                MessageBox.Show("Недостатньо коштів на балансі!");
                return;
            }

            // Віднімаємо ставку
            credit -= bet;

            // Генеруємо випадкові символи
            Symbol[] spinResult = new Symbol[SlotCount];
            for (int i = 0; i < SlotCount; i++)
            {
                spinResult[i] = GetRandomSymbol();
            }

            // Відображаємо символи у 6 PictureBox
            pbSlot1.Image = symbolImages[spinResult[0]];
            pbSlot2.Image = symbolImages[spinResult[1]];
            pbSlot3.Image = symbolImages[spinResult[2]];
            pbSlot4.Image = symbolImages[spinResult[3]];
            pbSlot5.Image = symbolImages[spinResult[4]];
            pbSlot6.Image = symbolImages[spinResult[5]];

            // Розрахунок виграшу
            decimal winAmount = CalculateWin(spinResult);
            credit += winAmount;

            // Оновлюємо написи (баланс, ставка тощо)
            UpdateLabels();

            // Якщо є виграш, показуємо повідомлення
            if (winAmount > 0)
            {
                MessageBox.Show($"Вітаємо! Ви виграли: €{winAmount:F2}");
            }
        }

        // Завантажуємо зображення в словник
        private void InitializeSymbols()
        {
            // Замініть шляхи на свої, якщо треба
            symbolImages[Symbol.Heart] = Image.FromFile("Images/heart.jpg");
            symbolImages[Symbol.Purple] = Image.FromFile("Images/purple.jpg");
            symbolImages[Symbol.Green] = Image.FromFile("Images/green.jpg");
            symbolImages[Symbol.Blue] = Image.FromFile("Images/blue.jpg");
            symbolImages[Symbol.Apple] = Image.FromFile("Images/apple.jpg");
            symbolImages[Symbol.Plum] = Image.FromFile("Images/plum.jpg");
            symbolImages[Symbol.Watermelon] = Image.FromFile("Images/watermelon.jpg");
            symbolImages[Symbol.Grapes] = Image.FromFile("Images/grapes.jpg");
            symbolImages[Symbol.Banana] = Image.FromFile("Images/banana.jpg");
            symbolImages[Symbol.Lollipop] = Image.FromFile("Images/lollipop_scatter.jpg");
        }

        // Заповнюємо таблицю виплат (спрощений приклад)
        private void InitializePayTable()
        {
            payTable[Symbol.Heart] = new Dictionary<int, decimal>
            {
                {8,  20m}, {10, 50m}, {12, 100m}
            };
            payTable[Symbol.Purple] = new Dictionary<int, decimal>
            {
                {8,  10m}, {10, 20m}, {12, 50m}
            };
            payTable[Symbol.Green] = new Dictionary<int, decimal>
            {
                {8,  9m}, {10, 15m}, {12, 30m}
            };
            payTable[Symbol.Blue] = new Dictionary<int, decimal>
            {
                {8,  5m}, {10, 12m}, {12, 24m}
            };
            payTable[Symbol.Apple] = new Dictionary<int, decimal>
            {
                {8,  2m}, {10, 3m}, {12, 20m}
            };
            payTable[Symbol.Plum] = new Dictionary<int, decimal>
            {
                {8,  2m}, {10, 4m}, {12, 16m}
            };
            payTable[Symbol.Watermelon] = new Dictionary<int, decimal>
            {
                {8,  1m}, {10, 2m}, {12, 10m}
            };
            payTable[Symbol.Grapes] = new Dictionary<int, decimal>
            {
                {8,  0.9m}, {10, 1.8m}, {12, 8m}
            };
            payTable[Symbol.Banana] = new Dictionary<int, decimal>
            {
                {8,  0.5m}, {10, 1.2m}, {12, 4m}
            };
            // Scatter (Lollipop)
            payTable[Symbol.Lollipop] = new Dictionary<int, decimal>
            {
                {4,  10m}, {5,  50m}, {6, 200m}
            };
        }

        // Генерація випадкового символу (рівномірно)
        private Symbol GetRandomSymbol()
        {
            Array symbols = Enum.GetValues(typeof(Symbol));
            return (Symbol)symbols.GetValue(rand.Next(symbols.Length));
        }

        // Перевірка, який виграш вийшов (якщо взагалі)
        private decimal CalculateWin(Symbol[] spinResult)
        {
            // Підрахунок, скільки кожного символу
            Dictionary<Symbol, int> counts = new Dictionary<Symbol, int>();
            foreach (var symbol in spinResult)
            {
                if (!counts.ContainsKey(symbol))
                    counts[symbol] = 0;
                counts[symbol]++;
            }

            decimal totalWin = 0m;
            foreach (var kv in counts)
            {
                Symbol sym = kv.Key;
                int count = kv.Value;

                if (sym == Symbol.Lollipop)
                {
                    // Scatter (4,5,6+)
                    if (count >= 4 && payTable[sym].ContainsKey(count))
                    {
                        int key = count > 6 ? 6 : count;
                        totalWin += (bet * payTable[sym][key]);
                    }
                }
                else
                {
                    // 8, 10, 12
                    if (count >= 12 && payTable[sym].ContainsKey(12))
                    {
                        totalWin += (bet * payTable[sym][12]);
                    }
                    else if (count >= 10 && payTable[sym].ContainsKey(10))
                    {
                        totalWin += (bet * payTable[sym][10]);
                    }
                    else if (count >= 8 && payTable[sym].ContainsKey(8))
                    {
                        totalWin += (bet * payTable[sym][8]);
                    }
                }
            }
            return totalWin;
        }

        // Оновлюємо текст на екрані (баланс, ставка)
        private void UpdateLabels()
        {
            lblCredit.Text = $"Credit: €{credit:F2}";
            lblBet.Text = $"Bet: €{nudBet.Value:F2}";
        }
    }
}
