using LeetCode.CSharp.Problems;

// ["MyStack","push","push","push","pop","pop","pop","empty"]
// [[],[1],[2],[3],[],[],[],[]]
var myStack = new MyStack();
myStack.Push(1);
myStack.Push(2);
myStack.Push(3);
Console.WriteLine(myStack.Pop());   // Expected: 3
Console.WriteLine(myStack.Pop());   // Expected: 2
Console.WriteLine(myStack.Pop());   // Expected: 1
Console.WriteLine(myStack.Empty()); // Expected: True

// ["MyStack","push","push","top","pop","empty"]
// [[],[1],[2],[],[],[]]
// Output: [null,null,null,2,2,false]
var myStack2 = new MyStack();
myStack2.Push(1);
myStack2.Push(2);
Console.WriteLine(myStack2.Top());   // Expected: 2
Console.WriteLine(myStack2.Pop());   // Expected: 2
Console.WriteLine(myStack2.Empty()); // Expected: False

