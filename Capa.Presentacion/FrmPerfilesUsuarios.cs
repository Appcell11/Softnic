using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ventas.CapaPresentacion
{
    public partial class FrmPerfilesUsuarios : Form
    {
        bool ItsReady = false;
        bool NotvisiblePass = true;
        Image[] Images = { Properties.Resources.NotVisible, Properties.Resources.EyeIcon };
        public FrmPerfilesUsuarios()
        {
            InitializeComponent();
        }

        private bool ContrasenaSegura()
        {
            string contrasena = txt_Contrasena.Text;
            string pattern = @"\W";
            Regex regex = new Regex(pattern);
            bool contieneSimbolos = regex.IsMatch(contrasena);

            if (contrasena.Length < 8) MessageBox.Show("La contraseña que ingresó es demasiado corta, ingrese una contraseña de entre 8 y 16 dígitos");
            else if (!contieneSimbolos) MessageBox.Show("Para que tu contraseña sea segura añade por lo menos un símbolo");
            else return true;
            return false;
        }

        private void btn_AddUser_Click(object sender, EventArgs e)
        {
            if(txt_Id.Text != string.Empty && txt_NombreUsuario.Text != string.Empty && txt_Contrasena.Text != string.Empty && cmb_Roles.Text != string.Empty)
            {
                if (ContrasenaSegura())
                {
                    string NombreUsuario = txt_NombreUsuario.Text;
                    string Contraseña = txt_Contrasena.Text;
                    int IdRol = cmb_Roles.Text == "Administrador" ? 1 : 2;
                    bool response = NLogin.AñadirPerfilUsuario(NombreUsuario, Contraseña, IdRol);
                    if (response) MessageBox.Show("El usuario se ha añadido con exito");
                    else MessageBox.Show("Ocurrió un error al crear el usuario, revisa que el usuario no esté registrado");
                    txt_Id.Text = string.Empty;
                    txt_NombreUsuario.Text = string.Empty;
                    txt_Contrasena.Text = string.Empty;
                    Cargar();
                }
            }
            else MessageBox.Show("Por favor rellena todos los campos solicitados");
        }

        private void FrmPerfilesUsuarios_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        private void Cargar()
        {
            cmb_Roles.Items.Clear();
            CargarDatos.CargarDatosCmb("sp_MostrarRoles", 1).ForEach(item => cmb_Roles.Items.Add(item));
            var bindingSource = new BindingSource();
            bindingSource.DataSource = CargarDatos.CargarPerfiles();
            dgv_Perfiles.DataSource = bindingSource;
        }


        private void FilaSeleccionada()
        {
            txt_Id.Text = dgv_Perfiles.CurrentRow.Cells[0].Value.ToString();
            cmb_Roles.Text = dgv_Perfiles.CurrentRow.Cells["Rol"].Value.ToString();
            txt_NombreUsuario.Text = dgv_Perfiles.CurrentRow.Cells["Nombre"].Value.ToString();
            txt_Contrasena.Text = string.Empty;
        }

        private void dgv_Perfiles_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            
            ItsReady = true;
            if (ItsReady)
            {
                FilaSeleccionada();
            }
        }

        private void dgv_Perfiles_SelectionChanged(object sender, EventArgs e)
        {
            if (ItsReady)
            {
                FilaSeleccionada();
            }
        }

        private void btn_UpdateUser_Click(object sender, EventArgs e)
        {
            if (txt_Id.Text != string.Empty && txt_NombreUsuario.Text != string.Empty && txt_Contrasena.Text != string.Empty && cmb_Roles.Text != string.Empty)
            {
                if (ContrasenaSegura())
                {
                    int Id = int.Parse(txt_Id.Text);
                    string NombreUsuario = txt_NombreUsuario.Text;
                    string Contraseña = txt_Contrasena.Text;
                    int IdRol = cmb_Roles.Text == "Administrador" ? 1 : 2;
                    bool response = NLogin.ModificarPerfilUsuario(Id, NombreUsuario, Contraseña, IdRol);
                    if (response) MessageBox.Show("El usuario se ha modificado con exito");
                    else MessageBox.Show("Ocurrió un error al modificar el usuario");
                    txt_Id.Text = string.Empty;
                    txt_NombreUsuario.Text = string.Empty;
                    txt_Contrasena.Text = string.Empty;
                    Cargar();
                }
            }
            else MessageBox.Show("Por favor rellena todos los campos solicitados");
        }

        private void btn_RemoveUser_Click(object sender, EventArgs e)
        {
            bool Result = false;
            DialogResult confirmacion = MessageBox.Show("¿Está seguro que quieres eliminar este usuario?", "Confirmar eliminar usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirmacion == DialogResult.Yes) Result = NLogin.EliminarPerfilUsuario(int.Parse(txt_Id.Text));
            if (Result) MessageBox.Show("Usuario Eliminado");
            else MessageBox.Show("No se ha podido eliminar este usuario");
            Cargar();
        }

        private void btn_VisiblePass_Click(object sender, EventArgs e)
        {
            if(!NotvisiblePass)
            {
                NotvisiblePass = true;
                txt_Contrasena.UseSystemPasswordChar = NotvisiblePass;
                btn_VisiblePass.BackgroundImage = Images[1];
            }
            else
            {
                NotvisiblePass = false;
                txt_Contrasena.UseSystemPasswordChar = NotvisiblePass;
                btn_VisiblePass.BackgroundImage = Images[0];
            }
        }
    }
}
