using System;

namespace colaDinamica.Models
{
    public class ColaDinamica
    {
        public NodoCola nodoFrente;
        public NodoCola nodoFinal;
        public int cantidadNodos;

        public ColaDinamica()
        {
            nodoFrente = null;
            nodoFinal = null;
            cantidadNodos = 0;
        }

        public void Insertar(int valor)
        {
            NodoCola nuevoNodo = new NodoCola(valor);

            if (cantidadNodos == 0)
            {
                nodoFrente = nuevoNodo;
                nodoFinal = nuevoNodo;
            }
            else
            {
                nodoFinal.enlaceSiguiente = nuevoNodo;
                nodoFinal = nuevoNodo;
            }

            cantidadNodos++;
            Console.WriteLine("Se inserto el numero " + valor + ".");
        }

        public void Eliminar()
        {
            if (cantidadNodos == 0)
            {
                Console.WriteLine("La cola esta vacia.");
                return;
            }

            int valorBorrado = nodoFrente.valorDato;
            nodoFrente = nodoFrente.enlaceSiguiente;
            cantidadNodos--;

            if (cantidadNodos == 0)
            {
                nodoFinal = null;
            }

            Console.WriteLine("Se elimino el numero " + valorBorrado + ".");
        }

        public void Imprimir()
        {
            if (cantidadNodos == 0)
            {
                Console.WriteLine("La cola esta vacia.");
                return;
            }

            NodoCola viajero = nodoFrente;
            Console.Write("Frente -> ");
            while (viajero != null)
            {
                Console.Write("[" + viajero.valorDato + "] -> ");
                viajero = viajero.enlaceSiguiente;
            }
            Console.WriteLine("NULL");
        }
    }
}