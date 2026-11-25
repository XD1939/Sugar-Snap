using System.Collections.Generic;
using MonoGameLibrary.Graphics;

public class SpriteFactory
{
    private readonly Dictionary<string, TextureAtlas> Atlases;

    public SpriteFactory(Dictionary<string, TextureAtlas> atlases)
    {
        Atlases = atlases;
    }

    public Sprite Create(Drawable drawable)
    {
        return Atlases[drawable.AtlasName]
            .CreateSprite(drawable.SpriteName);
    }

    public AnimatedSprite Create(AnimatedDrawable drawable)
    {
        return Atlases[drawable.AtlasName]
            .CreateAnimatedSprite(drawable.AnimationName);
    }
}