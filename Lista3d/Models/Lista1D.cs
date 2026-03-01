using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3D.Models
{
    // Esta clase representa una lista simple de enteros.
    public class Lista1D
    {
        public Nodo1D nodoInicio;
        public int cantidadNodos;

        public Lista1D()
        {
            nodoInicio = null;
            cantidadNodos = 0;
        }

        // Agrega un valor al final de la lista 1D.
        public void Agregar(int valor)
        {
            if (cantidadNodos == 0)
            {
                nodoInicio = new Nodo1D(valor);
            }
            else
            {
                Nodo1D viajero = nodoInicio;
                while (viajero.enlaceSiguiente != null)
                {
                    viajero = viajero.enlaceSiguiente;
                }
                viajero.enlaceSiguiente = new Nodo1D(valor);
            }

            cantidadNodos++;
        }

        // Imprime el contenido de la lista 1D en una sola linea.
        public void Imprimir()
        {
            if (cantidadNodos == 0)
            {
                Console.WriteLine("Lista 1D vacia.");
                return;
            }

            Nodo1D viajero = nodoInicio;
            while (viajero != null)
            {
                Console.Write("[" + viajero.valorDato + "] -> ");
                viajero = viajero.enlaceSiguiente;
            }
            Console.WriteLine("FIN");
        }
    }
}