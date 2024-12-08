using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalProgramacion.Classes_for_stacks
{
    internal class DynamicStack
    {
        private NodeStacks top;

        public DynamicStack()
        {
            top = null!;
        }

        // Método para insertar un elemento en la pila
        public void Push(NodeStacks newNode)
        {
            if (IsEmpty())
            {
                top = newNode;
                return;
            }

            newNode.Next = top;
            top = newNode;
            return;
        }


        // Método para eliminar y devolver el elemento en el tope de la pila
        public NodeStacks Pop()
        {
            if (!IsEmpty())
            {
                NodeStacks current = top;
                top = top.Next;
                current.Next = null!;
                return current;
            }
            return null!;

        }


        // Método para devolver el elemento en el tope de la pila sin eliminarlo
        public NodeStacks Peek()
        {
            if (IsEmpty())
            {
                return null!;
            }

            return top;
        }


        // Método para verificar si la pila está vacía
        public bool IsEmpty()
        {
            return top == null;
        }

        public int Size()
        {
            int count = 0;
            NodeStacks current = top;

            // Recorre la pila desde el frente hasta el final
            while (current != null)
            {
                count++;
                current = current.Next; // Avanza al siguiente nodo
            }

            return count; // Devuelve el número total de elementos Size
        }
    }
}
