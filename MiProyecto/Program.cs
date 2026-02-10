// Importamos el namespace donde estan nuestras clases Nodo y ListaEnlazada
using MiProyecto.Models;

namespace MiProyecto
{
    // Clase principal del programa
    class Program
    {
        // Metodo Main: es el punto de entrada del programa
        // Es lo primero que se ejecuta cuando corremos la aplicacion
        static void Main(string[] args)
        {
            // Creamos una nueva lista enlazada vacia
            ListaEnlazada lista = new ListaEnlazada();
            
            // Variable para controlar el ciclo del menu
            bool salir = false;

            // Mostramos el titulo del programa
            Console.WriteLine("LISTA ENLAZADA SIMPLE");
            Console.WriteLine("---------------------\n");

            // Ciclo principal del programa
            // Se repite hasta que el usuario seleccione "Salir"
            while (!salir)
            {
                // Mostrar el menu de opciones
                MostrarMenu();
                
                // Leer la opcion que ingresa el usuario
                string? opcion = Console.ReadLine();

                Console.WriteLine();

                // Evaluar la opcion seleccionada con switch
                switch (opcion)
                {
                    case "1":  // Opcion 1: Insertar elemento
                        InsertarElemento(lista);
                        break;

                    case "2":  // Opcion 2: Borrar por posicion
                        BorrarPorPosicion(lista);
                        break;

                    case "3":  // Opcion 3: Borrar por contenido
                        BorrarPorContenido(lista);
                        break;

                    case "4":  // Opcion 4: Imprimir lista
                        lista.ImprimirLista();
                        break;

                    case "5":  // Opcion 5: Ordenar lista
                        lista.OrdenarLista();
                        break;

                    case "6":  // Opcion 6: Salir del programa
                        salir = true;
                        Console.WriteLine("Saliendo...");
                        break;

                    default:   // Si ingresa algo que no es 1-6
                        Console.WriteLine("Opcion no valida.");
                        break;
                }

                // Si el usuario NO selecciono salir
                if (!salir)
                {
                    // Pausar para que el usuario vea el resultado
                    Console.WriteLine("\nPresiona Enter para continuar...");
                    Console.ReadLine();
                    
                    // Limpiar la consola para mostrar el menu nuevamente
                    Console.Clear();
                    Console.WriteLine("LISTA ENLAZADA SIMPLE");
                    Console.WriteLine("---------------------\n");
                }
            }
        }

        // Metodo para mostrar el menu de opciones
        // static: se puede llamar sin crear un objeto de Program
        // void: no retorna ningun valor
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

        // Metodo para insertar un elemento en la lista
        // Parametro: lista - la lista donde vamos a insertar
        static void InsertarElemento(ListaEnlazada lista)
        {
            // Pedimos al usuario que ingrese un numero
            Console.Write("Numero a insertar: ");
            string? entrada = Console.ReadLine();

            // int.TryParse: intenta convertir el texto a numero
            // Si tiene exito, guarda el numero en la variable 'numero'
            // y retorna true
            if (int.TryParse(entrada, out int numero))
            {
                // Si la conversion fue exitosa, insertamos el numero
                lista.InsertarElemento(numero);
            }
            else
            {
                // Si el usuario ingreso algo que no es un numero
                Console.WriteLine("Error: Numero invalido");
            }
        }

        // Metodo para borrar un elemento por su posicion
        // Parametro: lista - la lista de donde vamos a borrar
        static void BorrarPorPosicion(ListaEnlazada lista)
        {
            // Primero verificamos si la lista tiene elementos
            if (lista.EstaVacia())
            {
                Console.WriteLine("La lista esta vacia.");
                return;  // Salimos del metodo
            }

            // Pedimos al usuario la posicion a borrar
            Console.Write("Posicion a borrar: ");
            string? entrada = Console.ReadLine();

            // Intentamos convertir la entrada a numero
            if (int.TryParse(entrada, out int posicion))
            {
                // Si es un numero valido, borramos
                lista.BorrarPorPosicion(posicion);
            }
            else
            {
                Console.WriteLine("Error: Numero invalido");
            }
        }

        // Metodo para borrar un elemento por su valor
        // Parametro: lista - la lista de donde vamos a borrar
        static void BorrarPorContenido(ListaEnlazada lista)
        {
            // Verificamos si la lista tiene elementos
            if (lista.EstaVacia())
            {
                Console.WriteLine("La lista esta vacia.");
                return;
            }

            // Pedimos al usuario el valor a borrar
            Console.Write("Valor a borrar: ");
            string? entrada = Console.ReadLine();

            // Intentamos convertir la entrada a numero
            if (int.TryParse(entrada, out int valor))
            {
                // Si es un numero valido, buscamos y borramos
                lista.BorrarPorContenido(valor);
            }
            else
            {
                Console.WriteLine("Error: Numero invalido");
            }
        }
    }
}

