using System;
using pilaDinamica.Models;

namespace pilaDinamica
{
	class Program
	{
		static void Main(string[] args)
		{
			// Creamos una pila dinamica con capacidad maxima de 5.
			PilaDinamica miPila = new PilaDinamica();
			int seleccion = 0;
			string continuar = "s";

			do
			{
				Console.WriteLine("-------------------------------------------");
				Console.WriteLine("MENU PILA DINAMICA");
				Console.WriteLine("1. Push");
				Console.WriteLine("2. Pop");
				Console.WriteLine("3. Imprimir");
				Console.Write("Elige el numero de tu opcion: ");

				seleccion = int.Parse(Console.ReadLine());
				Console.WriteLine();

				switch (seleccion)
				{
					case 1:
						Console.WriteLine("PUSH");
						Console.Write("Escribe el numero que quieres meter: ");
						int numeroNuevo = int.Parse(Console.ReadLine());
						// Push: insertar en el tope.
						miPila.Apilar(numeroNuevo);
						miPila.Imprimir();
						break;

					case 2:
						Console.WriteLine("POP");
						// Pop: sacar el elemento del tope.
						miPila.Desapilar();
						miPila.Imprimir();
						break;

					case 3:
						Console.WriteLine("IMPRIMIR PILA");
						miPila.Imprimir();
						break;

					default:
						Console.WriteLine("Opcion invalida. Elige del 1 al 3.");
						break;
				}

				Console.WriteLine();
				Console.Write("Deseas hacer otra operacion? (s/n): ");
				continuar = Console.ReadLine();
				Console.WriteLine();

			} while (continuar == "s" || continuar == "S");

			Console.WriteLine("Programa finalizado. ¡Adios!");
		}
	}
}
