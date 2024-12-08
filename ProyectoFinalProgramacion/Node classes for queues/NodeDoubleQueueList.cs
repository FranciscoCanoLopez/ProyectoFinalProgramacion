using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ProyectoFinalProgramacion.Node_classes_for_queues
{
    internal class NodeDoubleQueueList
    {
        public int Value;
        public NodeDoubleQueueList Next;
        public NodeDoubleQueueList Prev;

        public NodeDoubleQueueList(int value)
        {
            Value = value;
            Next = null!;
            Prev = null!;
        }
    }
}
