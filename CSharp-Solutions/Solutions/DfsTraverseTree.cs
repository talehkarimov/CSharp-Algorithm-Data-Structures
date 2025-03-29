using CSharp_Solutions.DataStructures;

namespace CSharp_Solutions.Solutions;

internal class DfsTraverseTree
{
    public List<int> Values = new List<int>();
    public TreeNode<int> DfsPreOrder(TreeNode<int> root)
    {
        if (root == null) return null;
        Values.Add(root.Value);
        DfsPreOrder(root.Left);
        DfsPreOrder(root.Right);
        return root;
    }

    public TreeNode<int> DfsInOrder(TreeNode<int> root)
    {
        if (root == null) return null;
        DfsInOrder(root.Left);
        Values.Add(root.Value);
        DfsInOrder(root.Right);
        return root;
    }

    public TreeNode<int> DfsPostOrder(TreeNode<int> root)
    {
        if (root == null) return null;
        DfsPostOrder(root.Left);
        DfsPostOrder(root.Right);
        Values.Add(root.Value);
        return root;
    }
}
