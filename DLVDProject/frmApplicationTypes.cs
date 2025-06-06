using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLVDProject
{
    public partial class frmApplicationTypes : Form
    {
        public frmApplicationTypes()
        {
            InitializeComponent();
        }

        void _Refresh()
        {
            DGVApplicationTypesList.DataSource = clsApplicationTypes.GetData();
        }

        private void frmApplicationTypes_Load(object sender, EventArgs e)
        {
            _Refresh();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEditApplicationsTypes frmEditApplicationsTypes = new frmEditApplicationsTypes((int)DGVApplicationTypesList.CurrentRow.Cells[0].Value);
            frmEditApplicationsTypes.ShowDialog();
            _Refresh();
        }

        private void DGVApplicationTypesList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DGVApplicationTypesList_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
