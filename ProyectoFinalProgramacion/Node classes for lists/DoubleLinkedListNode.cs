using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ProyectoFinalProgramacion.Node_classes_for_lists
{
    internal class DoubleLinkedListNode
    {
        public int Data { get; set; }
        public DoubleLinkedListNode Next { get; set; }
        public DoubleLinkedListNode Prev { get; set; }

        public DoubleLinkedListNode(int data)
        {
            Data = data;
            Next = null!;
            Prev = null!;
        }
    }
}
