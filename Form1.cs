using System;
using System.ComponentModel;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace TylerClicker2
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.Timer timer;

        int AutoClicks = 1;
        int ClickBonus = 1;
        int AutoPrice = 100;
        int BonusPrice = 100;
        int PrestigeInt;
        double PrestigePrice = 1000;


        private int sharedVariable = 1;


        private int _score;
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int Score
        {
            get { return _score; }
            set
            {
                _score = value;
                UpdateScoreText();

            }
        }

        private void OpenForm2()
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
        private void Form2_VariableUpdated(object sender, int newValue)
        {
            sharedVariable = newValue;
            PrestigeLabel.Text = $"Prestige Tokens: {sharedVariable}";
        }

        public Form1()
        {
            InitializeComponent();
            InitializeTimer();
            GlobalVariables.OnVariableUpdated += GlobalVariables_OnVariableUpdated;
        }
        private void GlobalVariables_OnVariableUpdated(object sender, int newValue)
        {
            PrestigeLabel.Text = $"Prestige Tokens: {newValue}";
        }
        private void InitializeTimer()
        {
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000; // 1000 ms = 1 second
            timer.Tick += Timer_Tick;
            timer.Start();
        }


        private void TickEvent()
        {
            Score += AutoClicks;


        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            TickEvent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void UpdateScoreText()
        {

            scoreLbl.Text = $"Score: {Score}";
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            Score += ClickBonus;
        }

        private void UpdateUpgradeText()
        {
            AutoLabel.Text = $"Issac Cats: {AutoClicks} (Auto Clicks)";
            BonusLabel.Text = $"Lucy Cats: {ClickBonus - 1} (Click Bonus)";
            AutoBtn.Text = $"+1 Issac Cat (Auto) - {AutoPrice}";
            BonusBtn.Text = $"+1 Lucy Cat (Click) - {BonusPrice}";
        }

        private void AutoBtn_Click(object sender, EventArgs e)
        {
            if (Score >= AutoPrice)
            {
                Score -= AutoPrice;
                AutoPrice += 100;
                AutoClicks++;
                UpdateUpgradeText();
            }
        }

        private void BonusBtn_Click(object sender, EventArgs e)
        {
            if (Score >= BonusPrice)
            {
                Score -= BonusPrice;
                BonusPrice += 100;
                ClickBonus++;
                UpdateUpgradeText();
            }
        }

        private void PrestigeButton_Click(object sender, EventArgs e)
        {
            GlobalVariables.SharedVariable++;
            PrestigeLabel.Text = $"Prestige Tokens: {GlobalVariables.SharedVariable}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenForm2();
        }
    }
}
