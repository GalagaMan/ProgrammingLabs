namespace Lab3;

public class EightValveEngine : Engine
{
    public EightValveEngine() : base(10, 200)
    {
        
    }

    public override bool Equals(object? obj) => obj is EightValveEngine && base.Equals(obj);
}