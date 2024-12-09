using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalProgramacion.Classes_for_Binari_Trees
{
    internal class BinariTreeNode
    {
        public int Valor;
        public BinariTreeNode Izquierda;
        public BinariTreeNode Derecha;

        public BinariTreeNode(int valor)
        {
            Valor = valor;
            Izquierda = null!;
            Derecha = null!;
        }
    }
}
