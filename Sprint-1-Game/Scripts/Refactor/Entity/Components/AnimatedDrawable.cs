public class AnimatedDrawable
{
    public string AtlasName { get; }
    public string AnimationName { get; }

    public AnimatedDrawable(string atlasName, string animationName)
    {
        AtlasName = atlasName;
        AnimationName = animationName;
    }
}