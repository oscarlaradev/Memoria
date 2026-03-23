using System;
using GrafoDinamico2.Models;

namespace GrafoDinamico2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("GRAFO DINAMICO 2");
            Console.Write("Escribe la cantidad de vertices: ");
            int cantidadVertices = int.Parse(Console.ReadLine());

            Grafo miGrafo = new Grafo(cantidadVertices);
            int seleccion = 0;
            string continuar = "s";

            do
            {
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine("MENU GRAFO DINAMICO");
                Console.WriteLine("1. Agregar arista");
                Console.WriteLine("2. Borrar arista");
                Console.WriteLine("3. Imprimir grafo");
                Console.Write("Elige el numero de tu opcion: ");

                seleccion = int.Parse(Console.ReadLine());
                Console.WriteLine();

                switch (seleccion)
                {
                    case 1:
                        Console.WriteLine("AGREGAR ARISTA");
                        Console.Write("Origen: ");
                        int origenAgregar = int.Parse(Console.ReadLine());
                        Console.Write("Destino: ");
                        int destinoAgregar = int.Parse(Console.ReadLine());
                        Console.Write("Peso: ");
                        double pesoAgregar = double.Parse(Console.ReadLine());

                        bool aristaAgregada = miGrafo.AgregarArista(origenAgregar, destinoAgregar, pesoAgregar);
                        if (aristaAgregada)
                        {
                            Console.WriteLine("Arista agregada correctamente.");
                        }
                        else
                        {
                            Console.WriteLine("No se pudo agregar la arista. Revisa vertices y peso.");
                        }
                        break;

                    case 2:
                        Console.WriteLine("BORRAR ARISTA");
                        Console.Write("Origen: ");
                        int origenBorrar = int.Parse(Console.ReadLine());
                        Console.Write("Destino: ");
                        int destinoBorrar = int.Parse(Console.ReadLine());

                        bool aristaBorrada = miGrafo.BorrarArista(origenBorrar, destinoBorrar);
                        if (aristaBorrada)
                        {
                            Console.WriteLine("Arista borrada correctamente.");
                        }
                        else
                        {
                            Console.WriteLine("No se encontro esa arista para borrar.");
                        }
                        break;

                    case 3:
                        Console.WriteLine("IMPRIMIR GRAFO");
                        miGrafo.ImprimirGrafo();
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

            Console.WriteLine("Programa Termino");
        }
    }
}
