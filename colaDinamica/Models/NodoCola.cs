namespace colaDinamica.Models
{
    public class NodoCola
    {
        public int valorDato;
        public NodoCola enlaceSiguiente;

        public NodoCola(int nuevoDato)
        {
            valorDato = nuevoDato;
            enlaceSiguiente = null;
        }
    }
}