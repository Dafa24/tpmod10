using System;

public class todo
{
    internal readonly bool IsComplete;

    public string Name { get; internal set; }

    public class Todo
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public bool IsComplete { get; set; }
    }
    public todo()
	{
	}
}
