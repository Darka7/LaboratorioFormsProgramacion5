using BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormLaboratorio
{
   public struct IApp
    {

        public static IMarcaVehiculoService MarcaVehiculoService => new MarcaVehiculoService();

        public static IVehiculoService VehiculoService => new VehiculoService();

        public static IUsuariosServices UsuariosServices => new UsuariosServices();


    }
}
