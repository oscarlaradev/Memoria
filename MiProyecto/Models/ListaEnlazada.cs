namespace MiProyecto.Models
{
    /// <summary>
    /// Lista enlazada simple con operaciones básicas
    /// </summary>
    public class ListaEnlazada
    {
        private Nodo? cabeza;

        public ListaEnlazada()
        {
            cabeza = null;
        }

        /// <summary>
        /// Inserta un elemento al final de la lista
        /// </summary>
        public void InsertarElemento(int dato)
        {
            Nodo nuevoNodo = new Nodo(dato);

            if (cabeza == null)
            {
                cabeza = nuevoNodo;
                Console.WriteLine($"✓ Elemento {dato} insertado en la lista (primer elemento)");
                return;
            }

            Nodo actual = cabeza;
            while (actual.Siguiente != null)
            {
                actual = actual.Siguiente;
            }

            actual.Siguiente = nuevoNodo;
            Console.WriteLine($"✓ Elemento {dato} insertado al final de la lista");
        }

        /// <summary>
        /// Borra un elemento por posición (índice inicia en 0)
        /// </summary>
        public void BorrarPorPosicion(int posicion)
        {
            if (cabeza == null)
            {
                Console.WriteLine("❌ Error: La lista está vacía");
                return;
            }

            if (posicion < 0)
            {
                Console.WriteLine("❌ Error: La posición debe ser un número positivo");
                return;
            }

            // Si se elimina el primer elemento
            if (posicion == 0)
            {
                int datoEliminado = cabeza.Dato;
                cabeza = cabeza.Siguiente;
                Console.WriteLine($"✓ Elemento {datoEliminado} eliminado de la posición 0");
                return;
            }

            // Buscar el nodo anterior a la posición a eliminar
            Nodo? actual = cabeza;
            int contador = 0;

            while (actual != null && contador < posicion - 1)
            {
                actual = actual.Siguiente;
                contador++;
            }

            if (actual == null || actual.Siguiente == null)
            {
                Console.WriteLine($"❌ Error: La posición {posicion} no existe en la lista");
                return;
            }

            int dato = actual.Siguiente.Dato;
            actual.Siguiente = actual.Siguiente.Siguiente;
            Console.WriteLine($"✓ Elemento {dato} eliminado de la posición {posicion}");
        }

        /// <summary>
        /// Borra la primera ocurrencia de un elemento por su contenido
        /// </summary>
        public void BorrarPorContenido(int dato)
        {
            if (cabeza == null)
            {
                Console.WriteLine("❌ Error: La lista está vacía");
                return;
            }

            // Si el elemento a eliminar es el primero
            if (cabeza.Dato == dato)
            {
                cabeza = cabeza.Siguiente;
                Console.WriteLine($"✓ Elemento {dato} eliminado de la lista");
                return;
            }

            // Buscar el elemento
            Nodo? actual = cabeza;
            while (actual.Siguiente != null && actual.Siguiente.Dato != dato)
            {
                actual = actual.Siguiente;
            }

            if (actual.Siguiente == null)
            {
                Console.WriteLine($"❌ Error: El elemento {dato} no se encontró en la lista");
                return;
            }

            actual.Siguiente = actual.Siguiente.Siguiente;
            Console.WriteLine($"✓ Elemento {dato} eliminado de la lista");
        }

        /// <summary>
        /// Imprime todos los elementos de la lista
        /// </summary>
        public void ImprimirLista()
        {
            if (cabeza == null)
            {
                Console.WriteLine("La lista está vacía");
                return;
            }

            Console.WriteLine("\n═══════════════════════════════════");
            Console.WriteLine("       CONTENIDO DE LA LISTA");
            Console.WriteLine("═══════════════════════════════════");

            Nodo? actual = cabeza;
            int posicion = 0;

            while (actual != null)
            {
                Console.WriteLine($"  Posición {posicion}: {actual.Dato}");
                actual = actual.Siguiente;
                posicion++;
            }

            Console.WriteLine("═══════════════════════════════════");
            Console.WriteLine($"Total de elementos: {posicion}");
            Console.WriteLine();
        }

        /// <summary>
        /// Ordena la lista de menor a mayor (Bubble Sort)
        /// </summary>
        public void OrdenarLista()
        {
            if (cabeza == null || cabeza.Siguiente == null)
            {
                Console.WriteLine("✓ La lista ya está ordenada (0 o 1 elementos)");
                return;
            }

            bool intercambio;
            do
            {
                intercambio = false;
                Nodo? actual = cabeza;

                while (actual.Siguiente != null)
                {
                    if (actual.Dato > actual.Siguiente.Dato)
                    {
                        // Intercambiar datos
                        int temp = actual.Dato;
                        actual.Dato = actual.Siguiente.Dato;
                        actual.Siguiente.Dato = temp;
                        intercambio = true;
                    }
                    actual = actual.Siguiente;
                }
            } while (intercambio);

            Console.WriteLine("✓ Lista ordenada de menor a mayor");
        }

        /// <summary>
        /// Verifica si la lista está vacía
        /// </summary>
        public bool EstaVacia()
        {
            return cabeza == null;
        }
    }
}
