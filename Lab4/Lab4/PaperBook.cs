

using System.Text;

namespace lab4;

public class PaperBook : BookBase
{
    public override string TextData
    {
        get
        {
            StringBuilder stringBuilder = new();
            foreach (var page in Pages)
            {
                stringBuilder.Append(page);    
            }
            return stringBuilder.ToString();
        }
        init{}
    }
    
    public readonly Page[] Pages;
    
    public PaperBook(string title, FontType font, FontColor color, string[] text) : base(title, font, color, "")
    {
        if (text == null)
            throw new ArgumentNullException(nameof(text));
        Pages = new Page[text.Length];
        for (int i = 0; i < text.Length; i++)
        {
            //if (text[i] == "")
            //    break;
            Pages[i] = new Page(font, color, text[i]);
        }
    }

    public PaperBook(string title, List<Page> pageList)
    {
        Pages = pageList.ToArray();
    }

    public override void LogInfo()
    {
        Console.WriteLine("contents for book: " + Title);
        Console.WriteLine($"book consists of: {Pages.Length} pages" );
        Array.ForEach(Pages, page => Console.WriteLine(page.TextData));
        Console.WriteLine("");
    }
    
}