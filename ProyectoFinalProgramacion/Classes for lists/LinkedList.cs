using ProyectoFinalProgramacion.Node_class_for_lists;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ProyectoFinalProgramacion.Classes_for_lists
{
    internal class LinkedList
    {
        private SingleListNode head;

        public LinkedList()
        {
            head = null!;
        }

        public void Add(SingleListNode newNode)
        {
            //Node newNode = new Node(value);
            //If the list is empty, add the new node as the head
            if (head == null)
            {
                head = newNode;
                return;
            }
            //If the new node is less than the head, add it as the new head
            if (newNode.Value < head.Value)
            {
                newNode.Next = head;
                head = newNode;
                return;
            }
            //Find the correct position for the new node
            SingleListNode current = head;
            //While the current node is not the last node and the value of the next node is less than the value of the new node
            while (current.Next != null && current.Next.Value < newNode.Value)
            {
                current = current.Next;
            }
            newNode.Next = current.Next;
            current.Next = newNode;


        }
        public void Remove(int value)
        {
            if (head == null)
            {
                return;
            }
            if (head.Value == value)
            {
                head = head.Next!;
                return;
            }
            SingleListNode current = head;
            while (current.Next != null)
            {
                if (current.Next.Value == value)
                {
                    current.Next = current.Next.Next;
                    return;
                }
                current = current.Next;
            }
        }
        public bool Contains(int value)
        {
            SingleListNode? current = head;
            while (current != null)
            {
                if (current.Value == value)
                {
                    return true;
                }
                current = current.Next;
            }
            return false;
        }
        public int Count()
        {
            int count = 0;
            SingleListNode? current = head;
            while (current != null)
            {
                count++;
                current = current.Next;
            }
            return count;
        }
        public override string ToString()
        {
            string result = "";
            SingleListNode? current = head;
            while (current != null)
            {
                result += current.ToString() + " ";
                current = current.Next;
            }
            return result;
        }
    }
}
