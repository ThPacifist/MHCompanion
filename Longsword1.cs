using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterHunterCompanion
{
    public class Longsword : Blademaster
    {
        //constructors
        public Longsword(string Name, string Description, string Rarity, int Attack) //add array of items
        {
            _name = Name;

            _description = Description;

            _rarity = Rarity;

            _attack = Attack;

        }

        /*
         new Roaring Thunder = new Greatsword(Roaring Thunder, bsdjasbdkbask, 5, 70, {item1, 4, item2, 3})
         */

        public Longsword(string Name, string Desc, string Rarity, int Attack, int SpAtk, int Aff, int Def, int slots)
        {
            _name = Name;

            _description = Desc;

            _rarity = Rarity;

            _attack = Attack;

            // additional fields
            _slots = slots;

            _defense = Def;

            _affinity = Aff;

            //_specialAttack = SpAtk;
        }

        //deconstructor
        ~Longsword()
        {

        }
    }
}
