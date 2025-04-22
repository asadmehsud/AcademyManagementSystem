using AcademyManagementSystem.BL;
using AcademyManagementSystem.BlClass;
using AcademyManagementSystem.BlTeacher;
using AcademyManagementSystem.DAL;
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

namespace AcademyManagementSystem
{
    public partial class FrmClass : Form
    {
        public FrmClass()
        {
            InitializeComponent();
            DataTable dt = BlTblClass.GetData();
            DgvList.DataSource = dt;
        }
        int ClassId;
        private void DgvList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                ClassId = Convert.ToInt32(DgvList.Rows[e.RowIndex].Cells["ClassId"].Value);
                txtClassName.Text = Convert.ToString(DgvList.Rows[e.RowIndex].Cells["ClassName"].Value);
            }
            else if (e.ColumnIndex == 1)
            {
                ClassId = Convert.ToInt32(DgvList.Rows[e.RowIndex].Cells["ClassId"].Value);
                DialogResult d = MessageBox.Show("Are you sure", "conformation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (d == DialogResult.Yes)
                {
                    if (BlTblClass.Delete(ClassId) == 1)
                    {
                        DgvList.DataSource = BlTblClass.GetData();
                    }
                }
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            DataTable dt = BlTblClass.DuplicateClassTime(ddlClassTime.Text);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Duplicate Class Time!");
            }
            else if (txtClassName.Text == "")
            {
                lblClassName.Text = "required";
            }
            else
            {
                if (ClassId > 0)
                {
                    if (MessageBox.Show("Are you sure!", "conformation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        BlTblClass obj = new BlTblClass();
                        obj.ClassName = txtClassName.Text;
                        obj.Status = ddlStatus.Text;
                        obj.ClassTime = ddlClassTime.Text;
                        obj.IsDeleted = false;
                        obj.ClassId = ClassId;
                        if (BlTblClass.save(obj) == 1)
                        {
                            MessageBox.Show("Updated");
                            DgvList.DataSource = DataAccess.SpGetData("Select * from TblClass");
                        }
                    }
                }
                else
                {
                    if (MessageBox.Show("Are you sure!", "conformation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        BlTblClass obj = new BlTblClass();
                        obj.ClassName = txtClassName.Text;
                        obj.Status = ddlStatus.Text;
                        obj.ClassTime = ddlClassTime.Text;
                        obj.IsDeleted = false;

                        if (BlTblClass.save(obj) == 1)
                        {
                            MessageBox.Show("Inserted");
                            DgvList.DataSource = DataAccess.SpGetData("Select * from TblClass");
                        }
                    }
                }
            }

        }
    }
}