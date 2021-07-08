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
    public partial class Faculty : Form
    {
        public Faculty()
        {
            InitializeComponent();
        }

        private void Faculty_Load(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int val = 0;
            Int32.TryParse(textBox9.Text, out val);

            if (val >= 10 || val <= 0)
            {
                DialogResult result = MessageBox.Show("Please enter a valid Faculty ID", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
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
                using (SqlCommand cmd = new SqlCommand("select * from faculty where idfaculty='" + textBox9.Text.Trim() + "'"))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = conn;
                    conn.Open();
                    using (SqlDataReader sdr = cmd.ExecuteReader())
                    {
                        sdr.Read();
                        textBox1.Text = sdr["FirstName"].ToString();
                        textBox5.Text = sdr["LastName"].ToString();
                        textBox2.Text = sdr["Salary"].ToString();
                        textBox6.Text = sdr["Qualification"].ToString();
                        textBox8.Text = sdr["EmergencyContact"].ToString();
                        textBox4.Text = sdr["ContactNumber"].ToString();
                        textBox3.Text = sdr["Gender"].ToString();
                        textBox7.Text = sdr["Address"].ToString();
                    }
                    conn.Close();
                }

            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
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

        private void Label9_Click(object sender, EventArgs e)
        {

        }

        private void TextBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label8_Click(object sender, EventArgs e)
        {

        }

        private void TextBox9_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
