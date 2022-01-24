using System.Collections.Generic;

namespace BinaryTreeDepth
{
    class TreeNode
    {
        private int? _value;
        public TreeNode(int? value)
        {
            _value = value;
        }
        public int? Value { get { return _value; } set { _value = value; } } 
        public TreeNode LeftNode { get; set; }
        public TreeNode RightNode { get; set; }
        /// <summary>
        /// 取得TreeNode往下深度的樹節點
        /// 
        ///   2
        ///  / \
        /// 3   4
        /// 
        /// 如以上範例 depth=0 只有2 ；depth=1則有2、3、4
        /// </summary>
        /// <param name="root">根節點</param>
        /// <param name="depth">深度</param>
        /// <returns></returns>
        public static List<TreeNode> FindDepthNodes(TreeNode root,int depth)
        {
            List<TreeNode> treeNodeList = new List<TreeNode>();
            FindDepthNodesHelper(treeNodeList, root, 0,depth);
            return treeNodeList;
        }
        /// <summary>
        /// 用來協助FindDepthNodes的副程式，主要為遞迴去增加底下節點到List裡面
        /// </summary>
        /// <param name="treeNodeList">儲存結果的List</param>
        /// <param name="treeNode">節點</param>
        /// <param name="currentDepth">目前深度</param>
        /// <param name="maxDepth">最大深度</param>
        private static void  FindDepthNodesHelper(List<TreeNode> treeNodeList, TreeNode treeNode,int currentDepth,int maxDepth)
        {
            // 當超過目前指定深度則返回
            if(currentDepth > maxDepth)
            {
                return;
            }

            // 增加節點到結果陣列
            if(treeNode != null)
            {
                treeNodeList.Add(treeNode);
            }
            else
            {
                treeNodeList.Add(new TreeNode(null)); // 沒有節點則添加空值節點
            }

            if (treeNode!=null)
            {
                FindDepthNodesHelper(treeNodeList, treeNode.LeftNode, currentDepth + 1, maxDepth);
                FindDepthNodesHelper(treeNodeList, treeNode.RightNode, currentDepth + 1, maxDepth);
            }
            else
            {
                // 如果為空則增加null當作節點
                FindDepthNodesHelper(treeNodeList, null, currentDepth + 1, maxDepth);
                FindDepthNodesHelper(treeNodeList, null, currentDepth + 1, maxDepth);
            }
        }
    }
}
