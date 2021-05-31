using BD;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public interface IPruebaService
    {
        DBEntity Tran();
    }

    public class PruebaService : IPruebaService
    {

        public IDataAccess sql { get; set; }

        public PruebaService()
        {
            this.sql = new DataAccess();
        }

        public DBEntity Tran()
        {
            try
            {
                var result = sql.Execute("asd");


                return result;
            }
            catch (Exception)
            {

                throw;
            }

        }








    }
}
