using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms
{
    public class Graph
    {
        public static Dictionary<int, Node> nodeLookup = new Dictionary<int, Node>();

        public class Node 
        {
            public int id;
            public LinkedList<Node> adjacent = new LinkedList<Node>();

            public Node(int id)
            {
                this.id = id;
            }
        }

        public void AddNode(int id)
        {
            nodeLookup.Add(id, new Node(id));
        }
 
        private Node GetNode(int id)
        {
            return nodeLookup[id];
        }

        public void AddEdge(int source, int destination)
        {
            Node s = GetNode(source);
            Node d = GetNode(destination);
            s.adjacent.AddFirst(d);
        }

        public bool hasPathDFS(int source, int destination)
        {
            Node s = GetNode(source);
            Node d = GetNode(destination);

            HashSet<int> visited = new HashSet<int>();
            return hasPathDFS(s, d, visited);

        }

        private bool hasPathDFS(Node source, Node destination, HashSet<int> visited)
        {
            if (visited.Contains(source.id))
            {
                return false;
            }
            visited.Add(source.id);

            if (source == destination)
            {
                return true;
            }

            foreach (Node child in source.adjacent )
            {
                if (hasPathDFS(child, destination, visited))
                {
                    return true;
                }
            }
            return false;
        }
    }

}