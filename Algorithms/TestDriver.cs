using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Algorithms
{
    using static Utils;

    class Program
    {
        static void Main(string[] args)
        {
            List<int> unsortedMS = new List<int>();
            List<int> sorted;

            Random random = new Random();

            Console.WriteLine("MergeSort");
            Console.WriteLine("Unsorted Array: ");
            for (int i = 0; i < 20; i++)
            {
                unsortedMS.Add(random.Next(0, 100));
                Console.Write(unsortedMS[i] + " ");
            }
            Console.WriteLine();

            sorted = MergeSort(unsortedMS);

            Console.WriteLine("Sorted Array: ");

            foreach (int x in sorted)
            {
                Console.Write(x + " ");
            }
            Console.Write("\n-------------------------------------------------------------------\n");
            Console.WriteLine("QuickSort");
            List<int> unsortedQS = new List<int>();
            Console.WriteLine("Unsorted Array: ");

            for (int i = 0; i < 20; i++)
            {
                unsortedQS.Add(random.Next(0, 100));
                Console.Write(unsortedQS[i] + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Sorted Array: ");

            QuickSort(unsortedQS, 0, unsortedQS.Count() - 1);

            foreach (int x in unsortedQS)
            {
                Console.Write(x + " ");
            }

            Console.Write("\n-------------------------------------------------------------------\n");
            Console.WriteLine("Binary Search - Iterative");

            List<int> array = new List<int> { 1, 3, 5, 7, 9, 13, 16, 17, 18, 20, 24, 27, 30, 33, 36, 39, 44, 46};
            
            foreach (int x in array)
            {
                Console.Write(x + " ");
            }
            Console.Write("\n");
            Console.Write("Searching for 3:\n");
            Console.WriteLine(BinarySearch(array, 3));
            Console.Write("\n");
            Console.Write("Searching for 46:\n");
            Console.WriteLine(BinarySearch(array, 46));
            Console.Write("\n");
            Console.Write("Searching for 2:\n");
            Console.WriteLine(BinarySearch(array, 2));
            Console.WriteLine();
            Console.Write("\n-------------------------------------------------------------------\n");
            Console.WriteLine("SelectionSort");
            Console.WriteLine("Unsorted Array: ");
            List<int> unsortedSS = new List<int>();

            for (int i = 0; i < 20; i++)
            {
                unsortedSS.Add(random.Next(0, 100));
                Console.Write(unsortedSS[i] + " ");
            }
            Console.WriteLine();
            SelectionSort(unsortedSS);
            Console.WriteLine("Sorted Array: ");

            foreach (int x in unsortedSS)
            {
                Console.Write(x + " ");
            }
            Console.WriteLine();
            Console.Write("\n-------------------------------------------------------------------\n");
            Console.WriteLine("Factorial 20");

            Console.WriteLine(Factorial(20));
            Console.WriteLine(FibonacciRecursive(9));
            Console.WriteLine(FibonacciDynamic(9));
            Console.WriteLine(FibonacciSpaceOptimized(9));

            Console.WriteLine();
            Console.Write("\n-------------------------------------------------------------------\n");
            Console.WriteLine("Adding Villagers to Dictionary...");

            Dictionary<string, string> villagers = new Dictionary<string, string>();

            villagers.Add("squirrel", "Hazel");
            villagers.Add("eagle", "Keaton");
            villagers.Add("duck", "Drake");
            villagers.Add("bird", "Piper");
            villagers.Add("cat", "Kiki");
            villagers.Add("hamster", "Flurry");
            villagers.Add("goat", "Velma");
            villagers.Add("hippo", "Harry");
            villagers.Add("ostrich", "Sandy");

            foreach (KeyValuePair<string, string> kvp in villagers)
            {
                Console.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
            }

            Console.WriteLine("Removing Sandy...");

            villagers.Remove("ostrich");

            if (!villagers.ContainsKey("ostrich"))
            {
                Console.WriteLine("No Ostriches here... Sandy is gone");
            }

            if (villagers.ContainsKey("squirrel"))
            {
                Console.WriteLine("Whew, Hazel is still here!");
            }

            // Does a string have all unique characters?

            string test = new string("abcdefg");
            string test2 = new string("xnadiax");

            Console.WriteLine("Checking does string have unique chars");
            Console.WriteLine(DoesStringHaveUniqueChars(test));
            Console.WriteLine(DoesStringHaveUniqueChars(test2));

            Console.WriteLine("Checking  it one string is a permutation of another");
            Console.WriteLine(CheckPermutations("abc", "abd"));
            Console.WriteLine(CheckPermutations("abc", "abcd"));
            Console.WriteLine(CheckPermutations("abc", "bac"));

            Console.WriteLine("URLIfy a string");

            Console.WriteLine("URLify:  Me and Mrs Jones");
            string teststring = URLIfy("Me and Mrs Jones");
            Console.WriteLine(teststring);

            Console.WriteLine(HasPallindromePermutation("taco cat"));
            Console.WriteLine(HasPallindromePermutation("taco cats"));


            LinkedList<int> linkedInts = new LinkedList<int>();
            linkedInts.AddLast(1);
            linkedInts.AddLast(5);
            linkedInts.AddLast(7);
            linkedInts.AddLast(3);
            
            foreach (int num in linkedInts)
            {
                Console.WriteLine(num);
            }

            LinkedListNode<int> LinkedListNode = linkedInts.First;
            Console.WriteLine(LinkedListNode.Next.Value);

            LinkedListNode LinkedListNode1 = new LinkedListNode(9);
            LinkedListNode1.AppendToTail(11);
            LinkedListNode1.AppendToTail(13);

            LinkedListNode n = LinkedListNode1;

            while (n != null)
            {
                Console.WriteLine(n.data);
                n = n.next;
            }

            LinkedListNode n1 = LinkedListNode1.DeleteNode(LinkedListNode1, 11);

            Console.Write("\n-------------------------------------------------------------------\n");
            TraverseList(LinkedListNode1);
            Console.Write("\n-------------------------------------------------------------------\n");    
            for (int i = 1; i < 21; i++)
            {
                int num = random.Next(1, 100);
                LinkedListNode1.AppendToTail(num);
            }
            TraverseList(LinkedListNode1);
            Console.Write("\n-------------------------------------------------------------------\n");    

            int[] nums = { 1, 1, 2, 2, 3, 4, 5, 6, 7, 8, 8, 9, 10 };

            //LinkedList<int> dupeList = new LinkedList<int>(nums);
            LinkedListNode dupeList = new LinkedListNode(1);

            for (int i = 1; i <= 10; i++)
            {
                if  (i  % 2 == 0)
                {
                    dupeList.AppendToTail(i);
                    dupeList.AppendToTail(i);
                }
                else 
                {
                    dupeList.AppendToTail(i);
                }
            }

            Console.Write("\n-------------------------------------------------------------------\n");    
            Console.WriteLine("Linked List With Duplicates");

            TraverseList(dupeList);            
            Console.Write("\n-------------------------------------------------------------------\n");    
            Console.WriteLine("Delete Duplicates");
            DeleteDuplicates(dupeList);
            TraverseList(dupeList);
            Console.Write("\n-------------------------------------------------------------------\n");    
            Console.WriteLine("removing 2nd from Last");
            RemoveKthFromLast(dupeList, 2);
            TraverseList(dupeList);
            Console.Write("\n-------------------------------------------------------------------\n");    
            Console.WriteLine("Stack");

            MyStack stack = new MyStack();
            stack.Push(3);
            stack.Push(5);
            stack.Push(7);
            stack.Push(9);
            stack.Push(11);

            while (!stack.IsEmpty())
            {
                Console.WriteLine(stack.Pop());
            }
            Console.Write("\n-------------------------------------------------------------------\n");    
            Console.WriteLine("Queue");

            MyQueue queue = new MyQueue();
            queue.Add(2);
            queue.Add(4);
            queue.Add(6);
            queue.Add(8);
            queue.Add(10);
            
            while (!queue.IsEmpty())
            {
                Console.WriteLine(queue.Remove());
            }

            Console.Write("\n-------------------------------------------------------------------\n");    
            Console.WriteLine("Trees");
            TreeNode tree = new TreeNode(8);
            tree.Insert(4);
            tree.Insert(10);
            tree.Insert(2);
            tree.Insert(6);
            tree.Insert(20);

            Console.WriteLine(tree.Contains(1));
            Console.WriteLine(tree.Contains(20));
            Console.Write("\n-------------------------------------------------------------------\n");    
            Console.WriteLine("PreOrder Traversal");            
            tree.PreOrderTraversal();

            Console.Write("\n-------------------------------------------------------------------\n");    
            Console.WriteLine("InOrder Traversal");
            tree.InOrderTraversal();

            Console.Write("\n-------------------------------------------------------------------\n");    
            Console.WriteLine("PostOrder Traversal");
            tree.PostOrderTraversal();

            Console.Write("\n-------------------------------------------------------------------\n");    
            Console.WriteLine("Graph  Path ");

            Graph graph = new Graph();
             
            /*
             *               1
             *             / | \
             *            2  5  9
             *           /  / \   \
             *          3  6   8   10
             *         /  / 
             *        4  7
             *
             */

            for (int i = 1; i <= 10; i++)
            {
                graph.AddNode(i);
            }

            graph.AddEdge(1, 2);
            graph.AddEdge(2, 3);
            graph.AddEdge(3, 4);
            graph.AddEdge(1, 5);
            graph.AddEdge(5, 6);
            graph.AddEdge(6, 7);
            graph.AddEdge(5, 8);
            graph.AddEdge(1, 9);
            graph.AddEdge(9, 10);

            Console.WriteLine(graph.HasPathDFS(1, 7));
            Console.WriteLine(graph.HasPathDFS(6, 10));



        }
    }
}
