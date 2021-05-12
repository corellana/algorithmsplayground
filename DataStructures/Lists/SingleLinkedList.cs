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
            if(index == 0)
            {
                return Head.Value;
            }
            var runner = Head;
            for(int i=1; i<index; i++)
            {
                runner = runner.Next;
            }
            if(runner.Next == null)
            {
                return -1;
            }
            return runner.Next.Value;
        }

        public int DeleteAtIndex(int index)
        {
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
                runner = runner.Next;
            }
            deletedElement = runner.Next.Value;
            runner.Next = runner.Next.Next;
            return deletedElement;
        }
    }
}
