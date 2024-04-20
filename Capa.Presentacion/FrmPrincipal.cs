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
using System.Drawing.Printing;
using static System.Net.WebRequestMethods;
using System.Security.Permissions;

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
                    label_NumRecibo.Text = CargarDatos.CargarInfoDataGrid("sp_UltimoRecibo").Select()[0][0].ToString();
                    cmb_Clientes.Enabled = true;
                    dgv_Register.DataSource = CargarDatos.CargarInfoDataGrid("sp_MostrarReporteRecibo");
                    MessageBox.Show("El recibo se ha guardado con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmb_Clientes.Enabled = true;
                    label_Total.Text = "0";
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
                    try 
                    { 
                        bindingSource.DataSource = NRecibo.MostrarDetalleRecibo(int.Parse(label_NumRecibo.Text)); 
                        dgv_detalleRecibo.DataSource = bindingSource;
                    }
                    catch (Exception except) { MessageBox.Show("Error: " + except.Source + " " + except.Message, "Ha ocurrido un error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
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

        public BindingSource bindingSource = new BindingSource();
        private void btn_NuevoRecibo_Click(object sender, EventArgs e)
        {
            try
            {
                label_NumRecibo.Text = CargarDatos.CargarInfoDataGrid("sp_UltimoRecibo").Select()[0][0].ToString();
                cmb_Clientes.SelectedItem = null;
                bindingSource.DataSource = NRecibo.MostrarDetalleRecibo(int.Parse(label_NumRecibo.Text));
                dgv_detalleRecibo.DataSource = bindingSource;
                dgv_detalleRecibo.Refresh();
                cmb_Clientes.Enabled = true;
                cmb_Examenes.Enabled = true;
                imprimiendo = false;
            }
            catch (Exception except ) { MessageBox.Show("Error: " + except.Source + " " + except.Message, "Ha ocurrido un error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            int id_Detalle;
            bool Responce = false;
            //var bindingSource = new BindingSource();
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
            if (Responce) MessageBox.Show("Se ha eliminado el registro", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else { MessageBox.Show("No se ha podido eliminar el registro", "Ha ocurrido un error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void GenerarReporte()
        {
            double GranTotal = 0;
            Document doc = new Document(PageSize.LETTER);
            
            try
            {
                FileStream fs = new FileStream(Path.Combine(Application.StartupPath, @"Reporte") + DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + ".pdf" , FileMode.Create);
                PdfWriter Writer = PdfWriter.GetInstance(doc, fs);
                doc.AddTitle("ReporteSoftnic");
                doc.Open();
                iTextSharp.text.Font _standardFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);

                doc.Add(new Paragraph("Reporte de caja " + DateTime.Now.ToString("d")));
                doc.Add(new Paragraph("---------------------------------------------------------------------------------------------------------"));
                doc.Add(Chunk.NEWLINE);
                foreach (DataGridViewRow row in dgv_Register.Rows)
                {
                    var IdRecibo = row.Cells[0].Value;
                    var PacienteNombre = row.Cells[1].Value;
                    var PacienteApellido = row.Cells[2].Value;
                    var Subtotal = row.Cells[3].Value;
                    var Iva = row.Cells[4].Value;
                    var TotalPagar = row.Cells[5].Value.ToString();
                    var Fecha = row.Cells[6].Value;
                    if(TotalPagar.Length > 0) GranTotal += double.Parse(TotalPagar);
                    doc.Add(new Paragraph("No Recibo : " + IdRecibo + " --- " + PacienteNombre + " " + PacienteApellido + " --- " + " C$ " + Subtotal + " --- Iva: " + Iva + " --- Total: C$ " + TotalPagar + " --- " + Fecha));
                    doc.Add(Chunk.NEWLINE);
                }
                doc.Add(new Paragraph("---------------------------------------------------------------------------------------------------------"));
                doc.Add(new Paragraph("Gran Total: C$: " + GranTotal.ToString()));
                doc.Close();
                Writer.Close();
                MessageBox.Show("Guardado en " + Path.Combine(Application.StartupPath, @"Reporte") + DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + ".pdf", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }catch (Exception e) { MessageBox.Show(e.Message); }
            finally
            {
                doc.Close();
            }
        }

        private void btn_CierreCaja_Click(object sender, EventArgs e)
        {
            if(dgv_Register.Rows.Count > 0 ) {
                GenerarReporte();
            }
            else
            {
                MessageBox.Show("No se ha podido crear el reporte, revisa que el reporte no esté vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_CerrarSesion_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estás seguro de que quieres cerrar sesión?", "Cerrar sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            { 
                this.Hide();
                Login.Access = "0";
                Empezar();
            }
            else
            {
                MessageBox.Show("No quiso");
            }
        }
        bool imprimiendo = false;
        private void btn_Imprimir_Click(object sender, EventArgs e)
        {
            if(dgv_detalleRecibo.Rows.Count > 0 && imprimiendo == false) ImprimirRecibo();
        }

        private void FormClosedHandler(object sender, EventArgs e)
        {
            imprimiendo = false;
        }

        private void ImprimirRecibo()
        {
            int longPaper = dgv_detalleRecibo.Rows.Count * 100 + 240;
            PrintPreviewDialog vista = new PrintPreviewDialog();
            printDocument1 = new PrintDocument();
            printDocument1.PrinterSettings.PrinterName = printDocument1.DefaultPageSettings.PrinterSettings.PrinterName;
            PrinterSettings ps = new PrinterSettings();
            PageSettings pageSettings = new PageSettings();
            pageSettings.PaperSize = new PaperSize("Custom", 350, longPaper);
            printDocument1.DefaultPageSettings = pageSettings;
            printDocument1.PrinterSettings = ps;
            printDocument1.PrintPage += printDocument1_PrintPage;
            vista.Document = printDocument1;
            vista.Show();
            if(vista.Created) { imprimiendo = true; }
            vista.FormClosed += new FormClosedEventHandler(FormClosedHandler);
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            int line = 10;
            int subtotal = int.Parse(label_Total.Text);
            double iva = subtotal * 0.15;
            double granTotal = iva + subtotal;
            StringFormat center = new StringFormat();            
            center.Alignment = StringAlignment.Center;
            StringFormat left = new StringFormat();
            left.Alignment = StringAlignment.Near;
            System.Drawing.Font fontBold = new System.Drawing.Font("Arial", 14, FontStyle.Bold, GraphicsUnit.Point);
            System.Drawing.Font font = new System.Drawing.Font("Arial", 12, FontStyle.Regular, GraphicsUnit.Point);
            e.Graphics.DrawString("Recibo No." + label_NumRecibo.Text, fontBold, Brushes.Black, 170, line += 20, center);
            e.Graphics.DrawString("Cliente:" + cmb_Clientes.Text, fontBold, Brushes.Black, 350 / 2, line += 30, center);
            e.Graphics.DrawString(string.Concat(Enumerable.Repeat("-", 170)), fontBold, Brushes.Black, 170, line += 40, center);

            foreach (DataGridViewRow row in dgv_detalleRecibo.Rows)
            {
                int stringLong = row.Cells[4].Value.ToString().Length;
                if (stringLong > 20)
                {
                    //e.Graphics.DrawString(row.Cells[4].Value.ToString().Substring(0,40), font, Brushes.Black, 170, line += 40, center);
                    e.Graphics.DrawString(row.Cells[4].Value.ToString().Substring(0, 21) + "... : C$ " + row.Cells[5].Value.ToString(), font, Brushes.Black, 170, line += 30, center);
                }
                else
                {
                    e.Graphics.DrawString(row.Cells[4].Value.ToString() + ": C$ " + row.Cells[5].Value.ToString(), font, Brushes.Black, 170, line += 40, center);
                }
            }
            e.Graphics.DrawString(string.Concat(Enumerable.Repeat("-", 170)), fontBold, Brushes.Black, 170, line += 40, center);
            e.Graphics.DrawString("Subtotal: C$ " + subtotal.ToString() + "  " + "Iva: C$ " + iva.ToString(), fontBold, Brushes.Black, 170, line += 40, center);
            e.Graphics.DrawString("Total: C$ " + granTotal.ToString(), fontBold, Brushes.Black, 350 / 2, line += 40, center);
            e.Graphics.DrawString("Fecha:" + DateTime.Now.ToString("d"), fontBold, Brushes.Black, 350/2, line += 40, center);

        }

        private void printDocument1_EndPrint(object sender, PrintEventArgs e)
        {
            imprimiendo = false;
        }

        private void btn_controlRecibos_Click(object sender, EventArgs e)
        {
            var FrmRecibos = new FrmControlRecibos();
            FrmRecibos.ShowDialog();
        }
    }
}
