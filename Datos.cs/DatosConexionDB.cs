using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.cs
{
    public class DatosConexionDB
    {
        public OleDbConnection conexion;
        public string cadenaConexion = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Sanch\OneDrive\Escritorio\Tienda-de-Zapatillas.accdb";

        public DatosConexionDB()
        {
            conexion = new OleDbConnection(cadenaConexion);
        }

        public void AbrirConexion()
        {
            try
            {
                if (conexion.State == ConnectionState.Broken || conexion.State == ConnectionState.Closed) conexion.Open();

            }
            catch (Exception e)
            {
                throw new Exception("Error al tratar de abrir la conexion", e);
            }
        }

        public void CerrarConexion()
        {
            try
            {
                if (conexion.State == ConnectionState.Open) conexion.Close();
            }
            catch (Exception e)
            {

                throw new Exception("Error añ tratar de cerrar la conexion", e);
            }
        }
    }
}

