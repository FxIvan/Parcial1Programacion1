using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1Programacion1
{
    internal class Nodo
    {
        public string Impresora { get; set; }
        public int Copias { get; set; }
        public Nodo Siguiente { get; set; }

        public Nodo(string nombre, int copias)
        {
            Impresora = nombre;
            Copias = copias;
            Siguiente = null;
        }
    }
}
