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

namespace AsgriMangementAsset
{
    public partial class frmReports : Form
    {
        IAssetRepository assetRepository;
        public frmReports()
        {
            InitializeComponent();
            assetRepository = new AssetRepository();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFromDate.Text) || string.IsNullOrWhiteSpace(txtToDate.Text))
            {
                MessageBox.Show("لطفاً هر دو تاریخ را وارد کنید", "خطا",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DataTable reportData = assetRepository.FilterReport(txtFromDate.Text, txtToDate.Text);

            if (reportData != null && reportData.Rows.Count > 0)
            {
                dgvReports.DataSource = reportData;

                MessageBox.Show($"گزارش با موفقیت تولید شد\nتعداد رکوردها: {reportData.Rows.Count}", "موفقیت", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                dgvReports.DataSource = null;
                MessageBox.Show("هیچ داده‌ای برای تاریخ‌های انتخاب شده وجود ندارد", "اطلاع", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void frmReports_Load(object sender, EventArgs e)
        {
            ConvertDatesToShamsi();
            txtFromDate.Text = DateTime.Now.ToSahmsi();
            txtToDate.Text = DateTime.Now.ToSahmsi();
        }
        private void ConvertDatesToShamsi()
        {
            foreach (DataGridViewRow row in dgvReports.Rows)
            {
                if (row.Cells["DateLoogin"].Value != null && DateTime.TryParse(row.Cells["DateLoogin"].Value.ToString(), out DateTime assetDate))
                {
                    row.Cells["DateLoogin"].Value = assetDate.ToSahmsi();
                }
                if (row.Cells["TimeLogin"].Value != null && DateTime.TryParse(row.Cells["TimeLogin"].Value.ToString(), out DateTime AssetEditDate))
                {
                    row.Cells["TimeLogin"].Value = AssetEditDate.ToSahmsi();
                }
            }
        }

        private void btnClearReports_Click(object sender, EventArgs e)
        {
            dgvReports.DataSource = null;
            txtFromDate.Text = DateTime.Now.ToSahmsi();
            txtToDate.Text = DateTime.Now.ToSahmsi();
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


            foreach (DataGridViewRow item in dgvReports.Rows)
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
