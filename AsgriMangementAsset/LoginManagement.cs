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
using ValidationComponents;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace AsgriMangementAsset
{

    public partial class LoginManagement : Form
    {
        ILoginRepository loginRepository;
        public LoginManagement()
        {
            InitializeComponent();
            loginRepository = new LoginRepository();
        }

        private void LoginManagement_Load(object sender, EventArgs e)
        {
            Bindgrid();
            ConvertDatesToShamsi();


        }
        private void ConvertDatesToShamsi()
        {
            foreach (DataGridViewRow row in dgLogin.Rows)
            {
                if (row.Cells["DateLogin"].Value != null && DateTime.TryParse(row.Cells["DateLogin"].Value.ToString(), out DateTime date))
                {
                    row.Cells["DateLogin"].Value = date.ToSahmsi();
                }
            }
        }
        private void Bindgrid()
        {
            dgLogin.DataSource = loginRepository.SelectAll();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (BaseValidator.IsFormValid(this.components))
            {
                bool isSuccses = loginRepository.Insert(txtName.Text, txtPassword.Text);
                if (isSuccses == true)
                {
                    RtlMessageBox.Show("عملیات با موفق آمیز ثبت شد.", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtName.Clear();
                    txtPassword.Clear();
                    Bindgrid();
                }
                else
                {
                    RtlMessageBox.Show("عملیات ذخیره سازی با شکست مواجه شد", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }

            }
        }

        private void bunifuLabel4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string Name = dgLogin.CurrentRow.Cells[1].Value.ToString();
            if(RtlMessageBox.Show($"آیا از حذف کاربر {Name}مطمئن هستید","توجه",MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                int UserId = int.Parse(dgLogin.CurrentRow.Cells[0].Value.ToString());
                loginRepository.Delete(UserId);
                Bindgrid();
            }
            else
            {
                RtlMessageBox.Show("برای حذف اموال مورد نظر یک رکود را در جدول زیر انتخاب فرمایید","",MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Bindgrid();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //bool isSuccses = loginRepository.Update(txtName.Text,txtPassword.Text);
            //if (!isSuccses == true)
            //{
            //    RtlMessageBox.Show("عملیات با موفق آمیز ویرایش شد.", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    Bindgrid();
            //}
            //else
            //{
            //    RtlMessageBox.Show("عملیات ویرایش با شکست مواجه شد", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //}
        }

        private void dgLogin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int UserIdd = int.Parse(dgLogin.CurrentRow.Cells[0].Value.ToString());
            DataTable dt = loginRepository.SelectRow(UserIdd);
            txtName.Text = dt.Rows[0][1].ToString();
            txtPassword.Text = dt.Rows[0][2].ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
