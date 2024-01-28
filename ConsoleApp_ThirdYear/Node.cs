using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_ThirdYear
{
    
    class Node
    {
        private int? _value;
        private Node? _left;
        private Node? _right;

        public int? Value
        {
            get => _value;
            set => _value = value;
        }
        public Node? Left
        {
            get => _left;
            set => _left = value;
        }
        public Node? Right
        {
            get => _right;
            set => _right = value;
        }
        public Node(int? Val = null, Node? L = null, Node? R = null)
        {
            Value = Val;
            Left = L;
            Right = R;
        }

        public void Add(int number)
        {
            if (number > Value)
            {
                add(Right, number);
            }
            else
            {
                add(Left, number);
            }
        }
        private void add(Node node, int number)
        {
            if (node == null)
            {
                node = new Node(number);
            }
            else
            {
                node.Add(number);
            }
        }
    }
}
