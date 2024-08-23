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
    
    public partial class farfrom_boys : Form
    {
        Function2 con;
        public farfrom_boys()
        {
            
            InitializeComponent();
            con = new Function2();
        }

        private void farfrom_boys_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Fetch records where far_from > 2
                // String selectQuery = "SELECT * FROM boardings WHERE far_from > 2";
                string farValue = textBox1.Text; // Assuming textBox1 is the TextBox where user inputs far_from value
                String selectQuery = $"SELECT * FROM boys_boarding WHERE far_from < {farValue}";
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
                    String address = rows[i]["Address"].ToString();

                    Label boardingLabel = new Label();
                    boardingLabel.Text = $"Boarding {i + 1}: {boardingName}";
                    boardingLabel.Location = new Point(10, labelTop + (i * (labelHeight + labelMargin)));
                    boardingLabel.Size = new Size(300, labelHeight);

                    Label addressLabel = new Label();
                    addressLabel.Text = $"Address {i + 1}: {address}";
                    addressLabel.Location = new Point(320, labelTop + (i * (labelHeight + labelMargin)));
                    addressLabel.Size = new Size(300, labelHeight);

                    // Add labels to the form
                    this.Controls.Add(boardingLabel);
                    this.Controls.Add(addressLabel);
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

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
