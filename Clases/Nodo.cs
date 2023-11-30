using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Telefono_Unidad3.Clases
{
    internal class Nodo
    {
        private string dato;
        private Nodo siguiente;

        public string Dato
        {
            get { return dato; }
            set { dato = value; }
        }
        public Nodo Siguiente
        {
            get { return siguiente; }
            set { siguiente = value; }
        }
    }
}
