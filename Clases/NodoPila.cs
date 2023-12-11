using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Telefono_Unidad3.Clases
{
    public class NodoPila
    {
        private string nombre;
        private string model;
        private string memoria;
        private double precios;
        private NodoPila siguiente;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        public string Memoria
        {
            get { return memoria; }
            set { memoria = value; }
        }
        public double Precios
        {
            get { return precios; }
            set { precios = value; }
        }
        public NodoPila Siguiente
        {
            get { return siguiente; }
            set { siguiente = value; }
        }
    }
}
