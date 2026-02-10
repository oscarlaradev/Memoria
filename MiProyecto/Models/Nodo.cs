namespace MiProyecto.Models
{
    /// <summary>
    /// Representa un nodo de la lista enlazada
    /// </summary>
    public class Nodo
    {
        public int Dato { get; set; }
        public Nodo? Siguiente { get; set; }

        public Nodo(int dato)
        {
            Dato = dato;
            Siguiente = null;
        }
    }
}
