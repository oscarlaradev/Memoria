using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3D.Models
{
    // Esta clase representa una lista 2D (lista de listas 1D).
    public class Lista2DInterna
    {
        public Nodo2D nodoInicio;
        public int cantidadListas1D;

        public Lista2DInterna()
        {
            nodoInicio = null;
            cantidadListas1D = 0;
        }

        // Agrega una lista 1D al final de la lista 2D.
        public void AgregarLista1D(Lista1D nuevaLista)
        {
            Nodo2D nuevoNodo = new Nodo2D(nuevaLista);

            if (cantidadListas1D == 0)
            {
                nodoInicio = nuevoNodo;
            }
            else
            {
                Nodo2D viajero = nodoInicio;
                while (viajero.enlaceSiguiente != null)
                {
                    viajero = viajero.enlaceSiguiente;
                }
                viajero.enlaceSiguiente = nuevoNodo;
            }

            cantidadListas1D++;
        }

        // Imprime todas las listas 1D que contiene esta lista 2D.
        public void Imprimir()
        {
            if (cantidadListas1D == 0)
            {
                Console.WriteLine("Lista2D vacia.");
                return;
            }

            Nodo2D viajero = nodoInicio;
            int posicion = 1;

            while (viajero != null)
            {
                Console.Write("  Lista1D #" + posicion + ": ");
                viajero.listaInterna1D.Imprimir();
                viajero = viajero.enlaceSiguiente;
                posicion++;
            }
        }
    }
}