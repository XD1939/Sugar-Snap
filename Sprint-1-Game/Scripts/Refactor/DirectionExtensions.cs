using System;
using Microsoft.Xna.Framework;

public static class DirectionExtensions
{
    public static readonly Point North = new(0, -1);
    public static readonly Point East  = new(1, 0);
    public static readonly Point South = new(0, 1);
    public static readonly Point West  = new(-1, 0);

     public static Point ToVector(this Direction direction) => direction switch
    {
        Direction.North => North,
        Direction.East  => East,
        Direction.South => South,
        Direction.West  => West,
        _ => throw new ArgumentOutOfRangeException(nameof(direction))
    };
}