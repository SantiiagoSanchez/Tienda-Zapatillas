using Datos.cs;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios.cs
{
    public class NegCliente
    {
        private DatosClientes objDatosClientes = new DatosClientes();

        public NegCliente() 
        {
            Cliente objCliente = new Cliente();
        }

        public List<Cliente> CargarCliente() 
        {
            return objDatosClientes.CargarCliente();
        }

        public int AddCliente(string accion, Cliente objCliente) 
        {
            return objDatosClientes.AddCliente(accion, objCliente);
        }
    }
}
