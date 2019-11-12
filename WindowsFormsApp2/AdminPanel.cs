using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class AdminPanel : UserControl
    {
        public AdminPanel()
        {
            InitializeComponent();
        }
        private void AdminPanel_Load(object sender, EventArgs e)
        {
            groupBoxAdd.Visible = true;
            groupBoxEdit.Visible = false;
            groupBoxEdit.Location = new Point(4,95);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            groupBoxAdd.Visible = true;
            groupBoxEdit.Visible = false;
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            groupBoxAdd.Visible = false;
            groupBoxEdit.Visible = true;
        }
    }
}
