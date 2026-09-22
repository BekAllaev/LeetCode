namespace LeetCode.CSharp.Problems;

// Accepted solution that runs for 13ms
public class Twitter
{
    int postCount = 0;
    HashSet<int>[] network = new HashSet<int>[500];
    LinkedList<(int tweetId, int postCount, int authorId)>[] usersFeed = new LinkedList<(int tweetId, int postCount, int authorId)>[500];
    LinkedList<(int tweetId, int postCount, int authroId)>[] usersTweets = new LinkedList<(int tweetId, int postCount, int authorId)>[500];

    public Twitter() { }

    public void PostTweet(int userId, int tweetId)
    {
        postCount++;
        UpdateFeed(userId, tweetId, postCount, userId);
        AddTweet(userId, tweetId, postCount);

        var followers = network[userId];

        if (followers is null)
            return;

        foreach (var follower in followers)
        {
            UpdateFeed(follower, tweetId, postCount, userId);
        }
    }

    public IList<int> GetNewsFeed(int userId)
        => usersFeed[userId] is not null ? usersFeed[userId].Take(10).Select(x => x.Item1).ToList() : new List<int>();

    public void Follow(int followerId, int followeeId)
    {
        var followers = network[followeeId] ??= new HashSet<int>();
        var followeeTweets = usersTweets[followeeId];

        if (followers.Contains(followerId))
            return;

        followers.Add(followerId);

        var userFeed = usersFeed[followerId] ??= new LinkedList<(int tweetId, int postCount, int authorId)>();

        if (followeeTweets is not null)
            MergeIntoFollowerFeed(usersFeed[followerId], followeeTweets);
    }

    public void Unfollow(int followerId, int followeeId)
    {
        var followers = network[followeeId];
        var followerFeed = usersFeed[followerId];

        if (followers is null || followerFeed is null)
            return;

        followers.Remove(followerId);

        var cur = followerFeed.First;
        while (cur is not null)
        {
            var next = cur.Next;
            if (cur.Value.authorId == followeeId)
                followerFeed.Remove(cur);
            cur = next;
        }
    }

    private void UpdateFeed(int userId, int tweetId, int postCount, int authorId)
    {
        var userFeed = usersFeed[userId] ??= new LinkedList<(int tweetId, int postCount, int authorId)>();

        var cur = userFeed.First;
        while (cur is not null)
        {
            if (cur.Value.Item2 > postCount)
                cur = cur.Next;
            else break;
        }

        if (cur is not null)
            userFeed.AddBefore(cur, (tweetId, postCount, authorId));
        else
            userFeed.AddLast((tweetId, postCount, authorId));
    }

    private void AddTweet(int userId, int tweetId, int postCount)
    {
        var userTweets = usersTweets[userId] ??= new LinkedList<(int tweetId, int postCount, int authroId)>();

        userTweets.AddFirst((tweetId, postCount, userId));
    }

    private void MergeIntoFollowerFeed(LinkedList<(int, int, int)> followerFeed, LinkedList<(int, int, int)> followeeTweets)
    {
        var first = followerFeed.First;
        var second = followeeTweets.First;

        while (first is not null && second is not null)
        {
            if (second.Value.Item2 > first.Value.Item2)
            {
                followerFeed.AddBefore(first, second.Value);
                second = second.Next;
            }
            else
                first = first.Next;
        }

        while (second is not null)
        {
            followerFeed.AddLast(second.Value);
            second = second.Next;
        }
    }
}

// Accepted solution that runs for 700ms
/*
public class Twitter
{
    int postCount = 0;
    bool[][] network = new bool[500][];
    LinkedList<(int, int)>[] usersFeed = new LinkedList<(int, int)>[500];
    LinkedList<(int, int)>[] usersTweets = new LinkedList<(int, int)>[500];

    public Twitter() { }

    public void PostTweet(int userId, int tweetId)
    {
        postCount++;
        UpdateFeed(userId - 1, tweetId, postCount);
        AddTweet(userId - 1, tweetId, postCount);

        var followers = network[userId - 1];

        for (int i = 0; followers is not null && i < followers.Length; i++)
        {
            if (followers[i])
                UpdateFeed(i, tweetId, postCount);
        }
    }

    public IList<int> GetNewsFeed(int userId)
        => usersFeed[userId - 1] is not null ? usersFeed[userId - 1].Take(10).Select(x => x.Item1).ToList() : new List<int>();

    public void Follow(int followerId, int followeeId)
    {
        var followers = network[followeeId - 1];

        if (followers is null)
        {
            followers = new bool[500];
            network[followeeId - 1] = followers;
        }

        network[followeeId - 1][followerId - 1] = true;

        var followeeTweets = usersTweets[followeeId - 1];

        if (followeeTweets is null)
            return;

        foreach (var tweet in followeeTweets)
        {
            UpdateFeed(followerId - 1, tweet.Item1, tweet.Item2);
        }
    }

    public void Unfollow(int followerId, int followeeId)
    {
        var followers = network[followeeId - 1];

        if (followers is null)
            return;

        followers[followerId - 1] = false;
        var followeeTweets = usersTweets[followeeId - 1];
        var followerFeed = usersFeed[followerId - 1];

        if (followerFeed is null)
            return;

        foreach (var feedTweet in followerFeed.ToList())
        {
            if (followeeTweets.Contains(feedTweet))
                followerFeed.Remove(feedTweet);
        }
    }

    private void UpdateFeed(int userId, int tweetId, int postCount)
    {
        var userFeed = usersFeed[userId];

        if (userFeed is null)
        {
            userFeed = new LinkedList<(int, int)>();
            usersFeed[userId] = userFeed;
        }

        if (!userFeed.Contains((tweetId, postCount)))
        {
            var cur = userFeed.Last;
            while (cur is not null)
            {
                if (cur.Value.Item2 < postCount)
                    cur = cur.Previous;
                else break;
            }

            if (cur is not null)
                userFeed.AddAfter(cur, (tweetId, postCount));
            else
                userFeed.AddFirst((tweetId, postCount));
        }
    }

    private void AddTweet(int userId, int tweetId, int postCount)
    {
        var userTweets = usersTweets[userId];

        if (userTweets is null)
        {
            userTweets = new LinkedList<(int, int)>();
            usersTweets[userId] = userTweets;
        }

        userTweets.AddFirst((tweetId, postCount));
    }
}
*/

/**
 * Your Twitter object will be instantiated and called as such:
 * Twitter obj = new Twitter();
 * obj.PostTweet(userId,tweetId);
 * IList<int> param_2 = obj.GetNewsFeed(userId);
 * obj.Follow(followerId,followeeId);
 * obj.Unfollow(followerId,followeeId);
 */