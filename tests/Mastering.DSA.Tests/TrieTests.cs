using NUnit.Framework;

namespace Mastering.DSA.Tests;

[TestFixture]
public class TrieTests
{
    private Trie.MyTrie trie = null!;

    [SetUp]
    public void Setup()
    {
        trie = new Trie.MyTrie();
        trie.Insert("apple");
        trie.Insert("app");
        trie.Insert("banana");
    }

    [Test]
    public void Search_ExactWord_ReturnsTrue()
    {
        Assert.That(trie.Search("apple"), Is.True);
        Assert.That(trie.Search("app"), Is.True);
        Assert.That(trie.Search("banana"), Is.True);
    }

    [Test]
    public void Search_PrefixOnly_ReturnsFalse()
    {
        Assert.That(trie.Search("ap"), Is.False);
        Assert.That(trie.Search("ban"), Is.False);
    }

    [Test]
    public void Search_NonExistent_ReturnsFalse()
    {
        Assert.That(trie.Search("cat"), Is.False);
    }

    [Test]
    public void StartsWith_ValidPrefix_ReturnsTrue()
    {
        Assert.That(trie.StartsWith("app"), Is.True);
        Assert.That(trie.StartsWith("ba"), Is.True);
        Assert.That(trie.StartsWith("a"), Is.True);
    }

    [Test]
    public void StartsWith_InvalidPrefix_ReturnsFalse()
    {
        Assert.That(trie.StartsWith("cat"), Is.False);
        Assert.That(trie.StartsWith("xyz"), Is.False);
    }

    [Test]
    public void Delete_RemovesWord()
    {
        trie.Delete("app");
        Assert.That(trie.Search("app"), Is.False);
    }

    [Test]
    public void Delete_DoesNotAffectLongerWord()
    {
        trie.Delete("app");
        Assert.That(trie.Search("apple"), Is.True);
    }

    [Test]
    public void Delete_NonExistentWord_ReturnsFalse()
    {
        Assert.That(trie.Delete("xyz"), Is.False);
    }

    [Test]
    public void GetAllWords_ReturnsAllInsertedWords()
    {
        var words = trie.GetAllWords();
        Assert.That(words, Does.Contain("apple"));
        Assert.That(words, Does.Contain("app"));
        Assert.That(words, Does.Contain("banana"));
        Assert.That(words, Has.Count.EqualTo(3));
    }
}
