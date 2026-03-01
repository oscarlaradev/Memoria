using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3D.Models
{
    // Nodo de dimension 3: guarda una lista 2D.
    public class Nodo3D
    {
        public Lista2DInterna listaInterna2D;
        public Nodo3D enlaceSiguiente;

        public Nodo3D(Lista2DInterna nuevaLista2D)
        {
            listaInterna2D = nuevaLista2D;
            enlaceSiguiente = null;
        }
    }

    // Esta clase representa la lista 3D (lista de listas 2D).
    public class Lista3DContenedor
    {
        public Nodo3D nodoInicio;
        public int cantidadListas2D;

        public Lista3DContenedor()
        {
            nodoInicio = null;
            cantidadListas2D = 0;
        }

        // Agrega una lista2D al final de la lista3D.
        public void AgregarLista2D(Lista2DInterna nuevaLista2D)
        {
            Nodo3D nuevoNodo = new Nodo3D(nuevaLista2D);

            if (cantidadListas2D == 0)
            {
                nodoInicio = nuevoNodo;
            }
            else
            {
                Nodo3D viajero = nodoInicio;
                while (viajero.enlaceSiguiente != null)
                {
                    viajero = viajero.enlaceSiguiente;
                }
                viajero.enlaceSiguiente = nuevoNodo;
            }

            cantidadListas2D++;
            Console.WriteLine("Lista2D agregada en posicion " + cantidadListas2D + ".");
        }

        // Imprime todo el contenido de la lista3D.
        public void ImprimirContenidoCompleto()
        {
            if (cantidadListas2D == 0)
            {
                Console.WriteLine("Lista3D vacia. No hay contenido para mostrar.");
                return;
            }

            Nodo3D viajero = nodoInicio;
            int posicion2D = 1;

            while (viajero != null)
            {
                Console.WriteLine("Lista2D #" + posicion2D + ":");
                viajero.listaInterna2D.Imprimir();
                Console.WriteLine();

                viajero = viajero.enlaceSiguiente;
                posicion2D++;
            }
        }
    }
}