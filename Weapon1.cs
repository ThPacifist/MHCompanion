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
        //getUpgradePrice
        //getBuildPrice
    }

    public abstract class Weapon
    {
        public string _name { get; set; }

        public string _description { get; set; }

        public virtual string _rarity { get; set; }

        public int _attack { get; set; }

        public int _affinity { get; set; }

        public int _defense { get; set; }
        public virtual int _slots { get; set; }
    }
}