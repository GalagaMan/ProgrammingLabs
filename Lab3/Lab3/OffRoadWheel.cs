namespace Lab3;

public class OffRoadWheel : Wheel
{
    public OffRoadWheel() : base(10, 10)
    {
        
    }
    
    public override bool Equals(object? obj) => obj is OffRoadWheel && base.Equals(obj);
}