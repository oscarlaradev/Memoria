using System;

namespace pilaEstatica.Models
{
    public class PilaEstatica
    {
        private int[] arregloPila;
        private int tope;
        private int capacidad;

        public PilaEstatica()
        {
            capacidad = 5;
            arregloPila = new int[capacidad];
            tope = -1;
        }

        public void Push(int valor)
        {
            if (tope == capacidad - 1)
            {
                Console.WriteLine("La pila ya esta llena. Capacidad maxima: " + capacidad);
                return;
            }

            tope++;
            arregloPila[tope] = valor;
            Console.WriteLine("Se hizo push del numero " + valor + ".");
        }

        public void Pop()
        {
            if (tope == -1)
            {
                Console.WriteLine("La pila esta vacia.");
                return;
            }

            int valorBorrado = arregloPila[tope];
            tope--;
            Console.WriteLine("Se hizo pop del numero " + valorBorrado + ".");
        }

        public void Imprimir()
        {
            if (tope == -1)
            {
                Console.WriteLine("La pila esta vacia.");
                return;
            }

            Console.Write("Tope -> ");
            for (int i = tope; i >= 0; i--)
            {
                Console.Write("[" + arregloPila[i] + "] -> ");
            }
            Console.WriteLine("NULL");
        }
    }
}