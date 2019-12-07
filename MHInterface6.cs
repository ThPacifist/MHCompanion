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
            List<Greatsword> GSList;
            List<Longsword> LSList;
            List<Hammer> HMList;
            List<HuntingHorn> HHList;
            List<Gunlance> GLList;
            List<Lance> LCList;
            List<SnS> SNSList;
            List<DualBlades> DBList;
            List<Switchaxe> SAList;
            List<ChargeBlade> CBList;
            List<InsectGlaive> IGList;
            List<Bow> BowList;

            GSList = new List<Greatsword>
            {
                new Greatsword { _name = "Petrified Blade 1", _description = "sjdkandk", _rarity = "1", _attack = 60,
                    _specialAttack = 0, _affinity = 0, _defense = 0, _slots = 0, _sharpness = sharp1},
                new Greatsword { _name = "Khezu Shock Blade 6", _description = "Final Form", _rarity = "2", _attack = 240,
                    _specialAttack = 40, _affinity = 0, _defense = 0, _slots = 3, _sharpness = sharp2},
                new Greatsword { _name = "Hidden Blade 3", _description = "Made from Nargacuga parts", _rarity = "2", _attack = 150,
                    _specialAttack = 0, _affinity = 30, _defense = 0, _slots = 2, _sharpness = sharp3}
            };

            GSGridview.DataSource = GSList;
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
