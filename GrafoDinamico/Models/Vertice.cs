using System.Collections.Generic;

namespace GrafoDinamico.Models
{
    public class Vertice
    {
        public int destino;
        public double peso;
        public Vertice siguiente = null;

        public Vertice(int destino, double peso)
        {
            this.destino = destino;
            this.peso = peso;
        }
    }
}