public class Health
{
    public int Current { get; set; }
    public int Maximum { get; set; }

    public Health(int maximum)
    {
        Maximum = maximum;
        Current = maximum;
    }
}