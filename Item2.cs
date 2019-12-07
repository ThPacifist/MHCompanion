using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterHunterCompanion
{
    public class Item
    {
        public string _name { get; set; }

        public string _description { get; set; }

        public int _carryMax { get; set; }

        public int _sellPrice { get; set; }

        int x;
        public string _rarity
        {
            get { return "Rare" + x; }
            set
            {
                if (Int32.Parse(value) <= 10 && Int32.Parse(value) >= 1)
                    x = Int32.Parse(value);
            }
        }

        public Item()
        {

        }
        public Item(string Name, string Desc, int CarryM, int SellP, string Rarity)
        {
            _name = Name;

            _description = Desc;

            _carryMax = CarryM;

            _sellPrice = SellP;

            _rarity = Rarity;
        }
    }
}
