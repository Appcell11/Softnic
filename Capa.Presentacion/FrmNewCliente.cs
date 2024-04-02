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
    public partial class FrmNewCliente : Form
    {
        public FrmNewCliente()
        {
            InitializeComponent();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void FrmNewCliente_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        private void Cargar()
        {
            cmb_sexo.Items.Clear();
            CargarDatos.CargarDatosCmb("sp_MostrarSexos", 0).ForEach(item => cmb_sexo.Items.Add(item));
            ActualizarBusqueda();
        }

        private void ActualizarBusqueda()
        {
            var bindingSource = new BindingSource();
            bindingSource.DataSource = txt_Buscar.Text == string.Empty || txt_Buscar.Text == " " ? CargarDatos.CargarInfoDataGrid("sp_MostrarClientes") : NClientes.BuscarClientes(txt_Buscar.Text);
            dgv_Clientes.DataSource = bindingSource;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (txt_PrimerNombre.Text != string.Empty && txt_PrimerApellido.Text != string.Empty && txt_NumeroCedula.Text != string.Empty && cmb_sexo.Text != string.Empty && txt_NumeroCedula.Text.Length == 14 )
            {
                if (dateTimePicker.Value < DateTime.Now.AddYears(-16) )
                {
                    string PNombre = txt_PrimerNombre.Text;
                    string SNombre = txt_SegundoNombre.Text;
                    string PApellido = txt_PrimerApellido.Text;
                    string SApellido = txt_SegundoApellido.Text;
                    string Cedula = txt_NumeroCedula.Text;
                    DateTime FechaNacimiento = dateTimePicker.Value;
                    int id_Sexo = cmb_sexo.SelectedIndex+1;
                    bool responce = NClientes.AñadirCliente(PNombre, SNombre, PApellido, SApellido, FechaNacimiento, id_Sexo, Cedula);
                    if (responce) MessageBox.Show("Se ha añadido un nuevo cliente");
                    else MessageBox.Show("Ha ocurrido un error al agregar el nuevo cliente");
                    Cargar();
                    txt_PrimerNombre.Text = string.Empty;
                    txt_SegundoNombre.Text = string.Empty;
                    txt_PrimerApellido.Text = string.Empty;
                    txt_SegundoApellido.Text = string.Empty;
                    txt_NumeroCedula.Text = string.Empty;
                    cmb_sexo.SelectedIndex = 0;
                    dateTimePicker.Value = DateTime.Now.AddYears(-16);
                }
                else MessageBox.Show("Por favor ingrese una fecha válida");
            }
            else if(txt_NumeroCedula.Text.Length != 14) MessageBox.Show("Por favor ingresa un número de cédula válido");
            else MessageBox.Show("Por favor llena todos los campos requeridos");
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            bool Result = false;
            if(txt_PrimerNombre.Text != string.Empty && txt_PrimerApellido.Text != string.Empty)
            {
                DialogResult confirmacion = MessageBox.Show("¿Está seguro que quieres eliminar este cliente?", "Confirmar eliminar cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirmacion == DialogResult.Yes) Result = NClientes.EliminarCliente(int.Parse(dgv_Clientes.CurrentRow.Cells[0].Value.ToString()));
                if (Result) MessageBox.Show("Usuario Eliminado");
                else MessageBox.Show("No se ha podido eliminar este usuario");
                Cargar();
            }
            else
            {
                MessageBox.Show("No se ha seleccionado ningún cliente");
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (txt_PrimerNombre.Text != string.Empty && txt_PrimerApellido.Text != string.Empty && txt_NumeroCedula.Text != string.Empty && cmb_sexo.Text != string.Empty && txt_NumeroCedula.Text.Length == 14)
            {
                if (dateTimePicker.Value < DateTime.Now.AddYears(-16))
                {
                    int Id = int.Parse(dgv_Clientes.CurrentRow.Cells["ID"].Value.ToString());
                    string PNombre = txt_PrimerNombre.Text;
                    string SNombre = txt_SegundoNombre.Text;
                    string PApellido = txt_PrimerApellido.Text;
                    string SApellido = txt_SegundoApellido.Text;
                    string Cedula = txt_NumeroCedula.Text;
                    DateTime FechaNacimiento = dateTimePicker.Value;
                    int id_Sexo = cmb_sexo.SelectedIndex + 1;
                    bool responce = NClientes.ModificarCliente(Id, PNombre, SNombre, PApellido, SApellido, FechaNacimiento, id_Sexo, Cedula);
                    if (responce) MessageBox.Show("Se han modificado los datos del cliente");
                    else MessageBox.Show("Ha ocurrido un error al modificar los datos del cliente");
                    Cargar();
                    txt_PrimerNombre.Text = string.Empty;
                    txt_SegundoNombre.Text = string.Empty;
                    txt_PrimerApellido.Text = string.Empty;
                    txt_SegundoApellido.Text = string.Empty;
                    txt_NumeroCedula.Text = string.Empty;
                    cmb_sexo.SelectedIndex = 0;
                    dateTimePicker.Value = DateTime.Now.AddYears(-16);
                }
                else MessageBox.Show("Por favor ingrese una fecha válida");
            }
            else if (txt_NumeroCedula.Text.Length != 14) MessageBox.Show("Por favor ingresa un número de cédula válido");
            else MessageBox.Show("Por favor llena todos los campos requeridos");
        }

        private void FilaSeleccionada()
        {
            txt_PrimerNombre.Text = dgv_Clientes.CurrentRow.Cells["Primer Nombre"].Value.ToString();
            txt_SegundoNombre.Text = dgv_Clientes.CurrentRow.Cells["Segundo Nombre"].Value.ToString();
            txt_PrimerApellido.Text = dgv_Clientes.CurrentRow.Cells["Primer Apellido"].Value.ToString();
            txt_SegundoApellido.Text = dgv_Clientes.CurrentRow.Cells["Segundo Apellido"].Value.ToString();
            txt_NumeroCedula.Text = dgv_Clientes.CurrentRow.Cells["Número de Cédula"].Value.ToString();
            dateTimePicker.Value = DateTime.Parse(dgv_Clientes.CurrentRow.Cells["Fecha de nacimiento"].Value.ToString());
            cmb_sexo.SelectedValue = dgv_Clientes.CurrentRow.Cells["Sexo"].Value.ToString();
        }

        private void dgv_Clientes_SelectionChanged(object sender, EventArgs e)
        {
            FilaSeleccionada();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_PrimerNombre.Text = string.Empty;
            txt_SegundoNombre.Text = string.Empty;
            txt_PrimerApellido.Text = string.Empty;
            txt_SegundoApellido.Text = string.Empty;
            txt_NumeroCedula.Text = string.Empty;
            cmb_sexo.SelectedIndex = 0;
            dateTimePicker.Value = DateTime.Now.AddYears(-16);
        }

        private void txt_Buscar_TextChanged(object sender, EventArgs e)
        {
            ActualizarBusqueda();
        }
    }
}
