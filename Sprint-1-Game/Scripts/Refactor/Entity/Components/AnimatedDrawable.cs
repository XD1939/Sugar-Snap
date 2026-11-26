public class AnimatedDrawable:IComponent
{
    public string AtlasName { get; }
    public string AnimationName { get; }

    public AnimatedDrawable(string atlasName, string animationName)
    {
        AtlasName = atlasName;
        AnimationName = animationName;
    }
}