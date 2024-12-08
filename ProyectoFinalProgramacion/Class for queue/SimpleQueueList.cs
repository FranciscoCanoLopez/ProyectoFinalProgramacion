using ProyectoFinalProgramacion.Node_classes_for_queues;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ProyectoFinalProgramacion.Class_for_queue
{
    internal class SimpleQueueList
    {
        private NodeSimpleQueueList front;
        private NodeSimpleQueueList rear;

        public SimpleQueueList()
        {
            front = rear = null!;
        }

        public void Enqueue(int value)
        {
            NodeSimpleQueueList newSimpleQueueListNode = new NodeSimpleQueueList(value);

            if (rear == null) // If the queue is empty
            {
                front = rear = newSimpleQueueListNode;
            }
            else
            {
                rear.Next = newSimpleQueueListNode;
                rear = newSimpleQueueListNode;
            }
        }

        public int Dequeue()
        {
            if (front == null)
                throw new InvalidOperationException("Queue is empty");

            int value = front.Value;
            front = front.Next;

            if (front == null) // If the queue becomes empty
                rear = null!;

            return value;
        }

        public IEnumerable<int> GetQueueElements()
        {
            List<int> elements = new List<int>();
            NodeSimpleQueueList current = front;

            while (current != null)
            {
                elements.Add(current.Value);
                current = current.Next;
            }

            return elements;
        }
    }
}
