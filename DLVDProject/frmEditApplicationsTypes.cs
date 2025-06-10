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
    public partial class frmEditApplicationsTypes : Form   
    {
        int _ApplicationTypeID; 
        public frmEditApplicationsTypes(int ApplicationTypeID)
        {
            InitializeComponent();
            _ApplicationTypeID = ApplicationTypeID;
        }

        private void frmEditApplicationsTypes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // ❌ Block the key press
            }
        }
        clsApplicationTypes _ApplicationTypes;
        private void frmEditApplicationsTypes_Load(object sender, EventArgs e)
        {
            _ApplicationTypes = clsApplicationTypes.Find(_ApplicationTypeID);
            mtbFees.Text = _ApplicationTypes.ApplicationFees.ToString();
            mtbTitle.Text = _ApplicationTypes.ApplicationTypeTitle.ToString();
            lbID.Text = _ApplicationTypes.ApplicationTypeID.ToString();
        }

        private void lbSave_Click(object sender, EventArgs e)
        {
            _ApplicationTypes.ApplicationFees =Convert.ToInt32(mtbFees.Text);
            _ApplicationTypes.ApplicationTypeTitle = mtbTitle.Text;
             _ApplicationTypes.ApplicationFees = Convert.ToDouble(mtbFees.Text);
            if (_ApplicationTypes.Save())
            {
                MessageBox.Show("Application Type saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed to save the Application Type. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
         }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
