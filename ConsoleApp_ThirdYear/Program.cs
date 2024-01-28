using System;

namespace ConsoleApp_ThirdYear
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree bt = new BinaryTree();
            bt.Add(4);
            bt.Add(1);
            bt.Add(9);
            bt.Add(7);
            bt.Add(2);                      //ubralod gatestvistvis aris es yvelaferi

            // bt.print(bt.Root);

            Console.WriteLine(bt.Root.Value);
            Console.WriteLine(bt.Root.Left.Value);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}