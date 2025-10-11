using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementDataLayer.Repositories
{
    public interface IAssetRepository
    {
        DataTable SelectAll();
        DataTable SelectRow(int id);
        DataTable Search(string parameter);
        bool Insert(string AssetCode, string Status, string AssetTitle, string AssetCompany, string AssetCountry, decimal AssetPrice, string AssetColor, string AssetModel, string AssetSize);
        bool Update(int AssetLabelNumber,string AssetCode, string Status, string AssetTitle, string AssetCompany, string AssetCountry, decimal AssetPrice, string AssetColor, string AssetModel, string AssetSize);
        bool Delete(int AssetLabelNumber);
    }
}






