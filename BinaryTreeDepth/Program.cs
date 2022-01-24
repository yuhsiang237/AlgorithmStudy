using System;
using System.Collections.Generic;

namespace BinaryTreeDepth
{
    class Program
    {
        static void Main(string[] args)
        {
            // init tree
            TreeNode t1 = new TreeNode(1);
            TreeNode t2 = new TreeNode(2);
            TreeNode t3 = new TreeNode(3);
            TreeNode t4 = new TreeNode(4);
            TreeNode t5 = new TreeNode(5);
            TreeNode t6 = new TreeNode(6);
            TreeNode t7 = new TreeNode(7);
            TreeNode t8 = new TreeNode(8);
            TreeNode t9 = new TreeNode(9);
            TreeNode t10 = new TreeNode(10);
            TreeNode t11 = new TreeNode(11);
            TreeNode t12 = new TreeNode(12);
            TreeNode t13 = new TreeNode(13);
            TreeNode t14 = new TreeNode(14);
            TreeNode t15 = new TreeNode(15);

            t1.LeftNode = t2;
            t1.RightNode = t3;

            t2.LeftNode = t4;

            t3.LeftNode = t6;
            t3.RightNode = t7;
            
            t4.LeftNode = t8;
            t4.RightNode = t9;

            t5.LeftNode = t10;
            t5.RightNode = t11;
            
            t6.LeftNode = t12;
            t6.RightNode = t13;
        
            t7.LeftNode = t14;
            t7.RightNode = t15;

            // get all depth nodes
            List<TreeNode> nodes = TreeNode.FindDepthNodes(t2,2);
            foreach(TreeNode item in nodes)
            {
                if(item.Value == null)
                {
                    Console.Write("{0} ", "null");
                }
                else
                {
                    Console.Write("{0} ", item.Value);
                }
            }
        }
    }
}
