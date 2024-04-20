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
    public partial class FrmControlRecibos : Form
    {
        public FrmControlRecibos()
        {
            InitializeComponent();
        }

        private void CargarRecibos()
        {
            try
            {
                dgv_Recibos.DataSource = CargarDatos.CargarInfoDataGrid("sp_MostrarRecibos");
            }
            catch {
                MessageBox.Show("Ocurrió un error al obtener los recibos de la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);   
            }
        }

        private void BuscarRecibos()
        {
            try
            {
                dgv_Recibos.DataSource = CargarDatos.CargarInfoDataGrid("sp_MostrarRecibos");
            }
            catch
            {
                MessageBox.Show("Ocurrió un error al obtener los recibos de la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmControlRecibos_Load(object sender, EventArgs e)
        {
            CargarRecibos();
        }

        private void txt_numRecibo_TextChanged(object sender, EventArgs e)
        {
            int codigo;
            try
            {
                if(txt_numRecibo.Text.Trim(char.Parse(" ")).Length > 0 || int.TryParse(txt_numRecibo.Text.ToString(), out codigo)) dgv_Recibos.DataSource = NRecibo.BuscarRecibo(int.Parse(txt_numRecibo.Text));
                else if(txt_numRecibo.Text.Length <= 0) { dgv_Recibos.DataSource = CargarDatos.CargarInfoDataGrid("sp_MostrarRecibos"); }
                else { MessageBox.Show("El número de recibo no debe contener letras", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            }
            catch
            {
                MessageBox.Show("Ocurrió un error al obtener los recibos de la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        int filaSeleccionada;
        private void btn_activarRecibo_Click(object sender, EventArgs e)
        {
            try
            {
                bool responce = false;
                responce = NRecibo.CambiarEstadoRecibo(filaSeleccionada, 1);
                if(responce)
                {
                    MessageBox.Show("El recibo se ha registrado como activo", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarRecibos();
                }
                else
                {
                    MessageBox.Show("No se ha podido activar el recibo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Ocurrió un error al tratar de activar el recibo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            try
            {
                bool responce = false;
                responce = NRecibo.CambiarEstadoRecibo(filaSeleccionada, 3);
                if (responce)
                {
                    MessageBox.Show("El recibo se ha registrado como eliminado", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarRecibos();
                }
                else
                {
                    MessageBox.Show("No se ha podido eliminar el recibo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Ocurrió un error al tratar de eliminar el recibo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgv_Recibos_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgv_Recibos.SelectedRows.Count > 0)
                {
                    filaSeleccionada = int.Parse(dgv_Recibos.CurrentRow.Cells[0].Value.ToString());
                }
            }
            catch 
            {
                MessageBox.Show("Ocurrió un error en la aplicación", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
