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
    public partial class FrmForgetPassword : Form
    {
        public FrmForgetPassword()
        {
            InitializeComponent();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            if (txtOTP.Text=="")
            {
                MessageBox.Show("Enter OTP");
            }
            else if (txtCreatePassword.Text=="")
            {
                MessageBox.Show("Create Password");
            } 
            else if (txtConfirmPassword.Text=="")
            {
                MessageBox.Show("Confirm your Password");
            }
            else
            {
                if (txtCreatePassword.Text!=txtConfirmPassword.Text)
                {
                    MessageBox.Show("Re-confirm your password");
                }
                else
                {
                    DataTable dt = BlTblUser.CheckOTP(FrmGenerateOtp.Email, txtOTP.Text);
                    if (dt.Rows.Count>0)
                    {
                        int check = BlTblUser.UpdatePassword(FrmGenerateOtp.Email,txtCreatePassword.Text);
                        if (check == 1)
                        {
                            MessageBox.Show("Password updated successfully");
                        }
                        else
                        {
                            MessageBox.Show("Password Updation failed");
                        }
                    }
                }
            }
        }
    }
}
