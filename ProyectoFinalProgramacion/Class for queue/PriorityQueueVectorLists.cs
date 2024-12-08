using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalProgramacion.Class_for_queue
{
    internal class PriorityQueueVectorLists
    {
        private List<LinkedList<int>> priorityQueue;

        public PriorityQueueVectorLists(int priorityLevels)
        {
            priorityQueue = new List<LinkedList<int>>(priorityLevels);
            for (int i = 0; i < priorityLevels; i++)
            {
                priorityQueue.Add(new LinkedList<int>());
            }
        }

        public void Enqueue(int value, int priority)
        {
            if (priority < 0 || priority >= priorityQueue.Count)
                throw new ArgumentOutOfRangeException(nameof(priority), "Invalid priority level.");

            priorityQueue[priority].AddLast(value);
        }

        public int Dequeue()
        {
            for (int i = 0; i < priorityQueue.Count; i++)
            {
                if (priorityQueue[i].Count > 0)
                {
                    int value = priorityQueue[i].First!.Value;
                    priorityQueue[i].RemoveFirst();
                    return value;
                }
            }

            throw new InvalidOperationException("Priority queue is empty.");
        }

        public List<LinkedList<int>> GetQueueElements()
        {
            return priorityQueue;
        }
    }
}
