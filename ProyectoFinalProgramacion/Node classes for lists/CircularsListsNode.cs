using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ProyectoFinalProgramacion.Node_classes_for_lists
{
    internal class CircularsListsNode
    {
        public int Value { get; set; }
        public CircularsListsNode Next { get; set; }
        public CircularsListsNode()
        {
            Value = 0;
            Next = null!;
        }
        public CircularsListsNode(int value)
        {
            Value = value;
            Next = null!;
        }
    }
}
