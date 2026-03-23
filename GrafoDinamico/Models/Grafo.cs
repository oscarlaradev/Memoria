using System;
using System.Collections.Generic;

namespace GrafoDinamico.Models
{
    public class Grafo
    {
        private int numVertices;
        private Vertice[] listas;

        public Grafo(int numVertices)
        {
            this.numVertices = numVertices;
            listas = new Vertice[numVertices];
        }

        public void AgregarArista(int origen, int destino, double peso)
        {
            Vertice nuevo = new Vertice(destino, peso);
            nuevo.siguiente = listas[origen];
            listas[origen] = nuevo;
        }

        public void Imprimir()
        {
            for (int origen = 0; origen < numVertices; origen++)
            {
                Console.Write(origen + ": ");
                Vertice temp = listas[origen];
                while (temp != null)
                {
                    Console.Write($"-> {temp.destino} (peso: {temp.peso}) ");
                    temp = temp.siguiente;
                }
                Console.WriteLine();
            }
        }
    }
}
