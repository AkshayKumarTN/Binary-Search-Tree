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
            
            binarySearchTree.Display();

            Console.WriteLine("\n Size of Binary Search Tree is : "+binarySearchTree.Size());

            if (binarySearchTree.Search(63))
                Console.WriteLine(" Element 63 is Found in binary search tree");
            else
                Console.WriteLine(" Element 63 is NOT Found in binary search tree");
            Console.WriteLine();
        }
    }
}
