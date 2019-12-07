using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterHunterCompanion
{
    public class Decorations
    {
        int x;
        public string _name { get; set; }

        public string _rarity
        {
            get { return "Rare" + x; }
            set
            {
                if (Int32.Parse(value) <= 10 && Int32.Parse(value) >= 1)
                    x = Int32.Parse(value);
            }
        }

        public int _slots
        {
            get { return x; }
            set
            {
                if (value <= 3 && value >= 1)
                    x = value;
                else
                    x = 0;
            }
        }

        public int _sellPrice { get; set; }

        public int __buyPrice { get; set; }

        public string[,] _skills = new string[2,2];
        int i, k;
        public Decorations()
        {

        }
        public Decorations(string Name, string Rarity, int Slots, int SellP, int BuyP, string[,] Skills)
        {
            _name = Name;

            _rarity = Rarity;

            _slots = Slots;

            _sellPrice = SellP;

            __buyPrice = BuyP;

            for(i=0;i==2;i++)
            {
                for(k=0;k==2;i++)
                {
                      _skills[i, k] = Skills[i, k];
                }
            }
        }
    }
}
