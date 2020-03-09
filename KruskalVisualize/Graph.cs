using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KruskalVisualize
{
    class Graph
    {
        int numberOfVertices;
        int[,] edges;
        List<Edge> kruskalEdges;

        public Graph(int numberOfVertices)
        {
            this.numberOfVertices = numberOfVertices;

            edges = new int[numberOfVertices, numberOfVertices];
            kruskalEdges = new List<Edge>();
            
        }

        public int GetNumberOfVertices()
        {
            return numberOfVertices;
        }

        public void AddEdge(int from, int to, int weight)
        {
            if(edges[from, to] == 0 && edges[to, from] == 0)
            {
                Edge kruskalEdge = new Edge(from, to, weight);
                kruskalEdges.Add(kruskalEdge);
            }
            edges[from, to] = weight;
            edges[to, from] = weight;
        }

        public List<Edge> GetEdges()
        {
            return kruskalEdges;
        }

        public void PrintEdges()
        {
            foreach(Edge edge in kruskalEdges)
            {
                Console.WriteLine(edge.from + "->" + edge.to);
            }
        }

        public List<Edge> GetSortedEdges()
        {
            List<Edge> sortedEdges = kruskalEdges.OrderBy(o => o.weight).ToList();

            return sortedEdges;
        }
    }
}
