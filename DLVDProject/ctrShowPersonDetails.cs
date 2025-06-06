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
    public partial class ctrShowPersonDetails : UserControl
    {
        public ctrShowPersonDetails()
        {
            InitializeComponent();
        }

        private void ctrShowDetails_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lbEditPerson_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (lbPersonID.Text == "N/A") return;
         /*   frmAdd_UpdatePerson frmAdd_UpdatePerson = new frmAdd_UpdatePerson(Convert.ToInt32(lbPersonID.Text));
            frmAdd_UpdatePerson.ShowDialog();*/
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
