namespace Lab3;

public class RallyWheel : Wheel
{
    public RallyWheel() : base(7, 8)
    {
        
    }
    
    public override bool Equals(object? obj) => obj is RallyWheel && base.Equals(obj);
}