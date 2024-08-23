using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace boarding__management_system
{
    public partial class booking : Form
    {
        Function2 con;
        public booking()
        {
            con = new Function2();
            InitializeComponent();
        }

        private void booking_Load(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT * FROM girlsRoomPrice";
                DataTable data = con.GetData(query);
                pricelist.DataSource = data;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            
            
                try
                {
                    // Get the room ID entered by the user
                    int roomIdToDelete = Convert.ToInt32(textBox1.Text);

                    // Search for the row with the matching room ID and delete it
                    foreach (DataGridViewRow row in pricelist.Rows)
                    {
                        if (row.Cells["room_Id"].Value != null && Convert.ToInt32(row.Cells["room_Id"].Value) == roomIdToDelete)
                        {
                            pricelist.Rows.Remove(row);
                            MessageBox.Show($"Row with Room ID {roomIdToDelete} deleted successfully.");
                            return; // Exit the method after deleting the row
                        }
                    }

                    // If no row with the specified room ID is found
                    MessageBox.Show($"No row with Room ID {roomIdToDelete} found.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            

        }

        private void pricelist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
