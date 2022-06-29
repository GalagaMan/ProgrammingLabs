using System;

namespace lab4;

class Program
{
    public static void Main(string[] args)
    {
        //Text[] texts = {new Page(), new PaperBook("asd", 1, new string[]{"123"}) };
        List<Page> pages = new List<Page>
        {
            new (Text.FontType.Windings, Text.FontColor.Black, "lorem ipsum"),
            new (Text.FontType.ComicSans, Text.FontColor.Red, "asdefafsd")
        };
        var texts = new Text[4];
        texts[0] = new Graffiti(Text.FontColor.Red, Text.FontType.ComicSans, "ssfq", 2, 4);
        texts[1] = new PaperBook("XXX", pages);
        texts[2] = new Page(Text.FontType.Windings, Text.FontColor.Red, "e easde e");
        texts[3] = new EBook("sss", Text.FontType.Windings, Text.FontColor.Red, "fSSS");
        Array.ForEach(texts, text => text.LogInfo());
        Console.WriteLine();
        Console.ReadLine();
    }
}