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
    public partial class Student : Form
    {
        public Student()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void HScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Guardian gg = new Guardian();
            this.Hide();
            gg.ShowDialog();
           
        }

        private void Student_Load(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            DBConnections c = new DBConnections();
            c.Inserts("insert into student ([FirstName],[LastName],[Gender],[DateofBirth],[HomeAddress],[EmailAddress],[PhoneNumber],[EmergencyContactNumber],[BloodGroup],[Religion],[Nationality],[PrimaryLanguage],[BirthPlace]) " +
               "Values('" + fname.Text + "', '" + lname.Text + "', '" + gender.Text + "', '" + Convert.ToDateTime(dob.Text) + "' ,'" + address.Text + "' , '" + email.Text + "','" + textBox1.Text + "','" + em.Text + "','" + blood.Text + "','" + religion.Text + "','" + nationality.Text + "','" + plang.Text + "','" + birthpl.Text + "')");
            Guardian gg = new Guardian();
            this.Hide();
            gg.ShowDialog();
        }

        private void Label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click_1(object sender, EventArgs e)
        {

        }
    }
}
