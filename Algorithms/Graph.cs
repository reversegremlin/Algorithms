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
            s.adjacent.AddLast(d);
        }


        // Main Depth First Search, is there a path in the graph from source to destination.
        // keep the visited nodes in a hashset, instead of keeping a visited flag in the node object
        
        public bool HasPathDFS(int source, int destination)
        {
            Node s = GetNode(source);
            Node d = GetNode(destination);

            // use a hashset to track visited nodes

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

        public bool HasPathBFS(int source, int destination)
        {
            //get the nodes from the dictionary

            Node s = GetNode(source);
            Node d = GetNode(destination);

            // use a queue to track nodes to visit

            Queue<Node> nextToVisit = new Queue<Node>();

            // use a hashset to track visited nodes

            HashSet<int> visited = new HashSet<int>();

            // add the source to the queue (where we are starting the search)

            nextToVisit.Enqueue(s);

            //  while there are still things to visit

            while (nextToVisit.Count > 0)
            {
                // dequeue the node we are visiting from the queue

                Node node = nextToVisit.Dequeue();

                // check to see if it matches where we are going

                if (node == d)
                {
                    return true;
                }
                
                // skip over it if it has been visited and bail on the rest of this loop
                // going to the next unvisited node

                if (visited.Contains(node.id))
                {
                    continue;
                }

                visited.Add(node.id);

                foreach  (Node child in node.adjacent)
                {
                    nextToVisit.Enqueue(child);
                }
            }
            return false;
        }
    }
}