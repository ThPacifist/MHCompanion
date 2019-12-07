using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterHunterCompanion
{
    public class Gunlance : Blademaster
    {
        int sharpL;
        int i;
        string m;
        int x;
        public string _shellT
        {
            get { return m; }
            set
            {
                if(value == "Normal" || value == "Wide" || value == "Long")
                {
                    m = value;
                }
            }
        }
        public int _shellL
        {
            get { return x; }
            set
            {
                if(value >= 1 || value <= 4)
                {
                    x = value;
                }
            }
        }
        //constructors
        public Gunlance()
        {

        }
        public Gunlance(string Name, string Description, string Rarity, int Attack, string ShellT, int ShellL, int[] Sharpness) //add array of items
        {
            _name = Name;

            _description = Description;

            _rarity = Rarity;

            _attack = Attack;

            _shellL = ShellL;
            _shellT = ShellT;

            sharpL = Sharpness.GetLength(0);
            for (i = 0; i < sharpL; i++)
            {
                _sharpness[i] = Sharpness[i];
            }
        }

        /*
         new Roaring Thunder = new Greatsword(Roaring Thunder, bsdjasbdkbask, 5, 70, {item1, 4, item2, 3})
         */

        public Gunlance(string Name, string Desc, string Rarity, int Attack, string ShellT, int ShellL, int SpAtk, int Aff, int Def, int slots, int[] Sharpness)
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

            _specialAttack = SpAtk;

            sharpL = Sharpness.GetLength(0);
            for (i = 0; i < sharpL; i++)
            {
                _sharpness[i] = Sharpness[i];
            }
        }

        //deconstructor
        ~Gunlance()
        {

        }
    }
}
