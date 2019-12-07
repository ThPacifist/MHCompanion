using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterHunterCompanion
{
    public class HuntingHorn : Blademaster
    {
        private static string[] _notes = new string[3];

        //constructors
        public HuntingHorn(string Name, string Description, string Rarity, int Attack, string[] Notes) //add array of items
        {
            _name = Name;

            _description = Description;

            _rarity = Rarity;

            _attack = Attack;

            _notes = Notes;
        }

        /*
         new Roaring Thunder = new Greatsword(Roaring Thunder, bsdjasbdkbask, 5, 70, {item1, 4, item2, 3})
         */

        public HuntingHorn(string Name, string Desc, string Rarity, int Attack, string[] Notes, int SpAtk, int Aff, int Def, int slots)
        {
            _name = Name;

            _description = Desc;

            _rarity = Rarity;

            _attack = Attack;

            _notes = Notes;
            // additional fields
            _slots = slots;

            _defense = Def;

            _affinity = Aff;

            //_specialAttack = SpAtk;
        }

        //deconstructor
        ~HuntingHorn()
        {

        }
    }
}
