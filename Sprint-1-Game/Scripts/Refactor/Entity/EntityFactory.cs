using Microsoft.Xna.Framework;

public class EntityFactory
{
    private readonly EntityManager EntityManager;

    // public EntityFactory(EntityManager entityManager)
    // {
    //     EntityManager = entityManager;
    // }

    // public Entity CreatePlayer(Point coord)
    // {
    //     Entity player = EntityManager.CreateEntity();

    //     EntityConfigs.ConfigurePlayer(player);

    //     return player;
    // }
    // public Entity CreateSkeleton(Point coord)
    // {
    //     Entity skeleton = EntityManager.CreateEntity();

    //     skeleton.AddTag(EntityTag.Skeleton);
    //     skeleton.Add(new Movable { Coord = coord });
    //     skeleton.Add(new Rotatable());

    //     return skeleton;
    // }

    // public Entity CreateBomb(Point coord)
    // {
    //     Entity bomb = EntityManager.CreateEntity();

    //     bomb.AddTag(EntityTag.Bomb);
    //     bomb.Add(new Movable { Coord = coord });
    //     bomb.Add(new Rotatable());

    //     return bomb;
    // }
}