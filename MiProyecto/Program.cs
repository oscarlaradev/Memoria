using System;

namespace TareaEstructuras
{
    class Program
    {
        static void Main(string[] args)
        {
            Lista miLista = new Lista();
            int opcion = 0;

            // --- ESTO LO PIDE EL PROFESOR (Datos ya creados) ---
            Console.WriteLine("Cargando datos automaticos...");
            miLista.Insertar(50);
            miLista.Insertar(10);
            miLista.Insertar(30);
            miLista.Insertar(5);
            miLista.Insertar(20);
            miLista.Imprimir();
            Console.WriteLine("--------------------------------");

            // --- MENU ---
            while (opcion != 6)
            {
                Console.WriteLine("\n1. Insertar Elemento");
                Console.WriteLine("2. Borrar por Posicion");
                Console.WriteLine("3. Borrar por Contenido");
                Console.WriteLine("4. Imprimir Lista");
                Console.WriteLine("5. Ordenar Lista");
                Console.WriteLine("6. Salir");
                Console.Write("Elige una opcion: ");

                // Lectura simple
                opcion = int.Parse(Console.ReadLine());

                if (opcion == 1)
                {
                    Console.Write("Escribe el numero a insertar: ");
                    int num = int.Parse(Console.ReadLine());
                    miLista.Insertar(num);
                }
                else if (opcion == 2)
                {
                    miLista.Imprimir();
                    Console.Write("Escribe la posicion (0, 1, 2...): ");
                    int pos = int.Parse(Console.ReadLine());
                    miLista.BorrarPorPosicion(pos);
                }
                else if (opcion == 3)
                {
                    Console.Write("Escribe el numero que quieres borrar: ");
                    int val = int.Parse(Console.ReadLine());
                    miLista.BorrarPorContenido(val);
                }
                else if (opcion == 4)
                {
                    miLista.Imprimir();
                }
                else if (opcion == 5)
                {
                    miLista.Ordenar();
                    miLista.Imprimir();
                }
                else if (opcion == 6)
                {
                    Console.WriteLine("Adios.");
                }
            }
        }
    }
}