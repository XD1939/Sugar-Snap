public class Attack:IComponent
{
    public int Damage { get; set; }
    public int Range { get; set; }

    public Attack(int damage, int range = 1)
    {
        Damage = damage;
        Range = range;
    }
}