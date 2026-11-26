using System;
using Microsoft.Xna.Framework;

public class Grid
{
    private int Width;
    private int Height;
    private GridCell[,] GridArray;
    public void Init(int width, int height)
    {
        Width = width;
        Height = height;
        GridArray = new GridCell [Width, Height];
        for (int x = 0; x < Width; x++)
        {
            for (int y = 0; y < Height; y++)
            {
                GridArray[x, y] = new GridCell(new Point(x, y), TileTag.Empty);
            }
        }
    }
    public GridCell GetGridCell(Point Coord)
    {
        return GridArray[Coord.X,Coord.Y];
    }
    public bool IsValidCoord(Point position)
    {
        return position.X >= 0 && position.X < Width &&
               position.Y >= 0 && position.Y < Height;
    }

    public GridCell GetCell(Point position)
    {
        if (!IsValidCoord(position))
            throw new ArgumentOutOfRangeException(nameof(position));

        return GridArray[position.X, position.Y];
    }

    public void SetTile(Point position, TileTag tile)
    {
        GetCell(position).Tile = tile;
    }
}