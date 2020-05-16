using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms
{
    public class Graph
    {
        public static Dictionary<int, Node> nodeLookup = new Dictionary<int, Node>();
        //this is just a dictionary to quickly lookup id->node

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


        // Main Depth First Search, is there a path in the graph from source to destination.
        // keep the visited nodes in a hashset, instead of keeping a visited flag in the node object
        
        public bool HasPathDFS(int source, int destination)
        {
            Node s = GetNode(source);
            Node d = GetNode(destination);

            HashSet<int> visited = new HashSet<int>();
            return HasPathDFS(s, d, visited);

        }

        // helper method that does all the real work

        private bool HasPathDFS(Node source, Node destination, HashSet<int> visited)
        {
            // if it's been visited, we know there is  no path

            if (visited.Contains(source.id))
            {
                return false;
            }

            // or else add it to the visited dictionary

            visited.Add(source.id);

            // we found it

            if (source == destination)
            {
                return true;
            }
            
            // or else keep going through the graph

            foreach (Node child in source.adjacent )
            {
                if (HasPathDFS(child, destination, visited))
                {
                    return true;
                }
            }
            return false;
        }

        public bool HasPathBFS(Node source, Node destination)
        {

            return false;
        }
    }

}