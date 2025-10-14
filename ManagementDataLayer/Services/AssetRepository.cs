using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accounting.utility.Convertor;
using ManagementDataLayer.Repositories;

namespace ManagementDataLayer.Services
{
    public class AssetRepository : IAssetRepository
    {
        private string connectionString = $@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\ManagementDataLayer\Context\SchoolManagement1.accdb")}";
        public bool Delete(int AssetLabelNumber)
        {
            OleDbConnection connection = new OleDbConnection(connectionString);
            try
            {
                string query = "Delete From Property where AssetLabelNumber=@ID";
                OleDbCommand command = new OleDbCommand(query, connection);
                command.Parameters.AddWithValue("@ID", AssetLabelNumber);
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

        public DataTable Filter(string AssetTitle)
        {
            OleDbConnection connection = new OleDbConnection(connectionString);
            try
            {
                string query = "Select * From Property Where AssetCode = @Code";
                OleDbCommand command = new OleDbCommand(query, connection);
                command.Parameters.AddWithValue("@Code", AssetTitle);
                OleDbDataAdapter adapter = new OleDbDataAdapter(command);
                DataTable dt = new DataTable();
                connection.Open();
                adapter.Fill(dt);
                return dt;
            }
            catch
            {
                return null;
            }
            finally
            {
                connection.Close();
            }
        }
        public DataTable FilterReport(string frommDate, string tooDate)
        {
            OleDbConnection connection = new OleDbConnection(connectionString);
            try
            {
                DateTime fromDate = ParsePersianDate(frommDate);
                DateTime toDate = ParsePersianDate(tooDate);
                fromDate = DateConvertor.ToMiladi(fromDate);
                toDate = DateConvertor.ToMiladi(toDate);
                toDate = toDate.AddDays(1).AddSeconds(-1);
                string query = @"SELECT * FROM Property WHERE AssetDate >= @fromDate AND AssetDate <= @toDate ORDER BY AssetDate";
                OleDbCommand command = new OleDbCommand(query, connection);
                command.Parameters.AddWithValue("@fromDate", fromDate);
                command.Parameters.AddWithValue("@toDate", toDate);
                OleDbDataAdapter adapter = new OleDbDataAdapter(command);
                DataTable dt = new DataTable();
                connection.Open();
                adapter.Fill(dt);
                return dt;
            }
            catch 
            {
                return null;
            }
            finally
            {
                connection.Close();
            }
        }
        private DateTime ParsePersianDate(string persianDate)
        {
            string[] parts = persianDate.Split('/');
            int year = int.Parse(parts[0]);
            int month = int.Parse(parts[1]);
            int day = int.Parse(parts[2]);

            return new DateTime(year, month, day);
        }
        public bool Insert(string AssetCode, string Status, string AssetTitle, string AssetCompany, string AssetCountry, string AssetPrice, string AssetColor, string AssetModel, string AssetSize)
        {
            OleDbConnection connection = new OleDbConnection(connectionString);
            try
            {
                string query = "Insert Into Property (AssetCode,Status,AssetTitle,AssetCompany,AssetCountry,AssetPrice,AssetColor,AssetModel,AssetSize,AssetDate) values(@AssetCode,@Status,@AssetTitle,@AssetCompany,@AssetCountry,@AssetPrice,@AssetColor,@AssetModel,@AssetSize,@AssetDate)";
                OleDbCommand command = new OleDbCommand(query, connection);
                command.Parameters.AddWithValue("@AssetCode", string.IsNullOrWhiteSpace(AssetCode) ? "نامشخص" : AssetCode);
                command.Parameters.AddWithValue("@Status", string.IsNullOrWhiteSpace(Status) ? "نامشخص" : Status);
                command.Parameters.AddWithValue("@AssetTitle", string.IsNullOrWhiteSpace(AssetTitle) ? "نامشخص" : AssetTitle);
                command.Parameters.AddWithValue("@AssetCompany", string.IsNullOrWhiteSpace(AssetCompany) ? "نامشخص" : AssetCompany);
                command.Parameters.AddWithValue("@AssetCountry", string.IsNullOrWhiteSpace(AssetCountry) ? "نامشخص" : AssetCountry);
                command.Parameters.AddWithValue("@AssetPrice", string.IsNullOrWhiteSpace(AssetPrice) ? "نامشخص" : AssetPrice);
                command.Parameters.AddWithValue("@AssetColor", string.IsNullOrWhiteSpace(AssetColor) ? "نامشخص" : AssetColor);
                command.Parameters.AddWithValue("@AssetModel", string.IsNullOrWhiteSpace(AssetModel) ? "نامشخص" : AssetModel);
                command.Parameters.AddWithValue("@AssetSize", string.IsNullOrWhiteSpace(AssetSize) ? "نامشخص" : AssetSize);
                command.Parameters.AddWithValue("@AssetDate", DateTime.Now.ToString("MM/dd/yyyy"));
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

        public DataTable Search(string parameter)
        {
            string query = "Select * From Property where AssetTitle like @parameter or AssetCode like @parameter";
            DataTable data = new DataTable();
            OleDbConnection connection = new OleDbConnection(connectionString);
            OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection);
            adapter.SelectCommand.Parameters.AddWithValue("@parameter", "%" + parameter + "%");
            adapter.Fill(data);
            return data;
        }

        public DataTable SelectAll()
        {
            string query = "Select * From Property";
            DataTable data = new DataTable();
            OleDbConnection connection = new OleDbConnection(connectionString);
            OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection);
            adapter.Fill(data);

            return data;
        }

        public DataTable SelectRow(int AssetLablNumber)
        {
            string query = "Select * From Property where AssetLabelNumber=" + AssetLablNumber;
            DataTable data = new DataTable();
            OleDbConnection connection = new OleDbConnection(connectionString);
            OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection);
            adapter.Fill(data);
            return data;
        }

        public bool Update(int AssetLabelNumber, string AssetCode, string Status, string AssetTitle, string AssetCompany, string AssetCountry, string AssetPrice, string AssetColor, string AssetModel, string AssetSize)
        {
            OleDbConnection connection = new OleDbConnection(connectionString);
            try
            {
                string query = " Update Property set AssetCode=@AssetCode,Status=@Status,AssetTitle=@AssetTitle,AssetCompany=@AssetCompany,AssetCountry=@AssetCountry,AssetPrice=@AssetPrice,AssetColor=@AssetColor,AssetModel=@AssetModel,AssetSize=@AssetSize,AssetEditDate=@AssetEditDate Where AssetLabelNumber=@ID";
                OleDbCommand command = new OleDbCommand(query, connection);
                command.Parameters.AddWithValue("@AssetCode", string.IsNullOrWhiteSpace(AssetCode) ? "نامشخص" : AssetCode);
                command.Parameters.AddWithValue("@Status", string.IsNullOrWhiteSpace(Status) ? "نامشخص" : Status);
                command.Parameters.AddWithValue("@AssetTitle", string.IsNullOrWhiteSpace(AssetTitle) ? "نامشخص" : AssetTitle);
                command.Parameters.AddWithValue("@AssetCompany", string.IsNullOrWhiteSpace(AssetCompany) ? "نامشخص" : AssetCompany);
                command.Parameters.AddWithValue("@AssetCountry", string.IsNullOrWhiteSpace(AssetCountry) ? "نامشخص" : AssetCountry);
                command.Parameters.AddWithValue("@AssetPrice", string.IsNullOrWhiteSpace(AssetPrice) ? "نامشخص" : AssetPrice);
                command.Parameters.AddWithValue("@AssetColor", string.IsNullOrWhiteSpace(AssetColor) ? "نامشخص" : AssetColor);
                command.Parameters.AddWithValue("@AssetModel", string.IsNullOrWhiteSpace(AssetModel) ? "نامشخص" : AssetModel);
                command.Parameters.AddWithValue("@AssetSize", string.IsNullOrWhiteSpace(AssetSize) ? "نامشخص" : AssetSize);
                command.Parameters.AddWithValue("@EditDate", DateTime.Now.ToString("MM/dd/yyyy"));
                command.Parameters.AddWithValue("@ID", AssetLabelNumber);

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
    }
}
