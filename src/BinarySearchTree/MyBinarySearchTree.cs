namespace BinarySearchTree;

public class MyBinarySearchTree
{
    private TreeNode? root;

    public void Insert(int value)
    {
        root = InsertRecursive(root, value);
    }

    private TreeNode InsertRecursive(TreeNode? node, int value)
    {
        if (node == null)
            return new TreeNode(value);

        if (value < node.Value)
            node.Left = InsertRecursive(node.Left, value);
        else if (value > node.Value)
            node.Right = InsertRecursive(node.Right, value);

        return node;
    }

    public bool Contains(int value)
    {
        return Search(root, value);
    }

    private bool Search(TreeNode? node, int value)
    {
        if (node == null)
            return false;

        if (value == node.Value)
            return true;

        if (value < node.Value)
            return Search(node.Left, value);

        return Search(node.Right, value);
    }

    // In-order traversal: Left, Root, Right
    public void InOrder()
    {
        InOrderRecursive(root);
        Console.WriteLine();
    }

    private void InOrderRecursive(TreeNode? node)
    {
        if (node == null) return;

        InOrderRecursive(node.Left);
        Console.Write(node.Value + " ");
        InOrderRecursive(node.Right);
    }

    public void Delete(int value)
    {
        root = DeleteRecursive(root, value);
    }

    private TreeNode? DeleteRecursive(TreeNode? node, int value)
    {
        if (node == null)
            return null;

        if (value < node.Value)
            node.Left = DeleteRecursive(node.Left, value);
        else if (value > node.Value)
            node.Right = DeleteRecursive(node.Right, value);
        else
        {
            // Case 1 & 2
            if (node.Left == null)
                return node.Right;

            if (node.Right == null)
                return node.Left;

            // Case 3
            TreeNode successor = FindMin(node.Right);
            node.Value = successor.Value;
            node.Right = DeleteRecursive(node.Right, successor.Value);
        }

        return node;
    }

    private TreeNode FindMin(TreeNode node)
    {
        while (node.Left != null)
            node = node.Left;

        return node;
    }
}

//📊 Complexity

//If tree is balanced:

//Insert → O(log n)
//Search → O(log n)
//Delete → O(log n)