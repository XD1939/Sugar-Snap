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
                GridArray[x, y] = new GridCell(x, y);
            }
        }
    }
    public GridCell GetGridCell(Point Coord)
    {
        return GridArray[Coord.X,Coord.Y];
    }
}