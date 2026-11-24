
using Microsoft.Xna.Framework;

public class Movable
{
    public Point Coord = Point.Zero;
    public Point DirectionVec = DirectionVector.South;
    public int Displacement = 0;
    public Point Destination()
    {
        return Coord + DirectionVec * Displacement;
    }
    public void Move()
    {
        Coord += DirectionVec * Displacement;
    }
}