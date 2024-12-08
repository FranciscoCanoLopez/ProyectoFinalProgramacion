using ProyectoFinalProgramacion.Node_classes_for_lists;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ProyectoFinalProgramacion.Classes_for_lists
{
    internal class CircularsLists
    {
        private CircularsListsNode head;

        public CircularsLists()
        {
            head = null!;
        }

        public void Add(int value)
        {
            CircularsListsNode newCircularsListsNode = new CircularsListsNode { Value = value };

            //Lista vacía
            if (head == null)
            {
                head = newCircularsListsNode;
                head.Next = head;
            }
            //si el valor es menos que el head el valor sera el nuevo head
            else if (value < head.Value)
            {
                CircularsListsNode current = head;
                while (current.Next != head)
                {
                    current = current.Next;
                }
                newCircularsListsNode.Next = head;
                current.Next = newCircularsListsNode;
                head = newCircularsListsNode;
            }
            // Buscar la posición correcta en la lista
            else
            {
                CircularsListsNode current = head;

                while (current.Next != head && current.Next.Value < value)
                {
                    current = current.Next;
                }
                // Verificamos si el valor ya existe
                if (current.Next.Value == value)
                {
                    return;
                }
                newCircularsListsNode.Next = current.Next;
                current.Next = newCircularsListsNode;
            }
        }
        public void Remove(int value)
        {
            if (head == null)
            {
                MessageBox.Show("The list is empty, no nodes to remove.");
                return;
            }

            CircularsListsNode current = head;

            if (head.Value == value)
            {

                if (head.Next == head)
                {
                    head = null!;
                }
                else
                {
                    while (current.Next != head)
                    {
                        current = current.Next;
                    }

                    head = head.Next;
                    current.Next = head;
                }
                MessageBox.Show("Node removed successfully.");
                return;
            }

            // El nodo a eliminar no es el head
            current = head;

            while (current.Next != head)
            {
                if (current.Next.Value == value)
                {
                    current.Next = current.Next.Next;
                    MessageBox.Show("Node removed successfully.");
                    return;
                }

                current = current.Next;
            }

            MessageBox.Show("Node not found.");
        }

        public bool Contains(int value)
        {
            if (head == null)
            {
                return false;
            }

            CircularsListsNode current = head;

            do
            {
                if (current.Value == value)
                {
                    return true;
                }
                current = current.Next;
            }
            while (current != head);
            return false;
        }
        public string[] Display()
        {
            if (head == null)
            {
                MessageBox.Show("The list is empty.");
                return [];
            }

            var result = new List<string>();
            CircularsListsNode current = head;

            do
            {
                result.Add(current.Value.ToString());
                current = current.Next;
            } while (current != head);

            return result.ToArray();
        }

        public int Count()
        {
            if (head == null)
            {
                return 0;
            }

            int count = 1;
            CircularsListsNode current = head;

            while (current.Next != head)
            {
                count++;
                current = current.Next;
            }
            return count;
        }
    }
}
