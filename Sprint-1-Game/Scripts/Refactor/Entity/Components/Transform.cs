using Microsoft.Xna.Framework;

public class Transform:IComponent
{
    public Point Coord { get; set; } = Point.Zero;
    public Direction Facing { get; set; } = Direction.South;
}