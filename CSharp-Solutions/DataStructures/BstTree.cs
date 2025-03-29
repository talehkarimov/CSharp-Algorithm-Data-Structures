namespace CSharp_Solutions.DataStructures;

// Binary search tree
internal class BstTree<T> where T : IComparable<T>
{
    public TreeNode<T>? Root = null;

    public bool Insert(T value)
    {
        var newNode = new TreeNode<T>(value,null,null);
        if(Root is null)
        {
            Root = newNode;
            return true;
        }
        var current = Root;
        while(true)
        {
            int comparison = value.CompareTo(current.Value);
            if (comparison == 0) return false;

            if(comparison < 0 )
            {
                if(current.Left is null)
                {
                    current.Left = newNode;
                    return true;
                }
                current = current.Left;
            }
            else
            {
                if(current.Right is null)
                {
                    current.Right = newNode;
                    return true;
                }
                current = current.Right;
            }
        }
    }

    public bool Contains(T value)
    {
        var current = Root;

        while(current != null)
        {
            int comparison = value.CompareTo(current.Value);
            if(comparison == 0) return true;
            if (comparison < 0)
            {
                current = current.Left;
            }
            else 
            {
                current = current.Right;
            }
            
        }
        return false;
    }

    public T? MinOfNode(TreeNode<T>? tempNode)
    {
        while(tempNode.Left != null)
            tempNode = tempNode.Left;
        return tempNode.Value;
    }

    public T? MaxOfNode(TreeNode<T>? tempNode)
    {
        while (tempNode.Right != null)
            tempNode = tempNode.Right;
        return tempNode.Value;
    }
}
