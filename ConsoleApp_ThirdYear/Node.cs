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

        public Node(
            int? Value = null,
            Node? Left = null,
            Node? Right = null)
        {
            this.Value = Value;
            this.Left = Left;
            this.Right = Right;
        }

        public void Add(int number)
        {
            if (number < Value)
            {
                Left = new Node(number);
            }
            else
            {
                Right = new Node(number);
            }
        }
    }
}
