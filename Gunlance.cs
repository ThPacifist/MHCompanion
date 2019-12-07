using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterHunterCompanion
{
    public class Gunlance : Blademaster
    {
        public string _shellT
        {
            get { return this._shellT; }
            set
            {
                if(value == "Normal" || value == "Wide" || value == "Long")
                {
                    this._shellT = value;
                }
            }
        }
        public int _shellL
        {
            get { return this._shellL; }
            set
            {
                if(value >= 1 || value <= 4)
                {
                    this._shellL = value;
                }
            }
        }
        //constructors
        public Gunlance(string Name, string Description, string Rarity, int Attack, string ShellT, int ShellL) //add array of items
        {
            _name = Name;

            _description = Description;

            _rarity = Rarity;

            _attack = Attack;

            _shellL = ShellL;
            _shellT = ShellT;
        }

        /*
         new Roaring Thunder = new Greatsword(Roaring Thunder, bsdjasbdkbask, 5, 70, {item1, 4, item2, 3})
         */

        public Gunlance(string Name, string Desc, string Rarity, int Attack, string ShellT, int ShellL, int SpAtk, int Aff, int Def, int slots)
        {
            _name = Name;

            _description = Desc;

            _rarity = Rarity;

            _attack = Attack;

            _shellL = ShellL;
            _shellT = ShellT;
            // additional fields
            _slots = slots;

            _defense = Def;

            _affinity = Aff;

            //_specialAttack = SpAtk;
        }

        //deconstructor
        ~Gunlance()
        {

        }
    }
}
