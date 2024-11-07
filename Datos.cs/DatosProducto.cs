﻿using Entidades;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.cs
{
    public class DatosProducto : DatosConexionDB
    {
        public int abmProductos(string accion, Producto objProducto)
        {
            int resultado = -1;
            OleDbCommand cmd = new OleDbCommand();

            cmd.Connection = conexion;

            try
            {
                AbrirConexion();

                if (accion == "Alta")
                {
                    cmd.CommandText = "Insert into Producto values (@IdProd, @Nombre, @Marca, @Categoria, @Precio, @Cantstock)";
                    cmd.Parameters.AddWithValue("@IdProd", objProducto.IdProd);
                    cmd.Parameters.AddWithValue("@Nombre", objProducto.Nombre);
                    cmd.Parameters.AddWithValue("@Marca", objProducto.Marca);
                    cmd.Parameters.AddWithValue("@Categoria", objProducto.Categoria);
                    cmd.Parameters.AddWithValue("@Precio", objProducto.Precio);
                    cmd.Parameters.AddWithValue("@Cantstock", objProducto.Stock);
                }

                else if (accion == "Modificar")
                {
                    
                    cmd.CommandText = "UPDATE Producto SET Nombre = '" + objProducto.Nombre + "', Marca = '" + objProducto.Marca + "', Categoria = '" + objProducto.Categoria + "', Precio = '" + objProducto.Precio + "' WHERE IdProd = @IdProd;";
                    cmd.Parameters.AddWithValue("@IdProd", objProducto.IdProd);
                    cmd.Parameters.AddWithValue("@Nombre", objProducto.Nombre);
                    cmd.Parameters.AddWithValue("@Marca", objProducto.Marca);
                    cmd.Parameters.AddWithValue("@Categoria", objProducto.Categoria);
                    cmd.Parameters.AddWithValue("@Precio", objProducto.Precio);
                }
                else if (accion == "Baja")
                {
                    cmd.CommandText = "Delete from Producto where IdProd = @IdProd";
                    cmd.Parameters.AddWithValue("@IdProd", objProducto.IdProd);
                }

                resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Error al tratar de guardar, borrar o modificar Producto", e);
            }
            finally
            {
                CerrarConexion();
                cmd.Dispose();
            }
            return resultado;
        }

        public DataSet listaProductos(string cual)
        {
            string orden = string.Empty;
            if (cual != "Todos")
                orden = "Select * from Producto where IdProd = " + int.Parse(cual) + ";";
            else
                orden = "Select * from Producto;";
            OleDbCommand cmd = new OleDbCommand(orden, conexion);
            DataSet ds = new DataSet();
            OleDbDataAdapter da = new OleDbDataAdapter();
            try
            {
                AbrirConexion();
                cmd.ExecuteNonQuery();
                da.SelectCommand = cmd;
                da.Fill(ds);
            }
            catch (Exception e)
            {
                throw new Exception("Error al listar Producto", e);
            }
            finally
            {
                CerrarConexion();
                cmd.Dispose();
            }
            return ds;
        }
    }
}

