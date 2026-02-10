namespace MiProyecto.Models
{
    // Clase ListaEnlazada: implementa una lista enlazada simple
    // Una lista enlazada es una estructura de datos donde cada elemento
    // apunta al siguiente, formando una cadena
    public class ListaEnlazada
    {
        // Variable privada que apunta al primer nodo de la lista
        // Si es null, la lista esta vacia
        private Nodo? cabeza;

        // Constructor: inicializa la lista vacia
        public ListaEnlazada()
        {
            cabeza = null;  // Al inicio, la lista no tiene elementos
        }

        // Metodo para insertar un elemento al final de la lista
        // Parametro: dato - el numero que queremos agregar
        public void InsertarElemento(int dato)
        {
            // Paso 1: Crear un nuevo nodo con el valor
            Nodo nuevoNodo = new Nodo(dato);

            // Paso 2: Verificar si la lista esta vacia
            if (cabeza == null)
            {
                // Si esta vacia, el nuevo nodo es la cabeza
                cabeza = nuevoNodo;
                Console.WriteLine($"Elemento {dato} insertado");
                return;  // Terminamos aqui
            }

            // Paso 3: Si la lista no esta vacia, buscar el ultimo nodo
            Nodo actual = cabeza;  // Empezamos desde la cabeza
            
            // Recorremos hasta encontrar el ultimo nodo
            // (el que tiene Siguiente = null)
            while (actual.Siguiente != null)
            {
                actual = actual.Siguiente;  // Avanzamos al siguiente
            }

            // Paso 4: Conectar el nuevo nodo al final
            actual.Siguiente = nuevoNodo;
            Console.WriteLine($"Elemento {dato} insertado");
        }

        // Metodo para borrar un elemento por su posicion en la lista
        // Parametro: posicion - el indice del elemento (empieza en 0)
        // Ejemplo: posicion 0 es el primero, posicion 1 es el segundo, etc.
        public void BorrarPorPosicion(int posicion)
        {
            // Validacion 1: Verificar si la lista esta vacia
            if (cabeza == null)
            {
                Console.WriteLine("Error: La lista esta vacia");
                return;  // No podemos borrar de una lista vacia
            }

            // Validacion 2: La posicion debe ser un numero positivo
            if (posicion < 0)
            {
                Console.WriteLine("Error: La posicion debe ser positiva");
                return;
            }

            // Caso especial: Si queremos borrar el primer elemento (posicion 0)
            if (posicion == 0)
            {
                int datoEliminado = cabeza.Dato;  // Guardamos el valor para mostrarlo
                cabeza = cabeza.Siguiente;         // La cabeza ahora es el segundo nodo
                Console.WriteLine($"Elemento {datoEliminado} eliminado");
                return;
            }

            // Caso general: Buscar el nodo ANTERIOR al que queremos borrar
            // (necesitamos el anterior para poder "saltar" el nodo a borrar)
            Nodo? actual = cabeza;
            int contador = 0;

            // Recorremos hasta llegar al nodo anterior al que vamos a borrar
            // Ejemplo: si queremos borrar posicion 2, nos detenemos en posicion 1
            while (actual != null && contador < posicion - 1)
            {
                actual = actual.Siguiente;
                contador++;
            }

            // Verificar si la posicion existe
            if (actual == null || actual.Siguiente == null)
            {
                Console.WriteLine($"Error: La posicion {posicion} no existe");
                return;
            }

            // Realizar el borrado: "saltamos" el nodo
            // Ejemplo: A -> B -> C  si borramos B queda A -> C
            int dato = actual.Siguiente.Dato;              // Guardamos el valor
            actual.Siguiente = actual.Siguiente.Siguiente; // Hacemos el "salto"
            Console.WriteLine($"Elemento {dato} eliminado");
        }

        // Metodo para borrar un elemento buscando por su valor
        // Parametro: dato - el valor que queremos eliminar
        // Nota: solo elimina la primera aparicion si hay valores repetidos
        public void BorrarPorContenido(int dato)
        {
            // Validacion: Verificar si la lista esta vacia
            if (cabeza == null)
            {
                Console.WriteLine("Error: La lista esta vacia");
                return;
            }

            // Caso especial: Si el elemento a borrar es el primero
            if (cabeza.Dato == dato)
            {
                cabeza = cabeza.Siguiente;  // Movemos la cabeza al siguiente
                Console.WriteLine($"Elemento {dato} eliminado");
                return;
            }

            // Caso general: Buscar el elemento en el resto de la lista
            Nodo? actual = cabeza;
            
            // Recorremos la lista buscando el valor
            // Nos detenemos cuando:
            // 1. Encontramos el valor en el SIGUIENTE nodo, o
            // 2. Llegamos al final de la lista
            while (actual.Siguiente != null && actual.Siguiente.Dato != dato)
            {
                actual = actual.Siguiente;
            }

            // Verificar si encontramos el elemento
            if (actual.Siguiente == null)
            {
                // No lo encontramos (llegamos al final)
                Console.WriteLine($"Error: El elemento {dato} no se encontro");
                return;
            }

            // Si llegamos aqui, encontramos el elemento
            // Hacemos el "salto" para eliminarlo
            actual.Siguiente = actual.Siguiente.Siguiente;
            Console.WriteLine($"Elemento {dato} eliminado");
        }

        // Metodo para mostrar todos los elementos de la lista
        public void ImprimirLista()
        {
            // Verificar si la lista esta vacia
            if (cabeza == null)
            {
                Console.WriteLine("La lista esta vacia");
                return;
            }

            Console.WriteLine("\nContenido de la lista:");

            // Recorrer la lista desde la cabeza hasta el final
            Nodo? actual = cabeza;  // Empezamos en el primer nodo
            int posicion = 0;       // Contador de posicion

            // Mientras no lleguemos al final (actual != null)
            while (actual != null)
            {
                // Imprimimos el valor del nodo actual
                Console.WriteLine($"Posicion {posicion}: {actual.Dato}");
                
                // Avanzamos al siguiente nodo
                actual = actual.Siguiente;
                posicion++;
            }

            Console.WriteLine($"Total: {posicion} elementos\n");
        }

        // Metodo para ordenar la lista de menor a mayor
        // Algoritmo usado: Bubble Sort (Ordenamiento de burbuja)
        public void OrdenarLista()
        {
            // Si la lista esta vacia o tiene un solo elemento, ya esta ordenada
            if (cabeza == null || cabeza.Siguiente == null)
            {
                Console.WriteLine("Lista ordenada");
                return;
            }

            // Variable para saber si hubo intercambios
            bool intercambio;
            
            // Repetimos el proceso hasta que no haya mas intercambios
            do
            {
                intercambio = false;        // Asumimos que no habra intercambios
                Nodo? actual = cabeza;      // Empezamos desde la cabeza

                // Recorremos toda la lista
                while (actual.Siguiente != null)
                {
                    // Si el actual es mayor que el siguiente, intercambiamos
                    if (actual.Dato > actual.Siguiente.Dato)
                    {
                        // Intercambiar los valores (no los nodos)
                        int temp = actual.Dato;                     // Guardamos el valor actual
                        actual.Dato = actual.Siguiente.Dato;        // Ponemos el siguiente en actual
                        actual.Siguiente.Dato = temp;               // Ponemos el actual en siguiente
                        intercambio = true;  // Marcamos que hubo cambio
                    }
                    actual = actual.Siguiente;  // Avanzamos al siguiente nodo
                }
            } while (intercambio);  // Repetimos si hubo algun intercambio

            Console.WriteLine("Lista ordenada");
        }

        // Metodo auxiliar para verificar si la lista esta vacia
        // Retorna: true si esta vacia, false si tiene elementos
        public bool EstaVacia()
        {
            return cabeza == null;  // Si cabeza es null, no hay elementos
        }
    }
}
