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
    public partial class frmMainScreen : Form
    {
        public frmMainScreen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {   }

        private void frmMainScreen_Load(object sender, EventArgs e)
        {

        }

  
     

        private void signOutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void usersToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmManageUser users = new frmManageUser();
            users.ShowDialog();
        }

        private void peopleToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmManagePeople managePeople = new frmManagePeople();
            managePeople.ShowDialog();

        }

        private void msAccountSetting_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChangePassword frmChangePassword = new frmChangePassword(clsUsers.LoggedInUserID);
            frmChangePassword.ShowDialog(); 
        }

        private void changeUserInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowUserDetails frm = new frmShowUserDetails(clsUsers.LoggedInUserID);
            frm.ShowDialog();


        }

        private void applicationTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmApplicationTypes frmApplicationTypes = new frmApplicationTypes();
            frmApplicationTypes.ShowDialog();
        }

        private void manageTestTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListTestTypes frmListTestTypes = new frmListTestTypes();
            frmListTestTypes.ShowDialog();
        }

        private void drivingLicensToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
