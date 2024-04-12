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
            bool contieneMayusculas = contrasena.Any(char.IsUpper);
            string pattern = @"\W";
            Regex regex = new Regex(pattern);
            bool contieneSimbolos = regex.IsMatch(contrasena);

            if (contrasena.Length < 8) MessageBox.Show("La contraseña que ingresó es demasiado corta, ingrese una contraseña de entre 8 y 16 dígitos", "Contraseña no segura", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (!contieneSimbolos || !contieneMayusculas) MessageBox.Show("Para que tu contraseña sea segura añade por lo menos un símbolo y una letra mayúscula", "Contraseña no segura", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else return true;
            return false;
        }

        private void btn_AddUser_Click(object sender, EventArgs e)
        {
            if(txt_Id.Text != string.Empty && txt_NombreUsuario.Text != string.Empty && txt_Contrasena.Text != string.Empty && cmb_Roles.Text != string.Empty)
            {
                if (ContrasenaSegura() && !txt_NombreUsuario.Text.Contains(" "))
                {
                    string NombreUsuario = txt_NombreUsuario.Text;
                    string Contraseña = txt_Contrasena.Text;
                    int IdRol = cmb_Roles.Text == "Administrador" ? 1 : 2;
                    bool response = false;
                    try { response = NLogin.AñadirPerfilUsuario(NombreUsuario, Contraseña, IdRol); }
                    catch (Exception ex) { Console.WriteLine(ex.Message); }
                    if (response) MessageBox.Show("El usuario se ha añadido con exito", "Operación éxitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else MessageBox.Show("Ocurrió un error al crear el usuario, revisa que el usuario no esté registrado", "La operación ha fallado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_Id.Text = string.Empty;
                    txt_NombreUsuario.Text = string.Empty;
                    txt_Contrasena.Text = string.Empty;
                    Cargar();
                }
                else if (txt_NombreUsuario.Text.Contains(" ")) { MessageBox.Show("El nombre de usuario no debe contener espacios", "Usuario inválido", MessageBoxButtons.OK, MessageBoxIcon.Information); } ;
            }
            else MessageBox.Show("Por favor rellena todos los campos solicitados", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                    if (response) MessageBox.Show("El usuario se ha modificado con exito", "Se ha añadido el usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else MessageBox.Show("Ocurrió un error al modificar el usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_Id.Text = string.Empty;
                    txt_NombreUsuario.Text = string.Empty;
                    txt_Contrasena.Text = string.Empty;
                    Cargar();
                }
            }
            else MessageBox.Show("Por favor rellena todos los campos solicitados", "Entrada de datos inválida", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_RemoveUser_Click(object sender, EventArgs e)
        {
            bool Result = false;
            DialogResult confirmacion = MessageBox.Show("¿Está seguro que quieres eliminar este usuario?", "Confirmar eliminar usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirmacion == DialogResult.Yes) Result = NLogin.EliminarPerfilUsuario(int.Parse(txt_Id.Text));
            if (Result) MessageBox.Show("Usuario Eliminado", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else MessageBox.Show("No se ha podido eliminar este usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Cargar();
        }

        private void btn_VisiblePass_Click(object sender, EventArgs e)
        {
            if(!NotvisiblePass)
            {
                NotvisiblePass = true;
                txt_Contrasena.UseSystemPasswordChar = NotvisiblePass;
                btn_VisiblePass.BackgroundImage = Images[1];
                txt_Contrasena.Focus();
            }
            else
            {
                NotvisiblePass = false;
                txt_Contrasena.UseSystemPasswordChar = NotvisiblePass;
                btn_VisiblePass.BackgroundImage = Images[0];
                txt_Contrasena.Focus();
            }
        }
    }
}
