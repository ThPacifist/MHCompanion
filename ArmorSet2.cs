using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterHunterCompanion
{
    public class ArmorSet
    {
        int i;
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
        public string _name;
        public int _fireRes { get; set; }
        public int _waterRes { get; set; }
        public int _thunderRes { get; set; }
        public int _iceRes { get; set; }
        public int _dragonRes { get; set; }
        public int _lowDef { get; set; }
        public int _highDef { get; set; }

        public string[] _skills = new string[5];

        //implement methods for skills
        //implement something for materials needed

        public ArmorSet()
        {

        }
        public ArmorSet(string Name, string Rarity, int FR, int WR, int TR, int IR, int DR, int LD, int HD, string[] Skills)
        {
            _name = Name;

            _rarity = Rarity;

            _fireRes = FR;

            _waterRes = WR;

            _iceRes = IR;

            _dragonRes = DR;

            _lowDef = LD;

            _highDef = HD;

            for(i=0; i<Skills.GetLength(0); i++)
            {
                _skills[i] = Skills[i];
            }
        }
    }
}
