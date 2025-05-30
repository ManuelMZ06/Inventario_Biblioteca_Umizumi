using InventarioBibliotecaUmizumi.Controlador;
using InventarioBibliotecaUmizumi.Modelo;
using InventarioBibliotecaUmizumi.Vistas.Autenticacion;
using InventarioBibliotecaUmizumi.Vistas.dashboard;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace InventarioBibliotecaUmizumi
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void LinkRegistrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            FormRegistro formregistro = new FormRegistro();
            formregistro.ShowDialog();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string usuario = txtusuario.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Por favor llena todos los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool esValido = UsuarioController.ValidarLogin(usuario, password);

            if (esValido)
            {
                MessageBox.Show("✅ Bienvenido, acceso concedido.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // TODO: Redireccionar al Dashboard o formulario principal
                this.Hide();
                Dashboard tableroPrincipal = new Dashboard();
                tableroPrincipal.ShowDialog();
               
            }
            else
            {
                MessageBox.Show("❌ Usuario o contraseña incorrectos.", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
