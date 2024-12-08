using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalProgramacion.Class_for_queue
{
    internal class SimpleVectorQueue
    {
        private int[] queue;
        private int front, rear, size;

        public SimpleVectorQueue(int capacity)
        {
            queue = new int[capacity];
            front = -1;
            rear = -1;
            size = capacity;
        }

        public void Enqueue(int element)
        {
            if (rear == size - 1)
                throw new InvalidOperationException("Queue is full");

            if (front == -1) front = 0; // Set front if it's the first element
            queue[++rear] = element;
        }

        public int Dequeue()
        {
            if (front == -1 || front > rear)
                throw new InvalidOperationException("Queue is empty");

            int element = queue[front];
            if (front == rear) // Reset queue when empty
                front = rear = -1;
            else
                front++;

            return element;
        }

        public int[] GetQueueElements()
        {
            if (front == -1)
                return Array.Empty<int>();

            int[] elements = new int[rear - front + 1];
            Array.Copy(queue, front, elements, 0, elements.Length);
            return elements;
        }
    }
}
