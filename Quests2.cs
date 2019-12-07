using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterHunterCompanion
{
    public class Quests
    {
        public string _type { get; set; }

        public string _name { get; set; }
        
        public string _quest { get; set; }
        
        public int _reward { get; set; }
        
        public int _fee { get; set; }
        
        public string _location { get; set; }

        public  string _monster { get; set; }

        public Quests()
        {

        }
        public Quests(string Name, string Type, string Quest, int rew, int Fee, string Loc, string Mon)
        {
            _type = Type;

            _name = Name;

            _quest = Quest;

            _reward = rew;

            _fee = Fee;

            _location = Loc;

            _monster = Mon;
        }
    }
}
