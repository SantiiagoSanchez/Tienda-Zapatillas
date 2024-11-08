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
using Negocios.cs;

namespace Presentacion.cs
{
    public partial class AdministrarTienda : Form
    {
        public Producto EntProduto = new Producto();
        public NegProducto NegProducto = new NegProducto();
        public AdministrarTienda()
        {
            InitializeComponent();
            DGVProductos.ColumnCount = 6;
            DGVProductos.Columns[0].HeaderText = "Id";
            DGVProductos.Columns[1].HeaderText = "Nombre";
            DGVProductos.Columns[2].HeaderText = "Marca";
            DGVProductos.Columns[3].HeaderText = "Categoria";
            DGVProductos.Columns[4].HeaderText = "Precio";
            DGVProductos.Columns[5].HeaderText = "Stock";
            LlenarDGV();
        }

        private void LlenarDGV()
        {
            DGVProductos.Rows.Clear();
            DataSet ds = new DataSet();
            ds = NegProducto.listaProductos("Todos");
            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    DGVProductos.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString());
                }
            }
            else
            {
                MessageBox.Show("Todavia no hay productos cargados en el sistema");
            }
        }

        private void TxtBox_a_Obj()
        {
            EntProduto.IdProd = int.Parse(txtId.Text);
            EntProduto.Nombre = txtNombre.Text;
            EntProduto.Marca = txtMarca.Text;
            EntProduto.Categoria = txtCategoria.Text;
            EntProduto.Precio = decimal.Parse(txtPrecio.Text);
            EntProduto.Stock = int.Parse(txtStock.Text);
        }

        private void Limpiar()
        {
            txtId.Text = "";
            txtNombre.Text = "";
            txtMarca.Text = "";
            txtCategoria.Text = "";
            txtPrecio.Text = "";
            txtStock.Text = "";
        }

        private void btnAnadir_Click(object sender, EventArgs e)
        {
            int nGrabados = -1;
            TxtBox_a_Obj();
            nGrabados = NegProducto.abmProductos("Alta", EntProduto);

            if (nGrabados == -1)
            {
                MessageBox.Show("No se pudo grabar productos en el sistema");
            }
            else
            {
                MessageBox.Show("El producto se grabo con exito");
                LlenarDGV();
                Limpiar();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int nElim = -1;
            TxtBox_a_Obj();
            nElim = NegProducto.abmProductos("Baja", EntProduto);
            if (nElim == -1)
            {
                MessageBox.Show("No se pudo eliminar el producto");
            }
            else
            {
                MessageBox.Show("El producto se elimino con exito");
                LlenarDGV();
            }
        }

        private void DGVProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataSet ds = new DataSet();
            EntProduto.IdProd = Convert.ToInt32(DGVProductos.CurrentRow.Cells[0].Value);
            ds = NegProducto.listaProductos(EntProduto.IdProd.ToString());
            if (ds.Tables[0].Rows.Count > 0)
            {
                Ds_a_TxtBox(ds);
            }
        }
        private void Ds_a_TxtBox(DataSet ds)
        {
            txtId.Text = ds.Tables[0].Rows[0]["IdProd"].ToString();
            txtNombre.Text = ds.Tables[0].Rows[0]["Nombre"].ToString();
            txtMarca.Text = ds.Tables[0].Rows[0]["Marca"].ToString();
            txtCategoria.Text = ds.Tables[0].Rows[0]["Categoria"].ToString();
            txtPrecio.Text = ds.Tables[0].Rows[0]["Precio"].ToString();
            txtStock.Text = ds.Tables[0].Rows[0]["Stock"].ToString();
            txtId.Enabled = false;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int nResult = -1;
            TxtBox_a_Obj();
            nResult = NegProducto.abmProductos("Modificar", EntProduto);
            if (nResult != -1)
            {
                MessageBox.Show("El producto se modifico con exito");
                Limpiar();
                LlenarDGV();
                txtId.Enabled = true;
            }
            else
            {
                MessageBox.Show("No se pudo modificar el producto");
            }

        }
    }
}
