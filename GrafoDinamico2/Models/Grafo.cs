using System;

namespace GrafoDinamico2.Models
{
    public class Grafo
    {
        public int numVertices;
        public Vertice[] listas;

        public Grafo(int numVertices)
        {
            this.numVertices = numVertices;
            this.listas = new Vertice[numVertices];
        }

        public bool AgregarArista(int origen, int destino, double peso)
        {
            if (origen < 0 || origen >= numVertices)
            {
                return false;
            }

            if (destino < 0 || destino >= numVertices)
            {
                return false;
            }

            if (peso <= 0)
            {
                return false;
            }

            Vertice actual = listas[origen];
            while (actual != null)
            {
                if (actual.destino == destino)
                {
                    actual.peso = peso;
                    return true;
                }
                actual = actual.siguiente;
            }

            Vertice nuevo = new Vertice(destino, peso);
            nuevo.siguiente = listas[origen];
            listas[origen] = nuevo;
            return true;
        }

        public bool BorrarArista(int origen, int destino)
        {
            if (origen < 0 || origen >= numVertices)
            {
                return false;
            }

            if (destino < 0 || destino >= numVertices)
            {
                return false;
            }

            Vertice actual = listas[origen];
            Vertice anterior = null;

            while (actual != null)
            {
                if (actual.destino == destino)
                {
                    if (anterior == null)
                    {
                        listas[origen] = actual.siguiente;
                    }
                    else
                    {
                        anterior.siguiente = actual.siguiente;
                    }

                    return true;
                }

                anterior = actual;
                actual = actual.siguiente;
            }

            return false;
        }

        public void ImprimirGrafo()
        {
            Console.WriteLine("Grafo (lista de adyacencia):");

            for (int origen = 0; origen < numVertices; origen++)
            {
                Console.Write(origen + ": ");
                Vertice temp = listas[origen];

                if (temp == null)
                {
                    Console.Write("(sin aristas)");
                }

                while (temp != null)
                {
                    Console.Write("-> " + temp.destino + " (peso: " + temp.peso + ") ");
                    temp = temp.siguiente;
                }

                Console.WriteLine();
            }
        }
    }
}
