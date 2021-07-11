﻿using System;
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
                   if (root.data > node.data)
                    {
                        if (root.leftNode == null)
                        {
                            root.leftNode = node;
                            alive = false;
                        }
                        else
                            root = root.leftNode;
                   }
                   else
                   {
                        if (root.rightNode == null)
                        {
                            root.rightNode = node;
                            alive = false;
                        }
                        else
                            root = root.rightNode;
                   }
                    
                }
            }
        }
        public int Size()
        {
            return treeSize;
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
