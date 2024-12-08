using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalProgramacion.Class_for_queue
{
    internal class DoubleQueueVector
    {
        private int[] deque;
        private int front, rear, size, count;

        public DoubleQueueVector(int capacity)
        {
            size = capacity;
            deque = new int[size];
            front = 0;
            rear = -1;
            count = 0;
        }

        public void InsertFront(int value)
        {
            if (count == size)
                throw new InvalidOperationException("Deque is full");

            front = (front - 1 + size) % size;
            deque[front] = value;
            count++;
        }

        public void InsertRear(int value)
        {
            if (count == size)
                throw new InvalidOperationException("Deque is full");

            rear = (rear + 1) % size;
            deque[rear] = value;
            count++;
        }

        public int RemoveFront()
        {
            if (count == 0)
                throw new InvalidOperationException("Deque is empty");

            int value = deque[front];
            front = (front + 1) % size;
            count--;
            return value;
        }

        public int RemoveRear()
        {
            if (count == 0)
                throw new InvalidOperationException("Deque is empty");

            int value = deque[rear];
            rear = (rear - 1 + size) % size;
            count--;
            return value;
        }

        public int[] GetDequeElements()
        {
            int[] elements = new int[count];
            for (int i = 0; i < count; i++)
            {
                elements[i] = deque[(front + i) % size];
            }
            return elements;
        }
    }
}
