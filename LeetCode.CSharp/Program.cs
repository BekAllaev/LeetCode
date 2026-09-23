using LeetCode.CSharp.Problems;

var authManager = new AuthenticationManager(13);

authManager.Renew("ajvy", 1);
authManager.CountUnexpiredTokens(3);
authManager.CountUnexpiredTokens(4);
authManager.Generate("fuzzq", 5);
authManager.Generate("izmry", 7);
authManager.Renew("puv", 12);
authManager.Generate("ybiqb", 13);
authManager.Generate("gm", 14);
authManager.CountUnexpiredTokens(15);
authManager.CountUnexpiredTokens(18);
authManager.CountUnexpiredTokens(19);
authManager.Renew("ybiqb", 21);
authManager.CountUnexpiredTokens(23);
authManager.CountUnexpiredTokens(25);
authManager.CountUnexpiredTokens(26);
authManager.Generate("aqdm", 28);
Console.WriteLine(authManager.CountUnexpiredTokens(29));
authManager.Renew("puv", 30);