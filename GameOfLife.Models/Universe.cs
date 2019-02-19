using System;
using GameOfLife.Models;

public class Universe
{
    int cells;
    int rows;
    int columns;

    public Universe()
    {
        rows = 0;
        columns = 0;
        cells = 0;
    }

    public double GetAliveCellsCount()
    {
        return cells;
    }

    public void AddCell(int x, int y)
    {
        if(x > rows || y > columns || x < rows || y < columns)
        {
            throw new InvalidCellLocationException();
        }
        cells++;
    }

    public void SetDimensions(int x, int y)
    {
        rows = x;
        columns = y;
    }


}

public class InvalidCellLocationException : Exception
{
}

