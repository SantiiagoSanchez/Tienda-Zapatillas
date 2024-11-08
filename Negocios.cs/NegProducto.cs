using Datos.cs;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios.cs
{
    public class NegProducto
    {
        DatosProducto objDatosProducto = new DatosProducto();

        public int abmProductos(string accion, Producto objProducto)
        {
            return objDatosProducto.abmProductos(accion, objProducto);
        }
        public DataSet listaProductos(string cual)
        {
            return objDatosProducto.listaProductos(cual);
        }

        public DataSet listaProductosAdmin(string cual) 
        {
            return objDatosProducto.listaProductosAdmin(cual);
        }
    }
}
