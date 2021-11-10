using System;

namespace RecursiveMaze
{
    /// <summary>
    /// Maze
    /// 0:road
    /// 1:correctPath
    /// 2:wall
    /// </summary>
    class Maze
    {
        private int mazeSize;
        private int [,] maze,correctPath,visited;
        private int startX,startY,endX,endY;

        public Maze(int mazeSize,int [,] maze,int startX,int startY, int endX, int endY)
        {
            this.startX = startX;
            this.startY = startY;
            this.endX = endX;
            this.endY = endY;
            this.mazeSize = mazeSize;
            this.maze = maze;
            this.correctPath = new int[mazeSize, mazeSize];
            this.visited = new int[mazeSize, mazeSize];
        }

        public void printMaze()
        {
            Console.WriteLine("Maze:");

            for (int i = 0; i < this.maze.GetLength(0); i++)
            {
                for (int j = 0; j < this.maze.GetLength(1); j++)
                {
                    Console.Write(this.maze[i,j]);
                }
                Console.Write("\n");
            }
        }

        /// <summary>
        /// 0:road
        /// 1:correctPath
        /// 2:wall
        /// </summary>
        public void printCorrectPath()
        {
            for (int i = 0; i < this.maze.GetLength(0); i++)
            {
                for (int j = 0; j < this.maze.GetLength(1); j++)
                {
                    if(this.correctPath[i,j] == 1)
                    {
                        Console.Write(this.correctPath[i, j]);
                    }
                    else
                    {
                        Console.Write(this.maze[i, j]);
                    }
                }
                Console.Write("\n");
            }
        }
        public void solveMaze()
        {
           Boolean isSolved = recursiveSolve(startX, startY);
            if (isSolved)
            {
                Console.WriteLine("\nSolved:");
                printCorrectPath();
                Console.WriteLine("\nExplain:");
                Console.WriteLine("0:road");
                Console.WriteLine("1:correct path");
                Console.WriteLine("2:wall");
            }
            else
            {
                Console.WriteLine("This is an incorrect maze.");
            }
        }
        public Boolean recursiveSolve(int x,int y)
        {
            if(x == endX && y == endY) // find the correct path.
            {
                correctPath[x, y] = 1;
                return true;
            }
            if(maze[x,y] == 2 || visited[x,y] == 1)
            {
                return false;
            }

            visited[x,y] = 1; // arrived a new point

            if (x > 0) // left boundary
            {
                if (recursiveSolve(x - 1, y))
                {
                    correctPath[x,y] = 1;
                    return true;
                }
            }
            if (x < mazeSize - 1) // right boundary
            {
                if (recursiveSolve(x + 1, y))
                {
                    correctPath[x, y] = 1;
                    return true;
                }
            }
            if (y > 0) // top boundary
            {
                if (recursiveSolve(x, y-1))
                {
                    correctPath[x, y] = 1;
                    return true;
                }
            }
            if (y < mazeSize - 1) // bottom boundary
            {
                if (recursiveSolve(x, y + 1))
                {
                    correctPath[x, y] = 1;
                    return true;
                }
            }
            return false;
        }
    }
}
