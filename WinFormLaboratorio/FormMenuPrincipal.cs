using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormLaboratorio.Forms;

namespace WinFormLaboratorio
{
    public partial class FormMenuPrincipal : Form
    {
        public FormMenuPrincipal()
        {
            InitializeComponent();
        }

        public Form CurrentForm { get; set; }

        private void AbrirFormPrincipal(Form menuitem)
        {

            if (CurrentForm != null) CurrentForm.Close();


            CurrentForm = menuitem;

            menuitem.TopLevel = false;
            menuitem.FormBorderStyle = FormBorderStyle.None;
            menuitem.Dock = DockStyle.Fill;

            panelMenuPrincipal.Controls.Add(menuitem);
            panelMenuPrincipal.Tag = menuitem;

            menuitem.BringToFront();
            menuitem.Show();

            MenuLabelPrincipal.Text = menuitem.Text;



        }

        private void MenuMarcaVehiculo_Click(object sender, EventArgs e)
        {
            AbrirFormPrincipal( new FormMarcaVehiculo());
            
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            AbrirFormPrincipal(new FormVehiculo());
        }

        private void FormMenuPrincipal_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Session.Usuario?.Usuario))
            {
                var form = new FormLogin();

                form.Show();

                this.Dispose();
            }

            LbUsuario.Text = Session.Usuario?.Usuario;


        }

        private void FormMenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
