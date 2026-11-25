using Microsoft.Xna.Framework;

public class Transform
{
    public Point Coord { get; set; } = Point.Zero;
    public Point Facing { get; set; } = DirectionVector.South;
}