using System.Collections.Generic;

public class Inventory
{
    public int Capacity { get; set; } = 3;

    public List<int> ItemIds { get; } = new();
}