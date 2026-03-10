using System;

namespace colaEstatica.Models
{
    public class ColaEstatica
    {
        private int[] arregloCola;
        private int frente;
        private int final;
        private int cantidad;
        private int capacidad;

        public ColaEstatica()
        {
            capacidad = 5;
            arregloCola = new int[capacidad];
            frente = 0;
            final = 0;
            cantidad = 0;
        }

        public void Encolar(int valor)
        {
            if (cantidad == capacidad)
            {
                Console.WriteLine("La cola esta llena. Capacidad maxima: " + capacidad);
                return;
            }

            arregloCola[final] = valor;
            final = (final + 1) % capacidad;
            cantidad++;
            Console.WriteLine("Se encolo el numero " + valor + ".");
        }

        public void Desencolar()
        {
            if (cantidad == 0)
            {
                Console.WriteLine("La cola esta vacia.");
                return;
            }

            int valorBorrado = arregloCola[frente];
            frente = (frente + 1) % capacidad;
            cantidad--;
            Console.WriteLine("Se desencolo el numero " + valorBorrado + ".");
        }

        public void Imprimir()
        {
            if (cantidad == 0)
            {
                Console.WriteLine("La cola esta vacia.");
                return;
            }

            Console.Write("Frente -> ");
            for (int i = 0; i < cantidad; i++)
            {
                int indice = (frente + i) % capacidad;
                Console.Write("[" + arregloCola[indice] + "] -> ");
            }
            Console.WriteLine("NULL");
        }
    }
}