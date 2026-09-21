using LeetCode.CSharp.Problems;

var twitter = new Twitter();

//twitter.PostTweet(1, 5);
//twitter.GetNewsFeed(1);
//twitter.Follow(1, 2);
//twitter.PostTweet(2, 6);
//twitter.GetNewsFeed(1);
//twitter.Unfollow(1, 2);
//twitter.GetNewsFeed(1);

//twitter.PostTweet(1, 1);
//twitter.GetNewsFeed(1);
//twitter.Follow(2, 1);
//twitter.GetNewsFeed(2);
//twitter.Unfollow(2, 1);
//twitter.GetNewsFeed(2);

/*
 [[],[1,5],[1,3],[1,101],[1,13],[1,10],[1,2],[1,94],[1,505],[1,333],[1,22],[1,11],[1]]
 */

twitter.PostTweet(2, 5);
twitter.PostTweet(1, 3);
twitter.PostTweet(1, 101);
twitter.PostTweet(2, 13);
twitter.PostTweet(2, 10);
twitter.PostTweet(1, 2);
twitter.PostTweet(2, 94);
twitter.PostTweet(2, 505);
twitter.PostTweet(1, 333);
twitter.PostTweet(1, 22);
twitter.Follow(2, 1);
twitter.Unfollow(2, 1);
twitter.GetNewsFeed(1);