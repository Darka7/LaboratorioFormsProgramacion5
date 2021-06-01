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

        public static IMarcaVehiculoService PruebaService => new MarcaVehiculoService();



    }
}
