using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalProgramacion.Classes_for_stacks
{
    internal class NodeStacks
    {
        public int Data { get; set; }
        public NodeStacks Next { get; set; } // Apunta al siguiente nodo

        public NodeStacks()
        {
            Data = 0;
            Next = null!; // El siguiente nodo inicialmente es null
        }

        public NodeStacks(int data)
        {
            Data = data;
            Next = null!; // El siguiente nodo inicialmente es null
        }

        public override string ToString()
        {
            return Data.ToString();
        }
    }
}
