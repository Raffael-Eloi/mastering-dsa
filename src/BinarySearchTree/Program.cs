using BinarySearchTree;

internal class Program
{
    private static void Main(string[] args)
    {
        var bst = new MyBinarySearchTree();

        bst.Insert(8);
        bst.Insert(3);
        bst.Insert(10);
        bst.Insert(1);
        bst.Insert(6);

        bst.InOrder();     // Sorted output
        bst.Contains(6);   // true
        bst.Delete(3);
        bst.InOrder();
    }
}