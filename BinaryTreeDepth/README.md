# BinaryTreeDepth
This is an implementation of BinaryTreeDepth.  
It used to find target of root node depth and return their child nodes of depth.  

<table>
  <tr>
      <td>
        method
      </td>
      <td>
        description
      </td>
  </tr>
    <tr>
      <td>
         TreeNode.FindDepthNodes(TreeNode node,int depth)
      </td>
      <td>
       It used to find target of root node depth and return their child nodes of depth.  
      </td>
  </tr>
</table>

### Example 

```
  2
 / \
4   5
TreeNode.FindDepthNodes(node2,0); // 2
TreeNode.FindDepthNodes(node2,1); // 2、4、5
TreeNode.FindDepthNodes(node4,1); // 4、null、null
```
### demo
<img src="demo/demo.png">
