using System;
using System.Collections.Generic;
using System.Text;

namespace Binary_Search_Tree
{
    class BST
    {
        public Node root;
        public int treeSize = 0;

        public void add(int data)
        {
            treeSize++;
            Node node = new Node(data);
            if (root == null)
                root = node;
            else
            {
                Node temp = root;
                bool alive = true;
                while (alive)
                {
                   if (temp.data > node.data)
                    {
                        if (temp.leftNode == null)
                        {
                            temp.leftNode = node;
                            alive = false;
                        }
                        else
                            temp = temp.leftNode;
                   }
                   else
                   {
                        if (temp.rightNode == null)
                        {
                            temp.rightNode = node;
                            alive = false;
                        }
                        else
                            temp = temp.rightNode;
                   }
                    
                }
            }
        }
        public int Size()
        {
            return treeSize;
        }
        
        public bool Search(int userData)
        {
            if (root == null)
            {
                Console.WriteLine("\n Binary Search Tree is Empty");
                return false;
            }
            else
            {
                Node temp = root;
                while (temp != null)
                {
                    if (temp.data == userData)
                        return true;
                    else if (temp.data > userData)
                        temp = temp.leftNode;
                    else
                        temp = temp.rightNode;
                }
                return false;
            }
        }

        public void Display()
        {
            if (root == null)
            {
                Console.WriteLine("\n Binary Search Tree is Empty");
            }
            else
            {
                Console.Write("\n In Order Traversal :");
                root.InOrderTraversal();
            }
        }

    }
}
