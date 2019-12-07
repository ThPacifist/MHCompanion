using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterHunterCompanion
{
    public class Lance : Blademaster
    {
        int sharpL;
        int i;
        //constructors
        public Lance()
        {

        }
        public Lance(string Name, string Description, string Rarity, int Attack, int[] Sharpness) //add array of items
        {
            _name = Name;

            _description = Description;

            _rarity = Rarity;

            _attack = Attack;

            sharpL = Sharpness.GetLength(0);
            for (i = 0; i < sharpL; i++)
            {
                _sharpness[i] = Sharpness[i];
            }
        }

        /*
         new Roaring Thunder = new Greatsword(Roaring Thunder, bsdjasbdkbask, 5, 70, {item1, 4, item2, 3})
         */

        public Lance(string Name, string Desc, string Rarity, int Attack, int SpAtk, int Aff, int Def, int slots, int[] Sharpness)
        {
            _name = Name;

            _description = Desc;

            _rarity = Rarity;

            _attack = Attack;

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
        ~Lance()
        {

        }
    }
}
