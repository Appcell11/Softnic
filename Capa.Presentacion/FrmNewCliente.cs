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
            bindingSource.DataSource = CargarDatos.CargarInfoDataGrid("sp_MostrarSexos");
            dgv_Clientes.DataSource = bindingSource;
        }
    }
}
