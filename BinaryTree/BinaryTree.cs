using System;
using System.Collections.Generic;
using System.Linq;
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
        /// Print the data when the node visit
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
        /// Print the data from the right back
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
        /// Print the data from the left back
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

        /// <summary>
        /// LevelOrder
        /// Every Level print left to right 
        /// </summary>
        /// <param name="parent"></param>
        public static void TraverseLevelOrder(Node parent)
        {
            IList<IList<Object>> result = LevelOrder(parent);
            foreach(List<Object> list in result)
            {
                foreach (Object item in list)
                {
                    Console.Write(item + " ");
                }
            }
        }
        private static IList<IList<Object>> LevelOrder(Node root)
        {
            Dictionary<Object, List<Object>> dict = new Dictionary<Object, List<Object>>();
            LevelOrderHelper(root, 0, dict);
            return dict.Values.ToArray();
        }

        private static void LevelOrderHelper(Node node, int currentDepth, Dictionary<Object, List<Object>> dict)
        {
            if (node == null)
            {
                return;
            }
            // 遞迴到指定階層，增加指令階層的元素
            if (dict.ContainsKey(currentDepth))
            {
                // 增加到現有深度的List裡面
                dict[currentDepth].Add(node.data);
            }
            else
            {
                // 還未創立List，在字典中創立一個List，並添加目前元素
                dict.Add(currentDepth, new List<Object>() { node.data });
            }
            LevelOrderHelper(node.left, currentDepth + 1, dict);
            LevelOrderHelper(node.right, currentDepth + 1, dict);
        }
    }
}
