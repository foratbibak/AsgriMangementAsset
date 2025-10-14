using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Accounting.utility.Convertor;
using AsgriMangementAsset.AssetForms;
using ManagementDataLayer.Repositories;
using ManagementDataLayer.Services;
using Stimulsoft.Controls.Win.DotNetBar.Validator;

namespace AsgriMangementAsset
{
    public partial class FormAsli : Form
    {
        public FormAsli()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            FormAsset frm = new FormAsset();
            frm.ShowDialog();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            frmReports frm = new frmReports();
            frm.ShowDialog();
        }
        private void btnClearReports_Click(object sender, EventArgs e)
        {

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

        }

        private void btnManager_Click(object sender, EventArgs e)
        {
            LoginManagement frm = new LoginManagement();
            frm.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
           Close();
        }
    }
}