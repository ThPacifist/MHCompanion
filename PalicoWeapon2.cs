using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterHunterCompanion
{
    public class PalicoWeapon
    {
        public string _name { get; set; }

        public int _sharpness { get; set; }

        public int _meleeAtk { get; set; }

        public int _rangedAtk { get; set; }

        public int _affinity { get; set; }

        public int _specialAttack { get; set; }

        public string _wType { get; set; }

        public string _wBalance { get; set; }

        public PalicoWeapon()
        {

        }
        public PalicoWeapon(string Name, int Shar, int MA, int RA, int Aff, int SpAtk, string WType, string Wbal)
        {
            _name = Name;

            _sharpness = Shar;

            _meleeAtk = MA;

            _rangedAtk = RA;

            _affinity = Aff;

            _specialAttack = SpAtk;

            _wType = WType;

            _wBalance = Wbal;
        }
    }
}
