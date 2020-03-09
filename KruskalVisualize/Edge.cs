using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KruskalVisualize
{
    public class Edge
    {
        public int from;
        public int to;
        public int weight;

        public Edge(int from, int to, int weight)
        {
            this.from = from;
            this.to = to;
            this.weight = weight;
        }
    }
}
