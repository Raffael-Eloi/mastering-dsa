namespace BinaryTree;

public class MyBinaryTree
{
    private TreeNode? root;

    // Insert using level-order (BFS) to keep tree complete
    public void Insert(int value)
    {
        var newNode = new TreeNode(value);

        if (root == null)
        {
            root = newNode;
            return;
        }

        // Use a queue to find the first empty spot (level by level)
        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);

        while (queue.Count > 0)
        {
            var current = queue.Dequeue();

            if (current.Left == null)
            {
                current.Left = newNode;
                return;
            }
            queue.Enqueue(current.Left);

            if (current.Right == null)
            {
                current.Right = newNode;
                return;
            }
            queue.Enqueue(current.Right);
        }
    }

    // In-Order: Left -> Root -> Right
    public void InOrder()
    {
        Console.Write("In-Order:    ");
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

    // Pre-Order: Root -> Left -> Right
    public void PreOrder()
    {
        Console.Write("Pre-Order:   ");
        PreOrderRecursive(root);
        Console.WriteLine();
    }

    private void PreOrderRecursive(TreeNode? node)
    {
        if (node == null) return;
        Console.Write(node.Value + " ");
        PreOrderRecursive(node.Left);
        PreOrderRecursive(node.Right);
    }

    // Post-Order: Left -> Right -> Root
    public void PostOrder()
    {
        Console.Write("Post-Order:  ");
        PostOrderRecursive(root);
        Console.WriteLine();
    }

    private void PostOrderRecursive(TreeNode? node)
    {
        if (node == null) return;
        PostOrderRecursive(node.Left);
        PostOrderRecursive(node.Right);
        Console.Write(node.Value + " ");
    }

    // Level-Order (BFS): level by level, left to right
    public void LevelOrder()
    {
        Console.Write("Level-Order: ");
        if (root == null) { Console.WriteLine(); return; }

        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);

        while (queue.Count > 0)
        {
            var current = queue.Dequeue();
            Console.Write(current.Value + " ");

            if (current.Left != null) queue.Enqueue(current.Left);
            if (current.Right != null) queue.Enqueue(current.Right);
        }
        Console.WriteLine();
    }

    // Height of the tree (longest path from root to leaf)
    public int Height()
    {
        return HeightRecursive(root);
    }

    private int HeightRecursive(TreeNode? node)
    {
        if (node == null) return 0;
        int leftHeight = HeightRecursive(node.Left);
        int rightHeight = HeightRecursive(node.Right);
        return 1 + Math.Max(leftHeight, rightHeight);
    }

    // Count total nodes
    public int Count()
    {
        return CountRecursive(root);
    }

    private int CountRecursive(TreeNode? node)
    {
        if (node == null) return 0;
        return 1 + CountRecursive(node.Left) + CountRecursive(node.Right);
    }
}
