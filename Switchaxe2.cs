using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterHunterCompanion
{
    public class Switchaxe : Blademaster
    {
        int sharpL;
        int i;
        static string m;
        public string _phial
        {
            get { return m; }
            set
            {
                if (value == "Power" || value == "Dragon" || value == "Exhaust" || value == "Poison" || value == "Paralysis")
                {
                    m = value;
                }
            }
        }
        //constructors
        public Switchaxe()
        {

        }
        public Switchaxe(string Name, string Description, string Rarity, int Attack, string Phial, int[] Sharpness) //add array of items
        {
            _name = Name;

            _description = Description;

            _rarity = Rarity;

            _attack = Attack;

            _phial = Phial;

            sharpL = Sharpness.GetLength(0);
            for (i = 0; i < sharpL; i++)
            {
                _sharpness[i] = Sharpness[i];
            }
        }

        /*
         new Roaring Thunder = new Greatsword(Roaring Thunder, bsdjasbdkbask, 5, 70, {item1, 4, item2, 3})
         */

        public Switchaxe(string Name, string Desc, string Rarity, int Attack, string Phial, int SpAtk, int Aff, int Def, int slots, int[] Sharpness)
        {
            _name = Name;

            _description = Desc;

            _rarity = Rarity;

            _attack = Attack;

            _phial = Phial;

            // additional fields
            _slots = slots;

            _defense = Def;

            _affinity = Aff;

            _specialAttack = SpAtk;

            sharpL = Sharpness.GetLength(0);
            for (i = 0; i < sharpL; i++)
            {
                _sharpness[i] = Sharpness[i];
            }
        }

        //deconstructor
        ~Switchaxe()
        {

        }
    }
}
