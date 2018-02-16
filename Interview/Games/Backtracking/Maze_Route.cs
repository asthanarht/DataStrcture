using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interview.Games.Backtracking
{
    public class Maze_Route
    {
        int[,] maze = {{1,1,1,1},
                      {0,0,0,1},
                      {1,1,1,1}, 
                      {1,0,0,0}, 
                      {1,1,1,1}};

        int[,] sol = { { 0, 0, 0, 0 }, { 0, 0, 0, 0 }, { 0, 0, 0, 0 }, { 0, 0, 0, 0 }, { 0, 0, 0, 0 } };

        public int rows { get; set; }
        public int cols { get; set; }

        public Maze_Route()
        {
            rows = 4;
            cols = 4;
        }

        private bool isSafe(int[,] matrix, int x, int y)
        {
            if (x >= 0 && x < rows && y >= 0 && y < cols && maze[x, y] == 1)
            {
                return true;
            }

            return false;
        }

        private bool findMazePath(int[,] matrix, int x, int y)
        {
            if (x == rows - 1 && y == cols - 1 && matrix[x, y] != 0)
            {
                sol[x, y] = 1;
                return true;
            }

            if(isSafe(matrix, x, y))
            {
                //matrix[x, y] = 0;
                sol[x, y] = 1;

                if (findMazePath(matrix, x + 1, y) || findMazePath(matrix, x, y + 1) || findMazePath(matrix, x - 1, y) || findMazePath(matrix, x, y - 1))
                {
                    matrix[x, y] = 1;
                    return true;
                }
                else
                    matrix[x, y] = 1;

                //if (findMazePath(matrix, x, y + 1))
                //{
                //    matrix[x, y] = 1;
                //    return true;
                //}

                //if (findMazePath(matrix, x - 1, y))
                //{
                //    matrix[x, y] = 1;
                //    return true;
                //}

                //if (findMazePath(matrix, x, y - 1))
                //{
                //    matrix[x, y] = 1;
                //    return true;
                //}

                sol[x, y] = 0;
            }

            return false;
        }

        private void printPath()
        {
            int r = 0, c = 0;

            while (r < rows)
            {
                while (c < cols)
                {
                    if(sol[r,c] ==1)
                        Console.WriteLine("Row:" + r + " Col:" + c);

                    c++;
                }
                c = 0;
                r++;
            }
        }

        public void solveMazeRoute()
        {
            if (findMazePath(maze, 0, 0))
                printPath();
        }
    }
}
