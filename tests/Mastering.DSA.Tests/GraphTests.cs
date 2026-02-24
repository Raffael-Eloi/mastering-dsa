using NUnit.Framework;

namespace Mastering.DSA.Tests;

[TestFixture]
public class GraphTests
{
    [Test]
    public void BFS_VisitsAllConnectedVertices()
    {
        var graph = new Graph.MyGraph();
        graph.AddUndirectedEdge(0, 1);
        graph.AddUndirectedEdge(0, 2);
        graph.AddUndirectedEdge(1, 3);
        graph.AddUndirectedEdge(2, 3);

        var result = graph.BFS(0);
        Assert.That(result, Has.Count.EqualTo(4));
        Assert.That(result, Does.Contain(0));
        Assert.That(result, Does.Contain(1));
        Assert.That(result, Does.Contain(2));
        Assert.That(result, Does.Contain(3));
        Assert.That(result[0], Is.EqualTo(0)); // starts from source
    }

    [Test]
    public void DFS_VisitsAllConnectedVertices()
    {
        var graph = new Graph.MyGraph();
        graph.AddUndirectedEdge(0, 1);
        graph.AddUndirectedEdge(0, 2);
        graph.AddUndirectedEdge(1, 3);

        var result = graph.DFS(0);
        Assert.That(result, Has.Count.EqualTo(4));
        Assert.That(result, Does.Contain(0));
        Assert.That(result, Does.Contain(1));
        Assert.That(result, Does.Contain(2));
        Assert.That(result, Does.Contain(3));
        Assert.That(result[0], Is.EqualTo(0));
    }

    [Test]
    public void HasCycle_DirectedAcyclic_ReturnsFalse()
    {
        var graph = new Graph.MyGraph();
        graph.AddEdge(0, 1);
        graph.AddEdge(1, 2);
        graph.AddEdge(2, 3);

        Assert.That(graph.HasCycle(), Is.False);
    }

    [Test]
    public void HasCycle_DirectedCyclic_ReturnsTrue()
    {
        var graph = new Graph.MyGraph();
        graph.AddEdge(0, 1);
        graph.AddEdge(1, 2);
        graph.AddEdge(2, 0);

        Assert.That(graph.HasCycle(), Is.True);
    }

    [Test]
    public void Dijkstra_FindsShortestPaths()
    {
        var graph = new Graph.WeightedGraph();
        graph.AddUndirectedEdge(0, 1, 4);
        graph.AddUndirectedEdge(0, 2, 2);
        graph.AddUndirectedEdge(1, 3, 1);
        graph.AddUndirectedEdge(2, 3, 3);

        var distances = graph.Dijkstra(0);
        Assert.That(distances[0], Is.EqualTo(0));
        Assert.That(distances[1], Is.EqualTo(4));
        Assert.That(distances[2], Is.EqualTo(2));
        Assert.That(distances[3], Is.EqualTo(5)); // 0->1->3 = 4+1 = 5
    }
}
