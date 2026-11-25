public class Drawable
{
    public string AtlasName { get; }
    public string SpriteName { get; }

    public Drawable(string atlasName, string spriteName)
    {
        AtlasName = atlasName;
        SpriteName = spriteName;
    }
}