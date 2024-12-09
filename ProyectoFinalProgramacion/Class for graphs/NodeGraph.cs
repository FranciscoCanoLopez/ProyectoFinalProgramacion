using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalProgramacion.Class_for_graphs
{
    internal class NodeGraph
    {
        public string Name { get; set; }
        public List<Edge> Neighbors { get; set; }

        public NodeGraph(string name)
        {
            Name = name;
            Neighbors = new List<Edge>();
        }
    }
}
