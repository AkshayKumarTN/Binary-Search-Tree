using System;
using System.Collections.Generic;
using System.Text;

namespace Binary_Search_Tree
{
    class Node<T> 
    {
        public T data;
        public Node<T> leftNode;
        public Node<T> rightNode;
        public Node(T data)
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
