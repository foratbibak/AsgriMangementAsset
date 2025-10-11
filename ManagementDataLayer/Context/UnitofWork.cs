using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManagementDataLayer.Repositories;
using ManagementDataLayer.Services;

namespace ManagementDataLayer.Context
{
    //public class UnitofWork : IDisposable
    //{
    //    private string db = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\forat\source\repos\AsgriMangementAsset\ManagementDataLayer\Context\SchoolManagement1.accdb;";
    //    private readonly OleDbConnection _connection;
    //    private readonly OleDbTransaction _transaction;
    //    private IAssetRepository _assetRepository;
    //public IAssetRepository AssetRepository 
    //{
    //    get
    //    {
    //        if (_assetRepository = null)
    //        {
    //            _assetRepository = new AssetRepository(_connection, _transaction);
    //            _connection = new OleDbConnection(db);
    //            _connection.Open();
    //        }

    //        _transaction = _connection.BeginTransaction();

    //    }
    //}

    //public void Commit()
    //{
    //    _transaction?.Commit();
    //    _connection?.Close();
    //}

    //public void Dispose()
    //{
    //    _transaction?.Dispose();
    //    _connection?.Dispose();
    //}
    //    }
}
