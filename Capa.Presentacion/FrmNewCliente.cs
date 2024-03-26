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
            var bindingSource = new BindingSource();
            bindingSource.DataSource = CargarDatos.CargarInfoDataGrid("sp_MostrarClientes");
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
            DialogResult confirmacion = MessageBox.Show("¿Está seguro que quieres eliminar este cliente?", "Confirmar eliminar cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirmacion == DialogResult.Yes) Result = NClientes.EliminarCliente(int.Parse(dgv_Clientes.CurrentRow.Cells[0].Value.ToString()));
            if (Result) MessageBox.Show("Usuario Eliminado");
            else MessageBox.Show("No se ha podido eliminar este usuario");
            Cargar();
        }
    }
}
