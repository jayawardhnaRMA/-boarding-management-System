﻿using System;
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
    public partial class priceboys : Form
    {
        Function2 con;
        public priceboys()
        {
            InitializeComponent();
            con = new Function2();
            showprice();
        }
        private void showprice()
        {
            String query = "Select * from boysRoomPrice";
            pricelist2.DataSource = con.GetData(query);
        }
        private void priceboys_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "" || textBox2.Text == "")
                {
                    MessageBox.Show("Missing details");
                }
                else
                {

                    String price = textBox1.Text;
                    String members = textBox2.Text;
                    String name = textBox3.Text;
                    String no = textBox4.Text;

                    // Fixed the query construction and execution
                    String query = string.Format("INSERT INTO boysRoomPrice (room_price,count_of_room_members,boarding_name,phone_no) VALUES ('{0}', '{1}' ,'{2}' ,'{3}')", price, members, name, no);
                    con.SetData(query);
                    showprice();
                    MessageBox.Show(" room added");

                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";

                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }

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
