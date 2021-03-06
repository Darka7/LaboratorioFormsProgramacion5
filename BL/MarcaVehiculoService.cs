using BD;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public interface IMarcaVehiculoService
    {
        DBEntity Create(MarcaVehiculoEntity entity);
        DBEntity Delete(MarcaVehiculoEntity entity);
        IEnumerable<MarcaVehiculoEntity> Get();
        MarcaVehiculoEntity GetById(MarcaVehiculoEntity entity);
        DBEntity Update(MarcaVehiculoEntity entity);

        IEnumerable<MarcaVehiculoEntity> GetLista();
    }

    public class MarcaVehiculoService : IMarcaVehiculoService
    {

        public IDataAccess sql { get; set; }

        public MarcaVehiculoService()
        {
            sql = new DataAccess();
        }


        public IEnumerable<MarcaVehiculoEntity> Get()
        {
            try
            {
                var result = sql.Query<MarcaVehiculoEntity>("MarcaVehiculoObtener");

                return result;
            }
            catch (Exception ex)
            {

                throw;
            }
        }


        public MarcaVehiculoEntity GetById(MarcaVehiculoEntity entity)
        {
            try
            {
                var result = sql.QueryFirst<MarcaVehiculoEntity>("MarcaVehiculoObtener", new
                {
                    entity.MarcaVehiculoId
                });

                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }



        public DBEntity Create(MarcaVehiculoEntity entity)
        {
            try
            {
                var result = sql.Execute("MarcaVehiculoInsertar", new
                {
                    entity.Descripcion,
                    entity.Estado
                });

                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }


        public DBEntity Update(MarcaVehiculoEntity entity)
        {
            try
            {
                var result = sql.Execute("MarcaVehiculoActualizar", new
                {
                    entity.MarcaVehiculoId,
                    entity.Descripcion,
                    entity.Estado
                });

                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }


        public DBEntity Delete(MarcaVehiculoEntity entity)
        {
            try
            {
                var result = sql.Execute("MarcaVehiculoEliminar", new
                {
                    entity.MarcaVehiculoId,
                });

                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }





        public IEnumerable<MarcaVehiculoEntity> GetLista()
        {
            try
            {
                var result = sql.Query<MarcaVehiculoEntity>("MarcaVehiculoLista");

                return  result;
            }
            catch (Exception)
            {

                throw;
            }
        }



    }
}
