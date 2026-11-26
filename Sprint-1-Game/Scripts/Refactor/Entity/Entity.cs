using System;
using System.Collections.Generic;

public class Entity
{
    public int Id { get; }
    private readonly Dictionary<Type, object> Components = new();
    private readonly HashSet<EntityTag> Tags = new();
    public void AddTag(EntityTag tag)
    {
        Tags.Add(tag);
    }
    public bool HasTag(EntityTag tag)
    {
        return Tags.Contains(tag);
    }
    public Entity(int id)
    {
        Id = id;
    }
    public void Add<T>(T component) where T : class
    {
        Components[typeof(T)] = component;
    }
    public T Get<T>() where T : class
    {
        return Components.TryGetValue(typeof(T), out var component)
            ? (T)component
            : null;
    }
    public bool Has<T>() where T : class
    {
        return Components.ContainsKey(typeof(T));
    }
    public void Remove<T>() where T : class
    {
        Components.Remove(typeof(T));
    }
}