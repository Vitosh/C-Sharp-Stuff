using System;
using System.Collections.Generic;

class EightQueens
{

    const int Size = 8;
    static bool[,] chessboard = new bool[Size, Size];
    static int solutionsFound = 0;

    static HashSet<int> attackedRows = new HashSet<int>();
    static HashSet<int> attackedColumns = new HashSet<int>();
    static HashSet<int> attackedLeftDiagonals = new HashSet<int>();
    static HashSet<int> attackedRightDiagonals = new HashSet<int>();

    static void PrintSolution()
    {
        for (int row = 0; row < Size; row++)
        {
            for (int col = 0; col < Size; col++)
            {
                if (chessboard[row, col])
                {
                    Console.Write('*');
                }
                    else
                {
                    Console.Write('-');
                }

                //TODO : print '*' or '-' depending on scoreboard [row,col]
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }

    static bool CanPlaceQueen(int row, int col)
    {
        var positionOccupied =
            attackedRows.Contains(row) ||
            attackedColumns.Contains(col) ||
            attackedLeftDiagonals.Contains(col - row) ||
            attackedRightDiagonals.Contains(col + row);
        return !positionOccupied;
    }

    static void MarkAllAttackedPositions(int row, int col)
    {
        attackedRows.Add(row);
        attackedColumns.Add(col);
        attackedLeftDiagonals.Add(col - row);
        attackedRightDiagonals.Add(col + row);
        chessboard[row, col] = true;
    }

    static void UnmarkAllAttackedPositions(int row, int col)
    {
        attackedRows.Remove(row);
        attackedColumns.Remove(col);
        attackedLeftDiagonals.Remove(col - row);
        attackedRightDiagonals.Remove(col + row);
        chessboard[row, col] = false;
    }

    static void PutQueens(int row)
    {
        if (row == Size)
        {
            PrintSolution();
            solutionsFound++;
        }
        else
        {
            for (int col = 0; col < Size; col++)
            {
                if (CanPlaceQueen(row,col))
                {
                    MarkAllAttackedPositions(row, col);
                    PutQueens(row+1);
                    UnmarkAllAttackedPositions(row, col);
                }
            }
        }
    }

    static void Main()
    {
        PutQueens(0);
        Console.WriteLine("Total {0}: ",solutionsFound);
    }
}
