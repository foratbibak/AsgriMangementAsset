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
            BindGrid();
        }

        private void BindGrid()
        {
            dgAsset.DataSource = assetRepository.SelectAll();
            dgAsset.Columns[0].Visible = false;
            ConvertDatesToShamsi();

        }

        private void dgAsset_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

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
                if (row.Cells["AssetDate"].Value != null && DateTime.TryParse(row.Cells["AssetDate"].Value.ToString(), out DateTime assetDate))
                {
                    row.Cells["AssetDate"].Value = assetDate.ToSahmsi();
                }
                if (row.Cells["AssetEditDate"].Value != null && DateTime.TryParse(row.Cells["AssetEditDate"].Value.ToString(), out DateTime AssetEditDate))
                {
                    row.Cells["AssetEditDate"].Value = AssetEditDate.ToSahmsi();
                }
            }
        }

    }
}
