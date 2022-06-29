
namespace Lab3;

public abstract class Wheel
{
    private bool _isBroken = false;
    private int _timeBeforeBroke;
    public readonly int FrictionCoefficient;
    private readonly Lazy<Random> _rand = new();
    protected Wheel(int timeBeforeBroke, int frictionCoefficient)
   {
       _timeBeforeBroke = timeBeforeBroke;
       FrictionCoefficient = frictionCoefficient;
   }

    public void DamageTire()
    {
        if (!_isBroken && _rand.Value.Next(1, 12) <= 5)
            _timeBeforeBroke--;
        if (_timeBeforeBroke <= 0)
            _isBroken = true;
    }

    public override bool Equals(object? obj) =>
        (obj is Wheel wh) &&
        (wh._isBroken == this._isBroken
         && wh.FrictionCoefficient == this.FrictionCoefficient
         && wh._timeBeforeBroke == this._timeBeforeBroke);
    

    public override int GetHashCode()
    {   if(_isBroken)
            return 0;
        return FrictionCoefficient;
    }
}