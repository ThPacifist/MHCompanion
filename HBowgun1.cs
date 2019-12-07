﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterHunterCompanion
{
    public class HBowgun : Gunner
    {
        public string[,] _siegeM;
        int i, k;
        int rowC;

        public HBowgun()
        {

        }
        public HBowgun(string Name, string Desc, string Rarity, int Atk, string Recoil, string Reload, string Deviat, string[,] IntAm, string[,] SiegeM)
        {
            _name = Name;

            _description = Desc;

            _rarity = Rarity;

            _attack = Atk;

            _recoil = Recoil;

            _reload = Reload;

            _deviation = Deviat;

            rowC = IntAm.GetLength(0);
            for (i = 0; i < rowC; i++)
            {
                for (k = 0; k < 3; k++)
                {
                    _intAmmo[i, k] = IntAm[i, k];
                }
            }

            rowC = SiegeM.GetLength(0);
            for (i = 0; i < rowC; i++)
            {
                for (k = 0; k < 3; k++)
                {
                    _siegeM[i, k] = SiegeM[i, k];
                }
            }
        }
        public HBowgun(string Name, string Desc, string Rarity, int Atk, string Recoil, string Reload, string Deviat, int Slots, int Aff, int Def, string[,] IntAm, string[,] SiegeM)
        {
            _name = Name;

            _description = Desc;

            _rarity = Rarity;

            _attack = Atk;

            _recoil = Recoil;

            _reload = Reload;

            _deviation = Deviat;

            //addition parameters
            _slots = Slots;

            _affinity = Aff;

            _defense = Def;

            rowC = IntAm.GetLength(0);
            for(i = 0; i < rowC; i++)
            {
                for(k = 0; k < 3; k++)
                {
                    _intAmmo[i, k] = IntAm[i, k];
                }
            }

            rowC = SiegeM.GetLength(0);
            for(i = 0; i < rowC; i++)
            {
                for(k = 0; k < 3; k++)
                {
                    _siegeM[i, k] = SiegeM[i, k];
                }
            }
        }
    }
}
