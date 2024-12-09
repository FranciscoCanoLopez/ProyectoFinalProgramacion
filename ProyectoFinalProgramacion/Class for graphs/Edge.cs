using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ProyectoFinalProgramacion.Class_for_graphs
{
    internal class Edge
    {
        //public Node From { get; set; }
        public NodeGraph To { get; set; }
        public int Weight { get; set; }

        public Edge(/*Node from,*/ NodeGraph to, int weight)
        {
            //From = from;
            To = to;
            Weight = weight;
        }

        public Edge(/*Node from,*/ NodeGraph to)
        {
            //From = from;
            To = to;
        }
    }
}
