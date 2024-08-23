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
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            logins logins = new logins();
            logins.Show();
            this.Hide();
        }

       /* private void button3_Click(object sender, EventArgs e)
        {
            loginad logina = new loginad();
            logina.Show();
            this.Hide();
        }
       */
        private void bordingownerbtn_Click(object sender, EventArgs e)
        {


            login_bdo loginb = new login_bdo();
            loginb.Show();
            this.Hide();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        /*private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Close();
        }*/
    }
}
