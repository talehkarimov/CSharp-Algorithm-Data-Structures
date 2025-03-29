namespace CSharp_Solutions.DataStructures;

internal class TreeNode<T>
{
    public T? Value;
    public TreeNode<T>? Left;
    public TreeNode<T>? Right;

    public TreeNode(T? value, TreeNode<T>? left = null, TreeNode<T>? right = null)
    {
        Value = value;
        Left = left;
    }
}
