using System;

public abstract class Shape
{
    private string _color;

    public Shape(string color)
    {
        _color = color;
    }

    public string GetColor()
    {
        return _color;
    }

    // Abstract method → must be overridden by each shape
    public abstract double GetArea();
}
