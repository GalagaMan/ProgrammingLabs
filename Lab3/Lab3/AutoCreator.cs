namespace Lab3;

public class AutoCreator
{
    public Auto CreateMazdaRX7()
    {
        var auto = new Auto(new RotaryEngine(), 
            new Wheel[]{new SportWheel(), new SportWheel(), new SportWheel(), new SportWheel()}, 
            new GasTank(500), "Mazda");
        return auto;
    }

    public Auto CreateToyotaTundra()
    {
        var auto = new Auto(new EightValveEngine(),
            new Wheel[] {new OffRoadWheel(), new OffRoadWheel(), new OffRoadWheel(), new OffRoadWheel()},
            new GasTank(2000), "Toyota");
        return auto;
    }
}