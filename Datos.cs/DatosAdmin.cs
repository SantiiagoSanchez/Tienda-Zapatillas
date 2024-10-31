using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.cs
{
    public class DatosAdmin : DatosConexionDB
    {
        private DatosConexionDB _conexion;

        public DatosAdmin()
        {
            _conexion = new DatosConexionDB();
        }

        public List<Administrador> CargarAdministrador()
        {
            try
            {
                _conexion.AbrirConexion();
                string Cons = "Select Codigo, Contrasena from Administrador";
                OleDbCommand comand = new OleDbCommand(Cons, _conexion.conexion);
                OleDbDataReader lector = comand.ExecuteReader();

                List<Administrador> ListaAdmin = new List<Administrador>();

                while (lector.Read())
                {
                    Administrador user = new Administrador();

                    user.Codigo = lector["Codigo"].ToString();
                    user.Contrasena = lector["Contrasena"].ToString();

                    ListaAdmin.Add(user);
                }

                return ListaAdmin;
            }
            catch (Exception e)
            {
                throw new Exception("Error al cargar Administrador", e);
            }
            finally
            {
                _conexion.CerrarConexion();
            }
        }

    }
}
