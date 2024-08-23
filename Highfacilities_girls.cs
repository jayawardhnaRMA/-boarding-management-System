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
    public partial class Highfacilities_girls : Form
    {
        Function2 con;
        public Highfacilities_girls()
        {
            con = new Function2();
            InitializeComponent();
        }

        private void Highfacilities_girls_Load(object sender, EventArgs e)
        {
            try
            {
                string selectQuery = $"SELECT * FROM girlsRoomPrice WHERE count_of_room_members=1";
                DataTable resultTable = con.GetData(selectQuery);

                ClearLabels();

                int labelHeight = 30;
                int labelMargin = 5;
                int labelTop = 10;

                for (int i = 0; i < resultTable.Rows.Count; i++)
                {
                    string boardingName = resultTable.Rows[i]["boarding_name"].ToString();
                    string phoneno = resultTable.Rows[i]["phone_no"].ToString();

                    Label boardingLabel = new Label();
                    boardingLabel.Text = $"Boarding {i + 1}: {boardingName}";
                    boardingLabel.Location = new Point(10, labelTop + (i * (labelHeight + labelMargin)));
                    boardingLabel.Size = new Size(300, labelHeight);

                    Label phonenoLabel = new Label();
                    phonenoLabel.Text = $"phoneno {i + 1}: {phoneno}";
                    phonenoLabel.Location = new Point(320, labelTop + (i * (labelHeight + labelMargin)));
                    phonenoLabel.Size = new Size(300, labelHeight);

                    this.Controls.Add(boardingLabel);
                    this.Controls.Add(phonenoLabel);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void ClearLabels()
        {
            foreach (Control control in this.Controls.OfType<Label>().ToArray())
            {
                this.Controls.Remove(control);
                control.Dispose();
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    
}
