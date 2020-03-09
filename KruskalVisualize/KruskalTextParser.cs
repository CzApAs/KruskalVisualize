using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KruskalVisualize
{
    public class ParseResults
    {
        public int numberOfVertices;
        public List<Edge> allEdges;

        public ParseResults(int numberOfVertices, List<Edge> allEdges)
        {
            this.numberOfVertices = numberOfVertices;
            this.allEdges = allEdges;
        }
    }

    public static class KruskalTextParser
    {
        public static void SaveFileText(string targetFilePath, string savedText)
        {
            File.WriteAllText(targetFilePath, savedText);
        }

        public static string LoadFileText(string targetFilePath)
        {
            if (File.Exists(targetFilePath))
            {
                return File.ReadAllText(targetFilePath);
            }
            else
            {
                return null;
            }
        }

        public static ParseResults ParseText(string text)
        {
            int numberOfVertices = 0;
            List<Edge> allEdges = new List<Edge>();
            using (StringReader reader = new StringReader(text))
            {
                string line = null;
                if(null != (line = reader.ReadLine())) // first line - number of vertices
                {
                    numberOfVertices = int.Parse(line);
                }
                while (null != (line = reader.ReadLine())) // following lines - edge data
                {
                    if (string.IsNullOrEmpty(line))
                    {
                        continue;
                    }
                    string[] values = line.Split(';');
                    int from = int.Parse(values[0]);
                    int to = int.Parse(values[1]);
                    int weight = int.Parse(values[2]);
                    Edge resultEdge = new Edge(from, to, weight);
                    allEdges.Add(resultEdge);
                }
            }
            ParseResults result = new ParseResults(numberOfVertices, allEdges);
            return result;
        }
    }
}
