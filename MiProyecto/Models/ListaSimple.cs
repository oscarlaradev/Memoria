using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoListas
{
    // Cambiamos el nombre de la clase para que suene más pro
    public class ListaSimple
    {
        public Nodo nodoInicio;
        public int cantidadNodos;

        public ListaSimple()
        {
            nodoInicio = null;
            cantidadNodos = 0;
        }

        public void Agregar(int x)
        {
            if (cantidadNodos == 0)
            {
                nodoInicio = new Nodo(x);
                cantidadNodos++;
            }
            else
            {
                Nodo nodoViajero = nodoInicio;
                // Viajamos hasta el último nodo
                while (nodoViajero.enlaceSiguiente != null)
                {
                    nodoViajero = nodoViajero.enlaceSiguiente;
                }
                Nodo nuevoNodo = new Nodo(x);
                nodoViajero.enlaceSiguiente = nuevoNodo;
                cantidadNodos++;
            }
        }

        public void Imprimir()
        {
            if (cantidadNodos == 0)
            {
                Console.WriteLine("La lista no tiene elementos.");
                return;
            }
            
            Nodo nodoViajero = nodoInicio;
            Console.Write("Contenido de la lista: ");
            
            while (nodoViajero != null)
            {
                Console.Write("[" + nodoViajero.valorDato + "] -> ");
                nodoViajero = nodoViajero.enlaceSiguiente;
            }
            Console.WriteLine("FIN");
        }

        public void BorrarDosElementos(int elem1, int elem2)
        {
            BorrarElemento(elem1);
            BorrarElemento(elem2);
        }
        
        public void BorrarElemento(int datoABorrar)
        {
            if (cantidadNodos > 0)
            {
                Nodo temporal = nodoInicio;
                int indice = 0;
                
                // Buscamos el elemento
                while (temporal.valorDato != datoABorrar && temporal.enlaceSiguiente != null)
                {
                    temporal = temporal.enlaceSiguiente;
                    indice++;
                }
                
                // Si lo encontramos
                if (temporal.valorDato == datoABorrar)
                {
                    if (indice == 0)
                    {
                        nodoInicio = nodoInicio.enlaceSiguiente;
                        cantidadNodos--; 
                    }
                    else
                    {
                        Nodo nodoPrevio = nodoInicio;
                        for (int i = 0; i < indice - 1; i++)
                        {
                            nodoPrevio = nodoPrevio.enlaceSiguiente;
                        }
                        nodoPrevio.enlaceSiguiente = nodoPrevio.enlaceSiguiente.enlaceSiguiente;
                        cantidadNodos--; 
                    }
                    Console.WriteLine("El número " + datoABorrar + " fue borrado.");
                }
                else
                {
                    Console.WriteLine("No se encontró el número " + datoABorrar + " en la lista.");
                }
            }
            else
            {
                Console.WriteLine("La lista ya está vacía.");
            }
        }
        
        public void Borrar(int posicionTarget)
        {
            if (cantidadNodos == 0)
            {
                Console.WriteLine("La lista no tiene elementos.");
                return;
            }
            
            if (posicionTarget < 1 || posicionTarget > cantidadNodos)
            {
                Console.WriteLine("Posición incorrecta. Usa un número del 1 al " + cantidadNodos);
                return;
            }

            if (posicionTarget == 1)
            {
                nodoInicio = nodoInicio.enlaceSiguiente;
                cantidadNodos--;
            }
            else
            {
                Nodo temporal = nodoInicio;
              
                for (int i = 1; i < posicionTarget - 1; i++)
                {
                    temporal = temporal.enlaceSiguiente;
                }
        
                temporal.enlaceSiguiente = temporal.enlaceSiguiente.enlaceSiguiente;
                cantidadNodos--;
            }
            Console.WriteLine("Se borró el elemento de la posición " + posicionTarget);
        }

        public void OrdenarLista()
        {
            Nodo pivote1 = nodoInicio;
            
            while (pivote1 != null)
            {
                Nodo pivote2 = pivote1.enlaceSiguiente;
                while (pivote2 != null)
                {
                    // Intercambio si el primero es mayor que el segundo
                    if (pivote1.valorDato > pivote2.valorDato)
                    {
                        int guardado = pivote1.valorDato;
                        pivote1.valorDato = pivote2.valorDato;
                        pivote2.valorDato = guardado;
                    }
                    pivote2 = pivote2.enlaceSiguiente;
                }
                pivote1 = pivote1.enlaceSiguiente;
            }
            Console.WriteLine("Lista ordenada exitosamente.");
        }
    }
}