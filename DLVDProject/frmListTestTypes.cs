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
    public partial class frmListTestTypes : Form
    {
        public frmListTestTypes()
        {
            InitializeComponent();
        }
        void _Refresh()
        {
            DGVManageTestTypesList.DataSource = clsTestTypes.GetData();
        }
        private void frmListTestTypes_Load(object sender, EventArgs e)
        {
            _Refresh();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmUpdateManageTestTypes frmUpdateManageTestTypes = new frmUpdateManageTestTypes((int)DGVManageTestTypesList.CurrentRow.Cells[0].Value);
            frmUpdateManageTestTypes.ShowDialog();
            _Refresh();
        }

        private void DGVPeopleList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
