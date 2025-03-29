using CSharp_Solutions.DataStructures;

namespace CSharp_Solutions.Solutions;

internal class InvertBinaryTree
{
    /*
        Time Complexity: 𝑂(𝑛) (Each node is visited once)
        Space Complexity: 𝑂(ℎ) (Recursive call stack, where ℎ is the height of the tree; in the worst case, 
        𝑂(𝑛) for a skewed tree, and O(logn) for a balanced tree)
     */
    public TreeNode<int> InvertTree(TreeNode<int> root)
    {
        if (root is null) return null;

        var temp = root.Left;
        root.Left = InvertTree(root.Right);
        root.Right = InvertTree(temp);

        return root;
    }
}
