using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalProgramacion.Class_for_queue
{
    internal class PriorityQueueLists
    {
        private LinkedList<LinkedList<int>> priorityQueue;

        public PriorityQueueLists(int priorityLevels)
        {
            priorityQueue = new LinkedList<LinkedList<int>>();
            for (int i = 0; i < priorityLevels; i++)
            {
                priorityQueue.AddLast(new LinkedList<int>());
            }
        }

        public void Enqueue(int value, int priority)
        {
            if (priority < 0 || priority >= priorityQueue.Count)
                throw new ArgumentOutOfRangeException(nameof(priority), "Invalid priority level.");

            var node = GetPriorityNode(priority);
            node.Value.AddLast(value);
        }

        public int Dequeue()
        {
            foreach (var list in priorityQueue)
            {
                if (list.Count > 0)
                {
                    int value = list.First!.Value;
                    list.RemoveFirst();
                    return value;
                }
            }

            throw new InvalidOperationException("Priority queue is empty.");
        }

        public LinkedList<LinkedList<int>> GetQueueElements()
        {
            return priorityQueue;
        }

        private LinkedListNode<LinkedList<int>> GetPriorityNode(int priority)
        {
            var current = priorityQueue.First;
            for (int i = 0; i < priority; i++)
            {
                current = current?.Next;
            }

            return current ?? throw new ArgumentException("Invalid priority node.");
        }
    }
}
