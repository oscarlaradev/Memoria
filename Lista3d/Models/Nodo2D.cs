using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3D.Models
{
    // Nodo de dimension 2: guarda una lista 1D.
    public class Nodo2D
    {
        public Lista1D listaInterna1D;
        public Nodo2D enlaceSiguiente;

        public Nodo2D(Lista1D nuevaLista1D)
        {
            listaInterna1D = nuevaLista1D;
            enlaceSiguiente = null;
        }
    }
}