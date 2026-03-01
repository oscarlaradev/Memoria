using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3D.Models
{
    // Nodo basico para una lista simple de enteros (dimension 1).
    public class Nodo1D
    {
        public int valorDato;
        public Nodo1D enlaceSiguiente;

        public Nodo1D(int nuevoDato)
        {
            valorDato = nuevoDato;
            enlaceSiguiente = null;
        }
    }
}