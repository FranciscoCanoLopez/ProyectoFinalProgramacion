using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalProgramacion.Class_for_queue
{
    internal class PriorityQueueListVectors
    {
        private LinkedList<List<int>> priorityQueue;

        public PriorityQueueListVectors(int priorityLevels)
        {
            priorityQueue = new LinkedList<List<int>>();
            for (int i = 0; i < priorityLevels; i++)
            {
                priorityQueue.AddLast(new List<int>());
            }
        }

        public void Enqueue(int value, int priority)
        {
            if (priority < 0 || priority >= priorityQueue.Count)
                throw new ArgumentOutOfRangeException(nameof(priority), "Invalid priority level.");

            var node = GetNodeByPriority(priority);
            node.Value.Add(value);
        }

        public int Dequeue()
        {
            foreach (var list in priorityQueue)
            {
                if (list.Count > 0)
                {
                    int value = list[0];
                    list.RemoveAt(0);
                    return value;
                }
            }

            throw new InvalidOperationException("Priority queue is empty.");
        }

        public LinkedList<List<int>> GetQueueElements()
        {
            return priorityQueue;
        }

        private LinkedListNode<List<int>> GetNodeByPriority(int priority)
        {
            var current = priorityQueue.First;
            for (int i = 0; i < priority; i++)
            {
                current = current!.Next;
            }
            return current!;
        }
    }
}
