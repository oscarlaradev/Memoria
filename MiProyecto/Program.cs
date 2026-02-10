using MiProyecto.Models;

namespace MiProyecto
{
    class Program
    {
        static void Main(string[] args)
        {
            ListaEnlazada lista = new ListaEnlazada();
            bool salir = false;

            Console.WriteLine("LISTA ENLAZADA SIMPLE");
            Console.WriteLine("---------------------\n");

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
                        Console.WriteLine("Saliendo...");
                        break;

                    default:
                        Console.WriteLine("Opcion no valida.");
                        break;
                }

                if (!salir)
                {
                    Console.WriteLine("\nPresiona Enter para continuar...");
                    Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("LISTA ENLAZADA SIMPLE");
                    Console.WriteLine("---------------------\n");
                }
            }
        }

        static void MostrarMenu()
        {
            Console.WriteLine("1. Insertar Elemento");
            Console.WriteLine("2. Borrar Elemento por Posicion");
            Console.WriteLine("3. Borrar Elemento por Contenido");
            Console.WriteLine("4. Imprimir Lista");
            Console.WriteLine("5. Ordenar Lista");
            Console.WriteLine("6. Salir");
            Console.Write("\nOpcion: ");
        }

        static void InsertarElemento(ListaEnlazada lista)
        {
            Console.Write("Numero a insertar: ");
            string? entrada = Console.ReadLine();

            if (int.TryParse(entrada, out int numero))
            {
                lista.InsertarElemento(numero);
            }
            else
            {
                Console.WriteLine("Error: Numero invalido");
            }
        }

        static void BorrarPorPosicion(ListaEnlazada lista)
        {
            if (lista.EstaVacia())
            {
                Console.WriteLine("La lista esta vacia.");
                return;
            }

            Console.Write("Posicion a borrar: ");
            string? entrada = Console.ReadLine();

            if (int.TryParse(entrada, out int posicion))
            {
                lista.BorrarPorPosicion(posicion);
            }
            else
            {
                Console.WriteLine("Error: Numero invalido");
            }
        }

        static void BorrarPorContenido(ListaEnlazada lista)
        {
            if (lista.EstaVacia())
            {
                Console.WriteLine("La lista esta vacia.");
                return;
            }

            Console.Write("Valor a borrar: ");
            string? entrada = Console.ReadLine();

            if (int.TryParse(entrada, out int valor))
            {
                lista.BorrarPorContenido(valor);
            }
            else
            {
                Console.WriteLine("Error: Numero invalido");
            }
        }
    }
}

