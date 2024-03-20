using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ventas.CapaPresentacion
{
    public partial class FrmPerfilesUsuarios : Form
    {
        public FrmPerfilesUsuarios()
        {
            InitializeComponent();
        }

        private void btn_AddUser_Click(object sender, EventArgs e)
        {
            if(txt_Id.Text != string.Empty && txt_NombreUsuario.Text != string.Empty && txt_Contrasena.Text != string.Empty && cmb_Roles.Text != string.Empty)
            {
                string NombreUsuario = txt_NombreUsuario.Text;
                string Contraseña = txt_Contrasena.Text;
                int IdRol = cmb_Roles.Text == "Administrador" ? 1 : 2;
                bool response = NLogin.AñadirPerfilUsuario(NombreUsuario, Contraseña, IdRol);
                if (response) MessageBox.Show("El usuario se ha añadido con exito");
                else MessageBox.Show("Ocurrió un error al crear el usuario, revisa que el usuario no esté registrado");
            }
            else MessageBox.Show("Por favor rellena todos los campos solicitados");
        }

        private void FrmPerfilesUsuarios_Load(object sender, EventArgs e)
        {
            CargarDatos.CargarDatosCmb("sp_MostrarRoles", 1).ForEach(item => cmb_Roles.Items.Add(item));
            var bindingSource = new BindingSource();
            bindingSource.DataSource = CargarDatos.CargarPerfiles();
            dgv_Perfiles.DataSource = bindingSource;
        }
    }
}
