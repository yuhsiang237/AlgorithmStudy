namespace RecursiveMaze
{
    class Program
    {
        static void Main(string[] args)
        {
            Maze maze = new Maze(
                10, // maze size,meaning 10x10
               new int[,] // maze array
                          // 0:road
                          // 1:correctPath
                          // 2:wall
                {
                    {0,0,2,2,2,2,0,0,2,2 },
                    {2,0,2,0,0,0,2,0,2,2 },
                    {0,0,0,0,2,0,2,0,2,2 },
                    {2,2,2,0,2,0,2,0,0,2 },
                    {2,2,0,0,2,0,2,0,2,2 },
                    {0,0,0,2,2,2,0,0,2,2 },
                    {2,0,0,0,0,0,0,0,2,2 },
                    {2,0,2,2,0,2,2,0,2,2 },
                    {2,0,2,0,0,2,2,0,0,0 },
                    {2,2,2,2,2,2,2,2,2,0 }
                },
               0,// startX
               0,// startY
               9,// endX
               9);// endY
            maze.printMaze();
            maze.solveMaze();
        }
    }
}
