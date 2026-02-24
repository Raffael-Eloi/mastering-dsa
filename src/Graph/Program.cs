using Graph;

Console.WriteLine("=== Graph ===\n");

// -----------------------------------------
// Undirected Graph: BFS and DFS
// -----------------------------------------
//     0 --- 1
//     |     |
//     2 --- 3
//           |
//           4
Console.WriteLine("--- Undirected Graph ---");
var graph = new MyGraph();
graph.AddUndirectedEdge(0, 1);
graph.AddUndirectedEdge(0, 2);
graph.AddUndirectedEdge(1, 3);
graph.AddUndirectedEdge(2, 3);
graph.AddUndirectedEdge(3, 4);

Console.WriteLine("Adjacency list:");
graph.Print();

Console.WriteLine($"\nBFS from 0: [{string.Join(", ", graph.BFS(0))}]");
Console.WriteLine($"DFS from 0: [{string.Join(", ", graph.DFS(0))}]");

// -----------------------------------------
// Directed Graph: Cycle Detection
// -----------------------------------------
Console.WriteLine("\n--- Cycle Detection (Directed Graph) ---");

// No cycle: 0 -> 1 -> 2 -> 3
var acyclic = new MyGraph();
acyclic.AddEdge(0, 1);
acyclic.AddEdge(1, 2);
acyclic.AddEdge(2, 3);
Console.WriteLine($"0 -> 1 -> 2 -> 3 has cycle: {acyclic.HasCycle()}"); // False

// Has cycle: 0 -> 1 -> 2 -> 0
var cyclic = new MyGraph();
cyclic.AddEdge(0, 1);
cyclic.AddEdge(1, 2);
cyclic.AddEdge(2, 0);
Console.WriteLine($"0 -> 1 -> 2 -> 0 has cycle: {cyclic.HasCycle()}"); // True

// -----------------------------------------
// Weighted Graph: Dijkstra's Shortest Path
// -----------------------------------------
Console.WriteLine("\n--- Dijkstra's Shortest Path ---");
//     0 --4-- 1
//     |       |
//     2       1
//     |       |
//     2 --3-- 3
//      \     /
//       5   1
//        \ /
//         4
var weighted = new WeightedGraph();
weighted.AddUndirectedEdge(0, 1, 4);
weighted.AddUndirectedEdge(0, 2, 2);
weighted.AddUndirectedEdge(1, 3, 1);
weighted.AddUndirectedEdge(2, 3, 3);
weighted.AddUndirectedEdge(2, 4, 5);
weighted.AddUndirectedEdge(3, 4, 1);

Console.WriteLine("Adjacency list (weighted):");
weighted.Print();

var distances = weighted.Dijkstra(0);
Console.WriteLine("\nShortest distances from vertex 0:");
foreach (var kvp in distances.OrderBy(x => x.Key))
    Console.WriteLine($"  0 -> {kvp.Key}: {kvp.Value}");
// 0->0: 0, 0->1: 4, 0->2: 2, 0->3: 5, 0->4: 6
