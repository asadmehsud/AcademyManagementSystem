using AcademyManagementSystem.BL;
using AcademyManagementSystem.DAL;
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
    public partial class FrmCourse : Form
    {
        public FrmCourse()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtCourseName.Text == "")
            {
                lblExpenseheadName.Text = "required";
            }
            else if(txtCourseDuration.Text=="")
            {
                
            } 
            else if(txtFee.Text=="")
            {
                
            }
            else
            {
                if (CourseId > 0)
                {
                    if (MessageBox.Show("Are you sure!", "conformation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        BlTblCourse obj = new BlTblCourse();
                        obj.CourseName = txtCourseName.Text;
                        obj.CourseDuration = txtCourseDuration.Text;
                        obj.Status = ddlStatus.Text;
                        obj.CourseFee =Convert.ToInt32(txtFee.Text);
                        obj.IsDeleted = false;

                        obj.CourseId = CourseId;
                        if (BlTblCourse.save(obj) == 1)
                        {
                            MessageBox.Show("Updated");
                            DgvList.DataSource = DataAccess.SpGetData("Select * from TblCourse");
                        }
                    }
                }

                else
                {
                    if (MessageBox.Show("Are you sure!", "conformation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        BlTblCourse obj = new BlTblCourse();
                        obj.CourseName = txtCourseName.Text;
                        obj.CourseDuration=txtCourseDuration.Text;
                        obj.Status = ddlStatus.Text;
                        obj.CourseFee = Convert.ToInt32(txtFee.Text);
                        obj.IsDeleted = false;
                        if (BlTblCourse.save(obj) == 1)
                        {
                            MessageBox.Show("Inserted");
                            DgvList.DataSource = DataAccess.SpGetData("Select * from TblCourse");
                        }
                    }
                }
            }

        }

        int CourseId;

        private void DgvList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                CourseId = Convert.ToInt32(DgvList.Rows[e.RowIndex].Cells["CourseId"].Value);
                txtCourseName.Text = Convert.ToString(DgvList.Rows[e.RowIndex].Cells["CourseName"].Value);
                txtCourseDuration.Text = Convert.ToString(DgvList.Rows[e.RowIndex].Cells["CourseDuration"].Value);
            }
            else if (e.ColumnIndex == 0)
            {
                CourseId = Convert.ToInt32(DgvList.Rows[e.RowIndex].Cells["CourseId"].Value);
                DialogResult d = MessageBox.Show("Are you sure", "conformation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (d == DialogResult.Yes)
                {
                    if (BlTblCourse.Delete(CourseId) == 1)
                    {
                        DgvList.DataSource = BlTblCourse.GetData();
                    }
                }
            }
        }

        private void FrmCourse_Load(object sender, EventArgs e)
        {
            DgvList.DataSource = BlTblCourse.GetData();
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            DgvList.DataSource = BlTblFee.Search("FirstName", txtFirstName.Text);
        }
    }
}
        
        
