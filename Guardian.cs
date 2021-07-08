using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJECTDB
{
    public partial class Guardian : Form
    {
        public Guardian()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
            Guardian gg = new Guardian();
            this.Hide();
            gg.ShowDialog();        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Sibling_and_Emergency_Information gg = new Sibling_and_Emergency_Information();
            this.Hide();
            gg.ShowDialog();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Student gg = new Student();
            this.Hide();
            gg.ShowDialog();
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            DBConnections c = new DBConnections();
            c.Inserts("insert into guardian (Student_idStudent, gname, gaddress, phonenumber, relationshipwithstudent, Cnic, office, education) " +
              "Values((select max(idStudent) from student), '" + gname.Text + "', '" + address.Text + "', '" + phone.Text + "' ,'" + textBox1.Text + "' , '" + cnic.Text + "','" + office.Text + "','" + education.Text + "')");


            Sibling_and_Emergency_Information gg = new Sibling_and_Emergency_Information();
            this.Hide();
            gg.ShowDialog();
        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void Label9_Click(object sender, EventArgs e)
        {

        }

        private void Label14_Click(object sender, EventArgs e)
        {

        }

        private void Label15_Click(object sender, EventArgs e)
        {

        }

        private void Label11_Click(object sender, EventArgs e)
        {

        }

        private void Guardian_Load(object sender, EventArgs e)
        {

        }

        private void Label13_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
