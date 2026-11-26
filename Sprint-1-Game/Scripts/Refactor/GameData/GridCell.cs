using System.Collections.Generic;
using Microsoft.Xna.Framework;

public class GridCell
{
    public Point Position { get; }

    public TileTag Tile { get; set; }

    public List<int> EntityIds { get; } = new();

    public GridCell(Point position, TileTag tile)
    {
        Position = position;
        Tile = tile;
    }

    public void AddEntity(int entityId)
    {
        if (!EntityIds.Contains(entityId))
            EntityIds.Add(entityId);
    }

    public void RemoveEntity(int entityId)
    {
        EntityIds.Remove(entityId);
    }

}