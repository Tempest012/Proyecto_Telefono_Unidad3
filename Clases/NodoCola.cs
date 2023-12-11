using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Telefono_Unidad3.Clases
{
    public class NodoCola
    {
        public string Dato { get; set; }
        public string Model { get; set; }
        public string Memoria { get; set; }
        public double Precios { get; set; }
        public NodoCola Siguiente { get; set; }
    }
}
