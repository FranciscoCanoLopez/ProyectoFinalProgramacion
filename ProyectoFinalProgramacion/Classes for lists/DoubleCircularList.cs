using ProyectoFinalProgramacion.Node_classes_for_lists;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ProyectoFinalProgramacion.Classes_for_lists
{
    internal class DoubleCircularList
    {
        private DoubleCircularListNode head;

        public DoubleCircularList()
        {
            head = null!;
        }

        public void Add(DoubleCircularListNode newDoubleCircularListNode)
        {
            //If the list is empty 
            if (head == null)
            {
                head = newDoubleCircularListNode;
                head.Next = head;
                head.Prev = head;
                return;
            }

            //Agregegar un nodo si ya hay nodos en la lista 
            //Insertar un nodo al inicio 
            if (newDoubleCircularListNode.Value < head.Value)
            {
                newDoubleCircularListNode.Next = head;
                newDoubleCircularListNode.Prev = head.Prev;
                head.Prev!.Next = newDoubleCircularListNode; //Se actualiza en next del ultimo nodo para que apunte al nuevo nodo
                head.Prev = newDoubleCircularListNode;
                head = newDoubleCircularListNode;
                return;
            }

            //Insertar un nodo al final 
            //Evalua si el valor del nuevo nodo es mayor al valor de ultimo nodo (head.Prev.Value)
            if (newDoubleCircularListNode.Value > head.Prev!.Value)
            {
                newDoubleCircularListNode.Next = head; // El siguiente de newNode
                newDoubleCircularListNode.Prev = head.Prev;
                head.Prev.Next = newDoubleCircularListNode; // Update the next of the last node
                head.Prev = newDoubleCircularListNode; // Update head's previous to the new node
                return;
            }


            // Find the correct position for the new node
            DoubleCircularListNode current = head;

            // Traverse the list to find the right spot
            while (current.Next != head && current.Next!.Value < newDoubleCircularListNode.Value)
            {
                current = current.Next;
            }

            // Insert the new node
            newDoubleCircularListNode.Next = current.Next;
            newDoubleCircularListNode.Prev = current;

            current.Next.Prev = newDoubleCircularListNode; // Update the next node's previous
            current.Next = newDoubleCircularListNode; // Link current node to the new node
        }


        public void Remove(int value)
        {
            if (head == null)
            {
                return;
            }

            if (head.Next == head) // Solo hay un nodo en la lista
            {
                head = null!; // La lista queda vacía
                return;
            }

            //Eliminación al inicio 
            if (head.Value == value)
            {
                head.Prev!.Next = head.Next; // Update last node's next
                head.Next!.Prev = head.Prev; // Update second node's previous
                head = head.Next; // Update head to the next node
                return;
            }

            //Eliminación al final 
            if (head.Prev!.Value == value)
            {
                // Aquí eliminamos el último nodo
                head.Prev = head.Prev.Prev; // Mover el puntero de cabeza hacia atrás
                head.Prev!.Next = head; // Actualizar el siguiente del nuevo último nodo
                return;
            }

            // Eliminación de un nodo intermedio
            DoubleCircularListNode current = head;
            while (current!.Next != head && current.Value != value)
            {
                current = current.Next!;
            }

            // Si el nodo con el valor fue encontrado
            if (current.Value == value)
            {
                current.Prev!.Next = current.Next; // Actualizar el siguiente del nodo anterior
                current.Next!.Prev = current.Prev; // Actualizar el anterior del nodo siguiente
            }
        }


        public bool Contains(int value)
        {

            if (head == null)
            {
                return false;
            }

            DoubleCircularListNode current = head;
            do
            {
                if (current!.Value == value)
                {
                    return true;
                }
                current = current.Next!;

            } while (current != head);
            return false;
        }


        public override string ToString()
        {
            if (head == null)

                return "The doubly circular linked list is void";

            string result = "";
            DoubleCircularListNode? current = head;

            do
            {
                result += current.ToString() + " "; // Llama al ToString del nodo
                current = current.Next!; // Avanza al siguiente nodo
            } while (current!= head); // Detenerse cuando se regrese al nodo cabeza

            return result;
        }
    }
}
