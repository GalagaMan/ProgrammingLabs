namespace Lab3;

public class GasTank
{
    private int _remainingFuel;
    private readonly int _maxFuelCapacity;

    public GasTank(int capacity)
    {
        _maxFuelCapacity = capacity;
        Console.WriteLine("gas-tank created");
    }

    public void Refuel(int amount)
    {
        if (_remainingFuel + amount <= _maxFuelCapacity)
            _remainingFuel += amount;
        _remainingFuel = _maxFuelCapacity;
    }

    public void DecrementFuel(int amount)
    {
        if (_remainingFuel - amount < 0)
            _remainingFuel = 0;
        else
            _remainingFuel-=amount;
        Console.WriteLine($"{_remainingFuel} fuel remains");
    }

    public override int GetHashCode()
    {
        Console.WriteLine("GetHashCode engaged");
        return _maxFuelCapacity + _remainingFuel;
    }

    public override bool Equals(object? obj)
    {
        Console.WriteLine("Equals engaged");
        if (obj is not GasTank gt)
            return false;
        return gt._remainingFuel == this._remainingFuel 
               && gt._maxFuelCapacity == this._maxFuelCapacity;
    }

    public override string ToString()
    {
        Console.WriteLine("ToString");
            return String.Format($"remaining fuel: {_remainingFuel}, capacity: {_maxFuelCapacity}");
    }
}