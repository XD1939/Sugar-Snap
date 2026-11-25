using System.Collections.Generic;
using Microsoft.Xna.Framework;

public class GridCell(int x, int y)
{
    public Point Coord { get; } = new(x, y);
    public List<Entity> Entity = [];
    public List<IEnemy> EnemiesOnCell = [];
    public bool CanMoveTo = false;

}