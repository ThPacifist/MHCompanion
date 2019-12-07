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

            GSList = new List<Greatsword>
            {
                new Greatsword { _name = "Petrified Blade 1", _description = "sjdkandk", _rarity = "1", _attack = 60},
                new Greatsword { _name = "Khezu Shock Blade 6", _description = "Final Form", _rarity = "2", _attack = 240,
                    _specialAttack = 40, _affinity = 0, _defense = 0, _slots = 3, },
                new Greatsword { _name = "Hidden Blade 3", _description = "Made from Nargacuga parts", _rarity = "2", _attack = 150,
                    _specialAttack = 0, _affinity = 30, _defense = 0, _slots = 2}
            };
            GSGridview.DataSource = GSList;
        }

        private void vScrollBar1_ValueChanged(object sender, EventArgs e)
        {
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void vScrollBar1_Scroll_1(object sender, ScrollEventArgs e)
        {

        }
    }
}
