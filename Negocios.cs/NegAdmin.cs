using Datos.cs;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios.cs
{
    public class NegAdmin
    {
        private DatosAdmin objDatosAdmin = new DatosAdmin();

        public NegAdmin() 
        {
            Administrador Admin = new Administrador();
        }

        public List<Administrador> CargarAdministrador() 
        {
            return objDatosAdmin.CargarAdministrador();
        }
    }
}
