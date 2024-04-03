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
    public partial class FrmPrincipal : Form
    {
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

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            Empezar();
            cmb_Clientes.Items.Clear();
            cmb_Descuentos.Items.Clear();
            cmb_Examenes.Items.Clear();
            CargarDatos.CargarDatosCmb("sp_MostrarExamenes", 1).ForEach(item => cmb_Examenes.Items.Add(item));
            CargarDatos.CargarDatosCmb("sp_MostrarDescuentos", 1).ForEach(item => cmb_Descuentos.Items.Add(item));
            CargarDatos.CargarDatosClientes().ForEach(item => cmb_Clientes.Items.Add(item));
            label_NumRecibo.Text = CargarDatos.CargarInfoDataGrid("sp_UltimoRecibo").Select()[0][0].ToString();
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
            
        }

        private void FrmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void cmb_Clientes_MouseClick(object sender, MouseEventArgs e)
        {
            cmb_Clientes.Items.Clear();
            CargarDatos.CargarDatosClientes().ForEach(item => cmb_Clientes.Items.Add(item));
        }
    }
}
