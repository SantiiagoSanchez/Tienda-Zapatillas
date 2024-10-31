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
    public partial class FormRegister : Form
    {
        public Cliente objCliente = new Cliente();
        public NegCliente objNegCliente = new NegCliente();
        public FormRegister()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 formulario = new Form1();
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

        private void btnCrearCuenta_Click(object sender, EventArgs e)
        {

            if (txtNombre.Text == "")
            {
                MessageBox.Show("El nombre es OBLIGATORIO", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtDireccion.Text == "")
            {
                MessageBox.Show("La direccion es OBLIGATORIA", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtDocumento.Text == "")
            {
                MessageBox.Show("El documento es OBLIGATORIO", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtContrasena.Text == "")
            {
                MessageBox.Show("La contraseña es OBLIGATORIA", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                int nGrab = -1;
                TxtBox_a_Obj();
                nGrab = objNegCliente.AddCliente("add", objCliente);
                if (nGrab == -1)
                {
                    MessageBox.Show("Error al registrarse");
                }
                else
                {
                    Form1 form = new Form1();
                    DialogResult res = MessageBox.Show("¡Genial, ya puedes iniciar sesión!", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                    switch (res)
                    {
                        case DialogResult.OK: this.Close(); form.Show(); break;
                    }
                }

            }
        }

        private void Limpiar() 
        {
            txtNombre.Text = "";
            txtDocumento.Text = "";
            txtDireccion.Text = "";
            txtContrasena.Text = "";
        }

        private void TxtBox_a_Obj() 
        {
            objCliente.Nombre = txtNombre.Text;
            objCliente.IdUsuario = txtDocumento.Text;
            objCliente.Direccion = txtDireccion.Text;
            objCliente.Contrasena = txtContrasena.Text;
        }
    }
}
