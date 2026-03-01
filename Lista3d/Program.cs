using System;
using Lista3D.Models;

namespace Lista3D
{
    class Program
    {
        static void Main(string[] args)
        {
            Lista3DContenedor miLista3D = new Lista3DContenedor();
            int seleccion = 0;

            do
            {
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine("MENU LISTA 3D");
                Console.WriteLine("1. Agregar Lista2D");
                Console.WriteLine("2. Mostrar contenido Lista3D");
                Console.WriteLine("3. Cerrar programa");
                Console.Write("Elige el numero de tu opcion: ");
                seleccion = int.Parse(Console.ReadLine());

                Console.WriteLine();

                switch (seleccion)
                {
                    case 1:
                        Console.WriteLine("AGREGAR LISTA2D A LISTA3D");
                        Console.Write("Cuantas listas de 1 dimension tendra la Lista2D: ");
                        int totalListas1D = int.Parse(Console.ReadLine());

                        if (totalListas1D <= 0)
                        {
                            Console.WriteLine("La cantidad debe ser mayor a cero.");
                            break;
                        }

                        Lista2DInterna nuevaLista2D = new Lista2DInterna();

                        for (int i = 1; i <= totalListas1D; i++)
                        {
                            Console.Write("Cuantos elementos tendra la lista 1D #" + i + ": ");
                            int cantidadElementos = int.Parse(Console.ReadLine());

                            if (cantidadElementos <= 0)
                            {
                                Console.WriteLine("La cantidad debe ser mayor a cero. Esta lista se omite.");
                                continue;
                            }

                            Lista1D listaNueva = new Lista1D();
                            Console.WriteLine("Captura elementos de la lista 1D #" + i + ":");

                            for (int j = 1; j <= cantidadElementos; j++)
                            {
                                Console.Write("Elemento " + j + ": ");
                                int valor = int.Parse(Console.ReadLine());
                                listaNueva.Agregar(valor);
                            }

                            nuevaLista2D.AgregarLista1D(listaNueva);
                        }

                        miLista3D.AgregarLista2D(nuevaLista2D);
                        break;

                    case 2:
                        Console.WriteLine("MOSTRAR CONTENIDO COMPLETO DE LISTA3D");
                        miLista3D.ImprimirContenidoCompleto();
                        break;

                    case 3:
                        Console.WriteLine("Programa finalizado. ¡Adios!");
                        break;

                    default:
                        Console.WriteLine("Opcion invalida. Elige del 1 al 3.");
                        break;
                }

                Console.WriteLine();
            } while (seleccion != 3);
        }
    }
}