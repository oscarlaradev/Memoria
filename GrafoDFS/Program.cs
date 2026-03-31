using System;
using System.Collections.Generic;
using GrafoDFS.Models;

namespace GrafoDFS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BUSQUEDA PRIMERO EN PROFUNDIDAD (DFS)");
            Console.WriteLine("Vertices validos: 0 a n-1");

            Grafo? miGrafo = null;
            bool salir = false;

            while (!salir)
            {
                Console.WriteLine("\nMENU");
                Console.WriteLine("1) Crear grafo (cantidad de vertices)");
                Console.WriteLine("2) Agregar arista");
                Console.WriteLine("3) Pedir nodo fuente y recorrer DFS");
                Console.WriteLine("4) Salir");

                int opcion = LeerEntero("Elige opcion: ", 1, 4);

                switch (opcion)
                {
                    case 1:
                        int numeroVertices = LeerEntero("Ingresa la cantidad de vertices: ", 1);
                        miGrafo = new Grafo(numeroVertices, false);
                        Console.WriteLine("Grafo creado.");
                        break;
                    case 2:
                        if (!HayGrafo(miGrafo))
                        {
                            break;
                        }

                        AgregarAristaInteractiva(miGrafo!);
                        break;
                    case 3:
                        if (!HayGrafo(miGrafo))
                        {
                            break;
                        }

                        miGrafo!.ImprimirGrafo();
                        EjecutarDFS(miGrafo);
                        break;
                    case 4:
                        salir = true;
                        break;
                }
            }
        }

        static bool HayGrafo(Grafo? grafo)
        {
            if (grafo == null)
            {
                Console.WriteLine("Primero crea el grafo en la opcion 1.");
                return false;
            }

            return true;
        }

        static void AgregarAristaInteractiva(Grafo grafo)
        {
            int origen = LeerEntero("Origen: ", 0, grafo.NumeroVertices - 1);
            int destino = LeerEntero("Destino: ", 0, grafo.NumeroVertices - 1);

            bool agregado = grafo.AgregarArista(origen, destino);
            Console.WriteLine(agregado ? "Arista agregada correctamente." : "No se pudo agregar la arista.");
        }

        static void EjecutarDFS(Grafo grafo)
        {
            int fuente = LeerEntero("Ingresa el nodo fuente para DFS: ", 0, grafo.NumeroVertices - 1);
            List<int> recorrido = grafo.RecorridoDFS(fuente);

            if (recorrido.Count == 0)
            {
                Console.WriteLine("No se pudo realizar el recorrido DFS.");
                return;
            }

            Console.WriteLine("Recorrido DFS:");
            Console.WriteLine(string.Join(" -> ", recorrido));
        }

        static int LeerEntero(string mensaje, int minimo)
        {
            while (true)
            {
                Console.Write(mensaje);
                string? entrada = Console.ReadLine();

                if (int.TryParse(entrada, out int valor) && valor >= minimo)
                {
                    return valor;
                }

                Console.WriteLine($"Entrada invalida. Debe ser un entero mayor o igual a {minimo}.");
            }
        }

        static int LeerEntero(string mensaje, int minimo, int maximo)
        {
            while (true)
            {
                int valor = LeerEntero(mensaje, minimo);
                if (valor <= maximo)
                {
                    return valor;
                }

                Console.WriteLine($"Entrada invalida. Debe estar entre {minimo} y {maximo}.");
            }
        }
    }
}
