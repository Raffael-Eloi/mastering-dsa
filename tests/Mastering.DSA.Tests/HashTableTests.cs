using NUnit.Framework;

namespace Mastering.DSA.Tests;

[TestFixture]
public class HashTableTests
{
    private HashTable.MyHashTable table = null!;

    [SetUp]
    public void Setup()
    {
        table = new HashTable.MyHashTable();
    }

    [Test]
    public void Add_Get_ReturnsValue()
    {
        table.Add("apple", 10);
        Assert.That(table.Get("apple"), Is.EqualTo(10));
    }

    [Test]
    public void Get_NonExistentKey_ReturnsNull()
    {
        Assert.That(table.Get("missing"), Is.Null);
    }

    [Test]
    public void Add_UpdateExistingKey()
    {
        table.Add("apple", 10);
        table.Add("apple", 99);
        Assert.That(table.Get("apple"), Is.EqualTo(99));
    }

    [Test]
    public void Remove_KeyNoLongerFound()
    {
        table.Add("apple", 10);
        table.Remove("apple");
        Assert.That(table.Get("apple"), Is.Null);
    }

    [Test]
    public void Remove_NonExistentKey_DoesNotThrow()
    {
        Assert.DoesNotThrow(() => table.Remove("missing"));
    }

    [Test]
    public void Collision_HandledCorrectly()
    {
        // Small table forces collisions
        var small = new HashTable.MyHashTable(2);
        small.Add("a", 1);
        small.Add("b", 2);
        small.Add("c", 3);
        small.Add("d", 4);

        Assert.That(small.Get("a"), Is.EqualTo(1));
        Assert.That(small.Get("b"), Is.EqualTo(2));
        Assert.That(small.Get("c"), Is.EqualTo(3));
        Assert.That(small.Get("d"), Is.EqualTo(4));
    }
}
