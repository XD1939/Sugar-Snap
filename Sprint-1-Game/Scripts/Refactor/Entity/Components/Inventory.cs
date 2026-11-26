using System.Collections.Generic;

public class Inventory:IComponent
{
    public int Capacity { get; set; } = 3;

    public List<int> ItemIds { get; } = new();
}