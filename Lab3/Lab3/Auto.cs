
namespace Lab3;

public class Auto
{
    private Engine _engine;
    public Wheel[] _wheels { get; private set; }
    public GasTank GasTank { get; private set; }
    public string AutoBrand { get; private set; }
    
    public Auto(Engine engine, Wheel[] wheels, GasTank gasTank, String autoBrand)
    {
        AutoBrand = autoBrand;
        _engine = engine;
        _wheels = wheels;
        this.GasTank = gasTank;
    }

    public void Drive(int Distance)
    {
        GasTank.DecrementFuel(4 * Distance);
        Array.ForEach(_wheels, (wheel => wheel.DamageTire()));
    }

    public void ReplaceTire(int index, Wheel wheel)
    {
        _wheels[index] = wheel;
    }
}