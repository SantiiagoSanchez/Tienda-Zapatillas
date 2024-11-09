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
    public partial class Tienda : Form
    {
        public NegProducto NegProducto = new NegProducto();
        public Producto EntProducto = new Producto();

        public string NombreCalzado = string.Empty;
        public string MarcaCalzado = string.Empty;
        public string PrecioCalzado = string.Empty;

        public Tienda()
        {
            InitializeComponent();
            DgvProductos.ColumnCount = 6;
            DgvProductos.Columns[0].HeaderText = "Id";
            DgvProductos.Columns[1].HeaderText = "Nombre";
            DgvProductos.Columns[2].HeaderText = "Marca";
            DgvProductos.Columns[3].HeaderText = "Categoria";
            DgvProductos.Columns[4].HeaderText = "Precio";
            DgvProductos.Columns[5].HeaderText = "Stock";
            LlenarDGV();
            btnAddCarrito.Visible = false;
        }

        private void LlenarDGV()
        {
            DgvProductos.Rows.Clear();
            DataSet ds = new DataSet();
            ds = NegProducto.listaProductos("Todos");
            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    DgvProductos.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString());
                }
            }
            else
            {
                MessageBox.Show("Todavia no hay productos cargados en el sistema");
            }
        }

        #region TOOLSTRIPCLICK

        private void zapatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DgvProductos.Rows.Clear();
            DataSet ds = new DataSet();
            ds = NegProducto.listaProductos("Zapatos");

            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    DgvProductos.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString());
                }
            }
            else
            {
                MessageBox.Show("Nos quedamos sin stock en zapatos");
            }
        }

        private void casualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DgvProductos.Rows.Clear();
            DataSet ds = new DataSet();
            ds = NegProducto.listaProductos("Casual");

            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    DgvProductos.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString());
                }
            }
            else
            {
                MessageBox.Show("Nos quedamos sin stock en casuales");
            }
        }

        private void deportivaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DgvProductos.Rows.Clear();
            DataSet ds = new DataSet();
            ds = NegProducto.listaProductos("Deportiva");

            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    DgvProductos.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString());
                }
            }
            else
            {
                MessageBox.Show("Nos quedamos sin stock en deportivas");
            }
        }

        private void urbanaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DgvProductos.Rows.Clear();
            DataSet ds = new DataSet();
            ds = NegProducto.listaProductos("Urbana");

            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    DgvProductos.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString());
                }
            }
            else
            {
                MessageBox.Show("Nos quedamos sin stock en urbanas");
            }
        }

        private void gucciToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DgvProductos.Rows.Clear();
            DataSet ds = new DataSet();
            ds = NegProducto.listaProductos("Zapatos Gucci");

            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    DgvProductos.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString());
                }
            }
            else
            {
                MessageBox.Show("Nos quedamos sin stock en Zapatos Gucci");
            }
        }

        private void versaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DgvProductos.Rows.Clear();
            DataSet ds = new DataSet();
            ds = NegProducto.listaProductos("Zapatos Louis");

            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    DgvProductos.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString());
                }
            }
            else
            {
                MessageBox.Show("Nos quedamos sin stock en zapatos Louis Vuitton");
            }
        }

        private void adidasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DgvProductos.Rows.Clear();
            DataSet ds = new DataSet();
            ds = NegProducto.listaProductos("Casual Adidas");

            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    DgvProductos.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString());
                }
            }
            else
            {
                MessageBox.Show("Nos quedamos sin stock en casuales Adidas");
            }
        }

        private void nikeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DgvProductos.Rows.Clear();
            DataSet ds = new DataSet();
            ds = NegProducto.listaProductos("Deportiva Nike");

            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    DgvProductos.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString());
                }
            }
            else
            {
                MessageBox.Show("Nos quedamos sin stock en deportivas Nike");
            }
        }

        private void pumaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DgvProductos.Rows.Clear();
            DataSet ds = new DataSet();
            ds = NegProducto.listaProductos("Deportiva Puma");

            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    DgvProductos.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString());
                }
            }
            else
            {
                MessageBox.Show("Nos quedamos sin stock en deportivas Puma");
            }
        }

        private void vansToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DgvProductos.Rows.Clear();
            DataSet ds = new DataSet();
            ds = NegProducto.listaProductos("Urbana Vans");

            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    DgvProductos.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString());
                }
            }
            else
            {
                MessageBox.Show("Nos quedamos sin stock en urbanas Vans");
            }
        }

        private void nikeToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            DgvProductos.Rows.Clear();
            DataSet ds = new DataSet();
            ds = NegProducto.listaProductos("Casual Nike");

            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    DgvProductos.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString());
                }
            }
            else
            {
                MessageBox.Show("Nos quedamos sin stock en casuales Nike");
            }
        }

        private void topperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DgvProductos.Rows.Clear();
            DataSet ds = new DataSet();
            ds = NegProducto.listaProductos("Urbana Topper");

            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    DgvProductos.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString());
                }
            }
            else
            {
                MessageBox.Show("Nos quedamos sin stock en urbanas Topper");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 Form = new Form1();
            this.Hide();
            Form.Show();
        }

        private void nikeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DgvProductos.Rows.Clear();
            DataSet ds = new DataSet();
            ds = NegProducto.listaProductos("Nike");

            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    DgvProductos.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString());
                }
            }
            else
            {
                MessageBox.Show("Nos quedamos sin stock en Nike");
            }
        }

        private void adidasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DgvProductos.Rows.Clear();
            DataSet ds = new DataSet();
            ds = NegProducto.listaProductos("Adidas");

            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    DgvProductos.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString());
                }
            }
            else
            {
                MessageBox.Show("Nos quedamos sin stock en Adidas");
            }
        }

        private void pumaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DgvProductos.Rows.Clear();
            DataSet ds = new DataSet();
            ds = NegProducto.listaProductos("Puma");

            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    DgvProductos.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString());
                }
            }
            else
            {
                MessageBox.Show("Nos quedamos sin stock en Puma");
            }
        }

        private void gucciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DgvProductos.Rows.Clear();
            DataSet ds = new DataSet();
            ds = NegProducto.listaProductos("Gucci");

            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    DgvProductos.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString());
                }
            }
            else
            {
                MessageBox.Show("Nos quedamos sin stock en Gucci");
            }
        }

        private void vansToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DgvProductos.Rows.Clear();
            DataSet ds = new DataSet();
            ds = NegProducto.listaProductos("Vans");

            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    DgvProductos.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString());
                }
            }
            else
            {
                MessageBox.Show("Nos quedamos sin stock en Vans");
            }
        }

        private void topperToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DgvProductos.Rows.Clear();
            DataSet ds = new DataSet();
            ds = NegProducto.listaProductos("Topper");

            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    DgvProductos.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString());
                }
            }
            else
            {
                MessageBox.Show("Nos quedamos sin stock en Topper");
            }
        }

        private void louisVuittonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DgvProductos.Rows.Clear();
            DataSet ds = new DataSet();
            ds = NegProducto.listaProductos("Louis");

            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    DgvProductos.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString());
                }
            }
            else
            {
                MessageBox.Show("Nos quedamos sin stock en Louis Vuitton");
            }
        }


        #endregion


        private void Ds_a_Stng(DataSet ds)
        {
            NombreCalzado = ds.Tables[0].Rows[0]["Nombre"].ToString();
            MarcaCalzado = ds.Tables[0].Rows[0]["Marca"].ToString();
            PrecioCalzado = ds.Tables[0].Rows[0]["Precio"].ToString();
        }

        private void btnAddCarrito_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La zapatilla se añadio al carrito");
        }


        private void DgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnAddCarrito.Visible = true;
            DataSet ds = new DataSet();
            EntProducto.IdProd = Convert.ToInt32(DgvProductos.CurrentRow.Cells[0].Value);
            ds = NegProducto.listaProductosAdmin(EntProducto.IdProd.ToString());
            if (ds.Tables[0].Rows.Count > 0)
            {
                Ds_a_Stng(ds);
            }
        }

        private void btnMiCarrito_Click(object sender, EventArgs e)
        {
            Products Zapatilla = new Products();
            if (string.IsNullOrEmpty(NombreCalzado) && string.IsNullOrEmpty(MarcaCalzado) && string.IsNullOrEmpty(PrecioCalzado)) 
            {
                MessageBox.Show("No hay productos en el carrito", "Mi Carrito");
                return;
            }

            Zapatilla.NombreDelCalzado = NombreCalzado;
            Zapatilla.MarcaDelCalzado = MarcaCalzado;
            Zapatilla.PrecioDelCalzado = Convert.ToInt32(PrecioCalzado);

        }

        public struct Products 
        {
            public string NombreDelCalzado;
            public string MarcaDelCalzado;
            public int PrecioDelCalzado;
        }
    }
}
