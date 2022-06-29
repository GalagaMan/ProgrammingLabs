namespace lab4;

public abstract class Text
{          
    public enum FontType    
    {
        Nil,
        TimesNewRoman,      
        ComicSans,          
        Windings,
    }                       
                        
    public enum FontColor   
    {   
        Nil,
        White,              
        Green,              
        Red,                
        Black,
    }                       
    public virtual string? TextData { get; init; }
    public FontType Font { get; init; }
    public FontColor Color { get; init; }

    protected Text(FontType font, FontColor color, string text)
    {
        Color = color;
        Font = font;
        TextData = text;
    }
    
    protected  Text(){}
    protected int CountChars()
    {
        //string s = 
        return TextData.Replace(" ", "").Length;
    }

    public virtual void LogInfo()
    {
        Console.WriteLine(TextData);
        Console.WriteLine();
    }

}