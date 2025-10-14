using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementDataLayer.Repositories
{
    public interface ILoginRepository
    {
        DataTable SelectAll();
        DataTable SelectRow(int id);
        bool Insert(string UserName, string Password);
        //bool Update(string UserName, string Password);
        bool Delete(int Id);
    }
}
