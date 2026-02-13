using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoListas
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instanciamos la clase con el nuevo nombre
            ListaSimple miColeccion = new ListaSimple();
            int seleccion = 0;

            // CARGAR DE DATOS AUTOMÁTICAMENTE
            Console.WriteLine("-------------------------------------------\n");
            miColeccion.Agregar(77);
            miColeccion.Agregar(12);
            miColeccion.Agregar(5);
            miColeccion.Agregar(90);
            miColeccion.Imprimir();
            Console.WriteLine("-------------------------------------------\n");

            do 
            {
                Console.WriteLine("LISTA ENLAZADA SIMPLE - MENÚ DE OPCIONES");
                Console.WriteLine("1. Agregar un número a la lista");
                Console.WriteLine("2. Eliminar un número dando su posición");
                Console.WriteLine("3. Eliminar un número dando su valor");
                Console.WriteLine("4. Ver todos los números");
                Console.WriteLine("5. Ordenar de menor a mayor");
                Console.WriteLine("6. Cerrar programa");
                Console.Write("Elige el número de tu opción: ");
                
                try
                {
                    seleccion = int.Parse(Console.ReadLine());
                }
                catch (FormatException) 
                {
                    Console.WriteLine("\nCuidado: Tienes que escribir un número.");
                    seleccion = 0;
                    continue; 
                }
                
                Console.WriteLine();
                
                switch (seleccion)
                {
                    case 1:
                        Console.WriteLine("AGREGAR UN NÚMERO A LA LISTA");
                        Console.Write("Escribe el número que quieres meter: ");
                        try
                        {
                            int numNuevo = int.Parse(Console.ReadLine());
                            miColeccion.Agregar(numNuevo);
                            Console.WriteLine("-> " + numNuevo + " se guardó bien.");
                            miColeccion.Imprimir();
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Error: solo números.");
                        }
                        break;
                        
                    case 2:
                        Console.WriteLine("BORRAR POR POSICIÓN (ej. 1, 2, 3...)");
                        miColeccion.Imprimir();
                        try
                        {
                            int lugar = int.Parse(Console.ReadLine());
                            miColeccion.Borrar(lugar);
                            miColeccion.Imprimir();
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Error: Escribe un número de posición válido.");
                        }
                        break;
                        
                    case 3:
                        Console.WriteLine("BORRAR POR VALOR");
                        miColeccion.Imprimir();
                        try
                        {
                            int numBorrar = int.Parse(Console.ReadLine());
                            miColeccion.BorrarElemento(numBorrar);
                            miColeccion.Imprimir();
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Error: Escribe solo números.");
                        }
                        break;
                        
                    case 4:
                        Console.WriteLine("VER LISTA COMPLETA");
                        miColeccion.Imprimir();
                        break;
                        
                    case 5:
                        Console.WriteLine("ORDENAR LISTA");
                        miColeccion.OrdenarLista();
                        miColeccion.Imprimir();
                        break;
                        
                    case 6:
                        Console.WriteLine("Ese pedo me awuita ¡Adiós!");
                        break;
                        
                    default:
                        Console.WriteLine("Opcion invalida. Elige del 1 al 6.");
                        break;
                }
                
                Console.WriteLine(); 
                               
            } while (seleccion != 6);
        }
    }
}