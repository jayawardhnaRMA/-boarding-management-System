using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace boarding__management_system
{
    public partial class Mainform3 : Form
    {
        public Mainform3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            newone_boys newboys = new newone_boys();
            newboys.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            priceboys boys = new priceboys();
            boys.Show();
            this.Hide();
        }

        /*private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Close();
        }*/

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            boarding_owner_choice bdoc = new boarding_owner_choice();
            bdoc.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
