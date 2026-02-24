using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2D.Models
{
    public class NodoDoble
    {
        public int valorDato;
        public NodoDoble enlaceSiguiente;

        public NodoDoble(int nuevoDato)
        {
            valorDato = nuevoDato;
            enlaceSiguiente = null;
        }
    }
}