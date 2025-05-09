using System;
using System.ComponentModel;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace TylerClicker2
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.Timer timer;

        int AutoClicks = 0;
        int ClickBonus = 1;
        int AutoPrice = 50;
        int BonusPrice = 50;
        int PrestigePrice = 5000;
        int TimerInterval = 1000; // 1 second to start



        private int sharedVariable = 1;


        private Int64 _score;
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Int64 Score
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
            UpdateUpgradeText();
        }
        private void GlobalVariables_OnVariableUpdated(object sender, int newValue)
        {
            PrestigeLabel.Text = $"Prestige Tokens: {newValue}";
        }
        private void InitializeTimer()
        {
            timer = new System.Windows.Forms.Timer();
            timer.Interval = TimerInterval; // Can be changed using mittens
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            Score += AutoClicks;
            Score = Convert.ToInt64(Convert.ToDouble(Score) * 1.1);
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
            PrestigeButton.Text = $"+1 Prestige - {PrestigePrice}";
        }

        private void AutoBtn_Click(object sender, EventArgs e)
        {
            if (Score >= AutoPrice)
            {
                Score -= AutoPrice;
                AutoPrice += 50;
                AutoClicks++;
                UpdateUpgradeText();
            }
        }

        private void BonusBtn_Click(object sender, EventArgs e)
        {
            if (Score >= BonusPrice)
            {
                Score -= BonusPrice;
                BonusPrice += 50;
                ClickBonus++;
                UpdateUpgradeText();
            }
        }

        private void PrestigeButton_Click(object sender, EventArgs e)
        {
            if (Score >= PrestigePrice)
            {
                Score = 0;
                ClickBonus = 1;
                AutoClicks = 0;
                UpdateUpgradeText();
                GlobalVariables.SharedVariable++;
                PrestigeLabel.Text = $"Prestige Tokens: {GlobalVariables.SharedVariable}";
                PrestigePrice += 5000;
            }
            
        }

        private void OpenShop_Click(object sender, EventArgs e)
        {
            OpenForm2();
        }
    }
}
