﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTree
{
    class BinaryTree
    {
        public Node root;
        public BinaryTree()
        {

        }
        /// <summary>
        /// PreOrder
        /// Visit the root
        /// Traverse the left subtree
        /// Traverse the right subtree
        /// </summary>
        /// <param name="parent"></param>
        public static void TraversePreOrder(Node parent)
        {
            if (parent != null)
            {
                Console.Write(parent.data + " ");
                TraversePreOrder(parent.left);
                TraversePreOrder(parent.right);
            }
        }
        /// <summary>
        /// PostOrder
        /// Traverse the left subtree
        /// Traverse the right subtree
        /// Visit the root
        /// </summary>
        /// <param name="parent"></param>
        public static void TraversePostOrder(Node parent)
        {
            if (parent != null)
            {
                TraversePostOrder(parent.left);
                TraversePostOrder(parent.right);
                Console.Write(parent.data+" ");
            }
        }
        /// <summary>
        /// InOrder
        /// Traverse the left subtree
        /// Visit the root
        /// Traverse the right subtree
        /// </summary>
        /// <param name="parent"></param>
        public static void TraverseInOrder(Node parent)
        {
            if (parent != null)
            {
                TraverseInOrder(parent.left);
                Console.Write(parent.data + " ");
                TraverseInOrder(parent.right);
            }
        }
    }
}