using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Collections.Generic;

using System.Threading.Tasks;
using System.Windows.Forms;
using DVLDBusinessLayer;

namespace DLVDProject
{
    public partial class frmManagePeople : Form
    {
        public frmManagePeople()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DGVPeopleList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void _RefreshContactsList()
        {
            //DGVPeopleList.DataSource = clsPerson.GetData();
            DataTable dt = clsPerson.GetData();
            DGVPeopleList.DataSource = dt;
            
            Lbrecord.Text = clsPerson.GetCount().ToString();
        }

        private void frmManagePeople_Load(object sender, EventArgs e)
        {
            _RefreshContactsList();
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            frmAdd_UpdatePerson frmaddupdatePerson = new frmAdd_UpdatePerson(-1);
            frmaddupdatePerson.ShowDialog();
            _RefreshContactsList();
        }

        private void Lbrecord_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox_Click(object sender, EventArgs e)
        {

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdd_UpdatePerson add_UpdatePerson = new frmAdd_UpdatePerson((int)DGVPeopleList.CurrentRow.Cells[0].Value);
            add_UpdatePerson.ShowDialog();
            _RefreshContactsList();

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete contact [" + DGVPeopleList.CurrentRow.Cells[0].Value + "]",
              "Confirm Delete", MessageBoxButtons.OKCancel) == DialogResult.OK)

            {

                //Perform Delele and refresh
                if (clsPerson.DeletePerson((int)DGVPeopleList.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("Contact Deleted Successfully.");
                    _RefreshContactsList();
                }

                else
                    MessageBox.Show("Contact is not deleted.");

            }
            _RefreshContactsList();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowPersonDetails frmShowDetails = new frmShowPersonDetails(Convert.ToInt32(DGVPeopleList.CurrentRow.Cells[0].Value));
            frmShowDetails.ShowDialog();
        }




        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Enable or disable the search box based on filter selection
            mtbSearch.ReadOnly = string.IsNullOrWhiteSpace(cbFilter.Text);
            mtbSearch.Clear(); // Clear previous search text
        }

        private void mtbSearch_TextChanged(object sender, EventArgs e)
        {

           
            {

            }
        
            if (DGVPeopleList?.DataSource is DataTable dt && !string.IsNullOrWhiteSpace(cbFilter?.Text))
            {

               
                string columnName = cbFilter.Text;
                string searchText = mtbSearch.Text.Replace("'", "''"); // Escape single quotes
                
                // Check if the selected column exists in the DataTable
                if (!dt.Columns.Contains(columnName))
                {
                    return; // Don't filter if the column doesn't exist in the DataTable
                }

                Type columnType = dt.Columns[columnName].DataType;

                // Clear filter if search text is empty
                if (string.IsNullOrWhiteSpace(searchText))
                {
                    dt.DefaultView.RowFilter = ""; // Clear any existing filter
                    return;
                }

                // Apply filter based on column type
                if (columnType == typeof(string))
                {
                    // For string columns, we perform a LIKE operation
                    dt.DefaultView.RowFilter = $"{columnName} LIKE '%{searchText}%'";
                }
                else
                {
                    // For non-string columns, we convert to string and apply LIKE operation
                    dt.DefaultView.RowFilter = $"Convert([{columnName}], 'System.String') LIKE '%{searchText}%'";
                }
            }
        }

        private void mtbSearch_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
          
        }

        private void mtbSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilter.Text == "PersonID" || cbFilter.Text == "NationalityCountryID" || cbFilter.Text == "Phone")
            {
                // Allow control keys (like Backspace), and digits only
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true; // Block the key press
                }
            }
        }
    }
}

