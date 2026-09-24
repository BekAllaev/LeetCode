namespace LeetCode.CSharp.Problems;

public class LRUCache
{
    private readonly Dictionary<int, LinkedListNode<(int key, int value)>> _cacheMap;
    private readonly LinkedList<(int key, int value)> _cacheChain;
    private readonly int _capacity;

    public LRUCache(int capacity)
    {
        _capacity = capacity;
        _cacheMap = new(capacity);
        _cacheChain = new();
    }

    public int Get(int key)
    {
        if (_cacheMap.TryGetValue(key, out var node))
        {
            _cacheChain.Remove(node);
            _cacheChain.AddFirst(node);

            return node.Value.value;
        }
        else return -1;
    }

    public void Put(int key, int value)
    {
        LinkedListNode<(int key, int value)> node;

        if (_cacheMap.TryGetValue(key, out node))
        {
            node.Value = (key, value);
            _cacheChain.Remove(node);
            _cacheChain.AddFirst(node);
        }
        else
        {
            node = _cacheChain.AddFirst((key, value));
            _cacheMap[key] = node;
        }

        if (_cacheChain.Count > _capacity)
        {
            node = _cacheChain.Last;

            _cacheMap.Remove(node.Value.key);
            _cacheChain.RemoveLast();
        }
    }
}
