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
    public partial class StudentAttendance : Form
    {
        List<string> Students = new List<string>();
        public StudentAttendance()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            if (comboBox1.Text == "Montessori")
            {
                DBConnections c = new DBConnections();
                DataTable d = c.Select("select firstname from student");

                checkedListBox1.DataSource = d;
            }
            else if (comboBox1.Text == "Prep-I")
            {
                checkedListBox1.Items.Clear();
                Students.Clear();
                Students.Add("Darrell Torres");
                Students.Add("Jadyn Branch");
                Students.Add("Bailee Bowen");
                Students.Add("Kaila Knight");
                Students.Add("Raphael Cowan");
                Students.Add("Oswaldo Cisneros");
                for (int i = 0; i < Students.Count; i++)
                {
                    checkedListBox1.Items.Add(Students[i]);
                }
            }
            else if (comboBox1.Text == "Prep-II")
            {
                checkedListBox1.Items.Clear();
                Students.Clear();
                Students.Add("Alyvia Harrell");
                Students.Add("Dominik Peck");
                Students.Add("Ernest Huff");
                Students.Add("Adolfo Davenport");
                Students.Add("Carleigh Barrera");
                Students.Add("Ryder Holland");
                for (int i = 0; i < Students.Count; i++)
                {
                    checkedListBox1.Items.Add(Students[i]);
                }
            }
            else if (comboBox1.Text == "One")
            {
                checkedListBox1.Items.Clear();
                Students.Clear();
                Students.Add("Kaylah Moss");
                Students.Add("Allie Roberts");
                Students.Add("Deacon Wood");
                Students.Add("Chaim Cohen");
                Students.Add("Rigoberto Dunn");
                for (int i = 0; i < Students.Count; i++)
                {
                    checkedListBox1.Items.Add(Students[i]);
                }
            }
            else if (comboBox1.Text == "Two")
            {
                checkedListBox1.Items.Clear();
                Students.Clear();
                Students.Add("Raven Cuevas");
                Students.Add("Jimena Hopkins");
                Students.Add("Joselyn Ball");
                Students.Add("Makhi Lloyd");
                Students.Add("Angelique Ellison");
                for (int i = 0; i < Students.Count; i++)
                {
                    checkedListBox1.Items.Add(Students[i]);
                }
            }
            else if (comboBox1.Text == "Three")
            {
                checkedListBox1.Items.Clear();
                Students.Clear();
                Students.Add("Landin Washington");
                Students.Add("Kallie Bradley");
                Students.Add("Elian Peterson");
                Students.Add("Lilyana Mcpherson");
                Students.Add("Christine Mathis");
                for (int i = 0; i < Students.Count; i++)
                {
                    checkedListBox1.Items.Add(Students[i]);
                }
            }
            else if (comboBox1.Text == "Four")
            {
                checkedListBox1.Items.Clear();
                Students.Clear();
                Students.Add("Darrell Torres");
                Students.Add("Jadyn Branch");
                Students.Add("Bailee Bowen");
                Students.Add("Kaila Knight");
                Students.Add("Raphael Cowan");
                Students.Add("Oswaldo Cisneros");
                for (int i = 0; i < Students.Count; i++)
                {
                    checkedListBox1.Items.Add(Students[i]);
                }
            }
            else if (comboBox1.Text == "Five")
            {
                checkedListBox1.Items.Clear();
                Students.Clear();
                Students.Add("Landin Washington");
                Students.Add("Kallie Bradley");
                Students.Add("Elian Peterson");
                Students.Add("Lilyana Mcpherson");
                Students.Add("Christine Mathis");
                for (int i = 0; i < Students.Count; i++)
                {
                    checkedListBox1.Items.Add(Students[i]);
                }
            }
            else if (comboBox1.Text == "Six")
            {
                checkedListBox1.Items.Clear();
                Students.Clear();
                Students.Add("Kaylah Moss");
                Students.Add("Allie Roberts");
                Students.Add("Deacon Wood");
                Students.Add("Chaim Cohen");
                Students.Add("Rigoberto Dunn");
                for (int i = 0; i < Students.Count; i++)
                {
                    checkedListBox1.Items.Add(Students[i]);
                }
            }
            else if (comboBox1.Text == "Seven")
            {
                checkedListBox1.Items.Clear();
                Students.Clear();
                Students.Add("Kaylie Moss");
                Students.Add("Leena Khan");
                Students.Add("Maheen Fatima");
                Students.Add("Cara Chloe");
                Students.Add("Melinda Funn");
                for (int i = 0; i < Students.Count; i++)
                {
                    checkedListBox1.Items.Add(Students[i]);
                }
            }
            else if (comboBox1.Text == "Eight")
            {
                checkedListBox1.Items.Clear();
                Students.Clear();
                Students.Add("Marie Khan");
                Students.Add("Kylie Kloss");
                Students.Add("Peter Parker");
                Students.Add("Andrew Brew");
                Students.Add("Nicholas Cage");
                for (int i = 0; i < Students.Count; i++)
                {
                    checkedListBox1.Items.Add(Students[i]);
                }
            }
            else if (comboBox1.Text == "Nine")
            {
                checkedListBox1.Items.Clear();
                Students.Clear();
                Students.Add("Clark Kent");
                Students.Add("Red Blue");
                Students.Add("Paige Louis");
                Students.Add("Wes Anderson");
                Students.Add("Quentin Tarrantino");
                for (int i = 0; i < Students.Count; i++)
                {
                    checkedListBox1.Items.Add(Students[i]);
                }
            }
            else if (comboBox1.Text == "Ten")
            {
                checkedListBox1.Items.Clear();
                Students.Clear();
                Students.Add("Rija Sultan");
                Students.Add("Maham Raheel");
                Students.Add("Aqsa Tariq");
                Students.Add("Subata Khubaib");
                Students.Add("Mamoona Khan");
                Students.Add("Sabah Iqbal");
                for (int i = 0; i < Students.Count; i++)
                {
                    checkedListBox1.Items.Add(Students[i]);
                }
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button3_Click(object sender, EventArgs e)
        {

        }

        private void StudentAttendance_Load(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DBConnections c = new DBConnections();
            DataTable d = c.Select("select idclass, classname from class");
            comboBox1.DisplayMember = "classname";
            comboBox1.ValueMember = "idclass";
            comboBox1.DataSource = d.Columns[1];

        }

        private void CheckedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DBConnections c = new DBConnections();
            DataTable d = c.Select("select firstname from student");
            //checkedListBox1.Items.Add(d);
        }
    }
}
