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
    public partial class frmUpdateManageTestTypes : Form
    {
        clsTestTypes _TestTypes ;
        int _TestTypeID;
        public frmUpdateManageTestTypes(int TestTypeID)
        {
            InitializeComponent();
            _TestTypeID = TestTypeID;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void frmUpdateManageTestTypes_Load(object sender, EventArgs e)
        {
            _TestTypes = clsTestTypes.Find(_TestTypeID  );
            mtbFees.Text = _TestTypes.TestTypeFees.ToString();
            mtbTitle.Text = _TestTypes.TestTypeTitle.ToString();    
            lbID.Text = _TestTypeID.ToString();
            lbDescriptions.Text = _TestTypes.TestTypeDescription.ToString();
        }

        private void mtbFees_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // ❌ Block the key press
            }
        }

        private void lbSave_Click(object sender, EventArgs e)
        {
            _TestTypes.TestTypeTitle = mtbTitle.Text;
            _TestTypes.TestTypeFees = Convert.ToDouble(mtbFees.Text);
            if (_TestTypes.Save())
            {
                MessageBox.Show("Test Type saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed to save the Test Type. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
