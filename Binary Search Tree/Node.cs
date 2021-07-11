using System;
using System.Collections.Generic;
using System.Text;

namespace Binary_Search_Tree
{
    class Node
    {
        internal int data;
        public Node leftNode;
        internal Node rightNode;
        public Node(int data)
        {
            this.data = data;
        }

        public void InOrderTraversal()
        {
            if (leftNode != null)
            {
                leftNode.InOrderTraversal();
            }
            Console.Write(" "+data);
            if (rightNode != null)
            {
                rightNode.InOrderTraversal();
            }
        }
    }
}
