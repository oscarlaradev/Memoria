using System;
using pilaEstatica.Models;

namespace pilaEstatica
{
	class Program
	{
		static void Main(string[] args)
		{
			PilaEstatica miPila = new PilaEstatica();
			int seleccion = 0;
			string continuar = "s";

			do
			{
				Console.WriteLine("-------------------------------------------");
				Console.WriteLine("MENU PILA ESTATICA");
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
						miPila.Push(numeroNuevo);
						miPila.Imprimir();
						break;

					case 2:
						Console.WriteLine("POP");
						miPila.Pop();
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
