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

        public void InOrderTraversal(Node temp)
        {
      
            if (temp.leftNode != null)
            {
                InOrderTraversal(temp.leftNode);
            }
            Console.Write(" "+temp.data);
            if (temp.rightNode != null)
            {
                InOrderTraversal(temp.rightNode);
            }
        }

    }
}
