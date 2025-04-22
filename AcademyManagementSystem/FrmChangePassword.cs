using AcademyManagementSystem.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcademyManagementSystem
{
    public partial class FrmChangePassword : Form
    {
        public FrmChangePassword()
        {
            InitializeComponent();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            if (txtEmailContact.Text == "")
            {
                MessageBox.Show("Email or Contact required");
            }
            else if (txtPassword.Text == "")
            {
                MessageBox.Show("Password required");
            }
            else if (txtCreateNewPassword.Text == "")
            {
                MessageBox.Show("New Password required");
            }
            else if (txtConfirmPassword.Text == "")
            {
                MessageBox.Show("Confirm your Password");
            }
            else
            {
                if (txtCreateNewPassword.Text != txtConfirmPassword.Text)
                {
                    MessageBox.Show("Re-Confirm your password");
                }
                else
                {
                    DataTable dt = BlTblUser.CheckForChangePassword(txtEmailContact.Text);
                    if (dt.Rows.Count > 0)
                    {
                        dt = BlTblUser.CheckForChangePassword(txtEmailContact.Text, txtPassword.Text);
                        if (dt.Rows.Count > 0)
                        {
                            int check = BlTblUser.UpdatePassword(txtEmailContact.Text, txtCreateNewPassword.Text);
                            if (check>0)
                            {
                                MessageBox.Show("Password changed successfully");
                            }
                            else
                            {
                                MessageBox.Show("Password Updation failed");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Incorrect Password");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Incorrect Email or Contact");
                    }
                }
            }
        }
    }
}

