using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2D.Models
{
    public class ListaSimpleInterna
    {
        public NodoDoble nodoInicio;
        public int cantidadNodos;

        public ListaSimpleInterna()
        {
            nodoInicio = null;
            cantidadNodos = 0;
        }

        public void Agregar(int valor)
        {
            if (cantidadNodos == 0)
            {
                nodoInicio = new NodoDoble(valor);
            }
            else
            {
                NodoDoble viajero = nodoInicio;
                while (viajero.enlaceSiguiente != null)
                {
                    viajero = viajero.enlaceSiguiente;
                }
                viajero.enlaceSiguiente = new NodoDoble(valor);
            }

            cantidadNodos++;
        }

        public void Invertir()
        {
            if (cantidadNodos <= 1)
            {
                return;
            }

            NodoDoble previo = null;
            NodoDoble actual = nodoInicio;

            while (actual != null)
            {
                NodoDoble siguiente = actual.enlaceSiguiente;
                actual.enlaceSiguiente = previo;
                previo = actual;
                actual = siguiente;
            }

            nodoInicio = previo;
        }

        public void Imprimir()
        {
            if (cantidadNodos == 0)
            {
                Console.WriteLine("La lista esta vacia.");
                return;
            }

            NodoDoble viajero = nodoInicio;
            while (viajero != null)
            {
                Console.Write("[" + viajero.valorDato + "] -> ");
                viajero = viajero.enlaceSiguiente;
            }
            Console.WriteLine("FIN");
        }
    }
}