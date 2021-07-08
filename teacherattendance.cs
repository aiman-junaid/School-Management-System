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
    public partial class teacherattendance : Form
    {
        public teacherattendance()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            DBConnections c = new DBConnections();
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                if(checkedListBox1.GetItemChecked(i) && checkedListBox2.GetItemChecked(i))
                {
                    c.Inserts("insert into TeacherAttendance ([Date], Faculty_idFaculty, Attended, late)  Values('" + Convert.ToDateTime(dateTimePicker1.Text) + "' , (select idfaculty from Faculty where FirstName  = '" + checkedListBox1.Items[i].ToString() + "'),1,1)");
                }
                else if (checkedListBox1.GetItemChecked(i) == false && checkedListBox2.GetItemChecked(i) == false)
                {
                    c.Inserts("insert into TeacherAttendance ([Date], Faculty_idFaculty, Attended, late)  Values('" + Convert.ToDateTime(dateTimePicker1.Text) + "' , (select idfaculty from Faculty where FirstName  = '" + checkedListBox1.Items[i].ToString() + "'),0,0)");
                }
                else if(checkedListBox1.GetItemChecked(i)==true && checkedListBox2.GetItemChecked(i) ==false)
                {
                    c.Inserts("insert into TeacherAttendance ([Date], Faculty_idFaculty, Attended, late)  Values('" + Convert.ToDateTime(dateTimePicker1.Text) + "' , (select idfaculty from Faculty where FirstName  = '" + checkedListBox1.Items[i].ToString() + "'),1,0)");
                }
            }
            this.Close();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void CheckedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CheckedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void Teacherattendance_Load(object sender, EventArgs e)
        {
            DBConnections c = new DBConnections();
            DataTable d = c.Select("select idfaculty,firstname from faculty");
            for (int i = 0; i < d.Rows.Count; i++)
            {
                checkedListBox1.Items.Add(d.Rows[i]["firstname"].ToString());
                checkedListBox2.Items.Add(d.Rows[i]["firstname"].ToString());
            }


        }

        private void CheckedListBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
          
        }

       
    }
}
