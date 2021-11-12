using System;

namespace AlgorithmsPlayground.DataStructures.Lists
{
    public class SingleLinkedList
    {
        public class Node
        {
            public Node(int value)
            {
                Value = value;
            }

            public int Value { get; set; }
            public Node Next { get; set; }
        }



        public int Count {
            
            get {
                if(IsEmpty())
                {
                    return 0;
                }
                int count = 0;
                var runner = Head;
                while(runner !=null)
                {
                    count++;
                    runner = runner.Next;
                }
                return count;
            }
        }

        public Node Head { get; private set; }

        public bool IsEmpty()
        {
            if(Head == null)
            {
                return true;
            }
            else
            {
                return false;
            }  
        }

        public void AddToHead(int value)
        {
            Node node = new Node(value);
            node.Next = Head;
            Head = node;
        }

        public int GetAtIndex(int index)
        {
            // Case negative index
            if (index < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            if (Head == null)
            {
                throw new ArgumentOutOfRangeException();
            }
            if(index == 0)
            {
                return Head.Value;
            }
            var runner = Head;
            for(int i=1; i<index; i++)
            {
                // Case out of range
                if (runner.Next == null)
                {
                    throw new ArgumentOutOfRangeException();
                }
                runner = runner.Next;
            }
            if(runner.Next == null)
            {
                return -1;
            }
            return runner.Next.Value;
        }


        internal Node GetNodeAtIndex(int index)
        {
            // GetNodeAtIndex EmptyList
            if (Head == null)
            {
                throw new ArgumentOutOfRangeException();
            }

            // GetNodeAtIndex OutOfBounds
            if (index < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            var runner = Head;
            for (int counter = 0; counter < index; counter++)
            {
                // GetNodeAtIndex OutOfBounds 
                if (runner.Next == null)
                {
                    throw new ArgumentOutOfRangeException();
                }
                runner = runner.Next;

            }
            return runner;
        }

        public int DeleteAtIndex(int index)
        {
            // Case negative index
            if (index < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            
            // Case empty list
            if(Head == null)
            {
                throw new ArgumentOutOfRangeException();
            }
            int deletedElement;
            if(index == 0)
            {
                deletedElement = Head.Value;
                Head = Head.Next;
                return deletedElement;
            }
            var runner = Head;
            for(int jumps=0; jumps < index-1; jumps++)
            {
                // Case out of range
                if (runner.Next == null)
                {
                    throw new ArgumentOutOfRangeException();
                }
                runner = runner.Next;
            }
            deletedElement = runner.Next.Value;
            runner.Next = runner.Next.Next;
            return deletedElement;
        }

        public void AddToTail(int value)
        {
            Node node = new Node(value);
            if(Head == null)
            {
                Head = node;
                return;
            }
            var runner = Head;
            while(runner.Next != null)
            {
                runner = runner.Next;
            }
            runner.Next = node;
        }
    }
}
