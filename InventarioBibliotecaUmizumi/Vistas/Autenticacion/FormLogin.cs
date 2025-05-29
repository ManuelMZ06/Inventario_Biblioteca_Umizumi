using InventarioBibliotecaUmizumi.Modelo;
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

        private void btnConexion_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conexion = Conexion.ObtenerConexion();
                MessageBox.Show("✅ Conexión exitosa a la base de datos.", "Conexión OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Conexion.CerrarConexion(conexion);
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error de conexión: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
    }
}
