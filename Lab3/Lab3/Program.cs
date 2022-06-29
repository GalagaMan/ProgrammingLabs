using System;

namespace Lab3
{
    class Program
    {
        public static void Main(string[] args)
        {
            AutoCreator autoCreator = new AutoCreator();
            var mazdaRx7 = autoCreator.CreateMazdaRX7();
            mazdaRx7.GasTank.Refuel(125);
            mazdaRx7.Drive(2);
            mazdaRx7.ReplaceTire(1, new RallyWheel());
            Console.WriteLine(mazdaRx7.AutoBrand);
            Console.WriteLine("");
            var toyotaTundra = autoCreator.CreateToyotaTundra();
            toyotaTundra.GasTank.Refuel(24);
            toyotaTundra.Drive(2);
            Console.WriteLine(toyotaTundra.AutoBrand);
            List<Auto> autos  = new List<Auto>{mazdaRx7, toyotaTundra};
            Console.Read();
        }
    }    
}