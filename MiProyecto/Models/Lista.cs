using System;

namespace TareaEstructuras
{
    public class Lista
    {
        // Puntero al inicio de la lista
        public Nodo cabeza; 

        public Lista()
        {
            cabeza = null;
        }

        // 1. Insertar (al final)
        public void Insertar(int valor)
        {
            Nodo nuevo = new Nodo();
            nuevo.Dato = valor;
            nuevo.Siguiente = null;

            if (cabeza == null)
            {
                cabeza = nuevo;
            }
            else
            {
                Nodo actual = cabeza;
                // Recorremos hasta llegar al ultimo
                while (actual.Siguiente != null)
                {
                    actual = actual.Siguiente;
                }
                actual.Siguiente = nuevo;
            }
            Console.WriteLine("-> Se agrego el numero: " + valor);
        }

        // 2. Borrar por Posicion
        public void BorrarPorPosicion(int posicion)
        {
            if (cabeza == null) return;

            // Si es la primera posicion (0)
            if (posicion == 0)
            {
                cabeza = cabeza.Siguiente;
                Console.WriteLine("-> Se borro la posicion 0");
                return;
            }

            Nodo actual = cabeza;
            // Buscamos el nodo anterior al que queremos borrar
            for (int i = 0; i < posicion - 1; i++)
            {
                if (actual.Siguiente == null) break;
                actual = actual.Siguiente;
            }

            if (actual.Siguiente == null)
            {
                Console.WriteLine("Esa posicion no existe.");
                return;
            }

            // Saltamos el nodo
            Nodo aBorrar = actual.Siguiente;
            actual.Siguiente = aBorrar.Siguiente;
            
            Console.WriteLine("-> Se borro la posicion " + posicion);
        }

        // 3. Borrar por Contenido (Valor)
        public void BorrarPorContenido(int valor)
        {
            if (cabeza == null) return;

            // Si el valor esta en la cabeza
            if (cabeza.Dato == valor)
            {
                cabeza = cabeza.Siguiente;
                Console.WriteLine("-> Se borro el valor " + valor);
                return;
            }

            Nodo actual = cabeza;
            Nodo anterior = null;

            // Buscamos el valor
            while (actual != null && actual.Dato != valor)
            {
                anterior = actual;
                actual = actual.Siguiente;
            }

            if (actual == null)
            {
                Console.WriteLine("El valor no esta en la lista.");
                return;
            }

            // Lo saltamos para borrarlo
            anterior.Siguiente = actual.Siguiente;
            Console.WriteLine("-> Se borro el valor " + valor);
        }

        // 4. Imprimir (AQUI ESTA EL CAMBIO QUE PEDISTE)
        public void Imprimir()
        {
            Nodo actual = cabeza;
            
            Console.Write("Lista: ");
            
            while (actual != null)
            {
                // Forma basica: concatenar con el signo +
                Console.Write("[" + actual.Dato + "] -> ");
                
                actual = actual.Siguiente;
            }
            
            Console.WriteLine("null");
        }

        // 5. Ordenar (Metodo Burbuja facil)
        public void Ordenar()
        {
            if (cabeza == null) return;

            bool huboCambio = true;
            
            while (huboCambio)
            {
                huboCambio = false;
                Nodo actual = cabeza;

                while (actual.Siguiente != null)
                {
                    if (actual.Dato > actual.Siguiente.Dato)
                    {
                        // Intercambiamos los valores
                        int temporal = actual.Dato;
                        actual.Dato = actual.Siguiente.Dato;
                        actual.Siguiente.Dato = temporal;
                        
                        huboCambio = true;
                    }
                    actual = actual.Siguiente;
                }
            }
            Console.WriteLine("-> Lista ordenada.");
        }
    }
}