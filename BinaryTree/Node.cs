using System;

namespace BinaryTree
{
    class Node
    {
        public Node left { get; set; }
        public Node right { get; set; }
        public Object data { get; set; }
        public Node(Object data)
        {
            this.data = data;
        }
    }
}
