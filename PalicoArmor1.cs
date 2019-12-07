﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterHunterCompanion
{
    public class PalicoArmor
    {
        int x;
        public string _rarity
        {
            get { return "Rare" + x; }
            set
            {
                if (Int32.Parse(value) <= 10 && Int32.Parse(value) >= 1)
                    x = Int32.Parse(value);
            }
        }

        public int _fireRes { get; set; }
        public int _waterRes { get; set; }
        public int _thunderRes { get; set; }
        public int _iceRes { get; set; }
        public int _dragonRes { get; set; }
        public int _def { get; set; }
    }
}
