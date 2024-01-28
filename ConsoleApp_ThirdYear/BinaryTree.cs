using System;

namespace ConsoleApp_ThirdYear
{
    
    class BinaryTree
    {
        private Node? _root;
        public Node? Root
        {
            get { return _root; }
            set { _root = value; }
        }
        public BinaryTree(Node? Root = null)
        {
            this.Root = Root;
        }

        public BinaryTree(int[] Numbers)
        {
            foreach (int number in Numbers)
            {
                Add(number);
            }
        }

        public void Add(int number)
        {
            if (Root == null)
            {
                Root = new Node(number);
                return;
            }
            else
            {
                if (number < Root.Value)
                {
                    ADD(Root.Left, number);
                }
                else
                {
                    ADD(Root.Right, number);
                }
            }
        }
        private void ADD(Node? node, int number)
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
        public void print(Node root)
        {
            Console.WriteLine(root.Value);
            if (root.Left != null)
            {
                print(root.Left);
            }
            if (root.Right != null)
            {
                print(root.Right);
            }
        }
        public void Print(Node? root = null)
        {
            if (root == null)
            {
                root = Root;
            }
            if (root.Left != null) //არსებობს //2.1
            {
                Print(root.Left);
            }
            else  //არ არსებობს //2.2
            {
                Console.WriteLine(root.Value);
                return;
            }

            Console.WriteLine(root.Value);   //3

            if (root.Right != null) //4.1
            {
                Print(root.Right);
            }
        }
    }
}

