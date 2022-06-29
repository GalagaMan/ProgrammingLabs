
using System.Threading.Channels;

namespace lab4;

public class EBook : BookBase
{
    public EBook(string title, FontType font, FontColor color, string text) : base(title, font, color, text) { }

    public override void LogInfo()
    {
        Console.WriteLine("EBook's text color is set to: " + Color);
        Console.WriteLine("Ebook's font is set to: " + Font);
        Console.WriteLine("");
    }
}