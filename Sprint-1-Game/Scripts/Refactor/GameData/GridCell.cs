using System.Collections.Generic;
using Microsoft.Xna.Framework;

public class GridCell(int x, int y)
{
    public Point Coord { get; } = new(x, y);
    public List<IPlayer> PlayersOnCell = [];
    public List<IObject> ObjectsOnCell = [];
    public List<IEnemy> EnemiesOnCell = [];
    public bool CanMoveTo = false;

}