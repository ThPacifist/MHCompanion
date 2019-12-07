using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterHunterCompanion
{
    class Bow : Weapon
    {
        //SuperClass fields
        int x;
        public static string m;
        int i;

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

        //subclass fields
        public string _arc
        {
            get { return m; }
            //focus, wide, blast
            set
            {
                if (value == "Focus" || value == "Wide" || value == "Blast")
                {
                    m = value;
                }
                else
                    m = "$ERROR$";
            }
        }
        public string[] _charges;

        public int _specialAttack;
        public Bow()
        {

        }
        public Bow(string Name, string Desc, string Rarity, int Atk, string Arc, string[] Charges)
        {
            _name = Name;

            _description = Desc;

            _rarity = Rarity;

            _attack = Atk;

            _arc = Arc;

            for(i=0; i<4; i++)
            {
                _charges[i] = Charges[i];
            }
        }
        public Bow(string Name, string Desc, string Rarity, int Atk, int Aff, int Def, int Slots, string Arc, int SpAtk, string[] Charges)
        {
            _name = Name;

            _description = Desc;

            _rarity = Rarity;

            _attack = Atk;

            _arc = Arc;

            for (i = 0; i < 4; i++)
            {
                _charges[i] = Charges[i];
            }

            //additional fields
            _affinity = Aff;

            _defense = Def;

            _slots = Slots;

            _specialAttack = SpAtk;
        }
    }
}
