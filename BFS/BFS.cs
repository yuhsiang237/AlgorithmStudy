using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace BFS
{

    class BFS
    {
        public Queue<Node> unvisited;

        public BFS()
        {
            unvisited = new Queue<Node>();
        }
        public void Traverse(Node node)
        {
            unvisited.Enqueue(node);

            while(unvisited.Count > 0)
            {
                Node current = unvisited.Peek();
                // traverse children
                // in this case,we use Node so we have two nodes that it's left and right. 
                if (current.left != null)
                {
                    unvisited.Enqueue(current.left); // add left node to queue
                }
                if (current.right != null)
                {
                    unvisited.Enqueue(current.right);// add right node to queue
                }
                Console.Write(current.data+ " ");
                unvisited.Dequeue(); // remove first
            }
        }
    }
}
