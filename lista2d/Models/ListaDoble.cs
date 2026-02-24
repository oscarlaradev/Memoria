using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2D.Models
{
    public class NodoLista2D
    {
        public ListaSimpleInterna listaInterna;
        public NodoLista2D enlaceSiguiente;

        public NodoLista2D(ListaSimpleInterna nuevaLista)
        {
            listaInterna = nuevaLista;
            enlaceSiguiente = null;
        }
    }

    public class Lista2D
    {
        public NodoLista2D nodoInicio;
        public int cantidadListas;

        public Lista2D()
        {
            nodoInicio = null;
            cantidadListas = 0;
        }

        public void AgregarLista(ListaSimpleInterna listaNueva)
        {
            NodoLista2D nuevoNodo = new NodoLista2D(listaNueva);

            if (cantidadListas == 0)
            {
                nodoInicio = nuevoNodo;
            }
            else
            {
                NodoLista2D viajero = nodoInicio;
                while (viajero.enlaceSiguiente != null)
                {
                    viajero = viajero.enlaceSiguiente;
                }
                viajero.enlaceSiguiente = nuevoNodo;
            }

            cantidadListas++;
            Console.WriteLine("Lista agregada en posicion " + cantidadListas + ".");
        }

        public void BorrarLista(int posicion)
        {
            if (cantidadListas == 0)
            {
                Console.WriteLine("No hay listas para borrar.");
                return;
            }

            if (posicion < 1 || posicion > cantidadListas)
            {
                Console.WriteLine("Posicion incorrecta. Usa del 1 al " + cantidadListas);
                return;
            }

            if (posicion == 1)
            {
                nodoInicio = nodoInicio.enlaceSiguiente;
            }
            else
            {
                NodoLista2D previo = nodoInicio;
                for (int i = 1; i < posicion - 1; i++)
                {
                    previo = previo.enlaceSiguiente;
                }
                previo.enlaceSiguiente = previo.enlaceSiguiente.enlaceSiguiente;
            }

            cantidadListas--;
            Console.WriteLine("Se borro la lista en la posicion " + posicion + ".");
        }

        public void InvertirListaEnPosicion(int posicion)
        {
            ListaSimpleInterna lista = ObtenerListaPorPosicion(posicion);
            if (lista == null)
            {
                return;
            }

            lista.Invertir();
            Console.WriteLine("La lista de la posicion " + posicion + " fue invertida.");
        }

        public void ImprimirListaEnPosicion(int posicion)
        {
            ListaSimpleInterna lista = ObtenerListaPorPosicion(posicion);
            if (lista == null)
            {
                return;
            }

            Console.Write("Lista en posicion " + posicion + ": ");
            lista.Imprimir();
        }

        private ListaSimpleInterna ObtenerListaPorPosicion(int posicion)
        {
            if (cantidadListas == 0)
            {
                Console.WriteLine("No hay listas en Lista2D.");
                return null;
            }

            if (posicion < 1 || posicion > cantidadListas)
            {
                Console.WriteLine("Posicion incorrecta. Usa del 1 al " + cantidadListas);
                return null;
            }

            NodoLista2D viajero = nodoInicio;
            for (int i = 1; i < posicion; i++)
            {
                viajero = viajero.enlaceSiguiente;
            }

            return viajero.listaInterna;
        }
    }
}