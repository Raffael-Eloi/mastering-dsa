namespace Graph;

public class WeightedGraph
{
    private Dictionary<int, List<(int neighbor, int weight)>> adjacencyList = new();

    public void AddVertex(int vertex)
    {
        if (!adjacencyList.ContainsKey(vertex))
            adjacencyList[vertex] = new List<(int, int)>();
    }

    public void AddEdge(int from, int to, int weight)
    {
        AddVertex(from);
        AddVertex(to);
        adjacencyList[from].Add((to, weight));
    }

    public void AddUndirectedEdge(int a, int b, int weight)
    {
        AddVertex(a);
        AddVertex(b);
        adjacencyList[a].Add((b, weight));
        adjacencyList[b].Add((a, weight));
    }

    // Dijkstra's Algorithm: find shortest path from source to all vertices
    // Time: O((V + E) log V) with priority queue
    // Space: O(V)
    // Constraint: no negative weights
    public Dictionary<int, int> Dijkstra(int source)
    {
        var distances = new Dictionary<int, int>();
        foreach (var vertex in adjacencyList.Keys)
            distances[vertex] = int.MaxValue;

        distances[source] = 0;

        // Priority queue: (distance, vertex)
        var pq = new PriorityQueue<int, int>();
        pq.Enqueue(source, 0);

        var visited = new HashSet<int>();

        while (pq.Count > 0)
        {
            int current = pq.Dequeue();

            if (visited.Contains(current))
                continue;

            visited.Add(current);

            foreach (var (neighbor, weight) in adjacencyList[current])
            {
                int newDist = distances[current] + weight;

                if (newDist < distances[neighbor])
                {
                    distances[neighbor] = newDist;
                    pq.Enqueue(neighbor, newDist);
                }
            }
        }

        return distances;
    }

    public void Print()
    {
        foreach (var kvp in adjacencyList)
        {
            var edges = kvp.Value.Select(e => $"{e.neighbor}(w={e.weight})");
            Console.WriteLine($"  {kvp.Key} -> [{string.Join(", ", edges)}]");
        }
    }
}
