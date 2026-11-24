
using Microsoft.Xna.Framework;

public class Movable
{
    public Point Coord = Point.Zero;
    public Point Direction = DirectionVector.South;
    public int Displacement = 0;
    public void Move()
    {
        Coord += Direction * Displacement;
    }
}