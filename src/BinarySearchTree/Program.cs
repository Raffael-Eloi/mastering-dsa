using BinarySearchTree;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("=== Binary Search Tree ===\n");

        // Build BST:
        //        8
        //      /   \
        //     3     10
        //    / \      \
        //   1   6      14
        //      / \     /
        //     4   7   13
        //
        var bst = new MyBinarySearchTree();
        bst.Insert(8);
        bst.Insert(3);
        bst.Insert(10);
        bst.Insert(1);
        bst.Insert(6);
        bst.Insert(4);
        bst.Insert(7);
        bst.Insert(14);
        bst.Insert(13);

        Console.WriteLine("Tree structure:");
        Console.WriteLine("       8");
        Console.WriteLine("      / \\");
        Console.WriteLine("     3   10");
        Console.WriteLine("    / \\    \\");
        Console.WriteLine("   1   6    14");
        Console.WriteLine("      / \\   /");
        Console.WriteLine("     4   7 13");
        Console.WriteLine();

        // -----------------------------------------
        // Traversals
        // -----------------------------------------
        Console.WriteLine("--- Traversals ---");
        Console.Write("In-Order (sorted):  "); bst.InOrder();
        Console.Write("Pre-Order:          "); bst.PreOrder();
        Console.Write("Post-Order:         "); bst.PostOrder();

        // -----------------------------------------
        // Search
        // -----------------------------------------
        Console.WriteLine("\n--- Search ---");
        Console.WriteLine($"Contains 6:  {bst.Contains(6)}");   // True
        Console.WriteLine($"Contains 99: {bst.Contains(99)}");  // False

        // -----------------------------------------
        // Delete
        // -----------------------------------------
        Console.WriteLine("\n--- Delete ---");

        // Delete leaf node
        Console.WriteLine("Delete 4 (leaf):");
        bst.Delete(4);
        Console.Write("  In-Order: "); bst.InOrder();

        // Delete node with one child
        Console.WriteLine("Delete 14 (one child):");
        bst.Delete(14);
        Console.Write("  In-Order: "); bst.InOrder();

        // Delete node with two children
        Console.WriteLine("Delete 3 (two children):");
        bst.Delete(3);
        Console.Write("  In-Order: "); bst.InOrder();
    }
}
