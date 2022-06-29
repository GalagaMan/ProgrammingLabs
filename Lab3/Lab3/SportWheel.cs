namespace Lab3;

public class SportWheel : Wheel
{
    public SportWheel() : base(2, 1)
    {
        
    }
    public override bool Equals(object? obj)
    {
        if (obj is not SportWheel)
            return false;
        return base.Equals(obj);
    }
}