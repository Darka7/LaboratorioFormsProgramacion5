using BD;
using Entity;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public interface IUsuariosServices
    {
        UsuariosEntity Login(UsuariosEntity entity);
    }

    public class UsuariosServices : IUsuariosServices
    {
        public IDataAccess sql { get; set; }

        public UsuariosServices()
        {
            sql = new DataAccess();
        }



        public UsuariosEntity Login(UsuariosEntity entity)
        {
            try
            {
                var result = sql.QueryFirst<UsuariosEntity>("Login", new
                {
                    entity.Usuario,
                    entity.Contrasena
                });

                return result;
            }
            catch (Exception ex)
            {

                throw;
            }
        }


    }
}
