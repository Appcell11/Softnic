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
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using iTextSharp.tool.xml;
using System.Linq.Expressions;

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
            try
            {
                string totalPagar = NRecibo.MostrarImporteRecibo(int.Parse(label_NumRecibo.Text)).Select()[0][0].ToString();
                label_Total.Text = totalPagar.ToString();
            }
            catch (Exception except)
            {
                MessageBox.Show("Error: " + except.Source + " " + except.Message, "Ha ocurrido un error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Limpiar()
        {
            cmb_Clientes.Items.Clear();
            cmb_Examenes.Items.Clear();
            Cargar();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            Empezar();
            Cargar();

        }

        private void Cargar()
        {
            cmb_Clientes.Items.Clear();
            cmb_Examenes.Items.Clear();
            dgv_detalleRecibo.DataSource = null;
            try
            {
                ListExamenes = CargarDatos.cargarInformacionExamenes();
                ListClientes = CargarDatos.CargarDatosClientes();
                dgv_Register.DataSource = CargarDatos.CargarInfoDataGrid("sp_MostrarReporteRecibo");
            }
            catch (Exception except)
            {
                MessageBox.Show("Error: " + except.Source + " " + except.Message, "Ha ocurrido un error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ListExamenes.ForEach(item => cmb_Examenes.Items.Add(item.Nombre));
            ListClientes.ForEach(item => cmb_Clientes.Items.Add(item.PrimerNombre + " " + item.PrimerApellido));
            //CargarDatos.CargarDatosCmb("sp_MostrarDescuentos", 1).ForEach(item => cmb_Descuentos.Items.Add(item));
        }

        private void FrmPrincipal_Activated(object sender, EventArgs e)
        {
            Empezar();
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
                MessageBox.Show("Solo el administrador puede modificar los perfiles", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            bool Responce = NRecibo.GuardarDetalleRecibo(int.Parse(label_NumRecibo.Text));
            if (Responce) {
                try
                {
                    dgv_Register.DataSource = CargarDatos.CargarInfoDataGrid("sp_MostrarReporteRecibo");
                    MessageBox.Show("El recibo se ha guardado con éxito");
                    Limpiar();
                }
                catch (Exception except)
                {
                    MessageBox.Show("Error: " + except.Source + " " + except.Message, "Ha ocurrido un error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else MessageBox.Show("Se ha producido un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void FrmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void cmb_Clientes_MouseClick(object sender, MouseEventArgs e)
        {
            cmb_Clientes.Items.Clear();
            try
            {
                ListClientes = CargarDatos.CargarDatosClientes();
            }
            catch (Exception except)
            {
                MessageBox.Show("Error: " + except.Source + " " + except.Message, "Ha ocurrido un error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ListClientes.ForEach(item => cmb_Clientes.Items.Add(item.PrimerNombre + " " + item.PrimerApellido));
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if(cmb_Examenes.SelectedItem != null && cmb_Clientes.SelectedItem != null && label_NumRecibo.Text != "0000")
            {
                int CliIndex = cmb_Clientes.SelectedIndex;
                int ExamIndex = cmb_Examenes.SelectedIndex;
                bool responce = false;
                try
                {
                    responce = NRecibo.AgregarDetalleRecibo(int.Parse(label_NumRecibo.Text), ListClientes[CliIndex].id_Cliente, ListExamenes[ExamIndex].id_Examen);
                }
                catch (Exception except)
                {
                    MessageBox.Show("Error: " + except.Source + " " + except.Message, "Ha ocurrido un error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (responce)
                {
                    var bindingSource = new BindingSource();
                    try { bindingSource.DataSource = NRecibo.MostrarDetalleRecibo(int.Parse(label_NumRecibo.Text)); }
                    catch (Exception except) { MessageBox.Show("Error: " + except.Source + " " + except.Message, "Ha ocurrido un error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    dgv_detalleRecibo.DataSource = bindingSource;
                    if (bindingSource.Count > 0) cmb_Clientes.Enabled = false;
                    ActualizarTotal();
                    MessageBox.Show("El recibo se ha añadido con éxito", "Operación realizada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                else MessageBox.Show("Ups, Se ha producido un error", "Operación fallida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(label_NumRecibo.Text == "0000")
            {
                MessageBox.Show("Cree un nuevo recibo para empezar", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }else
            {
                MessageBox.Show("Por favor seleccione un examen y un cliente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_NuevoRecibo_Click(object sender, EventArgs e)
        {
            try
            {
                label_NumRecibo.Text = CargarDatos.CargarInfoDataGrid("sp_UltimoRecibo").Select()[0][0].ToString();
                cmb_Clientes.Enabled = true;
            }
            catch (Exception except ) { MessageBox.Show("Error: " + except.Source + " " + except.Message, "Ha ocurrido un error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            int id_Detalle;
            bool Responce = false;
            var bindingSource = new BindingSource();
            if(dgv_detalleRecibo.Rows.Count > 0)
            {
                try
                {
                    id_Detalle = int.Parse(dgv_detalleRecibo.CurrentRow.Cells[0].Value.ToString());
                    Responce = NRecibo.EliminarDetalleRecibo(id_Detalle);
                    bindingSource.DataSource = NRecibo.MostrarDetalleRecibo(int.Parse(label_NumRecibo.Text));
                    dgv_detalleRecibo.DataSource = bindingSource;
                }
                catch (Exception except)
                {
                    MessageBox.Show("Error: " + except.Source + " " + except.Message, "Ha ocurrido un error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            ActualizarTotal();
            if (Responce) MessageBox.Show("Se ha eliminado el registro");
            else { MessageBox.Show("No se ha podido eliminar el registro", "Ha ocurrido un error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void GenerarReporte()
        {
            SaveFileDialog guardar = new SaveFileDialog();
            guardar.FileName = DateTime.Now.ToString("Reporte_" + "ddMMyyyyHHmmss") + ".pdf";
            guardar.ShowDialog();

            string paginahtml = Properties.Resources.plantilla.ToString();
            string filas = string.Empty;
            foreach (DataGridViewRow row in dgv_Register.Rows)
            {
                filas += "<tr>";
                filas += "<td>" + row.Cells[0].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells[1].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells[2].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells[3].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells[4].Value.ToString() + "</td>";
                filas += "</tr>";
            }

            if (guardar.ShowDialog() == DialogResult.OK)
            {
                using (FileStream fileStream = new FileStream(guardar.FileName, FileMode.Create))
                {
                    Document document = new Document(PageSize.A4, 25, 25, 25, 25);
                    PdfWriter pdfWriter = PdfWriter.GetInstance(document, fileStream);
                    paginahtml.Replace("@fila", filas);
                    document.Open();
                    //document.Add(new Phrase());
                    using (StringReader reader = new StringReader(paginahtml))
                    {
                        try
                        {
                            XMLWorkerHelper.GetInstance().ParseXHtml(pdfWriter, document, reader);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("No se ha podido eliminar el registro", "Ha ocurrido un error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    document.Close();
                    fileStream.Close();
                }
            }
        }

        private void btn_CierreCaja_Click(object sender, EventArgs e)
        {
            if(dgv_Register.Rows.Count > 0 && dgv_Register.Columns.Count > 0) {
                GenerarReporte();
            }
            else
            {
                MessageBox.Show("No se ha podido crear el reporte", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
