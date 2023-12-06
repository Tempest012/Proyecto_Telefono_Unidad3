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
        private string model;
        private string memoria;
        private string precios;
        private Nodo siguiente;

        public string Dato
        {
            get { return dato; }
            set { dato = value; }
        }
        public string Model
        {
            get { return model; }
            set {  model = value; }
        }
        public string Memoria
        {
            get { return memoria; }
            set { memoria = value; }
        }
        public string Precios
        {
            get { return precios; }
            set { precios = value; }
        }
        public Nodo Siguiente
        {
            get { return siguiente; }
            set { siguiente = value; }
        }
    }
}
