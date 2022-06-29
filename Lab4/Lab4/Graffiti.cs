using System.Threading.Channels;

namespace lab4;

public class Graffiti : Text
{
    public readonly int SizeX, SizeY;

    public Graffiti(FontColor color, FontType font, string text, int x, int y) : base(font, color, text)
    {
        if (text.Length >= 15 || (x * y) >= 400)
            throw new Exception("such graffiti does not exist");
        SizeX = x;
        SizeY = y;

    }
    
    public override void LogInfo()
    {
        Console.WriteLine("graffiti font is: " + Font);
        Console.WriteLine("graffiti color is: " + Color);
        Console.WriteLine("graffiti size " + (SizeX * SizeY));
        Console.WriteLine("");
    }
}