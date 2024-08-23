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
    public partial class Highfacilities_boys : Form
    {
        Function2 con;
        public Highfacilities_boys()
        {
            InitializeComponent();
            con = new Function2();
        }

        private void Highfacilities_boys_Load(object sender, EventArgs e)
        {
            try
            {
                // Fetch records where far_from > 2
                // String selectQuery = "SELECT * FROM boardings WHERE far_from > 2";
                // Assuming textBox1 is the TextBox where user inputs far_from value
                String selectQuery = $"SELECT * FROM boysRoomPrice WHERE count_of_room_members=1";
                DataTable resultTable = con.GetData(selectQuery);

                // Convert the DataTable to an array
                DataRow[] rows = resultTable.Select();

                int labelHeight = 30; // Height of each label
                int labelMargin = 5; // Margin between labels
                int labelTop = 10; // Initial top position of labels

                // Clear existing labels if any
                ClearLabels();

                // Create and display labels for each record
                for (int i = 0; i < rows.Length; i++)
                {
                    String boardingName = rows[i]["boarding_name"].ToString();
                    String phoneno = rows[i]["phone_no"].ToString();

                    Label boardingLabel = new Label();
                    boardingLabel.Text = $"Boarding {i + 1}: {boardingName}";
                    boardingLabel.Location = new Point(10, labelTop + (i * (labelHeight + labelMargin)));
                    boardingLabel.Size = new Size(300, labelHeight);

                    Label phonenoLabel = new Label();
                    phonenoLabel.Text = $"phoneno {i + 1}: {phoneno}";
                    phonenoLabel.Location = new Point(320, labelTop + (i * (labelHeight + labelMargin)));
                    phonenoLabel.Size = new Size(300, labelHeight);

                    // Add labels to the form
                    this.Controls.Add(boardingLabel);
                    this.Controls.Add(phonenoLabel);
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }

            // Method to clear existing labels on the form
            void ClearLabels()
            {
                foreach (Control control in this.Controls)
                {
                    if (control is Label)
                    {
                        this.Controls.Remove(control);
                        control.Dispose();
                    }
                }
            }



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
