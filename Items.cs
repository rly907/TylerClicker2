using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TylerClicker2
{
    internal class Items
    {
        public static int ShinyIssac = 10;
        public static int SuperLucy = 0;
        public static int TimeMittens = 0;
        public static int CrueltySquad = 0;
        public static int MagicDice = 0;

        public static bool BlueLight = false;

        public static bool ShinyIssacUnlocked = true;
        public static bool SuperLucyUnlocked = false;
        public static bool TimeMittensUnlocked = false;
        public static bool CrueltySquadUnlocked = false;
        public static bool MagicDiceUnlocked = false;


        public static void CheckUnlocks()
        {
            if (ShinyIssac >= 1 && !ShinyIssacUnlocked)
            {
                ShinyIssacUnlocked = true;                
            }
            if (SuperLucy >= 1 && !SuperLucyUnlocked)
            {
                SuperLucyUnlocked = true;               
            }
            if (TimeMittens >= 1 && !TimeMittensUnlocked)
            {
                TimeMittensUnlocked = true;             
            }
            if (CrueltySquad >= 1 && !CrueltySquadUnlocked)
            {
                CrueltySquadUnlocked = true;                
            }
            if (MagicDice >= 1 && !MagicDiceUnlocked)
            {
                MagicDiceUnlocked = true;
            }
        }
    }
}
