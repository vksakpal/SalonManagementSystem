using Salon.DataLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.DataLayer.Concrete
{
    public class SqlCaller : ISqlCaller
    {
        public DataSet GetData(string connectionString, string databaseApi, DbParameter[] paramList)
        {
            DataSet dataSet = new DataSet();
            using SqlConnection sqlConnection = new SqlConnection(connectionString);
            using SqlCommand sqlCommand = new SqlCommand(databaseApi, sqlConnection);

            if (paramList?.Count() > 0)
                sqlCommand.Parameters.AddRange(paramList);

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dataSet);
            return dataSet;
        }
    }
}
