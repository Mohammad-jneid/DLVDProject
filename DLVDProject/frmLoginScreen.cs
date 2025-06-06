using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace DLVDProject
{
    public partial class frmLoginScreen : Form
    {

        List<string> _lines;
        string _FileName = "C:\\Users\\messi\\Desktop\\DLVDProject\\DLVDProject\\LoginInfo.txt"; // Add file extension for clarity  
        public static StreamReader _Reader = null; // Declare as a global variable        }

        public frmLoginScreen()
        {
            InitializeComponent();
        }

       void _Refresh()
        {
                if (File.Exists(_FileName))
                {
                    _lines = new List<string>(File.ReadAllLines(_FileName));
                    if (_lines.Count >= 2)
                    {
                        mtbUserName.Text = _lines[_lines.Count - 2];
                        mtbPassword.Text = _lines[_lines.Count - 1];
                        lbRememberMe.Checked = true;
                    }
                    else
                    {
                        mtbPassword.Text = "";
                        mtbUserName.Text = "";
                    }
                }
        }
   
        private void frmLoginScreen_Load(object sender, EventArgs e)
        {
            _Refresh();     
        }
        void CheckRememberMe()
        {
            if (!lbRememberMe.Checked)//if the checkmark is not ok delete the history
            {
                _lines = new List<string>(File.ReadAllLines(_FileName)); 
                if (_lines.Count == 2)
                {
                    _lines.RemoveAt(0);
                    _lines.RemoveAt(0);
                    File.WriteAllLines(_FileName, _lines);
                }
                return;
            }

                using (StreamWriter writer = new StreamWriter(_FileName, append: true))
                {
                    if (File.Exists(_FileName) )
                    {//Add the new login info
                        writer.WriteLine(mtbUserName.Text);
                        writer.WriteLine(mtbPassword.Text);
                        writer.Close();
                    }
                            _lines = new List<string>(File.ReadAllLines(_FileName));
                        // IsDataSavedBefore();
                        if (_lines.Count == 4)//if count 4 mean that there are old loginfo we must delete it 
                        {
                            _lines.RemoveAt(0);
                            _lines.RemoveAt(0);
                            File.WriteAllLines(_FileName, _lines);
                        }
                }
        }

        private void btnLogIN_Click(object sender, EventArgs e)
        {
            clsUsers User = clsUsers.Find(mtbUserName.Text.ToString(),mtbPassword.Text.ToString());
           if (User != null) // User Found
            {
                if (User.IsActive)
                {
                    CheckRememberMe();
                   clsUsers.LoggedInUserID = User.UserID;
                    frmMainScreen frmMainScreen = new frmMainScreen();
                    frmMainScreen.ShowDialog();
                    _Refresh();//refresh tbUserName and tbPassword

                }
                else
                    MessageBox.Show("This error is not currently active.", "Information");
            }
            else
                MessageBox.Show("Login information is incorrect. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }
}
