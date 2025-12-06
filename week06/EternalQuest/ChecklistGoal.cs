public class ChecklistGoal : Goal
{
    private int _count;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string desc, int points, int target, int bonus, int count = 0)
        : base(name, desc, points)
    {
        _count = count;
        _target = target;
        _bonus = bonus;
    }

    public override int RecordEvent()
    {
        _count++;

        if (_count >= _target)
            return Points + _bonus;

        return Points;
    }

    public override string GetStatus()
    {
        string check = _count >= _target ? "[X]" : "[ ]";
        return $"{check} {Name} -- Completed {_count}/{_target}";
    }

    public override string Serialize()
    {
        return $"Checklist|{Name}|{Description}|{Points}|{_count}|{_target}|{_bonus}";
    }
}
