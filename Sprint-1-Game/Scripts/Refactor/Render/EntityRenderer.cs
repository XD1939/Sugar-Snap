using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using MonoGameLibrary.Graphics;

public class EntityRenderer
{
    private readonly EntityManager EntityManager;
    private readonly SpriteFactory SpriteFactory;

    private readonly Dictionary<int, Sprite> _sprites = new();

    public EntityRenderer(
        EntityManager entityManager,
        SpriteFactory spriteFactory)
    {
        EntityManager = entityManager;
        SpriteFactory = spriteFactory;
    }

    private Sprite GetSprite(Entity entity)
    {
        if (_sprites.TryGetValue(entity.Id, out Sprite sprite))
            return sprite;

        if (entity.Has<Drawable>())
        {
            sprite = SpriteFactory.Create(entity.Get<Drawable>());
        }
        else if (entity.Has<AnimatedDrawable>())
        {
            sprite = SpriteFactory.Create(
                entity.Get<AnimatedDrawable>());
        }
        else
        {
            return null;
        }

        _sprites.Add(entity.Id, sprite);
        return sprite;
    }

    public void Update(GameTime gameTime)
    {
        foreach (Entity entity in EntityManager.Entities)
        {
            if (GetSprite(entity) is AnimatedSprite animatedSprite)
            {
                animatedSprite.Update(gameTime);
            }
        }
    }

    public void Draw(SpriteBatch spriteBatch)
    {
        foreach (Entity entity in EntityManager.Entities)
        {
            if (!entity.Has<Transform>())
                continue;

            Sprite sprite = GetSprite(entity);

            if (sprite == null)
                continue;

            Transform transform = entity.Get<Transform>();

            Vector2 drawPosition = new(
                transform.Position.X * 64,
                transform.Position.Y * 64
            );

            sprite.Draw(spriteBatch, drawPosition);
        }
    }
}