using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterHunterCompanion
{
    public interface IWeapon
    {
        string _name { get; set; }

        string _description { get; set; }

        string _rarity { get; set; }

        int _attack { get; set; }

        int _affinity { get; set; }

        int _defense { get; set; }
    }

    public abstract class Weapon : IWeapon
    {
        int x;
        public string _name { get; set; }

        public string _description { get; set; }

        public  string _rarity
        {
            get { return "Rare" + x; }
            set
            {
                if (Int32.Parse(value) <= 10 && Int32.Parse(value) >= 1)
                    x = Int32.Parse(value);
            }
        }

        public int _attack { get; set; }

        public int _affinity { get; set; }

        public int _defense { get; set; }

        public virtual int _slots { get; set; }
    }
}