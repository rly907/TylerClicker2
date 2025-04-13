using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TylerClicker2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            GlobalVariables.OnVariableUpdated += GlobalVariables_OnVariableUpdated;
        }

        private void GlobalVariables_OnVariableUpdated(object sender, int newValue)
        {
            PrestigeTokens.Text = $"Tokens: {GlobalVariables.SharedVariable}";
        }

        private void SomeMethodToUpdateVariable()
        {
            GlobalVariables.SharedVariable = 42; // Example update
        }


    }
}
