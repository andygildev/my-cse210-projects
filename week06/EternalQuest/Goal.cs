using System;

public abstract class Goal
{
    private string _name;
    private string _description;
    private int _points;

    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }

    public string Name => _name;
    public string Description => _description;
    public int Points => _points;

    public abstract int RecordEvent();
    public abstract string GetStatus();

    public abstract string Serialize();

 
    public static Goal Deserialize(string data)
    {
        string[] parts = data.Split("|");

        string type = parts[0];

        if (type == "Simple")
            return new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]), bool.Parse(parts[4]));

        if (type == "Eternal")
            return new EternalGoal(parts[1], parts[2], int.Parse(parts[3]));

        if (type == "Checklist")
            return new ChecklistGoal(
                parts[1],
                parts[2],
                int.Parse(parts[3]),
                int.Parse(parts[5]),
                int.Parse(parts[6]),
                int.Parse(parts[4])
            );

        return null;
    }
}
