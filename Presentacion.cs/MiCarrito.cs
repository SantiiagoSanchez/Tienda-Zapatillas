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
    public partial class MiCarrito : Form
    {

        public MiCarrito(Tienda.Products Zapatilla)
        {
            InitializeComponent();
            ProgressBar.Visible = false;
            lblNombre.Text = Zapatilla.NombreDelCalzado;
            lblMarca.Text = Zapatilla.MarcaDelCalzado;
            lblPrecio.Text = Convert.ToString(Zapatilla.PrecioDelCalzado);
            lblStock.Text = Convert.ToString(Zapatilla.StockDelCalzado);
            timer1.Stop();
        }

        public void UpDownCantidad_ValueChanged(object sender, EventArgs e)
        {
            int StockTotal = Convert.ToInt32(lblStock.Text); //Este es el stock total de zapatillas

            int PrecioUnidad = Convert.ToInt32(lblPrecio.Text); //Este es el precio de una zapatilla

            decimal CantidadUnidad = UpDownCantidad.Value; //Esta es la cantidad de zapatillas que se lleva

            decimal Resultado = PrecioUnidad * CantidadUnidad; //Este es el precio final.

            if (CantidadUnidad > StockTotal) 
            {
                MessageBox.Show("Lo sentimos. No tenemos suficiente Stock", "Error");
                UpDownCantidad.Value = StockTotal;
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Tienda tienda = new Tienda();
            tienda.Show();
        }



        private void btnConfirm_Click(object sender, EventArgs e)
        {
            ProgressBar.Visible = true;
            timer1.Start();
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            UpDownCantidad.Visible = false;
            lblNombre.Visible = false;
            lblMarca.Visible = false;
            lblPrecio.Visible = false;
            lblStock.Visible = false;
            btnCancel.Visible = false;
            btnConfirm.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (ProgressBar.Value < ProgressBar.Maximum)
            {
                ProgressBar.Value = ProgressBar.Value + 2;
            }
            else
            {
                ProgressBar.Visible = false;
                button1.Visible = true;
                pictureBox2.Visible = true;
                label6.Visible = true;
                timer1.Stop();

            }
        } 
        public struct DetalleVenta 
        {
            public string DetalleNombreS;
            public string DetalleMarcaS;
            public int DetalleCantidadS;
            public int DetalleTotalS;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int PrecioUnidad = Convert.ToInt32(lblPrecio.Text);

            decimal CantidadUnidad = UpDownCantidad.Value;

            decimal Resultado = PrecioUnidad * CantidadUnidad;

            DetalleVenta Detalle = new DetalleVenta();
            Detalle.DetalleNombreS = lblNombre.Text;
            Detalle.DetalleMarcaS = lblMarca.Text;
            Detalle.DetalleCantidadS = Convert.ToInt32(UpDownCantidad.Value);
            Detalle.DetalleTotalS = Convert.ToInt32(Resultado);
            DetalleCompra Form = new DetalleCompra(Detalle);
            this.Hide();
            Form.Show();
        }
    }
}
