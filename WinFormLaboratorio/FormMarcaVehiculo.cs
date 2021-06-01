using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormLaboratorio
{
    public partial class FormMarcaVehiculo : Form
    {
        public FormMarcaVehiculo()
        {
            InitializeComponent();
        }

        private void FormMarcaVehiculo_Load(object sender, EventArgs e)
        {

            GridViewMarcaVehiculo.DataSource = IApp.PruebaService.Get()
                .Select(r=>new { r.MarcaVehiculoId,r.Descripcion ,r.Estado})
                .ToList()
                ;
               
        }
    }
}
