using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace TylerClicker2
{
    public partial class Form2 : Form
    {

        private Form1 _form1;

        public Form2(Form1 form1)
        {
            InitializeComponent();
            _form1 = form1;
            GlobalVariables.OnVariableUpdated += GlobalVariables_OnVariableUpdated;
        }

        private void GlobalVariables_OnVariableUpdated(object sender, int newValue)
        {
            PrestigeTokens.Text = $"Tokens: {GlobalVariables.SharedVariable}";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (GlobalVariables.SharedVariable >= 5)
            {
                GlobalVariables.SharedVariable -= 5;
                Items.ShinyIssac++;
                Items.CheckUnlocks();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (GlobalVariables.SharedVariable >= 1)
            {
                GlobalVariables.SharedVariable -= 1;
                Items.SuperLucy++;
                Items.CheckUnlocks();
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (GlobalVariables.SharedVariable >= 8)
            {
                GlobalVariables.SharedVariable -= 8;
                Items.TimeMittens++;
                Items.CheckUnlocks();
                Form1.TimerInterval /= 2; // Halve the timer interval
                _form1.UpdateUpgradeText();

            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (GlobalVariables.SharedVariable >= 3)
            {
                GlobalVariables.SharedVariable -= 3;
                Items.CrueltySquad++;
                Items.CheckUnlocks();
                Form1.PrestigePrice /= 2;
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (GlobalVariables.SharedVariable >= 1)
            {
                GlobalVariables.SharedVariable -= 1;
                Items.MagicDice++;
                Items.CheckUnlocks();
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Items.BlueLight = true;
        }
    }
}
