using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms
{
    public class MyQueue {

        public  class QueueNode
        {
            public int data;

            public QueueNode next;

            public QueueNode(int data)
            {
                this.data = data;
            }
        }

        public QueueNode first;
        public QueueNode last;

        public void Add(int data)
        {
            QueueNode node = new QueueNode(data);

            if (last != null)
            {
                last.next = node;
            }

            last = node;

            if (first == null)
            {
                first = last;
            }
        }

        public int Remove()
        {
            if (first == null)
            {
                throw new System.ArgumentException("Queue is Empty", "Empty Queue");
            }

            int data = first.data;
            first = first.next;

            if (first == null)
            {
                last = null;
            }

            return data;
        }

        public int Peek()
        {
            if (first == null)
            {
                throw new System.ArgumentException("Queue is Empty", "Empty Queue");
            }

            return first.data;
        }

        public bool isEmpty() 
        {
            return first == null;
        }
    }
}
