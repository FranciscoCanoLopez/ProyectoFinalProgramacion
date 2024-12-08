using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ProyectoFinalProgramacion.Node_classes_for_lists
{
    internal class DoubleCircularListNode
    {
        public int Value { get; set; }
        public DoubleCircularListNode? Next { get; set; }
        public DoubleCircularListNode? Prev { get; set; }

        public DoubleCircularListNode()
        {
            Value = 0;
            Next = null;
            Prev = null;
        }

        public DoubleCircularListNode(int value)
        {
            Value = value;
            Next = null;
            Prev = null;
        }

        public override string ToString()
        {
            return Value.ToString() + ",";
        }
    }
}
