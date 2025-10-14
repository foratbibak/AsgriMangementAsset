using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManagementDataLayer.Repositories;

namespace ManagementDataLayer.Services
{
    public class LoginRepository : ILoginRepository
    {
        private string connectionString = $@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\ManagementDataLayer\Context\SchoolManagement1.accdb")}";
        public bool Delete(int Id)
        {
            OleDbConnection connection = new OleDbConnection(connectionString);
            try
            {
                string query = "Delete From Users where UserId=@ID";
                OleDbCommand command = new OleDbCommand(query, connection);
                command.Parameters.AddWithValue("@ID", Id);
                connection.Open();
                command.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                connection.Close();
            }
        }

        public bool Insert(string UserName, string Password)
        {
            OleDbConnection connection = new OleDbConnection(connectionString);
            try
            {
                string query = "Insert Into Users (UserName,UserPassword) values(@UserName,@Password)";
                OleDbCommand command = new OleDbCommand(query, connection);
                command.Parameters.AddWithValue("@UserName", UserName);
                command.Parameters.AddWithValue("@Password", Password);
                connection.Open();
                command.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                connection.Close();
            }
        }



        public DataTable SelectAll()
        {
            string query = "Select * From Users";
            DataTable data = new DataTable();
            OleDbConnection connection = new OleDbConnection(connectionString);
            OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection);
            adapter.Fill(data);

            return data;
        }


        public DataTable SelectRow(int id)
        {
            string query = "Select * From Users where UserId=" + id;
            DataTable data = new DataTable();
            OleDbConnection connection = new OleDbConnection(connectionString);
            OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection);
            adapter.Fill(data);
            return data;
        }

        //public bool Update(string UserName, string Password)
        //{

            //OleDbConnection connection = new OleDbConnection(connectionString);
            //try
            //{
            //    string query = "Update Users set UserName = @UserName , UserPassword=@Password";
            //    OleDbCommand command = new OleDbCommand(query, connection);
            //    command.Parameters.AddWithValue("@UserName", UserName);
            //    command.Parameters.AddWithValue("@Password", Password);
            //    connection.Open();
            //    command.ExecuteNonQuery();
            //    return true;
            //}
            //catch
            //{
            //    return false;
            //}
            //finally
            //{
            //    connection.Close();
            //}
        //}
    }
}
