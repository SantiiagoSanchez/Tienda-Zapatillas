using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Producto
    {
        #region ATRIBUTOS
        private int id;
        private string nombre;
        private string marca;
        private string categoria;
        private decimal precio;
        private int stock;
        #endregion

        #region CONSTRUCTOR
        public Producto()
        {
            nombre = string.Empty;
            marca = string.Empty;
            categoria = string.Empty;
            precio = 0;
            stock = 0;
        }
        #endregion

        #region PROPIEDADES/ENCAPSULAMIENTO

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        public string Categoria
        {
            get { return categoria; }
            set { categoria = value; }
        }

        public decimal Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        public int Stock
        {
            get { return stock; }
            set { stock = value; }
        }

        public int IdProd
        {
            get { return id; }
            set { id = value; }
        }

        #endregion
    }
}
