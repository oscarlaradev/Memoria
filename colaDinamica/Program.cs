using System;
using colaDinamica.Models;

namespace colaDinamica
{
	class Program
	{
		static void Main(string[] args)
		{
			ColaDinamica miCola = new ColaDinamica();
			int seleccion = 0;
			string continuar = "s";

			do
			{
				Console.WriteLine("-------------------------------------------");
				Console.WriteLine("MENU COLA DINAMICA");
				Console.WriteLine("1. Insertar elemento");
				Console.WriteLine("2. Eliminar elemento");
				Console.WriteLine("3. Imprimir contenido de la cola");
				Console.Write("Elige el numero de tu opcion: ");

				seleccion = int.Parse(Console.ReadLine());
				Console.WriteLine();

				switch (seleccion)
				{
					case 1:
						Console.WriteLine("INSERTAR ELEMENTO");
						Console.Write("Escribe el numero que quieres insertar: ");
						int numeroNuevo = int.Parse(Console.ReadLine());
						miCola.Insertar(numeroNuevo);
						miCola.Imprimir();
						break;

					case 2:
						Console.WriteLine("ELIMINAR ELEMENTO");
						miCola.Eliminar();
						miCola.Imprimir();
						break;

					case 3:
						Console.WriteLine("IMPRIMIR CONTENIDO DE LA COLA");
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
