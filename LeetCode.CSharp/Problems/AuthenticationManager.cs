namespace LeetCode.CSharp.Problems;

// Accepted solution for 5ms
public class AuthenticationManager
{
    private readonly int _timeToLive;
    private readonly Dictionary<string, LinkedListNode<Token>> _tokensNode;
    private readonly LinkedList<Token> _tokens;

    public AuthenticationManager(int timeToLive)
    {
        _timeToLive = timeToLive;
        _tokensNode = new();
        _tokens = new();
    }

    public void Generate(string tokenId, int currentTime)
    {
        DeleteExpiredTokens(currentTime);

        if (_tokensNode.ContainsKey(tokenId))
            return;

        var token = new Token(tokenId, currentTime, _timeToLive);
        var tokenNode = _tokens.AddLast(token);
        _tokensNode[tokenId] = tokenNode;
    }

    public void Renew(string tokenId, int currentTime)
    {
        DeleteExpiredTokens(currentTime);

        if (!_tokensNode.ContainsKey(tokenId))
            return;

        var tokenNode = _tokensNode[tokenId];
        tokenNode.Value.Renew(currentTime);
        _tokens.Remove(tokenNode);
        _tokens.AddLast(tokenNode);
    }

    public int CountUnexpiredTokens(int currentTime)
    {
        DeleteExpiredTokens(currentTime);

        return _tokens.Count;
    }

    private void DeleteExpiredTokens(int currentTime)
    {
        var cur = _tokens.First;

        while (cur is not null)
        {
            var next = cur.Next;
            if (cur.Value.IsExpired(currentTime))
            {
                _tokensNode.Remove(cur.Value.Id);
                _tokens.Remove(cur);
                cur = next;
            }
            else
                break;
        }
    }

    class Token
    {
        private string _id;
        private int _expireTime, _timeToLive;

        public Token(string id, int currentTime, int timeToLive)
        {
            _id = id;
            _timeToLive = timeToLive;
            _expireTime = currentTime + timeToLive;
        }

        public string Id => _id;

        public void Renew(int currentTime)
        {
            if (!IsExpired(currentTime))
                _expireTime = currentTime + _timeToLive;
        }

        public bool IsExpired(int currentTime) => _expireTime <= currentTime;
    }
}

// Accepted solution that runs for 68ms
//public class AuthenticationManager
//{
//    private readonly int _timeToLive;
//    private readonly Dictionary<string, Token> _tokens;
//    private readonly Dictionary<int, int> _activeTokens;

//    public AuthenticationManager(int timeToLive)
//    {
//        _timeToLive = timeToLive;
//        _tokens = new();
//        _activeTokens = new();
//    }

//    public void Generate(string tokenId, int currentTime)
//    {
//        if (_tokens.ContainsKey(tokenId))
//            return;

//        _tokens[tokenId] = new Token(tokenId, currentTime, _timeToLive);

//        var key = currentTime + _timeToLive - 1;
//        _activeTokens[key] =
//            _activeTokens.ContainsKey(key) ?
//                ++_activeTokens[key] :
//                1;
//    }

//    public void Renew(string tokenId, int currentTime)
//    {
//        if (!_tokens.ContainsKey(tokenId))
//            return;

//        var token = _tokens[tokenId];
//        token.Renew(currentTime);
//    }

//    public int CountUnexpiredTokens(int currentTime) => _activeTokens[currentTime];

//    class Token
//    {
//        private string _id;
//        private int _expireTime, _timeToLive;

//        public Token(string id, int currentTime, int timeToLive)
//        {
//            _id = id;
//            _timeToLive = timeToLive;
//            _expireTime = currentTime + timeToLive;
//        }

//        public void Renew(int currentTime)
//        {
//            if (!IsExpired(currentTime))
//                _expireTime = currentTime + _timeToLive;
//        }

//        public bool IsExpired(int currentTime) => _expireTime <= currentTime;
//    }
//}
