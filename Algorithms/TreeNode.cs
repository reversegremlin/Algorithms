using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms
{
    public class TreeNode 
    {
        TreeNode left, right;
        int data;

        public TreeNode(int data)
        {
            this.data = data;
        }

        public void Insert(int value)
        {
            if (value <= data)
            {
                if (left == null)
                {
                    left = new TreeNode(value);
                }
                else
                {
                    left.Insert(value);
                }
            }
            else
            {
                if (right == null)
                {
                    right = new TreeNode(value);
                }
                else 
                {
                    right.Insert(value);
                }
            }
        }

        public bool Contains(int value)
        {
            if (value == data)
            {
                return true;
            }
            if (value < data)
            {
                if (left == null)
                {
                    return false;
                }
                else
                {
                    return left.Contains(value);
                }
            }
            else
            {
                if (right == null)
                {
                    return false;
                }
                else
                {
                    return right.Contains(value);
                }
            }
        }

        public void InOrderTraversal()
        {
            if (left != null)
            {
                left.InOrderTraversal();
            }
            Console.WriteLine(data);
            if (right != null)
            {
                right.InOrderTraversal();
            }
        }

        public void PreOrderTraversal()
        {
            Console.WriteLine(data);
            if (left != null)
            {
                left.PreOrderTraversal();
            }
            if (right != null)
            {
                right.PreOrderTraversal();
            }
        }

        public void PostOrderTraversal()

        {
            if (left != null)
            {
                left.PostOrderTraversal();
            }
            if (right != null)
            {
                right.PostOrderTraversal();
            }
            Console.WriteLine(data);
        }
    }
}
