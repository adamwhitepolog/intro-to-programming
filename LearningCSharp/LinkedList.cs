using System;
using System.Diagnostics;

namespace LearningCSharp
{
    public class LinkedList : ILinkedList
    {
        [DebuggerDisplay("{Value}")]
        class Node
        {
            public Node(object value, Node next)
            {
                Value = value;
                Next = next;
            }
            
            public object Value { get; set; }
            public Node Next { get; set; }
        }
        
        private Node _root, _last;

        public int Length { get; private set; }

        public object this[int index]
        {
            get
            {
                var node = _root;
                var position = 0;

                while (position < Length)
                {
                    if (position == index)
                        return node.Value;
                    position += 1;
                    node = node.Next;
                }
                
                throw new IndexOutOfRangeException();
            }
        }

        public void Add(object value)
        {
            var node = new Node(value, null);
            
            if (_root == null)
            {
                _root = node;
            }
            else
            {
                _last.Next = node;
            }
            
            _last = node;
            Length += 1;
        }

        public static void Main(string[] args)
        {
            var ll = new LinkedList();
            ll.Add(5);
            ll.Add(6);
            ll.Add(7);
            ll.Add(8);

            Console.WriteLine(ll[2]);

            var array = new int[3];
            array[0] = 5;
            array[1] = 6;
            array[2] = 7;

            Console.WriteLine(array[2]);
        }
    }

    /// <summary>
    /// Represents the linked-list abstract data type.
    /// </summary>
    public interface ILinkedList
    {
        int Length { get; }
        object this[int index] { get; }
        void Add(object value);
    }
}