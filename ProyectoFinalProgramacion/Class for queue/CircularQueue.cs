using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalProgramacion.Class_for_queue
{
    internal class CircularQueue
    {
        private int[] queue;
        private int front, rear, count, size;

        public CircularQueue(int capacity)
        {
            size = capacity;
            queue = new int[size];
            front = 0;
            rear = -1;
            count = 0;
        }

        public void Enqueue(int element)
        {
            if (count == size)
                throw new InvalidOperationException("Queue is full");

            rear = (rear + 1) % size; // Move rear to the next position
            queue[rear] = element;
            count++;
        }

        public int Dequeue()
        {
            if (count == 0)
                throw new InvalidOperationException("Queue is empty");

            int element = queue[front];
            front = (front + 1) % size; // Move front to the next position
            count--;
            return element;
        }

        public int[] GetQueueElements()
        {
            int[] elements = new int[count];
            for (int i = 0; i < count; i++)
            {
                elements[i] = queue[(front + i) % size];
            }
            return elements;
        }
    }
}
