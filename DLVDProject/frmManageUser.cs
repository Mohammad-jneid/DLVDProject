using DVLDBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLDBusinessLayer;
namespace DLVDProject
{
    public partial class frmManageUser : Form
    {
        public frmManageUser()
        {
            InitializeComponent();
        }
        private void _RefreshContactsList()
        {
            DGVUserList.DataSource = clsUsers.GetData();
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void DGVUserList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmManageUser_Load(object sender, EventArgs e)
        {
            _RefreshContactsList();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
         
        
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdd_UpdateDrivingLicense frmAdd_UdateUser = new frmAdd_UpdateDrivingLicense((int)DGVUserList.CurrentRow.Cells[0].Value);
            frmAdd_UdateUser.ShowDialog();
            _RefreshContactsList();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            frmAdd_UpdateDrivingLicense frmAdd_UdateUser = new frmAdd_UpdateDrivingLicense(-1);
            frmAdd_UdateUser.ShowDialog();  
            _RefreshContactsList();
        }

        /*    private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
            {
                mtbSearch.ReadOnly = string.IsNullOrWhiteSpace(cbFilter.Text);
                mtbSearch.Clear(); // Clear previous search text

                if (cbFilter.Text == "IsActive")
                {
                    cbFilterIsActive.Visible = true;
                    mtbSearch.Visible = false;
                    _IsActriveMode = true;
                }
                else if (cbFilter.Text == "None")
                {
                    cbFilterIsActive.Visible = false;
                    mtbSearch.Visible = false;
                    cbFilterIsActive.Text = "No";
                }
                else
                {
                    cbFilterIsActive.Visible = false;
                    mtbSearch.Visible = true;
                    _IsActriveMode = false;
                }
            }*/

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            mtbSearch.ReadOnly = string.IsNullOrWhiteSpace(cbFilter.Text);
            mtbSearch.Clear(); // Clear previous search text

            if (cbFilter.Text == "IsActive")
            {
                cbFilterIsActive.Visible = true;
                mtbSearch.Visible = false;
                _IsActriveMode = true;
            }
            else if (cbFilter.Text == "None")
            {
                cbFilterIsActive.Visible = false;
                mtbSearch.Visible = false;
                cbFilterIsActive.Text = "No";

                // Clear the filter when 'None' is selected
                if (DGVUserList?.DataSource is DataTable dt)
                {
                    dt.DefaultView.RowFilter = "";
                }
            }
            else
            {
                cbFilterIsActive.Visible = false;
                mtbSearch.Visible = true;
                _IsActriveMode = false;
            }
        }

        bool _IsActriveMode = false;


        private void mtbSearch_TextChanged(object sender, EventArgs e)
        {
            if (cbFilter?.Text == "All" )
            {
                if (DGVUserList?.DataSource is DataTable dtNone)
                {
                    dtNone.DefaultView.RowFilter = ""; // Clear any filters
                }
                return; // Skip filtering
            }

            if (DGVUserList?.DataSource is DataTable dt && !string.IsNullOrWhiteSpace(cbFilter?.Text))
            {
                string columnName = cbFilter.Text;
                string searchText = mtbSearch.Text.Replace("'", "''"); // Escape single quotes

                // Check if the selected column exists
                if (!dt.Columns.Contains(columnName))
                    return;

                Type columnType = dt.Columns[columnName].DataType;

                // Filtering for boolean column (IsActiveMode)
                if (_IsActriveMode)
                {
                    string filterValue = cbFilterIsActive.Text.Trim().ToLower();

                    if (filterValue == "yes")
                        dt.DefaultView.RowFilter = $"[{columnName}] = true";
                    else if (filterValue == "no")
                        dt.DefaultView.RowFilter = $"[{columnName}] = false";
                    else
                        dt.DefaultView.RowFilter = "";

                    return; // Done filtering in boolean mode
                }

                // If no search text, clear the filter
                if (string.IsNullOrWhiteSpace(searchText))
                {
                    dt.DefaultView.RowFilter = "";
                    return;
                }

                // Filtering for other types
                if (columnType == typeof(string))
                {
                    dt.DefaultView.RowFilter = $"[{columnName}] LIKE '%{searchText}%'";
                }
                else
                {
                    dt.DefaultView.RowFilter = $"Convert([{columnName}], 'System.String') LIKE '%{searchText}%'";
                }
            }
        }

        /*        private void mtbSearch_TextChanged(object sender, EventArgs e)
                {

                    if (DGVUserList?.DataSource is DataTable dt && !string.IsNullOrWhiteSpace(cbFilter?.Text))
                    {


                        string columnName = cbFilter.Text;
                        string searchText;
                       //* if (_IsActriveMode)
                        {
                            if (cbFilterIsActive.Text == "yes") searchText = "1";
                            if (cbFilterIsActive.Text == "No") searchText = "0";
                            else searchText = ""; ;
                            // Escape single quotes

                        }//*
                         if (cbFilter.Text == "None")
                            searchText = "";
                         else
                                    searchText = mtbSearch.Text.Replace("'", "''"); // Escape single quotes

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
                        if (string.IsNullOrWhiteSpace(cbFilterIsActive.Text))
                                    return;
                        }

                        // Apply filter based on column type
                        if (_IsActriveMode)
                        {
                            string filterValue = cbFilterIsActive.Text.Trim().ToLower();

                            if (filterValue == "yes")
                                dt.DefaultView.RowFilter = $"[{columnName}] = 1";
                            else if (filterValue == "no")
                                dt.DefaultView.RowFilter = $"[{columnName}] = 0";
                            else
                                dt.DefaultView.RowFilter = "";

                        }
                        else
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
        */

        private void mtbSearch_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void mtbSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilter.Text == "PersonID")
            {
                // Allow control keys (like Backspace), and digits only
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true; // Block the key press
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete User [" + DGVUserList.CurrentRow.Cells[0].Value + "]",
       "Confirm Delete", MessageBoxButtons.OKCancel) == DialogResult.OK)

            {

                //Perform Delele and refresh
                if (clsUsers.DeletedUser((int)DGVUserList.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("User Deleted Successfully.");
                    _RefreshContactsList();
                }

                else
                    MessageBox.Show("User is not deleted.");

            }
            _RefreshContactsList();
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowUserDetails frmShowUserDetails = new frmShowUserDetails((int)DGVUserList.CurrentRow.Cells[0].Value);
            frmShowUserDetails.ShowDialog();    
        }
    }
}
