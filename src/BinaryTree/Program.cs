using BinaryTree;

Console.WriteLine("=== Binary Tree ===\n");

// Build a tree using level-order insertion:
//
//        1
//      /   \
//     2     3
//    / \   /
//   4   5 6
//
var tree = new MyBinaryTree();
tree.Insert(1);
tree.Insert(2);
tree.Insert(3);
tree.Insert(4);
tree.Insert(5);
tree.Insert(6);

Console.WriteLine("Tree structure:");
Console.WriteLine("       1");
Console.WriteLine("      / \\");
Console.WriteLine("     2   3");
Console.WriteLine("    / \\ /");
Console.WriteLine("   4  5 6");
Console.WriteLine();

// -----------------------------------------
// Four Traversal Types
// -----------------------------------------
Console.WriteLine("--- Traversals ---");
tree.InOrder();     // Left, Root, Right  -> 4 2 5 1 6 3
tree.PreOrder();    // Root, Left, Right  -> 1 2 4 5 3 6
tree.PostOrder();   // Left, Right, Root  -> 4 5 2 6 3 1
tree.LevelOrder();  // Level by level     -> 1 2 3 4 5 6

// -----------------------------------------
// Tree Properties
// -----------------------------------------
Console.WriteLine($"\nHeight: {tree.Height()}"); // 3
Console.WriteLine($"Count:  {tree.Count()}");    // 6
