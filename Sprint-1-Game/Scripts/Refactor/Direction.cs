using Microsoft.Xna.Framework;

public static class DirectionVector
{
    public static readonly Point North = new(0, -1);
    public static readonly Point East  = new(1, 0);
    public static readonly Point South = new(0, 1);
    public static readonly Point West  = new(-1, 0);
}