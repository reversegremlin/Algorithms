using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms
{
    public static class Utils
    {
        public static List<int> MergeSort(List<int> unsorted)
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

        public static List<int> Merge(List<int> left, List<int> right)
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

        public static void QuickSort(List<int> array, int low, int high)
        {
            if (low < high)
            {
                int pivot = Partition(array, low, high);
                QuickSort(array, low, pivot - 1);
                QuickSort(array, pivot + 1, high);
            }
        }

        public static int Partition(List<int> array, int low, int high)
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

        public static int? BinarySearch(List<int> array, int item)
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

        public static void SelectionSort(List<int> array)
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

        public static long Factorial(long number)
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

        public static int FibonacciRecursive(int number)
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

        public static int FibonacciDynamic(int number)
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

        public static int FibonacciSpaceOptimized(int number)
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

        public static bool DoesStringHaveUniqueChars(string test)
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

        public static bool CheckPermutations(string one, string two)
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

        public static string URLIfy(string test)
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

        public static bool HasPallindromePermutation(string test)
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