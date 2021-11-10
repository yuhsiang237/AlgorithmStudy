using System;

namespace BFS
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Tree:
                 a
                / \
               c   b
                  /  \
                 e    d
                     /
                    f
            */
            Console.WriteLine(@"Tree:");
            Console.WriteLine(@"     a");
            Console.WriteLine(@"    / \");
            Console.WriteLine(@"   c   b");
            Console.WriteLine(@"      /  \");
            Console.WriteLine(@"     e    d");
            Console.WriteLine(@"         /");
            Console.WriteLine(@"        f");
            Console.Write("\n");

            BinaryTree btree = new BinaryTree();
            btree.root = new Node("a");
            btree.root.right = new Node("b");
            btree.root.left = new Node("c");
            btree.root.right.right = new Node("d");
            btree.root.right.left = new Node("e");
            btree.root.right.right.left = new Node("f");
            Console.WriteLine("BFS Traverse:");
            new BFS().Traverse(btree.root);
        }
    }
}
