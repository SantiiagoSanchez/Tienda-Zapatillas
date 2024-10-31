using Entidades;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.cs
{
    public class DatosClientes : DatosConexionDB
    {
        private DatosConexionDB _conexion;

        public DatosClientes() 
        {
            _conexion = new DatosConexionDB();
        }

        public List<Cliente> CargarCliente()
        {
            try
            {
                _conexion.AbrirConexion();
                string Cons = "Select IdUsuario, Contrasena from Cliente";
                OleDbCommand comand = new OleDbCommand(Cons, _conexion.conexion);
                OleDbDataReader lector = comand.ExecuteReader();

                List<Cliente> listaUser = new List<Cliente>();

                while (lector.Read())
                {
                    Cliente user = new Cliente();

                    user.IdUsuario = lector["IdUsuario"].ToString();
                    user.Contrasena = lector["Contrasena"].ToString();

                    listaUser.Add(user);
                }

                return listaUser;
            }
            catch (Exception e)
            {
                throw new Exception("Error al cargar Cliente", e);
            }
            finally
            {
                _conexion.CerrarConexion();
            }
        }

        public int AddCliente(string accion, Cliente objCliente)
        {
            int resultado = -1;
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = conexion;
            try
            {
                AbrirConexion();

                if (accion == "add")
                {
                    cmd.CommandText = "Insert into Cliente values (@IdUsuario, @Nombre, @Direccion, @Contrasena)";
                    cmd.Parameters.AddWithValue("@IdUsuario", objCliente.IdUsuario);
                    cmd.Parameters.AddWithValue("@Nombre", objCliente.Nombre);
                    cmd.Parameters.AddWithValue("@Direccion", objCliente.Direccion);
                    cmd.Parameters.AddWithValue("@Contrasena", objCliente.Contrasena);
                }
                resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("No se pudo registrar", e);
            }
            finally
            {
                CerrarConexion();
                cmd.Dispose();
            }
            return resultado;
        }
    }
}
