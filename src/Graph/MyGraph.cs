namespace Graph;

public class MyGraph
{
    private Dictionary<int, List<int>> adjacencyList = new();

    public void AddVertex(int vertex)
    {
        if (!adjacencyList.ContainsKey(vertex))
            adjacencyList[vertex] = new List<int>();
    }

    // Directed edge: from -> to
    public void AddEdge(int from, int to)
    {
        AddVertex(from);
        AddVertex(to);
        adjacencyList[from].Add(to);
    }

    // Undirected edge: both directions
    public void AddUndirectedEdge(int a, int b)
    {
        AddVertex(a);
        AddVertex(b);
        adjacencyList[a].Add(b);
        adjacencyList[b].Add(a);
    }

    // BFS: explore level by level using a queue
    // Time: O(V + E), Space: O(V)
    public List<int> BFS(int start)
    {
        var visited = new HashSet<int>();
        var result = new List<int>();
        var queue = new Queue<int>();

        visited.Add(start);
        queue.Enqueue(start);

        while (queue.Count > 0)
        {
            int vertex = queue.Dequeue();
            result.Add(vertex);

            foreach (int neighbor in adjacencyList[vertex])
            {
                if (!visited.Contains(neighbor))
                {
                    visited.Add(neighbor);
                    queue.Enqueue(neighbor);
                }
            }
        }

        return result;
    }

    // DFS: explore as deep as possible using a stack (iterative)
    // Time: O(V + E), Space: O(V)
    public List<int> DFS(int start)
    {
        var visited = new HashSet<int>();
        var result = new List<int>();
        var stack = new Stack<int>();

        stack.Push(start);

        while (stack.Count > 0)
        {
            int vertex = stack.Pop();

            if (visited.Contains(vertex))
                continue;

            visited.Add(vertex);
            result.Add(vertex);

            // Push neighbors in reverse order to visit in natural order
            var neighbors = adjacencyList[vertex];
            for (int i = neighbors.Count - 1; i >= 0; i--)
            {
                if (!visited.Contains(neighbors[i]))
                    stack.Push(neighbors[i]);
            }
        }

        return result;
    }

    // Detect cycle in a directed graph using DFS with 3-color marking
    // White (unvisited), Gray (in current path), Black (fully explored)
    public bool HasCycle()
    {
        var white = new HashSet<int>(adjacencyList.Keys); // unvisited
        var gray = new HashSet<int>();  // in current DFS path
        var black = new HashSet<int>(); // fully explored

        foreach (int vertex in adjacencyList.Keys)
        {
            if (white.Contains(vertex))
            {
                if (HasCycleDFS(vertex, white, gray, black))
                    return true;
            }
        }

        return false;
    }

    private bool HasCycleDFS(int vertex, HashSet<int> white, HashSet<int> gray, HashSet<int> black)
    {
        white.Remove(vertex);
        gray.Add(vertex);

        foreach (int neighbor in adjacencyList[vertex])
        {
            if (black.Contains(neighbor))
                continue;

            if (gray.Contains(neighbor))
                return true; // back edge = cycle!

            if (HasCycleDFS(neighbor, white, gray, black))
                return true;
        }

        gray.Remove(vertex);
        black.Add(vertex);
        return false;
    }

    public void Print()
    {
        foreach (var kvp in adjacencyList)
        {
            Console.WriteLine($"  {kvp.Key} -> [{string.Join(", ", kvp.Value)}]");
        }
    }
}
