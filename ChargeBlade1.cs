using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterHunterCompanion
{
    public class ChargeBlade : Blademaster
    {
        static string m;
        public static string _phial
        {
            get { return m; }
            set
            {
                if(value == "Impact" || value == "Element")
                {
                    m = value;
                }
            }
        }
        //constructors
        public ChargeBlade(string Name, string Description, string Rarity, int Attack, string Phial) //add array of items
        {
            _name = Name;

            _description = Description;

            _rarity = Rarity;

            _attack = Attack;

            _phial = Phial;
        }

        /*
         new Roaring Thunder = new Greatsword(Roaring Thunder, bsdjasbdkbask, 5, 70, {item1, 4, item2, 3})
         */

        public ChargeBlade(string Name, string Desc, string Rarity, int Attack, string Phial, int SpAtk, int Aff, int Def, int slots)
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

            //_specialAttack = SpAtk;
        }

        //deconstructor
        ~ChargeBlade()
        {

        }
    }
}
