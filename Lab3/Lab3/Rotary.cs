namespace Lab3;

public class RotaryEngine : Engine
{
    public RotaryEngine() : base(15, 350)
    {
        
    }
    
    public override bool Equals(object? obj) => obj is RotaryEngine && base.Equals(obj);
}