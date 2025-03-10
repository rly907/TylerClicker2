using System;
using System.ComponentModel;
using System.Windows.Forms;
namespace TylerClicker2
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.Timer timer;

        int AutoClicks = 1;
        int ClickBonus = 1;

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

        public Form1()
        {
            InitializeComponent();
            InitializeTimer();
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
            UpdateUpgradeText();
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
        }

        private void AutoBtn_Click(object sender, EventArgs e)
        {
            AutoClicks++;
            UpdateUpgradeText();
        }

        private void BonusBtn_Click(object sender, EventArgs e)
        {
            ClickBonus++;
            UpdateUpgradeText();
        }
    }
}
