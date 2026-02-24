using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lista2D.Models;
using ListaDeListas = Lista2D.Models.Lista2D;

namespace Lista2D
{
	class Program
	{
		static void Main(string[] args)
		{
			ListaDeListas miLista2D = new ListaDeListas();
			int seleccion = 0;

			do
			{
				Console.WriteLine("-------------------------------------------");
				Console.WriteLine("MENU LISTA 2D (LISTA DE LISTAS)");
				Console.WriteLine("1. Agregar Lista a Lista2D");
				Console.WriteLine("2. Borrar Lista de Lista2D");
				Console.WriteLine("3. Invertir Lista en Posicion");
				Console.WriteLine("4. Imprimir Lista en Posicion");
				Console.WriteLine("5. Cerrar programa");
				Console.Write("Elige el numero de tu opcion: ");

				try
				{
					seleccion = int.Parse(Console.ReadLine());
				}
				catch (FormatException)
				{
					Console.WriteLine("\nCuidado: Tienes que escribir un numero.");
					seleccion = 0;
					continue;
				}

				Console.WriteLine();

				switch (seleccion)
				{
					case 1:
						Console.WriteLine("AGREGAR LISTA A LISTA2D");
						Console.Write("Pedir Tamano de la lista: ");
						try
						{
							int tamano = int.Parse(Console.ReadLine());
							if (tamano <= 0)
							{
								Console.WriteLine("El tamano debe ser mayor a cero.");
								break;
							}

							ListaSimpleInterna nuevaLista = new ListaSimpleInterna();

							Console.WriteLine("Pedir elementos de la lista:");
							for (int i = 1; i <= tamano; i++)
							{
								Console.Write("Elemento " + i + ": ");
								int valor = int.Parse(Console.ReadLine());
								nuevaLista.Agregar(valor);
							}

							miLista2D.AgregarLista(nuevaLista);
						}
						catch (FormatException)
						{
							Console.WriteLine("Error: solo numeros.");
						}
						break;

					case 2:
						Console.WriteLine("BORRAR LISTA DE LISTA2D");
						Console.Write("Pedir posicion de la lista a borrar: ");
						try
						{
							int posicionBorrar = int.Parse(Console.ReadLine());
							miLista2D.BorrarLista(posicionBorrar);
						}
						catch (FormatException)
						{
							Console.WriteLine("Error: posicion invalida.");
						}
						break;

					case 3:
						Console.WriteLine("INVERTIR LISTA DE LISTA2D");
						Console.Write("Pedir posicion de la lista a invertir: ");
						try
						{
							int posicionInvertir = int.Parse(Console.ReadLine());
							miLista2D.InvertirListaEnPosicion(posicionInvertir);
						}
						catch (FormatException)
						{
							Console.WriteLine("Error: posicion invalida.");
						}
						break;

					case 4:
						Console.WriteLine("IMPRIMIR LISTA EN POSICION");
						Console.Write("Pedir posicion de la lista a imprimir: ");
						try
						{
							int posicionImprimir = int.Parse(Console.ReadLine());
							miLista2D.ImprimirListaEnPosicion(posicionImprimir);
						}
						catch (FormatException)
						{
							Console.WriteLine("Error: posicion invalida.");
						}
						break;

					case 5:
						Console.WriteLine("Programa finalizado. ¡Adios!");
						break;

					default:
						Console.WriteLine("Opcion invalida. Elige del 1 al 5.");
						break;
				}

				Console.WriteLine();
			} while (seleccion != 5);
		}
	}
}
