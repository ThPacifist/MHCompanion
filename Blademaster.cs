using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterHunterCompanion
{
    public class Blademaster : Weapon
    {
        public static int[] _sharpness;

        // Work on specifics of special attack
        public static int _specialAttack;

        int x;
        public override string _rarity
        {
            get { return "Rare" + x; }
            set
            {
                if (Int32.Parse(value) <= 10 && Int32.Parse(value) >= 1)
                    x = Int32.Parse(value);
            }
        }

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
    }
}
