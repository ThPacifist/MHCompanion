using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterHunterCompanion
{
    public class Blademaster : Weapon
    {
        public int[] _sharpness { get; set; }

        public int _specialAttack;

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
    }
}
