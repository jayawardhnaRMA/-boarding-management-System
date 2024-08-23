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
    public partial class Price_range_boys : Form
    {
        Function2 con;
        public Price_range_boys()
        {
            InitializeComponent();
            con = new Function2();
        }

        private void Price_range_boys_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string Value = textBox1.Text; // Assuming textBox1 is the TextBox where user inputs far_from value
                String selectQuery = $"SELECT * FROM boysRoomPrice WHERE room_price < {Value}";
                DataTable resultTable = con.GetData(selectQuery);

                // Debugging: Output the number of rows retrieved
                Console.WriteLine($"Number of rows retrieved: {resultTable.Rows.Count}");

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
                    String roomId = rows[i]["room_Id"].ToString();
                    String boardingName = rows[i]["boarding_name"].ToString();

                    Label boardingLabel = new Label();
                    boardingLabel.Text = $"Room Id {i + 1}: {roomId}";
                    boardingLabel.Location = new Point(10, labelTop + (i * (labelHeight + labelMargin)));
                    boardingLabel.Size = new Size(100, labelHeight);

                    Label nameLabel = new Label();
                    nameLabel.Text = $"Boarding {i + 1}: {boardingName}";
                    nameLabel.Location = new Point(10, labelTop + (i * (labelHeight + labelMargin)));
                    nameLabel.Size = new Size(300, labelHeight);
                    // Calculate the dynamic location for nameLabel
                    int nameLabelTop = boardingLabel.Bottom + labelMargin;
                    nameLabel.Location = new Point(10, nameLabelTop);

                    // Update labelTop for the next iteration
                    labelTop = nameLabel.Bottom + labelMargin;


                    // Add labels to the form
                    this.Controls.Add(boardingLabel);
                    this.Controls.Add(nameLabel);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }

