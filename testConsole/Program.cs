using System;

namespace testConsole
{
    class Program
    {
        static void Main(string[] argus)
        {

        }
        static void PrintDirectories(string rootPath)
        {
            Stack<string> directoryStack = new Stack<string>();
            directoryStack.Push(rootPath);

            while (directoryStack.Count > 0)
            {
                string currentDir = directoryStack.Pop();
                Console.WriteLine(currentDir);

                string[] subDirectories = Directory.GetDirectories(currentDir);
                foreach (string subDir in subDirectories)
                {
                    directoryStack.Push(subDir);
                }
            }
        }
    }
}