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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
        int Stratpos = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            Stratpos += 1;
            progressBar1.Value = Stratpos;
            percentage_lbl.Text = Stratpos + "%";
            if (progressBar1.Value == 100)
            {
                progressBar1.Value = 0;
                timer1.Stop();
                menu obj = new menu();
                obj.Show();

                this.Hide();

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
