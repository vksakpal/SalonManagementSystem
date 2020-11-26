using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.DataLayer.Abstract
{
    public interface ISqlCaller
    {
        DataSet GetData(string connectionString,string databaseApi, DbParameter[] paramList);
        
    }
}
