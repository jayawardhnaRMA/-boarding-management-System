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
    public partial class signin_stu : Form
    {
        private Function function;

        public signin_stu()
        {
            InitializeComponent();
            function = new Function();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text.Trim();
            string password = textBox2.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                string checkQuery = "SELECT COUNT(*) FROM Users WHERE Username = @Username";
                DataTable checkResult = function.GetData(checkQuery, "@Username", username);
                int count = Convert.ToInt32(checkResult.Rows[0][0]);

                if (count > 0)
                {
                    MessageBox.Show("Username already exists. Please choose a different username.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string insertQuery = "INSERT INTO Users (Username, Password) VALUES (@Username, @Password)";
                int rowsAffected = function.SetData(insertQuery, "@Username", username, "@Password", password);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Mainfrm mainForm = new Mainfrm();
                    mainForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Registration failed. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void signin_stu_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            menu obj = new menu();
            obj.Show();

            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
