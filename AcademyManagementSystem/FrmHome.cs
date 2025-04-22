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
    public partial class FrmHome : Form
    {
        public FrmHome()
        {
            InitializeComponent();
        }

        private void frmUserRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUserRegistration obj=new FrmUserRegistration();
            this.Hide();
            obj.ShowDialog();
        }
    }
}
;