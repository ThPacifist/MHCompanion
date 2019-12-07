using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterHunterCompanion
{
    public class HuntingHorn : Blademaster
    {
        public string[] _notes = new string[3];
        int sharpL;
        int i;

        //constructors
        public HuntingHorn()
        {

        }
        public HuntingHorn(string Name, string Description, string Rarity, int Attack, string[] Notes, int[] Sharpness) //add array of items
        {
            _name = Name;

            _description = Description;

            _rarity = Rarity;

            _attack = Attack;

            for(i = 0; i < 3; i++)
            {
                _notes[i] = Notes[i];
            }

            sharpL = Sharpness.GetLength(0);
            for (i = 0; i < sharpL; i++)
            {
                _sharpness[i] = Sharpness[i];
            }
        }

        /*
         new Roaring Thunder = new Greatsword(Roaring Thunder, bsdjasbdkbask, 5, 70, {item1, 4, item2, 3})
         */

        public HuntingHorn(string Name, string Desc, string Rarity, int Attack, string[] Notes, int SpAtk, int Aff, int Def, int slots, int[] Sharpness)
        {
            _name = Name;

            _description = Desc;

            _rarity = Rarity;

            _attack = Attack;

            for (i = 0; i < 3; i++)
            {
                _notes[i] = Notes[i];
            }
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
        ~HuntingHorn()
        {

        }
    }
}
