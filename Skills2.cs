using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterHunterCompanion
{
    public class Skills
    {
        public string _name { get; set; }

        public string _description { get; set; }

        public int _pointsNeeded { get; set; }

        public string _typePoint { get; set; }

        public Skills()
        {

        }
        public Skills(string Name, string Desc,  string TypeP, int PointN)
        {
            _name = Name;

            _description = Desc;

            _typePoint = TypeP;

            _pointsNeeded = PointN;
        }
    }
}
