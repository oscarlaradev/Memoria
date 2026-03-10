using System;
using colaEstatica.Models;

namespace colaEstatica
{
	class Program
	{
		static void Main(string[] args)
		{
			ColaEstatica miCola = new ColaEstatica();
			int seleccion = 0;
			string continuar = "s";

			do
			{
				Console.WriteLine("-------------------------------------------");
				Console.WriteLine("MENU COLA ESTATICA");
				Console.WriteLine("1. Encolar");
				Console.WriteLine("2. Desencolar");
				Console.WriteLine("3. Imprimir");
				Console.Write("Elige el numero de tu opcion: ");

				seleccion = int.Parse(Console.ReadLine());
				Console.WriteLine();

				switch (seleccion)
				{
					case 1:
						Console.WriteLine("ENCOLAR");
						Console.Write("Escribe el numero que quieres insertar: ");
						int numeroNuevo = int.Parse(Console.ReadLine());
						miCola.Encolar(numeroNuevo);
						miCola.Imprimir();
						break;

					case 2:
						Console.WriteLine("DESENCOLAR");
						miCola.Desencolar();
						miCola.Imprimir();
						break;

					case 3:
						Console.WriteLine("IMPRIMIR COLA");
						miCola.Imprimir();
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
