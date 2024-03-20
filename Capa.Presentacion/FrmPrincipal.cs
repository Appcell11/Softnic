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
        private int childFormNumber = 0;

        public FrmPrincipal()
        {
            InitializeComponent();
           
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void articulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void rolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
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
            CargarDatos.CargarDatosCmb("sp_MostrarExamenes", 1).ForEach(item => cmb_Examenes.Items.Add(item));
            CargarDatos.CargarDatosCmb("sp_MostrarDescuentos", 1).ForEach(item => cmb_Descuentos.Items.Add(item));
            CargarDatos.CargarDatosClientes().ForEach(item => cmb_Clientes.Items.Add(item));
            var bindingSource = new BindingSource();
            bindingSource.DataSource = CargarDatos.cargarInformacionExamenes();
            dgv_Examenes.DataSource = bindingSource;
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

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Caja_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

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
    }
}
