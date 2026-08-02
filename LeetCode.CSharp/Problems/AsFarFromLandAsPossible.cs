namespace AsFarFromLandAsPossible
{
    using System;
    using System.Collections.Generic;

    public class Solution
    {
        private readonly (int x, int y, int distance) Empty = (-1, -1, -1);

        // TODO: return the largest Manhattan distance from a water cell to its nearest land; -1 if degenerate.
        public int MaxDistance(int[][] grid)
        {
            // I liked the idea - on the first run we find lands
            // Then we use BFS (using queue) to keep going away from the land.
            // One mistake that I've made is - I marked the cell as visited when I did dequeue
            // as a result I did in dequeue I had several duplicate items.
            // So in BFS you should mark cell as visited once it get enqueued so there won't be duplicates.
            int[,] visited = new int[grid.Length, grid.Length];
            Queue<(int x, int y, int distance)> queue = GetLands(grid, visited);
            int max = -1, gridSize = grid.Length * grid.Length;

            if (queue.Count == gridSize || queue.Count == 0)
                return -1;

            while (queue.Count > 0)
            {
                var item = queue.Dequeue();

                if (item.distance > max)
                    max = item.distance;

                Enqueue(GetNeighbour(grid, item, 0, 1), queue, visited);
                Enqueue(GetNeighbour(grid, item, 0, -1), queue, visited);
                Enqueue(GetNeighbour(grid, item, 1, 0), queue, visited);
                Enqueue(GetNeighbour(grid, item, -1, 0), queue, visited);
            }

            return max;
        }

        private void Enqueue((int x, int y, int distance) item, Queue<(int x, int y, int distance)> queue, int[,] visited)
        {
            if (ShouldEnqueue(item, visited))
            {
                queue.Enqueue(item);
                visited[item.y, item.x] = 1;
            }
        }

        private bool ShouldEnqueue((int x, int y, int distance) item, int[,] visited)
            => item != Empty && visited[item.y, item.x] == 0;

        private (int x, int y, int distance) GetNeighbour(
            int[][] grid,
            (int x, int y, int distance) currentItem,
            int dx,
            int dy)
        {
            int x = currentItem.x + dx;
            int y = currentItem.y + dy;

            if (x >= grid[0].Length || x < 0 || y >= grid.Length || y < 0)
                return Empty;

            return (x, y, currentItem.distance + 1);
        }

        private Queue<(int x, int y, int distance)> GetLands(
            int[][] grid, int[,] visited)
        {
            Queue<(int x, int y, int distance)> lands = new();

            for (int i = 0; i < grid.Length; i++)
                for (int j = 0; j < grid[i].Length; j++)
                    if (grid[i][j] == 1)
                    {
                        lands.Enqueue((j, i, 0));
                        visited[i, j] = 1;
                    }

            return lands;
        }
    }
}
