using CapaNegocio;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlTypes;

namespace Ventas.CapaPresentacion
{
    public partial class FrmPrincipal : Form
    {
        List<Examenes> ListExamenes = CargarDatos.cargarInformacionExamenes();
        List<Clientes> ListClientes = CargarDatos.CargarDatosClientes();
        public FrmPrincipal()
        {
            InitializeComponent();
           
        }
        protected void Empezar()
        {
            if (Login.Access == "Admin" || Login.Access == "1")
            {
                
            }
            else
            {
                var Logueo = new Login();
                Logueo.ShowDialog();
            }
        }

        private void ActualizarTotal()
        {
            string totalPagar = NRecibo.MostrarImporteRecibo(int.Parse(label_NumRecibo.Text)).Select()[0][0].ToString();
            label_Total.Text = totalPagar.ToString();
        }

        private void Limpiar()
        {
            cmb_Clientes.Items.Clear();
            cmb_Descuentos.Items.Clear();
            cmb_Examenes.Items.Clear();
            dgv_detalleRecibo.DataSource = null;
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            Empezar();
            Cargar();

        }

        private void Cargar()
        {
            ListExamenes = CargarDatos.cargarInformacionExamenes();
            ListClientes = CargarDatos.CargarDatosClientes();
            cmb_Clientes.Items.Clear();
            cmb_Descuentos.Items.Clear();
            cmb_Examenes.Items.Clear();
            ListExamenes.ForEach(item => cmb_Examenes.Items.Add(item.Nombre));
            CargarDatos.CargarDatosCmb("sp_MostrarDescuentos", 1).ForEach(item => cmb_Descuentos.Items.Add(item));
            ListClientes.ForEach(item => cmb_Clientes.Items.Add(item.PrimerNombre + " " + item.PrimerApellido));
        }

        private void FrmPrincipal_Activated(object sender, EventArgs e)
        {
            Empezar();
        }

        private void btn_Caja_Click(object sender, EventArgs e)
        {
            var FrmCaja = new FrmNewCliente();
            FrmCaja.ShowDialog();
        }

        private void btn_AgregarCliente_Click(object sender, EventArgs e)
        {
            var FrmAddCliente = new FrmNewCliente();
            FrmAddCliente.ShowDialog();
        }

        private void btn_AdminUsuarios_Click(object sender, EventArgs e)
        {
            if(Login.Access == "Admin")
            {
                var FrmPerfiles = new FrmPerfilesUsuarios();
                FrmPerfiles.ShowDialog();
            }
            else
            {
                MessageBox.Show("Solo el administrador puede modificar los perfiles");
            }
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            bool Responce = NRecibo.GuardarDetalleRecibo(int.Parse(label_NumRecibo.Text));
            if (Responce) { 
                MessageBox.Show("El recibo se ha guardado con éxito");
                Limpiar(); }
            else MessageBox.Show("Se ha producido un error");
        }

        private void FrmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void cmb_Clientes_MouseClick(object sender, MouseEventArgs e)
        {
            cmb_Clientes.Items.Clear();
            ListClientes.ForEach(item => cmb_Clientes.Items.Add(item.PrimerNombre + " " + item.PrimerApellido));
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if(cmb_Examenes.SelectedItem != null && cmb_Clientes.SelectedItem != null && label_NumRecibo.Text != "0000")
            {
                int CliIndex = cmb_Clientes.SelectedIndex;
                int ExamIndex = cmb_Examenes.SelectedIndex;
                bool responce = NRecibo.AgregarDetalleRecibo(int.Parse(label_NumRecibo.Text), ListClientes[CliIndex].id_Cliente, ListExamenes[ExamIndex].id_Examen);
                if (responce)
                {
                    var bindingSource = new BindingSource();
                    bindingSource.DataSource = NRecibo.MostrarDetalleRecibo(int.Parse(label_NumRecibo.Text));
                    dgv_detalleRecibo.DataSource = bindingSource;
                    if (bindingSource.Count > 0) cmb_Clientes.Enabled = false;
                    ActualizarTotal();
                    MessageBox.Show("Se ha añadido con éxito");
                }
                else MessageBox.Show("Ups, Se ha producido un error");
            }
            else if(label_NumRecibo.Text == "0000")
            {
                MessageBox.Show("Cree un nuevo recibo para empezar");
            }else
            {
                MessageBox.Show("Por favor seleccione un examen y un cliente");
            }
        }

        private void btn_NuevoRecibo_Click(object sender, EventArgs e)
        {
            label_NumRecibo.Text = CargarDatos.CargarInfoDataGrid("sp_UltimoRecibo").Select()[0][0].ToString();
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            int id_Detalle = int.Parse(dgv_detalleRecibo.CurrentRow.Cells[0].Value.ToString());
            bool Responce = NRecibo.EliminarDetalleRecibo(id_Detalle);
            var bindingSource = new BindingSource();
            bindingSource.DataSource = NRecibo.MostrarDetalleRecibo(int.Parse(label_NumRecibo.Text));
            ActualizarTotal();
            if (Responce) MessageBox.Show("Se ha eliminado");
            else MessageBox.Show("Se ha producido un error");
        }
    }
}
