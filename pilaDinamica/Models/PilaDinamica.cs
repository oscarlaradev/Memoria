using System;

namespace pilaDinamica.Models
{
    public class PilaDinamica
    {
        public int capacidadMaxima;
        public NodoPila nodoTope;
        public int cantidadNodos;

        public PilaDinamica()
        {
            // La pila tendra un maximo de 5 elementos.
            capacidadMaxima = 5;
            nodoTope = null;
            cantidadNodos = 0;
        }

        public void Apilar(int valor)
        {
            if (cantidadNodos >= capacidadMaxima)
            {
                Console.WriteLine("La pila ya esta llena. Capacidad maxima: " + capacidadMaxima);
                return;
            }

            // El nuevo nodo se conecta arriba del tope actual.
            NodoPila nuevoNodo = new NodoPila(valor);
            nuevoNodo.enlaceSiguiente = nodoTope;
            nodoTope = nuevoNodo;
            cantidadNodos++;
            Console.WriteLine("Se apilo el numero " + valor + ".");
        }

        public void Desapilar()
        {
            if (cantidadNodos == 0)
            {
                Console.WriteLine("La pila esta vacia.");
                return;
            }

            int valorBorrado = nodoTope.valorDato;
            nodoTope = nodoTope.enlaceSiguiente;
            cantidadNodos--;
            Console.WriteLine("Se desapilo el numero " + valorBorrado + ".");
        }

        public void Imprimir()
        {
            if (cantidadNodos == 0)
            {
                Console.WriteLine("La pila esta vacia.");
                return;
            }

            // Recorremos desde el tope hasta el final.
            NodoPila viajero = nodoTope;
            Console.Write("Tope -> ");
            while (viajero != null)
            {
                Console.Write("[" + viajero.valorDato + "] -> ");
                viajero = viajero.enlaceSiguiente;
            }
            Console.WriteLine("NULL");
        }
    }
}