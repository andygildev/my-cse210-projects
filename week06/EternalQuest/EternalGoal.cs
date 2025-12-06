public class EternalGoal : Goal
{
    public EternalGoal(string name, string desc, int points)
        : base(name, desc, points)
    {}

    public override int RecordEvent()
    {
        return Points;
    }

    public override string GetStatus()
    {
        return $"[∞] {Name}";
    }

    public override string Serialize()
    {
        return $"Eternal|{Name}|{Description}|{Points}";
    }
}
