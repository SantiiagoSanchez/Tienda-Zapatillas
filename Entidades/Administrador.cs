using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Administrador
    {
        #region ATRIBUTOS

        public string codigo;

        private string contrasena;

        #endregion


        #region CONSTRUCTOR

        public Administrador()
        {
            codigo = string.Empty;

            contrasena = string.Empty;
        }

        #endregion

        #region PROPIEDADES/ENCAPSULAMIENTO

        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public string Contrasena
        {
            get { return contrasena; }
            set { contrasena = value; }
        }

        #endregion
    }
}
