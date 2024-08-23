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
    public partial class newone_boys : Form
    {
        Function2 con;
        public newone_boys()
        {
            InitializeComponent();
            con = new Function2();
            shownewone_boys();
        }

        private void newone_boys_Load(object sender, EventArgs e)
        {

        }
        private void shownewone_boys()
        {
            String query = "Select * from boys_boarding";
            boardingboyslist.DataSource = con.GetData(query);
        }

        private void addone_Click(object sender, EventArgs e)
        {
            try
            {
                if (nametb.Text == "" || addresstb.Text == "" || textBox5.Text == "" || phoneno.Text == "")
                {
                    MessageBox.Show("Missing details");
                }
                else
                {
                    String boardingName = nametb.Text;
                    String add = addresstb.Text;

                    String type = textBox3.Text;
                    String owner = textBox5.Text;
                    String no = phoneno.Text;
                    String far = textBox1.Text;
                    // Fixed the query construction and execution
                    //String query = string.Format("INSERT INTO boys_boarding (boarding_name, Address, type, no_of_single_rooms, no_of_sharing_rooms, no_of_triple_rooms, owner_name, phone_no, far_from) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}')",
                    //boardingName, add, type, owner, no, far);
                    string query = string.Format("INSERT INTO boys_boarding (boarding_name, Address, type, owner_name, phone_no, far_from) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')",
                    boardingName, add, type, owner, no, far);
                    con.SetData(query);
                    shownewone_boys();
                    MessageBox.Show(" boarding  added");
                    nametb.Text = "";
                    addresstb.Text = "";
                    textBox1.Text = "";
                     textBox3.Text = "";
                    textBox5.Text = "";
                    phoneno.Text = "";
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (nametb.Text == "" || addresstb.Text == "" || textBox3.Text == "" || textBox5.Text == "" || phoneno.Text == "" || textBox1.Text == "")
                {
                    MessageBox.Show("Missing details");
                }
                else
                {
                    string boardingName = nametb.Text;
                    string address = addresstb.Text;
                    string type = textBox3.Text;
                    string owner = textBox5.Text;
                    string phoneNumber = phoneno.Text;
                    string far = textBox1.Text;

                    string query = string.Format("UPDATE boys_boarding SET Address='{0}', type='{1}', owner_name='{2}', phone_no='{3}', far_from={4} WHERE boarding_name='{5}'",
                                        address, type, owner, phoneNumber, far, boardingName);
                    con.SetData(query);
                    shownewone_boys();
                    MessageBox.Show("Boarding updated successfully.");
                    nametb.Text = "";
                    addresstb.Text = "";
                    textBox3.Text = "";
                    textBox5.Text = "";
                    phoneno.Text = "";
                    textBox1.Text = "";
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void boardingboyslist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void typetb_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void addresstb_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Mainform3 mainform3 = new Mainform3();
            mainform3.Show();
            this.Hide();
        }
    }
}
