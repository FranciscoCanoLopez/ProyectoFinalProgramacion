using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalProgramacion.Class_for_queue
{
    internal class PriorityQueueVectors
    {
        private List<List<int>> priorityQueue;

        public PriorityQueueVectors(int priorityLevels)
        {
            priorityQueue = new List<List<int>>(priorityLevels);
            for (int i = 0; i < priorityLevels; i++)
            {
                priorityQueue.Add(new List<int>());
            }
        }

        public void Enqueue(int value, int priority)
        {
            if (priority < 0 || priority >= priorityQueue.Count)
                throw new ArgumentOutOfRangeException(nameof(priority), "Invalid priority level.");

            priorityQueue[priority].Add(value);
        }

        public int Dequeue()
        {
            for (int i = 0; i < priorityQueue.Count; i++)
            {
                if (priorityQueue[i].Count > 0)
                {
                    int value = priorityQueue[i][0];
                    priorityQueue[i].RemoveAt(0);
                    return value;
                }
            }

            throw new InvalidOperationException("Priority queue is empty.");
        }

        public List<int>[] GetQueueElements()
        {
            return priorityQueue.ToArray();
        }
    }
}
