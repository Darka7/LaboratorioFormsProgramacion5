using Dapper;
using Dapper.Mapper;
using Entity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD
{
    public class DataAccess : IDataAccess
    {

        public SqlConnection DbConnection => new SqlConnection(
          new SqlConnectionStringBuilder(ConfigurationManager.AppSettings["Conn"]).ConnectionString
         );

        public IEnumerable<T> Query<T>(string sp, object Param = null, int? Timeout = null)
        {
            try
            {

                using (var exec = DbConnection)
                {
                    exec.Open();

                    var result = exec.Query<T>(sql: sp, param: Param, commandType: System.Data.CommandType.StoredProcedure
                        , commandTimeout: Timeout);

                    return result;

                }
            }
            catch (Exception)
            {

                throw;
            }
        }


        public IEnumerable<dynamic> Query(string sp, object Param = null, int? Timeout = null)
        {
            try
            {

                using (var exec = DbConnection)
                {
                    exec.Open();

                    var result = exec.Query(sql: sp, param: Param, commandType: System.Data.CommandType.StoredProcedure
                        , commandTimeout: Timeout);

                    //var list = result.Select(r => new DBEntity{ 
                    //    CodeError=r.MarcaVehiculoId,
                    //    MsgError=r.Descripcion

                    //});

                    return result;

                }
            }
            catch (Exception)
            {

                throw;
            }
        }



        public IEnumerable<A> Query<A, B>(string sp, object Param = null, int? Timeout = null)
        {
            try
            {

                using (var exec = DbConnection)
                {
                    exec.Open();

                    var result = exec.Query<A, B>(sql: sp, param: Param, commandType: System.Data.CommandType.StoredProcedure
                        , commandTimeout: Timeout);

                    return result;

                }
            }
            catch (Exception)
            {

                throw;
            }
        }


        public IEnumerable<A> Query<A, B, C>(string sp, object Param = null, int? Timeout = null)
        {
            try
            {

                using (var exec = DbConnection)
                {
                    exec.Open();

                    var result = exec.Query<A, B, C>(sql: sp, param: Param, commandType: System.Data.CommandType.StoredProcedure
                        , commandTimeout: Timeout);

                    return result;

                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public IEnumerable<A> Query<A, B, C, D>(string sp, object Param = null, int? Timeout = null)
        {
            try
            {

                using (var exec = DbConnection)
                {
                    exec.Open();

                    var result = exec.Query<A, B, C, D>(sql: sp, param: Param, commandType: System.Data.CommandType.StoredProcedure
                        , commandTimeout: Timeout);

                    return result;

                }
            }
            catch (Exception)
            {

                throw;
            }
        }


        public IEnumerable<A> Query<A, B, C, D, E>(string sp, object Param = null, int? Timeout = null)
        {
            try
            {

                using (var exec = DbConnection)
                {
                    exec.Open();

                    var result = exec.Query<A, B, C, D, E>(sql: sp, param: Param, commandType: System.Data.CommandType.StoredProcedure
                        , commandTimeout: Timeout);

                    return result;

                }
            }
            catch (Exception)
            {

                throw;
            }
        }


        public IEnumerable<A> Query<A, B, C, D, E, H>(string sp, object Param = null, int? Timeout = null)
        {
            try
            {

                using (var exec = DbConnection)
                {
                    exec.Open();

                    var result = exec.Query<A, B, C, D, E, H>(sql: sp, param: Param, commandType: System.Data.CommandType.StoredProcedure
                        , commandTimeout: Timeout);

                    return result;

                }
            }
            catch (Exception)
            {

                throw;
            }
        }


        public IEnumerable<A> Query<A, B, C, D, E, H, I>(string sp, object Param = null, int? Timeout = null)
        {
            try
            {

                using (var exec = DbConnection)
                {
                    exec.Open();

                    var result = exec.Query<A, B, C, D, E, H, I>(sql: sp, param: Param, commandType: System.Data.CommandType.StoredProcedure
                        , commandTimeout: Timeout);

                    return result;

                }
            }
            catch (Exception)
            {

                throw;
            }
        }




        public T QueryFirst<T>(string sp, object Param = null, int? Timeout = null)
        {
            try
            {

                using (var exec = DbConnection)
                {
                    exec.Open();

                    var result = exec.QueryFirstOrDefault<T>(sql: sp, param: Param, commandType: System.Data.CommandType.StoredProcedure
                        , commandTimeout: Timeout);

                    return result;

                }
            }
            catch (Exception)
            {

                throw;
            }
        }


        public DBEntity Execute(string sp, object Param = null, int? Timeout = null)
        {
            try
            {

                using (var exec = DbConnection)
                {
                    exec.Open();

                    var result = exec.ExecuteReader(sql: sp, param: Param, commandType: System.Data.CommandType.StoredProcedure
                        , commandTimeout: Timeout);

                    result.Read();


                    return new DBEntity()
                    {
                        CodeError = result.GetInt32(0),
                        MsgError = result.GetString(1)
                    };

                }
            }
            catch (Exception)
            {

                throw;
            }
        }





    }
}
