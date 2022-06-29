
namespace Lab3;

public abstract class Engine
{
    private readonly int fuelConsumption;
    private readonly int power;
    
   //public enum EngineType
   //{
   //    FourValve,
   //    EightValve,
   //    SixteenValve,
   //    Rotary
   //}

    protected Engine(int fuelConsumption, int power)
    {
        this.power = power;
        this.fuelConsumption = fuelConsumption;
    }

    public override int GetHashCode()
    {
        return fuelConsumption + power;
    }

    public override bool Equals(object? obj)
    {
        if (obj is not Engine)
            return false;
        return fuelConsumption == this.fuelConsumption && power == this.power;
    }
}