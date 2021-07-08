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
    public partial class Sibling_and_Emergency_Information : Form
    {
        public Sibling_and_Emergency_Information()
        {
            InitializeComponent();
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void TableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Guardian gg = new Guardian();
            this.Hide();
            gg.ShowDialog();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
           
        }

        private void TableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Guardian gg = new Guardian();
            this.Hide();
            gg.ShowDialog();
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
