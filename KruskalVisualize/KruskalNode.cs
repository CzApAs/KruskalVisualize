using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KruskalVisualize
{
    class KruskalNode
    {
        KruskalNode parent;
        uint height;


        public KruskalNode()
        {
            this.parent = null;
            this.height = 0;
        }

        public KruskalNode Root()
        {
            if(this.parent == null)
            {
                return this;
            }
            KruskalNode newNode = this.parent.Root();
            this.parent = newNode;
            return newNode;

        }

        bool InSameSet(KruskalNode other)
        {
            return this.Root() == other.Root();
        }

        bool Merge(KruskalNode other)
        {
            KruskalNode rootThis = this.Root();
            KruskalNode rootOther = other.Root();
            if(rootThis == rootOther)
            {
                return false;
            }
            if(rootThis.height < rootOther.height)
            {
                rootThis.parent = rootOther;
            }
            else
            {
                rootOther.parent = rootThis;
                if(rootThis.height == rootOther.height)
                {
                    rootThis.height += 1;
                }
            }
            return true;  // merge successful
        }

        private static void Print(List<Edge> results)
        {
            foreach(Edge result in results)
            {
                Console.WriteLine("{0} -- {1} == {2}", result.from, result.to, result.weight);
            }
        }

        public static List<Edge> Kruskal(Graph graph)
        {
            int numberofVertices = graph.GetNumberOfVertices();

            List<Edge> results = new List<Edge>();
            int resultEdge = 0;
            int currentSortedEdge = 0;


            List<Edge> sortedEdges = graph.GetSortedEdges();

            KruskalNode[] subSets = new KruskalNode[numberofVertices];
            for(int i = 0; i < numberofVertices; i++)
            {
                subSets[i] = new KruskalNode();
                //subSets[i].parent = null;
                subSets[i].height = 0;
            }

            while(resultEdge < numberofVertices - 1)
            {
                Edge nextEdge = sortedEdges[currentSortedEdge++];

                KruskalNode firstNode = subSets[nextEdge.from].Root();
                KruskalNode secondNode = subSets[nextEdge.to].Root();

                if(firstNode.Merge(secondNode))
                {
                    results.Add(nextEdge);
                    resultEdge++;
                }
            }

            //Print(results);

            return results;
        }
    }
}
