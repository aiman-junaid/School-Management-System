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
    public partial class mainpage : Form
    {
        public mainpage()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            StudentAttendance f1 = new StudentAttendance();
            f1.ShowDialog();
            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            teacherattendance f1 = new teacherattendance();
            f1.ShowDialog();
          
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            selectStudentForVoucher f1 = new selectStudentForVoucher();
            f1.ShowDialog();

            this.Close(); 
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            Student gg = new Student();
            gg.Show();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            student_details gg = new student_details();
            gg.Show();
           //this.Hide();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Faculty c = new Faculty();
            c.Show();
           
        }
    }
}
