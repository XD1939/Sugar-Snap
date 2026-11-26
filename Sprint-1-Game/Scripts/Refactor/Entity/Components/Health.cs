public class Health:IComponent
{
    public int Current { get; set; }
    public int Maximum { get; set; }

    public Health(int maximum)
    {
        Maximum = maximum;
        Current = maximum;
    }
}