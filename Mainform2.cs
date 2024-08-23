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
    public partial class Mainform2 : Form
    {
        public Mainform2()
        {
            InitializeComponent();
        }

        private void Mainform2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            newone one = new newone();
            one.Show();
            
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            newone one = new newone();
            one.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            prices prices = new prices();
            prices.Show();
            this.Hide();
        }

       /* private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Close();
        }*/

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            boarding_owner_choice bdoc = new boarding_owner_choice();
            bdoc.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox6_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
