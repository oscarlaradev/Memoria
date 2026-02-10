using MiProyecto.Models;

namespace MiProyecto
{
    class Program
    {
        static void Main(string[] args)
        {
            ListaEnlazada lista = new ListaEnlazada();
            bool salir = false;

            Console.WriteLine("╔════════════════════════════════════════════════╗");
            Console.WriteLine("║     LISTA ENLAZADA SIMPLE - MENÚ PRINCIPAL    ║");
            Console.WriteLine("╚════════════════════════════════════════════════╝");
            Console.WriteLine();

            while (!salir)
            {
                MostrarMenu();
                string? opcion = Console.ReadLine();

                Console.WriteLine();

                switch (opcion)
                {
                    case "1":
                        InsertarElemento(lista);
                        break;

                    case "2":
                        BorrarPorPosicion(lista);
                        break;

                    case "3":
                        BorrarPorContenido(lista);
                        break;

                    case "4":
                        lista.ImprimirLista();
                        break;

                    case "5":
                        lista.OrdenarLista();
                        break;

                    case "6":
                        salir = true;
                        Console.WriteLine("👋 ¡Hasta luego!");
                        break;

                    default:
                        Console.WriteLine("❌ Opción no válida. Intenta de nuevo.");
                        break;
                }

                if (!salir)
                {
                    Console.WriteLine("\nPresiona cualquier tecla para continuar...");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("╔════════════════════════════════════════════════╗");
                    Console.WriteLine("║     LISTA ENLAZADA SIMPLE - MENÚ PRINCIPAL    ║");
                    Console.WriteLine("╚════════════════════════════════════════════════╝");
                    Console.WriteLine();
                }
            }
        }

        static void MostrarMenu()
        {
            Console.WriteLine("┌────────────────────────────────────────────────┐");
            Console.WriteLine("│  1. Insertar Elemento                         │");
            Console.WriteLine("│  2. Borrar Elemento por Posición              │");
            Console.WriteLine("│  3. Borrar Elemento por Contenido             │");
            Console.WriteLine("│  4. Imprimir Lista                            │");
            Console.WriteLine("│  5. Ordenar Lista                             │");
            Console.WriteLine("│  6. Salir                                     │");
            Console.WriteLine("└────────────────────────────────────────────────┘");
            Console.Write("\nSelecciona una opción: ");
        }

        static void InsertarElemento(ListaEnlazada lista)
        {
            Console.Write("Ingresa el número a insertar: ");
            string? entrada = Console.ReadLine();

            if (int.TryParse(entrada, out int numero))
            {
                lista.InsertarElemento(numero);
            }
            else
            {
                Console.WriteLine("❌ Error: Debes ingresar un número válido");
            }
        }

        static void BorrarPorPosicion(ListaEnlazada lista)
        {
            if (lista.EstaVacia())
            {
                Console.WriteLine("❌ La lista está vacía. No hay elementos para borrar.");
                return;
            }

            Console.Write("Ingresa la posición a borrar (inicia en 0): ");
            string? entrada = Console.ReadLine();

            if (int.TryParse(entrada, out int posicion))
            {
                lista.BorrarPorPosicion(posicion);
            }
            else
            {
                Console.WriteLine("❌ Error: Debes ingresar un número válido");
            }
        }

        static void BorrarPorContenido(ListaEnlazada lista)
        {
            if (lista.EstaVacia())
            {
                Console.WriteLine("❌ La lista está vacía. No hay elementos para borrar.");
                return;
            }

            Console.Write("Ingresa el valor a borrar: ");
            string? entrada = Console.ReadLine();

            if (int.TryParse(entrada, out int valor))
            {
                lista.BorrarPorContenido(valor);
            }
            else
            {
                Console.WriteLine("❌ Error: Debes ingresar un número válido");
            }
        }
    }
}

