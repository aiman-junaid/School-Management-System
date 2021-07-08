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
    public partial class selectStudentForVoucher : Form
    {
        public selectStudentForVoucher()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Voucher gg = new Voucher();
            this.Hide();
            gg.ShowDialog();
        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            DBConnections c = new DBConnections();
            DataTable d = c.Select("select idclass, classname from class");
            comboBox2.DisplayMember = "classname";
            comboBox2.ValueMember = "idclass";
            comboBox2.DataSource = d.Columns[1];
        }
    }
}
