using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoListas
{
    public class Nodo
    {
        // El valor que guarda el cuadrito
        public int valorDato; 
        
        // La flecha que apunta al siguiente
        public Nodo enlaceSiguiente;

        // Constructor
        public Nodo(int nuevoDato)
        {
            valorDato = nuevoDato;
            enlaceSiguiente = null; // Al principio no apunta a nada
        }
    }
}