using System;
using System.Collections.Generic;


namespace Stack
{
    class Stack
    {
        public int Count { get; private set; }
        private Node _head { get; set; }

        public Node this[int index]
        {
            get
            {
                if (index < 0 || index > Count)
                {
                    throw new Exception("invalid index");
                }

                Node temp;

                temp = _head;
                for(int i = 0; i < index; i++)
                {
                    temp = temp.Next;
                }

                return temp;
            }

            set
            {
                if (index < 0 || index > Count)
                {
                    throw new Exception("invalid index");
                }

                Node temp;

                temp = _head;
                for (int i = 0; i < index; i++)
                {
                    temp = temp.Next;
                }

                temp = value;
            }
        }

        public Stack()
        {
            Count = 0;
        }

        public int Push(Node x)
        {
            if (x == null)
            {
                throw new ArgumentNullException(nameof(x));
            }

            x.Next = _head;
            _head = x;

            Count++;

            return x.Inf;
        }

        public int Pop(Node x)
        {
            if (x == null)
            {
                throw new ArgumentNullException(nameof(x));
            }

            if (_head == null)
            {
                throw new Exception("stack is empty");
            }

            x = _head;
            _head = _head.Next;

            Count--;

            return x.Inf;
        }

        public List<Node> Peek()
        {
            Node x = _head;

            List<Node> myStack = new List<Node>();
            for (int i = 0; i < Count; i++)
            {
                myStack.Add(x);
                x = x.Next;
            }

            return myStack;
        }
    }
}
