
namespace lab4;

public abstract class BookBase : Text
{
    public string Title { get; init; }

    protected BookBase(string title, FontType font, FontColor color, string text) : base(font, color, text)
    {
        Title = title;
    }

    protected BookBase() { }
}