using System;
using System.Collections.Generic;

namespace GrafoBFS.Models
{
    public class Grafo
    {
        private readonly List<int>[] listaAdyacencia;
        private readonly bool esDirigido;

        public int NumeroVertices { get; }

        public Grafo(int numeroVertices, bool esDirigido)
        {
            NumeroVertices = numeroVertices;
            this.esDirigido = esDirigido;
            listaAdyacencia = new List<int>[numeroVertices];

            for (int i = 0; i < numeroVertices; i++)
            {
                listaAdyacencia[i] = new List<int>();
            }
        }

        public bool AgregarArista(int origen, int destino)
        {
            if (!EsVerticeValido(origen) || !EsVerticeValido(destino))
            {
                return false;
            }

            if (!listaAdyacencia[origen].Contains(destino))
            {
                listaAdyacencia[origen].Add(destino);
            }

            if (!esDirigido && !listaAdyacencia[destino].Contains(origen))
            {
                listaAdyacencia[destino].Add(origen);
            }

            return true;
        }

        public void ImprimirGrafo()
        {
            Console.WriteLine("\nLista de adyacencia del grafo:");
            for (int i = 0; i < NumeroVertices; i++)
            {
                Console.Write(i + ": ");
                if (listaAdyacencia[i].Count == 0)
                {
                    Console.Write("(sin conexiones)");
                }
                else
                {
                    Console.Write(string.Join(" -> ", listaAdyacencia[i]));
                }
                Console.WriteLine();
            }
        }

        public List<int> RecorridoBFS(int nodoFuente)
        {
            List<int> recorrido = new List<int>();
            if (!EsVerticeValido(nodoFuente))
            {
                return recorrido;
            }

            bool[] visitado = new bool[NumeroVertices];
            Queue<int> cola = new Queue<int>();

            visitado[nodoFuente] = true;
            cola.Enqueue(nodoFuente);

            while (cola.Count > 0)
            {
                int actual = cola.Dequeue();
                recorrido.Add(actual);

                foreach (int vecino in listaAdyacencia[actual])
                {
                    if (!visitado[vecino])
                    {
                        visitado[vecino] = true;
                        cola.Enqueue(vecino);
                    }
                }
            }

            return recorrido;
        }

        public bool EsVerticeValido(int vertice)
        {
            return vertice >= 0 && vertice < NumeroVertices;
        }
    }
}
