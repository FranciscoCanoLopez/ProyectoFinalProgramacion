using ProyectoFinalProgramacion.Node_classes_for_queues;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ProyectoFinalProgramacion.Class_for_queue
{
    internal class DoubleQueueList
    {
        private NodeDoubleQueueList front;
        private NodeDoubleQueueList rear;
        private int count;

        public DoubleQueueList()
        {
            front = null!;
            rear = null!;
            count = 0;
        }

        public void InsertFront(int value)
        {
            NodeDoubleQueueList newDoubleQueueListNode = new NodeDoubleQueueList(value);

            if (count == 0)
            {
                front = rear = newDoubleQueueListNode;
            }
            else
            {
                newDoubleQueueListNode.Next = front;
                front.Prev = newDoubleQueueListNode;
                front = newDoubleQueueListNode;
            }

            count++;
        }

        public void InsertRear(int value)
        {
            NodeDoubleQueueList newDoubleQueueListNode = new NodeDoubleQueueList(value);

            if (count == 0)
            {
                front = rear = newDoubleQueueListNode;
            }
            else
            {
                newDoubleQueueListNode.Prev = rear;
                rear.Next = newDoubleQueueListNode;
                rear = newDoubleQueueListNode;
            }

            count++;
        }

        public int RemoveFront()
        {
            if (count == 0)
                throw new InvalidOperationException("Deque is empty");

            int value = front.Value;
            front = front.Next;

            if (front != null)
                front.Prev = null!;
            else
                rear = null!;

            count--;
            return value;
        }

        public int RemoveRear()
        {
            if (count == 0)
                throw new InvalidOperationException("Deque is empty");

            int value = rear.Value;
            rear = rear.Prev;

            if (rear != null)
                rear.Next = null!;
            else
                front = null!;

            count--;
            return value;
        }

        public int[] GetDequeElements()
        {
            int[] elements = new int[count];
            NodeDoubleQueueList current = front;
            for (int i = 0; i < count; i++)
            {
                elements[i] = current.Value;
                current = current.Next;
            }
            return elements;
        }
    }
}
