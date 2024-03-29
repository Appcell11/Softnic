﻿using CapaNegocio;
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
        public static string Access = "false";
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            NLogin.Perfiles().ForEach(perfil => cmb_Usuario.Items.Add(perfil));

        }

        public string Acceso(string perfil, string contrasena)
        {
            string Access = NLogin.ValidarAcceso(perfil, contrasena);
            return Access;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(Acceso(cmb_Usuario.Text, txt_Contrasena.Text) == "Admin")
            {
                Access = "Admin";
                var Menu = new FrmPrincipal();
                Menu.Show();
                this.Hide();
            }
            else if(Acceso(cmb_Usuario.Text, txt_Contrasena.Text) == "1")
            {
                Access = "1";
                var Menu = new FrmPrincipal();
                Menu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Contraseña Incorrecta");
            }
        }
    }
}
