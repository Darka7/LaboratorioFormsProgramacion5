using BD;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public interface IVehiculoService
    {
        DBEntity Create(VehiculoEntity entity);
        DBEntity Delete(VehiculoEntity entity);
        IEnumerable<VehiculoEntity> Get();
        VehiculoEntity GetById(VehiculoEntity entity);
        DBEntity Update(VehiculoEntity entity);
    }

    public class VehiculoService : IVehiculoService
    {

        public IDataAccess sql { get; set; }

        public VehiculoService()
        {
            sql = new DataAccess();
        }

        public IEnumerable<VehiculoEntity> Get()
        {
            try
            {
                var result = sql.Query<VehiculoEntity, MarcaVehiculoEntity>("VehiculoObtener", "VehiculoId,MarcaVehiculoId");

                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }


        public VehiculoEntity GetById(VehiculoEntity entity)
        {
            try
            {
                var result = sql.QueryFirst<VehiculoEntity>("VehiculoObtener", new
                {
                    entity.VehiculoId
                });

                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }



        public DBEntity Create(VehiculoEntity entity)
        {
            try
            {
                var result = sql.Execute("VehiculoInsertar", new
                {
                    entity.Matricula,
                    entity.Color,
                    entity.Modelo,
                    entity.FechaModelo,
                    entity.Estado,
                    entity.MarcaVehiculoId,
                    entity.TieneDefectos,
                    entity.Defectos
                });

                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }


        public DBEntity Update(VehiculoEntity entity)
        {
            try
            {
                var result = sql.Execute("VehiculoActualizar", new
                {
                    entity.VehiculoId,
                    entity.Matricula,
                    entity.Color,
                    entity.Modelo,
                    entity.FechaModelo,
                    entity.Estado,
                    entity.MarcaVehiculoId,
                    entity.TieneDefectos,
                    entity.Defectos
                });

                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }


        public DBEntity Delete(VehiculoEntity entity)
        {
            try
            {
                var result = sql.Execute("VehiculoEliminar", new
                {
                    VehiculoId = entity.VehiculoId,
                });

                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }



    }
}
