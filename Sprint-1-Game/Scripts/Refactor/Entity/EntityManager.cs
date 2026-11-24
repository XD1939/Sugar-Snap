using System.Collections.Generic;

public class EntityManager
{
    private int NextId = 0;

    private readonly Dictionary<int, Entity> Entities = new();

    public Entity CreateEntity()
    {
        Entity entity = new(NextId++);

        Entities.Add(entity.Id, entity);

        return entity;
    }

    public Entity GetEntity(int id)
    {
        return Entities.TryGetValue(id, out var entity)
            ? entity
            : null;
    }
}