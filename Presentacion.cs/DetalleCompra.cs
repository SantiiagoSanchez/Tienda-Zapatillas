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
    public partial class DetalleCompra : Form
    {
        public DateTime Fecha = DateTime.Today;
        public DetalleCompra(MiCarrito.DetalleVenta Detalle)
        {
            InitializeComponent();
            lblNombre.Text = Detalle.DetalleNombreS;
            lblMarca.Text = Detalle.DetalleMarcaS;
            lblCantidad.Text = Convert.ToString(Detalle.DetalleCantidadS);
            lblPrecio.Text = Convert.ToString(Detalle.DetalleTotalS);
            lblFecha.Text = Convert.ToString(Fecha);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
