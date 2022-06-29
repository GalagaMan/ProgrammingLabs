
namespace lab4;

public class Page : Text
{
    //private fontType pageFont;
    //private fontColor charColor;

    public Page(FontType font, FontColor color, string text) 
        : base(font, color, text){}
    
    public override void LogInfo()
    {
        Console.WriteLine("page char count is: " + CountChars());
        Console.WriteLine("page font type is: " + Font);
        Console.WriteLine("page font color is set to: " + Color);
        Console.WriteLine("");
    }
}