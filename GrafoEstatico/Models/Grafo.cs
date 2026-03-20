using System;

namespace GrafoEstatico.Models
{
	class Grafo
	{
		public double[,] data;
        public int numVertices;

        public Grafo(int vertices)
        {
            this.numVertices = vertices;
            data = new double[numVertices, numVertices];
        }
        public void setEdge(int i,int j, double weight)
        {
           if (i >= 0 && i < numVertices && j >= 0 && j < numVertices)
            {
                data[i, j] = weight;
            }
            else
            {
                Console.WriteLine("Error: Indices fuera de rango.");
                Console.WriteLine("Asegúrate de que i y j estén entre 0 y " + (numVertices - 1) + ".");
            }
        }

        public int numVerticesGrafo()
        {
            return numVertices;
        }
        public void ImprimirGrafo()
        {
            
            for (int i = 0; i < numVertices; i++)
            {
                for (int j = 0; j < numVertices; j++)
                {
                    Console.Write(data[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
	}
}