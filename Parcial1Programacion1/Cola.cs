using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1Programacion1
{
    internal class Cola
    {
        Nodo _inicio;

        public void Encolar(Nodo unNodo)
        {
            if (_inicio == null)
            {
                _inicio = unNodo;
            }
            else
            {
                // Encontramos el final de la cola y al ultimo le agregamos una nueva
                // La variable auxiliar nos permite apuntar al ultimo nodo de la lista
                Nodo aux = BuscarUltimo(_inicio); // Nos devuelve el ultimo nodo
                aux.Siguiente = unNodo; // Decimos que el siguiente el ultimo es el Nodo que queremos encolar
            }
        }

        // Funcion recursiva
        private Nodo BuscarUltimo(Nodo unNodo)
        {
            // Si el Nodo.siguiente es null, entonces ese es el ultimo
            if (unNodo.Siguiente == null)
            {
                return unNodo;
            }
            else
            {
                return BuscarUltimo(unNodo.Siguiente);
            }
        }


        // Quitar el elemento que esta adelante
        public void Desencolar()
        {

            _inicio = _inicio.Siguiente;
        }

        // Permite conocer el inicio de la cola, sin modificar la estructura
        public Nodo Inicio
        {
            get
            {
                return _inicio;
            }
        }

        public bool Vacia()
        {
            return (_inicio == null);
        }
    }
}
