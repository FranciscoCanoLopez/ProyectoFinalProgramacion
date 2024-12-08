using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ProyectoFinalProgramacion.Node_classes_for_queues
{
    internal class NodeSimpleQueueList
    {
        public int Value { get; set; }
        public NodeSimpleQueueList Next { get; set; }

        public NodeSimpleQueueList(int value)
        {
            Value = value;
            Next = null!;
        }
    }
}
