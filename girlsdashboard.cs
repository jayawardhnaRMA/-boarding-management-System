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
    public partial class girlsdashboard : Form
    {
        public girlsdashboard()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
             openchildform(new far_from());
        }
        private void customdesign()
        {
            submenupnl.Visible = false;
        }
        private void girlsdashboard_Load(object sender, EventArgs e)


        {
            customdesign();
        }
       
        private void showsubmenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                hidesubmenu();
                submenu.Visible = true;
            }
            else { submenu.Visible = false; }

        }
        private void hidesubmenu()
        {
            if (submenupnl.Visible == true)
            {
                submenupnl.Visible = false;
            }


        }
        private Form activeform = null;
        private void openchildform(Form childform)
        {
            if (activeform != null)
            {
                activeform.Close();
            }
            activeform = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            rightpnl.Controls.Add(childform);
            rightpnl.Tag = childform;
            childform.BringToFront();
            childform.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            showsubmenu(submenupnl);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openchildform(new details_g1());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            openchildform(new booking());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            openchildform(new Price_range());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openchildform(new Highfacilities_girls());
        }

        private void rightpnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Mainfrm mainForm = new Mainfrm();
            mainForm.Show();
            this.Hide();
        }
    }
}
