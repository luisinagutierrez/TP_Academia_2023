using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIDesktop
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void registrarseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserSignUp frmUserSp = new frmUserSignUp();
            frmUserSp.ShowDialog();
        }

        private void especialidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSpecialitiesList frmSpecialitiesList = new frmSpecialitiesList();
            frmSpecialitiesList.ShowDialog();
        }

        private void msMain_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
