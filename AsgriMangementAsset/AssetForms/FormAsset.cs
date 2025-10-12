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
using ManagementDataLayer.Repositories;
using ManagementDataLayer.Services;

namespace AsgriMangementAsset.AssetForms
{
    public partial class FormAsset : Form
    {
        IAssetRepository assetRepository;
        public FormAsset()
        {
            InitializeComponent();
            assetRepository = new  AssetRepository();
        }
        private void FormAsset_Load(object sender, EventArgs e)
        {
            DataTable dtTitle = assetRepository.SelectAll().DefaultView.ToTable(true, "AssetTitle");
            cmbTitle.Items.Clear();
            cmbTitle.Items.Add("مقدار مورد نظر را انتخاب کنید");
            foreach (DataRow row in dtTitle.Rows)
            {
                cmbTitle.Items.Add(row["AssetTitle"].ToString());
            }
            cmbTitle.SelectedIndex = 0;
            BindGrid();
        }
        private void FilterGrid()
        {
            string Title = cmbTitle.Text;

            if (Title != "مقدار مورد نظر را انتخاب کنید")
            {
                dgAsset.DataSource = assetRepository.Filter(Title);
                ConvertDatesToShamsi();
            }
        }
        private void BindGrid()
        {
            dgAsset.AutoGenerateColumns = false;
            dgAsset.DataSource = assetRepository.SelectAll();
            dgAsset.Columns[0].Visible = false;
            ConvertDatesToShamsi();

        }

        private void dgAsset_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            frmAddoredit frm = new frmAddoredit();
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                BindGrid();
            }
        }

        private void btnDelet_Click(object sender, EventArgs e)
        {
            if(dgAsset.CurrentRow != null)
            {
                string Code = dgAsset.CurrentRow.Cells[1].Value.ToString();
                string Title = dgAsset.CurrentRow.Cells[3].Value.ToString();
                if (RtlMessageBox.Show($"آیا از حذف امول با کد   {Code}   و با عنوان   {Title}   مطمئن هستید.", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int AssetLabelNumber = int.Parse(dgAsset.CurrentRow.Cells [0].Value.ToString());
                    assetRepository.Delete(AssetLabelNumber);
                    BindGrid();
                }
            }
            else
            {
                RtlMessageBox.Show("برای حذف اموال مورد نظر یک رکود را در جدول زیر انتخاب فرمایید","",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgAsset.CurrentRow != null)
            {
                string Code = dgAsset.CurrentRow.Cells[1].Value.ToString();
                string Title = dgAsset.CurrentRow.Cells[3].Value.ToString();
                int AssetLabelNumber = int.Parse(dgAsset.CurrentRow.Cells[0].Value.ToString());
                frmAddoredit frmEdit = new frmAddoredit();
                frmEdit.AssetLableNumber = AssetLabelNumber;
                if (RtlMessageBox.Show($"آیا از حذف امول با کد   {Code}   و با عنوان   {Title}   مطمئن هستید.", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    frmEdit.ShowDialog();
                    BindGrid();
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dgAsset.DataSource = assetRepository.Search(txtSearch.Text);
        }
        private void ConvertDatesToShamsi()
        {
            foreach (DataGridViewRow row in dgAsset.Rows)
            {
                if (row.Cells["Date"].Value != null && DateTime.TryParse(row.Cells["Date"].Value.ToString(), out DateTime assetDate))
                {
                    row.Cells["Date"].Value = assetDate.ToSahmsi();
                }
                if (row.Cells["DateEdit"].Value != null && DateTime.TryParse(row.Cells["DateEdit"].Value.ToString(), out DateTime AssetEditDate))
                {
                    row.Cells["DateEdit"].Value = AssetEditDate.ToSahmsi();
                }
            }
        }

        private void cmbTitle_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterGrid();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("AssetCode");
            dt.Columns.Add("Status");
            dt.Columns.Add("AssetTitle");
            dt.Columns.Add("AssetCompany");
            dt.Columns.Add("AssetCountry");
            dt.Columns.Add("AssetPrice");
            dt.Columns.Add("AssetColor");
            dt.Columns.Add("AssetModel");
            dt.Columns.Add("AssetSize");
            dt.Columns.Add("AssetDate");
            dt.Columns.Add("AssetEditDate");


            foreach (DataGridViewRow item in dgAsset.Rows)
            {
                dt.Rows.Add(
                    item.Cells[1].Value.ToString(),
                    item.Cells[2].Value.ToString(),
                    item.Cells[3].Value.ToString(),
                    item.Cells[4].Value.ToString(),
                    item.Cells[5].Value.ToString(),
                    item.Cells[6].Value.ToString(),
                    item.Cells[7].Value.ToString(),
                    item.Cells[8].Value.ToString(),
                    item.Cells[9].Value.ToString(),
                    item.Cells[10].Value.ToString(),
                    item.Cells[11].Value.ToString()
                    );
            }
            stiReports.Load(Application.StartupPath + "/Report.mrt");
            stiReports.RegData("DT", dt);
            stiReports.Show();
        }
    }
}
