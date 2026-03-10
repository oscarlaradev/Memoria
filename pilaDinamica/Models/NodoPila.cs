namespace pilaDinamica.Models
{
    // Nodo basico: guarda el dato y apunta al siguiente nodo.
    public class NodoPila
    {
        public int valorDato;
        public NodoPila enlaceSiguiente;

        public NodoPila(int nuevoDato)
        {
            valorDato = nuevoDato;
            enlaceSiguiente = null;
        }
    }
}