using Entidades;
using Negocios.cs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.cs
{
    public partial class LoginAdmin : Form
    {
        private NegAdmin objNegAdmin = new NegAdmin();
        public LoginAdmin()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Form1 Inicio = new Form1();
            this.Hide();
            Inicio.Show();
        }

        private void btnIniciarADMIN_Click(object sender, EventArgs e)
        {
            string Cod = txtCodigo.Text;
            string ContrasenaAdmin = txtContrasena.Text;
            if (Cod == "")
            {
                MessageBox.Show("El codigo es necesario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (ContrasenaAdmin == "")
            {
                MessageBox.Show("La contraseña es necesaria", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (ValidarCod(Cod)) 
            {
                List<Administrador> ListaAdmin = objNegAdmin.CargarAdministrador();

                bool ValidarAdmin = ListaAdmin.Any(x => x.Codigo == Cod && x.Contrasena == ContrasenaAdmin);

                if (ValidarAdmin == true) 
                {
                    MessageBox.Show("Bienvenido/a Administrador", "¡Bienvenido/a!");
                    this.Hide();
                    AdministrarTienda formAdmin = new AdministrarTienda();
                    formAdmin.Show();
                }
                else
                {
                    MessageBox.Show("Error al iniciar Sesion. Datos incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else 
            {
                MessageBox.Show("El formato del codigo debe ser (LLLNNNN)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidarCod(string Cod)
        {
            string patron = @"^([A-Z]{3}[0-9]{4})$";
            return Regex.IsMatch(Cod, patron);
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
    }
}
