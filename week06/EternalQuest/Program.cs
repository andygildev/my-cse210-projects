using System;
using System.Collections.Generic;
using System.IO;


class Program
{
    static List<Goal> goals = new List<Goal>();
    static int score = 0;
    static int streak = 0;

    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("====== Eternal Quest ======");
            Console.WriteLine($"Score: {score} | Level: {GetLevel()} | Rank: {GetRank()}");
            Console.WriteLine("---------------------------");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Load");
            Console.WriteLine("6. Quit");
            Console.Write("Select option: ");

            switch (Console.ReadLine())
            {
                case "1": CreateGoal(); break;
                case "2": ListGoals(); break;
                case "3": RecordEvent(); break;
                case "4": SaveGoals(); break;
                case "5": LoadGoals(); break;
                case "6": return;
            }
        }
    }

    
    static void CreateGoal()
    {
        Console.Clear();
        Console.WriteLine("Types: 1) Simple  2) Eternal  3) Checklist");
        Console.Write("Choose type: ");
        string type = Console.ReadLine();

        Console.Write("Goal Name: ");
        string name = Console.ReadLine();

        Console.Write("Description: ");
        string description = Console.ReadLine();

        Console.Write("Points: ");
        int points = int.Parse(Console.ReadLine());

        if (type == "1")
        {
            goals.Add(new SimpleGoal(name, description, points));
        }
        else if (type == "2")
        {
            goals.Add(new EternalGoal(name, description, points));
        }
        else if (type == "3")
        {
            Console.Write("Target count: ");
            int target = int.Parse(Console.ReadLine());

            Console.Write("Bonus points: ");
            int bonus = int.Parse(Console.ReadLine());

            goals.Add(new ChecklistGoal(name, description, points, target, bonus));
        }

        Console.WriteLine("Goal created! Press ENTER...");
        Console.ReadLine();
    }

  
    static void ListGoals()
    {
        Console.Clear();
        Console.WriteLine("==== Your Goals ====");

        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {goals[i].GetStatus()}");
        }

        Console.WriteLine("\nPress ENTER...");
        Console.ReadLine();
    }

   
    static void RecordEvent()
    {
        Console.Clear();
        Console.WriteLine("Select goal to record:");

        ListGoals();
        Console.Write("Choice: ");
        int index = int.Parse(Console.ReadLine()) - 1;

        int earned = goals[index].RecordEvent();
        score += earned;
        streak++;

        int bonus = streak >= 5 ? 50 : 0;
        score += bonus;

        Console.WriteLine($"\n+{earned} points! (Streak Bonus: {bonus})");
        Console.WriteLine("Press ENTER...");
        Console.ReadLine();
    }

      static void SaveGoals()
    {
        using (StreamWriter writer = new StreamWriter("goals.txt"))
        {
            writer.WriteLine(score);
            writer.WriteLine(streak);

            foreach (Goal g in goals)
                writer.WriteLine(g.Serialize());
        }

        Console.WriteLine("Saved! Press ENTER...");
        Console.ReadLine();
    }

      static void LoadGoals()
    {
        goals.Clear();

        string[] lines = File.ReadAllLines("goals.txt");

        score = int.Parse(lines[0]);
        streak = int.Parse(lines[1]);

        for (int i = 2; i < lines.Length; i++)
            goals.Add(Goal.Deserialize(lines[i]));

        Console.WriteLine("Loaded! Press ENTER...");
        Console.ReadLine();
    }

    static int GetLevel() => score / 500;

    static string GetRank()
    {
        int level = GetLevel();
        if (level < 2) return "Beginner";
        if (level < 5) return "Warrior";
        if (level < 10) return "Champion";
        return "Legend";
    }
}
