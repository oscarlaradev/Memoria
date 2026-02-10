namespace MiProyecto.Models
{
    // Clase Nodo: representa cada elemento de la lista enlazada
    // Cada nodo contiene:
    //   - Un dato (el valor que guardamos)
    //   - Una referencia al siguiente nodo
    public class Nodo
    {
        // Propiedad que almacena el valor del nodo
        public int Dato { get; set; }
        
        // Propiedad que apunta al siguiente nodo en la lista
        // Si es null, significa que este es el ultimo nodo
        public Nodo? Siguiente { get; set; }

        // Constructor: se ejecuta cuando creamos un nuevo nodo
        // Recibe el valor que queremos guardar
        public Nodo(int dato)
        {
            Dato = dato;           // Guardamos el valor
            Siguiente = null;      // Al inicio no apunta a nadie
        }
    }
}
