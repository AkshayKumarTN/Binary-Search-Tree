using System;

namespace Binary_Search_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n Binary Search Tree");
            BST binarySearchTree = new BST();
            binarySearchTree.add(56);
            binarySearchTree.add(30);
            binarySearchTree.add(70);
            Console.Write("In Order Traversal :");
            binarySearchTree.InOrderTraversal(binarySearchTree.root);
            Console.WriteLine();
        }
    }
}
