using System;
using GrafoDinamico.Models;

namespace GrafoDinamico
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¡Bienvenido al programa de Grafo Dinámico!");
            Grafo G = new Grafo(4);
            G.AgregarArista(0,1,3.0);
            G.AgregarArista(0,2,1.5);
            G.AgregarArista(1,2,2.0);
            G.AgregarArista(1,3,4.0);
            G.Imprimir();
        }
    }
}