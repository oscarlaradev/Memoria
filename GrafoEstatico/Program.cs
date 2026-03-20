using System;
using GrafoEstatico.Models;

namespace GrafoEstatico
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Bienvenido al programa de Grafo Estático");
            Console.Write("Ingresa el número de vértices del grafo: ");

            Grafo grafo = new Grafo(int.Parse(Console.ReadLine()));


            Console.WriteLine("Ingresa el número de aristas del grafo: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("introduce inicio de la arista: ");
                int inicio = int.Parse(Console.ReadLine());
                Console.WriteLine("introduce fin de la arista: ");
                int fin = int.Parse(Console.ReadLine());
                Console.WriteLine("introduce peso de la arista: ");
                grafo.setEdge(inicio, fin, double.Parse(Console.ReadLine()));
            }
            Console.WriteLine("imprime el grafo: ");
            grafo.ImprimirGrafo();
		}
	}
}
