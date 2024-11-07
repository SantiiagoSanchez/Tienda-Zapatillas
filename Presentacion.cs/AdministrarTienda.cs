using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Negocios;

namespace Presentacion.cs
{
    public partial class AdministrarTienda : Form
    {
        public Producto EntProduto = new Producto();

        public AdministrarTienda()
        {
            InitializeComponent();
        }
    }
}
