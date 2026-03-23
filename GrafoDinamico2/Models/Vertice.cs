namespace GrafoDinamico2.Models
{
    public class Vertice
    {
        public int destino;
        public double peso;
        public Vertice siguiente;

        public Vertice(int destino, double peso)
        {
            this.destino = destino;
            this.peso = peso;
            this.siguiente = null;
        }
    }
}
