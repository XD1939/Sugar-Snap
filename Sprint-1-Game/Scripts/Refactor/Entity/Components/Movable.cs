using Microsoft.Xna.Framework;

public class Movable
{
    public Point Coord { get; set; } = Point.Zero;
    public Point Direction { get; set; } = DirectionVector.South;
    public int Displacement { get; set; } = 1;
    public Point Destination()
    {
        return Coord + Direction * Displacement;
    }
}