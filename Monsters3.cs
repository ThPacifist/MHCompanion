using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterHunterCompanion
{
    public class Monsters
    {
        int i;
        public string _name { get; set; }

        public string[] _ailments = new string[8];

        public string[] _habitats = new string[8];

        public string[] _weaknesses = new string[8];

        public string[] _lowItems = new string[8];

        public string[] _highItems = new string[8];

        public string[] _Gitems = new string[8];

        int count;

        public Monsters()
        {

        }
        public Monsters(string Name, string[] Ail, string[] Hab, string[] Weak, string[] Low, string[] High, string[] GR)
        {
            _name = Name;

            count = Ail.Length;
            for(i = 0; i < count; i++)
            {
                _ailments[i] = Ail[i];
            }
            count = Hab.GetLength(0);
            for (i = 0; i < count; i++)
            {
                _habitats[i] = Hab[i];
            }
            count = Weak.GetLength(0);
            for (i = 0; i < count; i++)
            {
                _weaknesses[i] = Weak[i];
            }
            count = Low.GetLength(0);
            for (i = 0; i < count; i++)
            {
                _lowItems[i] = Low[i];
            }
            count = High.GetLength(0);
            for (i = 0; i < count; i++)
            {
                _highItems[i] = High[i];
            }
            count = GR.GetLength(0);
            for (i = 0; i < count; i++)
            {
                _Gitems[i] = GR[i];
            }
        }
    }
}
