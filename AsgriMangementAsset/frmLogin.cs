using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsgriMangementAsset
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        private string connectionString = $@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\ManagementDataLayer\Context\SchoolManagement1.accdb")}";
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("لطفاً نام کاربری و رمز عبور را وارد کنید.");
                return;
            }


            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM Users WHERE Username = @username AND UserPassword = @password ";
                OleDbCommand cmd = new OleDbCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                conn.Open();
                int count = (int)cmd.ExecuteScalar();
                if (count > 0)
                {
                    string updateQuery = "UPDATE Users SET Status = @Status,TimeLogin = @LastLogin,DateLogin=@DateLogin WHERE Username = username";
                    OleDbCommand updateCmd = new OleDbCommand(updateQuery, conn);
                    updateCmd.Parameters.AddWithValue("@Status", "فعال");
                    updateCmd.Parameters.AddWithValue("@TimeLogin", DateTime.Now.ToString("HH:mm:ss"));
                    updateCmd.Parameters.AddWithValue("@DateLogin", DateTime.Now.ToString("yyyy/MM/dd"));
                    updateCmd.Parameters.AddWithValue("@username", username);
                    updateCmd.ExecuteNonQuery();
                    MessageBox.Show("خوش آمدید");
                    FormAsli frm = new FormAsli();
                    frm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("نام کاربری یا رمز عبور اشتباه است.");
                }
            }
        }
        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPassword.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
        }
    }
}
