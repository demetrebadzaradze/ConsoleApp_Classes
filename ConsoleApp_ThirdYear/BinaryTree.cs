using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            //??
        }

        public /*static*/ void Add(Node? Root, int number)
        {
            if (Root == null)
            {
                Root = new Node(number);
                //return;
            }
            else
            {
                if (number < Root.Value)
                {
                    Add(Root.Left, number);
                }
                else
                {
                    Add(Root.Right, number);
                }
            }
        }
    }
}
