using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonsterHunterCompanion
{
    public partial class MHCompanion : Form
    {
        public MHCompanion()
        {
            InitializeComponent();
        }
        private void TableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Weapons_Click(object sender, EventArgs e)
        {
            
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void MHCompanion_Load(object sender, EventArgs e)
        {
            int[] sharp1 = new int[] { 5, 4, 6 };
            int[] sharp2 = new int[] { 7, 4, 3, 5 };
            int[] sharp3 = new int[] { 5, 7, 4, 7, 7 };
            //Weapon Lists
            List<Greatsword> GSList; //$
            List<Longsword> LSList; //$
            List<Hammer> HMList; //$
            List<HuntingHorn> HHList; //$
            List<Gunlance> GLList; //$
            List<Lance> LList; //$ 
            List<SnS> SNSList; //$
            List<DualBlades> DBList; //$
            List<Switchaxe> SAList; //$
            List<ChargeBlade> CBList; //$
            List<InsectGlaive> IGList; //$
            List<Bow> BowList; //$
            List<HBowgun> HBList;
            List<LBowgun> LBList;

            GSList = new List<Greatsword>
            {
                new Greatsword { _name = "Petrified Blade 1", _description = "First Form", _rarity = "1", _attack = 60,
                    _specialAttack = 0, _affinity = 0, _defense = 0, _slots = 0, _sharpness = sharp1},
                new Greatsword { _name = "Khezu Shock Blade 6", _description = "Final Form", _rarity = "2", _attack = 240,
                    _specialAttack = 40, _affinity = 0, _defense = 0, _slots = 3, _sharpness = sharp2},
                new Greatsword { _name = "Hidden Blade 3", _description = "Made from Nargacuga parts", _rarity = "2", _attack = 150,
                    _specialAttack = 0, _affinity = 30, _defense = 0, _slots = 2, _sharpness = sharp3}
            };

            GSGridview.DataSource = GSList;

            SNSList = new List<SnS>
            {
                new SnS { _name = "Petrified Sword 1", _description = "First Form", _rarity = "1", _attack = 60,
                    _specialAttack = 0, _affinity = 0, _defense = 0, _slots = 0, _sharpness = sharp1},
                new SnS { _name = "Dream Duke Shure 6", _description = "Final Form", _rarity = "2", _attack = 180,
                    _specialAttack = 24, _affinity = 0, _defense = 0, _slots = 1, _sharpness = sharp2},
                new SnS { _name = "Lunatic Briar 3", _description = "Soul of the Old, noble queen", _rarity = "7", _attack = 170,
                    _specialAttack = 40, _affinity = 30, _defense = 0, _slots = 2, _sharpness = sharp3}

            };

            SnSGridview.DataSource = SNSList;

            LSList = new List<Longsword>
            {
                new Longsword { _name = "Petrified Saber 1", _description = "First Form", _rarity = "1", _attack = 60,
                    _specialAttack = 0, _affinity = 0, _defense = 0, _slots = 0, _sharpness = sharp1},
                new Longsword { _name = "Eager Cleaver", _description = "A beautiful blade", _rarity = "2", _attack = 80,
                    _specialAttack = 25, _affinity = 0, _defense = 0, _slots = 0, _sharpness = sharp2},
                new Longsword { _name = "Zealous Sedition 5", _description = "Final Form", _rarity = "6", _attack = 270,
                    _specialAttack = 0, _affinity = 20, _defense = 0, _slots = 2, _sharpness = sharp3}
            };

            LSGridview.DataSource = LSList;

            GLList = new List<Gunlance>
            {
                new Gunlance { _name = "Petrified Gunlance 1", _description = "First Form", _rarity = "1", _attack = 60,
                    _specialAttack = 0, _affinity = 0, _defense = 0, _slots = 0, _sharpness = sharp1,
                    _shellT = "Normal", _shellL = 1},
                new Gunlance { _name = "Flamethrower 1", _description = "Based on Agnaktor Armor", _rarity = "6", _attack = 160,
                    _specialAttack = 34, _affinity = 15, _defense = 0, _slots = 1, _sharpness = sharp2,
                    _shellT = "Long", _shellL = 2},
                new Gunlance { _name = "Imperial Guardlance 7", _description = "Final Form", _rarity = "2", _attack = 280,
                    _specialAttack = 0, _affinity = 0, _defense = 0, _slots = 1, _sharpness = sharp3,
                    _shellT = "Normal", _shellL = 3}
            };

            GLGridview.DataSource = GLList;

            LList = new List<Lance>
            {
                new Lance  { _name = "Petrified Lance 1", _description = "First Form", _rarity = "1", _attack = 60,
                    _specialAttack = 0, _affinity = 0, _defense = 0, _slots = 0, _sharpness = sharp1},
                new Lance { _name = "Chivalric Spear 7", _description = "Ultimate Form", _rarity = "4", _attack = 320,
                    _specialAttack = 0, _affinity = 0, _defense = 0, _slots = 3, _sharpness = sharp2},
                new Lance { _name = "Drill Lance 2", _description = "A Mechanical Lance", _rarity = "2", _attack = 100,
                    _specialAttack = 12, _affinity = 5, _defense = 0, _slots = 0, _sharpness = sharp3}
            };

            LGridview.DataSource = LList;

            CBList = new List<ChargeBlade>
            {
                new ChargeBlade { _name = "Petrified Strongarm 1", _description = "First Form", _rarity = "1", _attack = 60,
                    _specialAttack = 0, _affinity = 0, _defense = 0, _slots = 0, _sharpness = sharp1, _phial = "Impact"},
                new ChargeBlade { _name = "Trios Tristesse 4", _description = "Final Form", _rarity = "5", _attack = 260,
                    _specialAttack = 39, _affinity = -10, _defense = 0, _slots = 3, _sharpness = sharp2, _phial = "Element"},
                new ChargeBlade { _name = "Horror Zofar 3", _description = "Malfestio-inspired design", _rarity = "2", _attack = 120,
                    _specialAttack = 11, _affinity = 0, _defense = 0, _slots = 1, _sharpness = sharp3, _phial = "Impact"}

            };

            CBGridview.DataSource = CBList;

            IGList = new List<InsectGlaive>
            {
                new InsectGlaive { _name = "Petrified Rod 1", _description = "First Form", _rarity = "1", _attack = 60,
                    _specialAttack = 0, _affinity = 0, _defense = 0, _slots = 0, _sharpness = sharp1},
                new InsectGlaive { _name = "Azure Bayonet 1", _description = "Added Velociprey Materials", _rarity = "1", _attack = 80,
                    _specialAttack = 24, _affinity = 0, _defense = 0, _slots = 2, _sharpness = sharp2},
                new InsectGlaive { _name = "Sturdy Glaive 4", _description = "Crafted from bone with Legendary skill", _rarity = "3", _attack = 160,
                    _specialAttack = 0, _affinity = 0, _defense = 0, _slots = 2, _sharpness = sharp3}
            };

            IGGridview.DataSource = IGList;

            string[] noteG1 = new string[] { "Note 1", "Note 2", "Note 3" };
            string[] noteG2 = new string[] { "Note 4", "Note 5", "Note 6" };
            string[] noteG3 = new string[] { "Note 2", "Note 5", "Note 4" };
            HHList = new List<HuntingHorn>
            {
                new HuntingHorn { _name = "Petrified Horn 1", _description = "First Form", _rarity = "1", _attack = 60,
                    _specialAttack = 0, _affinity = 0, _defense = 0, _slots = 0, _sharpness = sharp1, _notes = noteG1},
                new HuntingHorn { _name = "Iron Horn 6", _description = "Musical weapon made of Iron", _rarity = "1", _attack = 140,
                    _specialAttack = 0, _affinity = 0, _defense = 0, _slots = 0, _sharpness = sharp2, _notes = noteG2},
                new HuntingHorn { _name = "Timbral Demolisher 3", _description = "Final Form", _rarity = "6", _attack = 190,
                    _specialAttack = 38, _affinity = 0, _defense = 0, _slots = 1, _sharpness = sharp3, _notes = noteG3}

            };

            HHGridview.DataSource = HHList;

            HMList = new List<Hammer>
            {
                new Hammer { _name = "Petrified Hammer 1", _description = "First Form", _rarity = "1", _attack = 60,
                    _specialAttack = 0, _affinity = 0, _defense = 0, _slots = 0, _sharpness = sharp1},
                new Hammer { _name = "Iron Devil's Soul 5", _description = "Final Form", _rarity = "5", _attack = 240,
                    _specialAttack = 16, _affinity = 0, _defense = 0, _slots = 2, _sharpness = sharp2},
                new Hammer { _name = "Spiked Glory 7", _description = "Final Form", _rarity = "1", _attack = 220,
                    _specialAttack = 0, _affinity = 15, _defense = 0, _slots = 0, _sharpness = sharp3}
            };

            HMGridview.DataSource = HMList;

            SAList = new List<Switchaxe>
            {
                new Switchaxe { _name = "Petrified Axe 1", _description = "First Form", _rarity = "1", _attack = 60,
                    _specialAttack = 0, _affinity = 0, _defense = 0, _slots = 0, _sharpness = sharp1, _phial = "Power"},
                new Switchaxe { _name = "Notched Oppressor 4", _description = "Designed to look like a Zamtrios fang", _rarity = "1", _attack = 80,
                    _specialAttack = 36, _affinity = -10, _defense = 0, _slots = 2, _sharpness = sharp2, _phial = "Element"},
                new Switchaxe { _name = "Diablos Axe 10", _description = "Final Form", _rarity = "1", _attack = 320,
                    _specialAttack = 0, _affinity = 0, _defense = 0, _slots = 2, _sharpness = sharp3, _phial = "Power"}
            };

            SAGridview.DataSource = SAList;

            DBList = new List<DualBlades>
            {
                new DualBlades { _name = "Petrified Daggers 1", _description = "First Form", _rarity = "1", _attack = 60,
                    _specialAttack = 0, _affinity = 0, _defense = 0, _slots = 0, _sharpness = sharp1},
                new DualBlades { _name = "Dios Slicers 1", _description = "Blades coated in an explosive slime", _rarity = "3", _attack = 130,
                    _specialAttack = 12, _affinity = 0, _defense = 0, _slots = 2, _sharpness = sharp2},
                new DualBlades { _name = "Dual Piercers 4", _description = "The claws intimidate prey", _rarity = "1", _attack = 140,
                    _specialAttack = 0, _affinity = 0, _defense = 0, _slots = 2, _sharpness = sharp3}
            };

            DBGridview.DataSource = DBList;

            string[] charge1 = new string[] { "Rapid1", "Rapid1", "Rapid2", "(Spread2)" };
            string[] charge2 = new string[] { "Heavy 3", "Heavy 4", "Pierce 5", "(Pierce 4)" };
            string[] charge3 = new string[] { "Heavy 2", "Pierce 3", "Heavy 3", "Pierce 4" };

            BowList = new List<Bow>
            {
                new Bow { _name = "Petrified Rod 1", _description = "First Form", _rarity = "1", _attack = 60,
                    _specialAttack = 0, _affinity = 0, _defense = 0, _slots = 0, _arc = "Focus", _charges = charge1},
                new Bow { _name = "Ursa Major 6", _description = "Ultimate Form", _rarity = "4", _attack = 340,
                    _specialAttack = 0, _affinity = 0, _defense = 35, _slots = 1, _arc = "Wide", _charges = charge2},
                new Bow { _name = "Brazencord 3", _description = "Made from Uragaan parts", _rarity = "3", _attack = 180,
                    _specialAttack = 0, _affinity = 0, _defense = 0, _slots = 3, _arc = "Wide", _charges = charge3}
            };

            BowGridview.DataSource = BowList;

            string[,] SM1 = new string[1,2] { { "Stone S", "12" } };
            string[,] SM2 = new string[2, 2] { { "Normal S 3", "15" },
                                              { "Pierce S 2", "12" } };
            string[,] SM3 = new string[2, 2] { { "Para S 1", "6" },
                                               { "Exhaust S 1", "6" } };

            string[,] IA1 = new string[1, 3] { { "Stone S", "20", "4" } };
            string[,] IA2 = new string[1, 3] { { "Armor S", "5", "1" } };
            string[,] IA3 = new string[2, 3] { { "Sting S", "30", "3" },
                                               { "Group Recover S", "5", "1" } };

            HBList = new List<HBowgun>
            {
                new HBowgun { _name = "Petrified Rod 1", _description = "First Form", _rarity = "1", _attack = 60,
                    _affinity = 0, _defense = 0, _slots = 0, _reload = "Bel. Ave.", _recoil = "Medium", _deviation = "None", 
                    _siegeM = SM1, _intAmmo = IA1 },
                new HBowgun { _name = "Crab Buster 1", _description = "Daimyo Hermitaur Materials", _rarity = "2", _attack = 110,
                    _affinity = 0, _defense = 35, _slots = 1, _reload = "Bel. Ave.", _recoil = "Medium", _deviation = "None", 
                    _siegeM = SM2, _intAmmo = IA2},
                new HBowgun { _name = "Rapidcaster 1", _description = "Bowgun designed for rapid reloads", _rarity = "4", _attack = 150,
                    _affinity = 0, _defense = 0, _slots = 0, _reload = "V.Fast", _recoil = "Medium", _deviation = "None", 
                    _siegeM = SM3, _intAmmo = IA3}
            };

            HBGridview.DataSource = HBList;

            string[,] RF1 = new string[1, 4] { { "Stone S", "3", "80%", "Short" } };
            string[,] RF2 = new string[2, 4] { { "Water S", "3", "70%", "Short"},
                                               { "Dung S", "2", "100%", "Short"} };
            string[,] RF3 = new string[1, 4] { { "Exhaust S 1", "3", "100%", "Medium" } };

            string[,] IA4 = new string[1, 3] { { "Dung S", "5", "1" } };
            string[,] IA5 = new string[2, 3] { { "Shrapnel S", "30", "3"},
                                               { "Heavy S 1", "6", "1"} };

            LBList = new List<LBowgun>
            {
                new LBowgun { _name = "Petrified Shooter 1", _description = "First Form", _rarity = "1", _attack = 80,
                    _affinity = 0, _defense = 0, _slots = 0, _reload = "Average", _recoil = "Medium", _deviation = "None",
                    _rapidF = RF1, _intAmmo = IA1 },
                new LBowgun { _name = "Sawgun 1", _description = "Like a Kecha Wacha", _rarity = "4", _attack = 170,
                    _affinity = 0, _defense = 35, _slots = 1, _reload = "Average", _recoil = "Medium", _deviation = "None",
                    _rapidF = RF2, _intAmmo = IA4},
                new LBowgun { _name = "Durambarrel 1", _description = "Made from Duramboros parts", _rarity = "6", _attack = 200,
                    _affinity = 0, _defense = 0, _slots = 0, _reload = "Bel. Ave.", _recoil = "Some", _deviation = "None",
                    _rapidF = RF3, _intAmmo = IA5}
            };

            LBGridview.DataSource = LBList;

            /*List<Item> ItemList;

            ItemList = new List<Item>
            {
                new Item( "Potion", "Restores a small amount of Health", 10, 7, "1"),
                new Item("Mega Potion", "Restores a moderate amount of Health", 10, 16, "2"),
                new Item("Pitfall Trap", "A trap for catching certain large monsters.", 1, 230, "3"),
                new Item("Antidote Flute", "Elimates poison in the blood of those who hear it.", 11, 270, "4")
            };

            ItemsGridview.DataSource = ItemList;*/


        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabPage12_Click(object sender, EventArgs e)
        {

        }
    }
}
