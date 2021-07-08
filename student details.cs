using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PROJECTDB
{
    public partial class student_details : Form
    {
        public student_details()
        {
            InitializeComponent();
        }

        private void Student_details_Load(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int val = 0;
            Int32.TryParse(textBox1.Text, out val);

            if (val >= 50 || val <= 0)
            {
                DialogResult result = MessageBox.Show("Please enter a valid Student ID", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.OK)
                {
                    student_details gg = new student_details();
                   
                }
                else
                {
                    this.Close();
                }
            }
            else
            { 
                SqlConnection conn = new SqlConnection(@"Server=DESKTOP-TP8ATKN;Database=myschool;Trusted_Connection=Yes");
                using (SqlCommand cmd = new SqlCommand("select * from student where idstudent='" + textBox1.Text.Trim() + "'"))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = conn;
                    conn.Open();
                    using (SqlDataReader sdr = cmd.ExecuteReader())
                    {
                        sdr.Read();
                        textBox2.Text = sdr["FirstName"].ToString();
                        textBox3.Text = sdr["LastName"].ToString();
                        textBox4.Text = sdr["Gender"].ToString();
                        textBox5.Text = sdr["DateofBirth"].ToString();
                        textBox6.Text = sdr["EmailAddress"].ToString();
                        textBox7.Text = sdr["PhoneNumber"].ToString();
                        textBox8.Text = sdr["HomeAddress"].ToString();
                        textBox9.Text = sdr["EmergencyContactNumber"].ToString();
                    }
                    conn.Close();
                }

            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
       
            this.Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }

        private void Label10_Click(object sender, EventArgs e)
        {

        }
    }
}
