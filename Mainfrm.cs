﻿using System;
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
    public partial class Mainfrm : Form
    {
        public Mainfrm()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

       /* private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
       */
        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            girlsdashboard dg = new girlsdashboard();
            dg.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            boysdashboard db = new boysdashboard();
            db.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

       /* private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Close();
        }*/

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            logins logins = new logins();
            logins.Show();
            this.Hide();
        }

        private void Mainfrm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
