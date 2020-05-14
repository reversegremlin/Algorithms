using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms
{
    public class MyStack {

        public class StackNode {
            public int data;
            public StackNode next;

            public StackNode(int data)
            {
                this.data = data;
            }
        }

        private StackNode top;

        public int Pop()
        {
            IsNull();
            int item = top.data;
            top = top.next;
            return item;
        }



        public void Push(int item)
        {
            StackNode t = new StackNode(item);
            t.next = top;
            top = t;
        }

        public int Peek() {
            {
                IsNull();
                return top.data;
            }
        }
        private void IsNull()
        {
            if (top == null)
            {
                throw new System.ArgumentException("Parameter cannot be null", "Empty Stack");
            }
        }

        public bool IsEmpty()
        {
            return top == null;
        }

    }


}
