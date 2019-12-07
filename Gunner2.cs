using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterHunterCompanion
{
    public class Gunner : Weapon
    {
        public static string m;
        public string _recoil
        {
            get { return m; }
            set
            {
                if(value == "Short" || value == "Medium" || value == "High" || value == "Some")
                {
                    m = value;
                }
                else
                    m = "$ERROR$";
            }
        }

        public string _reload 
        {
            get { return m; }
            set
            {
                if (value == "V.Fast" || value == "Abv. Ave." || value == "Average" || value == "Bel. Ave." || value == "V. Slow")
                {
                    m = value;
                }
                else
                    m = "$ERROR$";
            }
        }

        public string _deviation
        {
            get { return m; }
            set
            {
                if( value == "None" || value == "L Mild" || value == "R Mild" || value == "RL Severe" || value == "R Severe" || value == "RL Mild" || value == "L Severe")
                {
                    m = value;
                }
                else
                    m = "$ERROR$";
            }
        }

        int x;
        public override int _slots
        {
            get { return x; }
            set
            {
                if (value <= 3 && value >= 1)
                    x = value;
                else
                    x = 0;
            }
        }

        public string[,] _intAmmo;
    }
}
