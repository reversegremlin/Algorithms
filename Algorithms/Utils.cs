using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms
{
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
            traverseList(LinkedListNode1);
            Console.Write("\n-------------------------------------------------------------------\n");    
            for (int i = 1; i < 21; i++)
            {
                int num = random.Next(1, 100);
                LinkedListNode1.AppendToTail(num);
            }
            traverseList(LinkedListNode1);
            Console.Write("\n-------------------------------------------------------------------\n");    

            int[] nums = { 1, 1, 2, 2, 3, 4, 5, 6, 7, 8, 8, 9, 10 };

            //LinkedList<int> dupeList = new LinkedList<int>(nums);
            LinkedListNode dupeList = new LinkedListNode(1);
            dupeList.AppendToTail(1);
            dupeList.AppendToTail(2);
            dupeList.AppendToTail(3);
            dupeList.AppendToTail(4);
            dupeList.AppendToTail(5);
            dupeList.AppendToTail(5);
            dupeList.AppendToTail(6);
            dupeList.AppendToTail(7);
            dupeList.AppendToTail(8);
            dupeList.AppendToTail(9);
            dupeList.AppendToTail(9);
            dupeList.AppendToTail(9);
            dupeList.AppendToTail(9);
            dupeList.AppendToTail(9);
            dupeList.AppendToTail(9);
            dupeList.AppendToTail(10);
            Console.Write("\n-------------------------------------------------------------------\n");    
            traverseList(dupeList);            
            Console.Write("\n-------------------------------------------------------------------\n");    
            Console.WriteLine("Delete Duplicates");
            deleteDuplicates(dupeList);
            traverseList(dupeList);
            Console.Write("\n-------------------------------------------------------------------\n");    
            Console.WriteLine("removing 2nd from Last");
            RemoveKthFromLast(dupeList, 2);
            traverseList(dupeList);
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
            //TODO: Pre and Post Order

            tree.InOrderTraversal();
            Console.Write("\n-------------------------------------------------------------------\n");    
            Console.WriteLine("Graph");

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

            Console.WriteLine(graph.hasPathDFS(1, 7));
            Console.WriteLine(graph.hasPathDFS(6, 10));



        }

        private static List<int> MergeSort(List<int> unsorted)
        {
            if (unsorted.Count <= 1)
            {
                return unsorted;
            }

            List<int> left = new List<int>();
            List<int> right = new List<int>();

            int middle = unsorted.Count / 2;

            //divide the unsorted list

            for (int i = 0; i < middle; i++)
            {
                left.Add(unsorted[i]);
            }

            for (int i = middle; i < unsorted.Count; i++)
            {
                right.Add(unsorted[i]);
            }

            left = MergeSort(left);
            right = MergeSort(right);

            return Merge(left, right);

        }

        private static List<int> Merge(List<int> left, List<int> right)
        {
            List<int> result = new List<int>();

            while (left.Count > 0 || right.Count > 0)
            {
                if (left.Count > 0 && right.Count > 0)
                {
                    if (left.First() <= right.First())
                    {
                        result.Add(left.First());
                        left.Remove(left.First());
                    }
                    else
                    {
                        result.Add(right.First());
                        right.Remove(right.First());
                    }
                }
                else if (left.Count > 0)
                {
                    result.Add(left.First());
                    left.Remove(left.First());
                }
                else if (right.Count > 0)

                {
                    result.Add(right.First());
                    right.Remove(right.First());
                }
            }

            return result;
        }

        private static void QuickSort(List<int> array, int low, int high)
        {
            if (low < high)
            {
                int pivot = Partition(array, low, high);
                QuickSort(array, low, pivot - 1);
                QuickSort(array, pivot + 1, high);
            }
        }

        private static int Partition(List<int> array, int low, int high)
        {
            int pivot = array[high];
            int lowIndex = low - 1;

            for (int i = low; i < high; i++)
            {
                if (array[i] <= pivot)
                {
                    lowIndex++;  //Move the index to the item we want to  move
                    int tmp = array[lowIndex];
                    array[lowIndex] = array[i];
                    array[i] = tmp;
                }
            }

            int temp = array[lowIndex + 1];
            array[lowIndex + 1] = array[high];
            array[high] = temp;

            return lowIndex + 1;
        }

        private static int? BinarySearch(List<int> array, int item)
        {
            int low = 0;
            int high = array.Count - 1;

            while (low <= high)
            {
                int mid = (high + low ) / 2;
                int guess = array[mid];
                Console.WriteLine("guess: " + guess);
                if (guess == item)
                {
                    return mid;
                }
                else if (guess > item)
                {
                    high = mid - 1;
                }
                else 
                {
                    low = mid + 1;
                }
            }
            return null;
        }

        private static void SelectionSort(List<int> array)
        {
            int arrayCount = array.Count();
            int temp;
            int smallestIndex;

           for (int i = 0; i < arrayCount; i++)
           {
               smallestIndex = i;
               for (int j = i + 1; j < arrayCount; j++ )
               {
                   if (array[j] < array[smallestIndex])
                   {
                       smallestIndex = j;
                   }
               }
               temp = array[smallestIndex];
               array[smallestIndex] = array[i];
               array[i] = temp;
           }
        }

        private static long Factorial(long number)
        {
            if (number == 1)
            {
                return number;
            }
            else
            {
                return number * Factorial(number - 1);
            }
        }

        private static int FibonacciRecursive(int number)
        {
            if (number == 0 || number == 1)
            {
                return number;
            }
            else 
            {
                return FibonacciRecursive(number - 1) + FibonacciRecursive(number - 2);
            }
        }

        private static int FibonacciDynamic(int number)
        {
            int[] memo = new int[number + 2];
            memo[0] = 0;
            memo[1] = 1;

            for (int i = 2; i <= number; i++)
            {
                memo[i] = memo[i - 1] + memo[i - 2];
            }
            return memo[number];
        }

        private static int FibonacciSpaceOptimized(int number)
        {
            int a = 0;
            int b = 1;
            int c;

            if (number == 0)
            {
                return 0;
            }

            for (int i = 2; i <= number; i++)
            {
                c = a + b;
                a = b;
                b = c;
            }

            return b;
        }

        private static bool DoesStringHaveUniqueChars(string test)
        {
            Dictionary <char, bool> uniqueDict = new Dictionary<char, bool>();

            foreach (char c in test.ToCharArray())
            {
                if (uniqueDict.ContainsKey(c))
                {
                    Console.WriteLine("Found duplicate char"); 
                    return false;
                }
                else 
                {
                    uniqueDict.Add(c, true);
                }
            }
            return true;
        }

        private static bool CheckPermutations(string one, string two)
        {
            if (one.Length != two.Length)
            {
                return false; //not same length, can't match
            }

            char [] chOne = one.ToCharArray();
            char [] chTwo = two.ToCharArray();

            Array.Sort(chOne);
            Array.Sort(chTwo);

            for (int i = 0; i < chOne.Length; i++)
            {
                if (chOne[i] != chTwo[i])
                {
                    return false;
                }
            }
            return true;
        }

        private static string URLIfy(string test)
        {
            //replace whitespace with %20
            //"Mr John Smith  " = "Mr%20John%20Smith"
            char [] testArray = test.ToCharArray();
            List<char> newArray = new List<char>();

            for (int  i = 0; i < testArray.Length; i++)
            {
                if (testArray[i] == ' ')
                {
                    newArray.Add('%');
                    newArray.Add('2');
                    newArray.Add('0');
                }
                else
                {
                    newArray.Add(testArray[i]);
                }

            }  
            string str = new string(newArray.ToArray());
            return str;

        }

        private static bool HasPallindromePermutation(string test)
        {
            //if it is odd, one char without a twin

            string trimmed = test.Replace(" ", "");

            char [] stringArray = trimmed.ToCharArray();
            
            Dictionary<char, int> charDict = new Dictionary<char, int>();

            for (int i = 0; i < trimmed.Length; i++)
            {
                if (charDict.ContainsKey(trimmed[i]))
                {
                    charDict[trimmed[i]]++;
                }
                else
                {
                    charDict.Add(trimmed[i], 1);
                }
            }

            if (trimmed.Length % 2 == 0)  //even, so all must be even
            {
                foreach( KeyValuePair<char, int> kvp in charDict )
                {
                    if (kvp.Value % 2 != 0)
                    {
                        return false;
                    }
                }
            }
            else 
            {
                int oddCount = 0;
                foreach( KeyValuePair<char, int> kvp in charDict )
                {
                    if (kvp.Value % 2 != 0)
                    {
                        oddCount++;
                        if (oddCount > 1)
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }
        public static void traverseList(LinkedListNode head)
        {
            if (head == null)
            {
                return;
            }
            Console.WriteLine(head.data);
            traverseList(head.next);
        }
        public static LinkedListNode deleteDuplicates(LinkedListNode head)
        {
            LinkedListNode  n = head;

            Dictionary<int, int> LinkedListNodeDict = new Dictionary<int, int>();
            LinkedListNodeDict.Add(n.data, 1);

            while (n.next != null)
            {

                if (LinkedListNodeDict.ContainsKey(n.next.data))
                {   
                    n.next = n.next.next;
                }
                else 
                {
                    LinkedListNodeDict[n.next.data] = 1;
                    n = n.next;
                }
                
            }
            return head;
        }

        public static LinkedListNode RemoveKthFromLast(LinkedListNode head, int index)
        {
            int count = 0;
            LinkedListNode n = head;
            LinkedListNode turtle = head;

            while (n.next != null)
            {
                count++;
                if (count > index)
                {
                    turtle = turtle.next;
                }
                n = n.next;
            }
            turtle.next = turtle.next.next;

            return head;
        }
    }
}
