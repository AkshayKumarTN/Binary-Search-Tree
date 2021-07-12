using System;
using System.Collections.Generic;
using System.Text;

namespace Binary_Search_Tree
{
    class BST<T> where T : IComparable<T>
    {
        public Node<T> root;
        public int treeSize = 0;

        public void add(T data)
        {
            treeSize++;
            Node<T> node = new Node<T>(data);
            if (root == null)
                root = node;
            else
            {
                Node<T> temp = root;
                bool alive = true;
                while (alive)
                {
                   if ( 0<(temp.data.CompareTo(node.data)))
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
        
        public bool Search(T userData)
        {
            if (root == null)
            {
                Console.WriteLine("\n Binary Search Tree is Empty");
                return false;
            }
            else
            {
                Node<T> temp = root;
                while (temp != null)
                {
                    if (temp.data.Equals( userData))
                        return true;
                    else if (0<(temp.data.CompareTo(userData)))
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
