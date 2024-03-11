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
using System.Xml.Linq;

namespace Ventas.CapaPresentacion
{
    public partial class Login : Form
    {
        public static bool Access = false;
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            NLogin.Perfiles().ForEach(perfil => cmb_Usuario.Items.Add(perfil));

        }

        public bool Acceso(string perfil, string contrasena)
        {
            bool Access = NLogin.ValidarAcceso(perfil, contrasena);
            return Access;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(Acceso(cmb_Usuario.Text, txt_Contrasena.Text))
            {
                Access = true;
                var Menu = new FrmPrincipal();
                Menu.Show(this);
                this.Close();
            }
            else
            {
                MessageBox.Show("Contraseña Incorrecta");
            }
        }
    }
}
