using Entity;
using System;
using System.Windows.Forms;

namespace WinFormLaboratorio.Forms
{
    public partial class FormMarcaVehiculo : Form
    {
        public FormMarcaVehiculo()
        {
            InitializeComponent();
        }

        public void CargarDatos()
        {
            try
            {

                GridViewMarcaVehiculo.AutoGenerateColumns = false;
                GridViewMarcaVehiculo.DataSource = IApp.MarcaVehiculoService.Get();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void FormMarcaVehiculo_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }


        public void LimpiarDatos()
        {

            txtMarcaVehiculoId.Text = null;
            txtDescripcion.Text = null;
            chkEstado.Checked = true;

        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {

            LimpiarDatos();

            panelForm.Visible = true;
        }


        public int? GetSelectedRowGrid()
        {
            if (GridViewMarcaVehiculo.SelectedRows.Count > 0)
            {
                var row = GridViewMarcaVehiculo.SelectedRows[0];

                return Convert.ToInt32(row.Cells["MarcaVehiculoId"].Value);
            }
            else
            {
                return null;

            }
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {

            try
            {
                //limpiar datos 
                LimpiarDatos();

                // obtenemos el id de la fila seleccionada
                var IdSelected = GetSelectedRowGrid();

                if (IdSelected.HasValue)
                {

                    // traemos los datos de la base de datos del id seleccionado
                    var result = IApp.MarcaVehiculoService.GetById(new MarcaVehiculoEntity()
                    {
                        MarcaVehiculoId = IdSelected
                    });

                    //llenamos el formulario

                    txtMarcaVehiculoId.Text = result.MarcaVehiculoId.ToString();
                    txtDescripcion.Text = result.Descripcion;
                    chkEstado.Checked = result.Estado;

                    panelForm.Visible = true;
                }
                else
                {
                    MessageBox.Show("Por favor seleccione un registro");

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                panelForm.Visible = false;

                var IdSelected = GetSelectedRowGrid();

                if (IdSelected.HasValue)
                {
                    //mandamos a eliminar el registro desde la base de datos
                    var result = IApp.MarcaVehiculoService.Delete(new MarcaVehiculoEntity()
                    {
                        MarcaVehiculoId = IdSelected
                    });
                    //si el mensaje de error es igual a cero  se elimino correctamente
                    if (result.CodeError == 0)
                    {
                        MessageBox.Show("El Registro Se elimino Correctamente!");
                        // cargamos de nuevos los datos en la tabla 
                        CargarDatos();
                    }
                    else
                    {
                        throw new Exception(result.MsgError);
                    }

                }
                else
                {
                    MessageBox.Show("Por favor seleccione un registro");
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }


        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidacionFormulario())
                {
                    var MarcaVehiculoId = string.IsNullOrEmpty(txtMarcaVehiculoId.Text)
                                            ? (int?)null // Insertar
                                            : Convert.ToInt32(txtMarcaVehiculoId.Text); //Editar

                    var entity = new MarcaVehiculoEntity
                    {
                        MarcaVehiculoId = MarcaVehiculoId,
                        Descripcion = txtDescripcion.Text,
                        Estado = chkEstado.Checked
                    };

                    var result = new DBEntity();

                    if (entity.MarcaVehiculoId.HasValue)
                    {
                        //actualizar
                        result = IApp.MarcaVehiculoService.Update(entity);

                        if (result.CodeError == 0) MessageBox.Show("Se Actualizo el registro correctamente!");

                    }
                    else
                    {
                        //Insertar
                        result = IApp.MarcaVehiculoService.Create(entity);

                        if (result.CodeError == 0) MessageBox.Show("Se guardo el registro correctamente!");
                    }

                    //verificamos que la base de datos no retorne un error
                    if (result.CodeError != 0) throw new Exception(result.MsgError);
                    //limpiamos  refrescamos y desaparecemos el form
                    LimpiarDatos();
                    CargarDatos();
                    panelForm.Visible = false;

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }


        public bool ValidacionFormulario()
        {

            if (string.IsNullOrEmpty(txtDescripcion.Text))
            {
                MessageBox.Show("El campo Descripcion es obligatorio!");

                return false;
            }


            return true;
        }


    }
}
