using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManagementDataLayer.Repositories;
using ManagementDataLayer.Services;
using ValidationComponents;

namespace AsgriMangementAsset.AssetForms
{
    public partial class frmAddoredit : Form
    {
        IAssetRepository assetRepository;
        public int AssetLableNumber = 0;
        public frmAddoredit()
        {
            assetRepository = new AssetRepository();
            InitializeComponent();
        }

        private void lblAddress_Click(object sender, EventArgs e)
        {

        }

        private void frmAddoredit_Load(object sender, EventArgs e)
        {
            txtnumric.Maximum = decimal.MaxValue;
            if (AssetLableNumber == 0)
            {
                this.Text = "افزودن اموال";
            }
            else
            {
                this.Text = "ویرایش اموال";
                DataTable dt = assetRepository.SelectRow(AssetLableNumber);
                txTitle.Text = dt.Rows[0][3].ToString();
                txtCode.Text = dt.Rows[0][1].ToString();
                txtStatus.Text = dt.Rows[0][2].ToString();
                txtCompany.Text = dt.Rows[0][4].ToString();
                txtCountry.Text = dt.Rows[0][5].ToString();
                txtnumric.Text = dt.Rows[0][6].ToString();
                txtColor.Text = dt.Rows[0][7].ToString();
                txtModel.Text = dt.Rows[0][8].ToString();
                txtSize.Text = dt.Rows[0][9].ToString();
                btnsabt.Text = "ویرایش";
            }
        }

        private void btnsabt_Click(object sender, EventArgs e)
        {
            if (BaseValidator.IsFormValid(this.components))
            {
                bool isSuccses;
                if(AssetLableNumber == 0)
                {
                    isSuccses = assetRepository.Insert(txtCode.Text, txtStatus.Text, txTitle.Text, txtCompany.Text, txtCountry.Text, (decimal)txtnumric.Value, txtColor.Text, txtModel.Text, txtSize.Text);
                }
                else
                {
                    isSuccses = assetRepository.Update(AssetLableNumber, txtCode.Text, txtStatus.Text, txTitle.Text, txtCompany.Text, txtCountry.Text, (decimal)txtnumric.Value, txtColor.Text, txtModel.Text, txtSize.Text);
                }
                if (isSuccses == true)
                {
                    RtlMessageBox.Show("عملیات با موفق آمیز ثبت شد.", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    RtlMessageBox.Show("عملیات خیره سازی با شکست مواجه شد.", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void txTitle_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtnumric_Leave(object sender, EventArgs e)
        {
        }

        private void txtnumric_ValueChanged(object sender, EventArgs e)
        {
            txtnumric.Text = string.Format("{0:N0}", txtnumric.Value);

        }
    }
}
