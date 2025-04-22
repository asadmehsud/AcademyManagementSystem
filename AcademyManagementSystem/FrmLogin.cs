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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtEmailUserNameContact.Text == "")
            {
                lblEmailUserNameContact.Text = "Required";
            }
            else if (txtPassword.Text == "")
            {
                lblPassword.Text = "Required";
            }
            else
            {
                DataTable dt = BlTblUser.Login(txtEmailUserNameContact.Text);
                if (dt.Rows.Count > 0)
                {
                    dt = BlTblUser.Login(txtEmailUserNameContact.Text, txtPassword.Text);
                    if (dt.Rows.Count > 0)
                    {
                        //CraetedBy=userid;
                        FrmHome obj = new FrmHome();
                        this.Hide();
                        obj.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Incorrect Password");
                    }
                }
                else
                {
                    MessageBox.Show("Incorrect UserName or Email or Contact");
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmGenerateOtp obj = new FrmGenerateOtp();
            this.Hide();
            obj.ShowDialog();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmChangePassword obj = new FrmChangePassword();
            this.Hide();
            obj.ShowDialog();
        }

        private void txtEmailUserNameContact_TextChanged(object sender, EventArgs e)
        {
            lblEmailUserNameContact.Text = "";
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            lblPassword.Text = "";
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmUserRegistration obj=new FrmUserRegistration();
            this.Hide();
            obj.ShowDialog();
        }
    }
    }

