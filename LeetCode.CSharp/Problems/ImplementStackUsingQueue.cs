namespace LeetCode.CSharp.Problems;

// Accepted solution for 1ms. Push - O(n). Top and pop is for O(1)
// public class MyStack 
// {
//     private Queue<int> q1;
//     private Queue<int> q2;

//     public MyStack() 
//     {
//         q1 = new Queue<int>();
//         q2 = new Queue<int>();
//     }

//     public void Push(int x) 
//     {
//         q2.Enqueue(x);

//         while (q1.Count > 0)
//             q2.Enqueue(q1.Dequeue());

//         var tmp = q2;
//         q2 = q1;
//         q1 = tmp;
//     }

//     public int Pop() 
//     {
//         return q1.Dequeue();
//     }

//     public int Top() 
//     {
//         return q1.Peek();
//     }

//     public bool Empty() => q1.Count == 0;
// }

// Accepted solution for 1ms. Using one stack.
// Push is for O(n), pop and top is O(1)
public class MyStack
{
    private Queue<int> queue;

    public MyStack()
    {
        queue = new Queue<int>();
    }

    public void Push(int x)
    {
        queue.Enqueue(x);

        var size = queue.Count;
        for (int i = 0; i < size - 1; i++)
            queue.Enqueue(queue.Dequeue());
    }

    public int Pop()
    {
        return queue.Dequeue();
    }

    public int Top()
    {
        return queue.Peek();
    }

    public bool Empty() => queue.Count == 0;
}

// Accepted solution that runs for 0ms. Push is O(1) and Pop is O(n)
// Two queues are used
// public class MyStack 
// {
//     private Queue<int> queue;
//     private Queue<int> backingQueue;

//     public MyStack() 
//     {
//         queue = new Queue<int>();
//         backingQueue = new Queue<int>();
//     }

//     public void Push(int x) 
//     {
//         queue.Enqueue(x);
//     }

//     public int Pop() 
//     {
//         while (queue.Count > 1)
//         {
//             backingQueue.Enqueue(queue.Dequeue());
//         }

//         var result = queue.Dequeue();

//         var temp = backingQueue;
//         backingQueue = queue;
//         queue = temp;

//         return result;
//     }

//     public int Top() 
//     {
//         var result = 0;
//         foreach (var item in queue)
//         {
//             result = item;
//         }

//         return result;
//     }

//     public bool Empty() => queue.Count == 0;
// }
