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
        public static int PrestigePrice = 5000;
        public static int TimerInterval = 1000; // 1 second to start



        private int sharedVariable = 1;


        private Int64 _score;
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Int64 Score
        {
            get { return _score; }
            set
            {
                try
                {
                    _score = value;
                    UpdateScoreText();
                }
                catch (OverflowException)
                {
                    MessageBox.Show("You hit the largest possible number and beat the game, Congrats!", "Good Game", MessageBoxButtons.OK);
                    _score = 0; // Reset the score or take another appropriate action
                    UpdateScoreText();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An unexpected error occurred: {ex.Message}", "You messed something up", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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
            if (Items.ShinyIssacUnlocked == true)
            {
                for (int i = 0; i < Items.ShinyIssac; i++)
                {
                    Score = Convert.ToInt64(Convert.ToDouble(Score) * 1.1);
                }
            }
            if (Items.MagicDiceUnlocked == true)
            {
                Random random = new Random();
                int randomNumber = random.Next(1, 101);
                if (randomNumber == 1)
                {
                    Score = Convert.ToInt64(Convert.ToDouble(Score) * 2);
                    MessageBox.Show("Magic Dice Rolled a 1! Score Doubled");
                }
            }

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

        public void UpdateUpgradeText()
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
                ClickBonus /= 2;
                AutoClicks /= 2;

                BonusPrice = ClickBonus * 50;
                AutoPrice = AutoClicks * 50;

                GlobalVariables.SharedVariable++;
                PrestigeLabel.Text = $"Prestige Tokens: {GlobalVariables.SharedVariable}";
                PrestigePrice += 5000;
                if (PrestigePrice > 100000)
                {
                    PrestigePrice = 100000;
                }
                if (Items.CrueltySquadUnlocked == true)
                {
                    for (int i = 0; i < Items.CrueltySquad; i++)
                    {
                        PrestigePrice /= 2;
                    }
                }
                UpdateUpgradeText();    
            }
            
        }

        private void OpenShop_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this);
            form2.Show();
        }
    }
}
