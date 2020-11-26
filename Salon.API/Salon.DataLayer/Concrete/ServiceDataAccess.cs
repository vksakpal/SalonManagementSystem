using Salon.DataLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Salon.DataLayer.Concrete
{
    public class ServiceDataAccess : IServiceDataAccess
    {
        private readonly ISqlCaller _sqlCaller;
        private readonly string _salonConnectionString;
        //public ServiceDataAccess(ISqlCaller sqlCaller, IConfiguration configuration)
        //{
        //    _sqlCaller = sqlCaller;
        //    _salonConnectionString =   

        //}

        public void GetServices()
        {
           // _sqlCaller.GetData()
        }
    }
}
