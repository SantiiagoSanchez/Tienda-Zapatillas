using Entidades;
using Negocios.cs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.cs
{
    public partial class Form1 : Form
    {
        private NegCliente objNegCliente = new NegCliente();
        public Form1()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormRegister formulario = new FormRegister();
            formulario.Show();
            this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtContrasena.PasswordChar = '\0';
            }
            else
            {
                txtContrasena.PasswordChar = '*';
            }
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            string DniCliente = txtDocumento.Text;
            string ContrasenaCliente = txtContrasena.Text;

            List<Cliente> ListaCliente = objNegCliente.CargarCliente();

            bool ValidarCliente = ListaCliente.Any(x => x.IdUsuario == DniCliente && x.Contrasena == ContrasenaCliente);

            if (ValidarCliente == true) 
            {
                MessageBox.Show("Bienvenidx a nuestra tienda de zapatillas", "¡Bienvenidx!");
                this.Hide();
                Tienda formulariotienda = new Tienda();
                formulariotienda.Show();
            }
            else 
            {
                MessageBox.Show("Error al iniciar Sesion. Datos incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
