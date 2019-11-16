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
            GroupBoxAdd.Visible = true;
            GroupBoxEdit.Visible = false;
            GroupBoxMessage.Visible = false;
            GroupBoxEdit.Location = new Point(4,95);
            GroupBoxAdd.Location = new Point(4,95);
            GroupBoxMessage.Location = new Point(4,95);
            GroupBoxAdd.Size = new Size(569, 460);
            GroupBoxEdit.Size = new Size(569, 460);
            GroupBoxMessage.Size = new Size(569, 460);
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            GroupBoxAdd.Visible = true;
            GroupBoxEdit.Visible = false;
            GroupBoxMessage.Visible = false;
            GroupBoxEdit.Size = new Size(569, 460);
        }

        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            GroupBoxAdd.Visible = false;
            GroupBoxMessage.Visible = false;
            GroupBoxEdit.Visible = true;
            GroupBoxEdit.Size = new Size(569, 560);

        }

        private void ButtonMessage_Click(object sender, EventArgs e)
        {
            GroupBoxAdd.Visible = false;
            GroupBoxEdit.Visible = false;
            GroupBoxMessage.Visible = true;
            GroupBoxEdit.Size = new Size(569, 460);
        }
    }
}
