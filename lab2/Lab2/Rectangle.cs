
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Lab2;

public class Rectangle
{
    public Vertex _InitVertex { get; set; }
    public float _width { get; set; }
    public float _height { get; set; }
    
    private readonly Vertex[] _vertices = new Vertex[4];

    public Rectangle() {}

    public Rectangle(float initPointX, float initPointY, float width, float height)
    {
        _InitVertex = new Vertex(initPointX, initPointY);
        _width = width;
        _height = height;
        SetVertices();
    }

    private Rectangle(double minX, double minY, double maxX, double maxY)
    {
        _InitVertex = new Vertex( (float)minX, (float)minY);
        _width = (float) (maxX - minX);
        _height = (float) (maxY - minY);
        SetVertices();
    }

    public void SetVertices()
    {
        _vertices[0] = new Vertex(_InitVertex.X, _InitVertex.Y);
        _vertices[1] = new Vertex(_InitVertex.X + _width, _InitVertex.Y);
        _vertices[2] = new Vertex(_InitVertex.X, +_InitVertex.Y + _height);
        _vertices[3] = new Vertex(_InitVertex.X + _width, _InitVertex.Y);
    }

    public void MoveRectangle(float x, float y)
    {
        _InitVertex = new Vertex(x, y);
        SetVertices();
    }
    public void SetWidth(float newWidth)
    {
        _width = newWidth;
    }

    public void CheckVertices()
    {
        Console.WriteLine("rectangle vertices are following: ");
        foreach (var vertex in _vertices)
        {
            Console.WriteLine($"X: {vertex.X}, Y: {vertex.Y}");
        }
    }

    public static Rectangle BuildSmallestRectangle(Rectangle first, Rectangle second)
    {
        List<double> X = new List<double>();
        List<double> Y = new List<double>();

        Array.ForEach(first._vertices, vertex => X.Add(vertex.X));
        Array.ForEach(second._vertices, vertex => X.Add(vertex.X));
        Array.ForEach(first._vertices, vertex => Y.Add(vertex.Y));
        Array.ForEach(second._vertices, vertex => Y.Add(vertex.Y) );
        
        return new Rectangle(Enumerable.Min(X), Enumerable.Min(Y), Enumerable.Max(X), Enumerable.Max(Y));
    }

    public void ToJson(string filePath)
    {
        //File.Create(filePath);
        string s = JsonSerializer.Serialize(this, new JsonSerializerOptions(){IncludeFields = true});
        File.WriteAllText(filePath, s);
    }

    public static Rectangle FromJson(string filePath)
    {
        var s = File.ReadAllText(filePath); 
        return JsonSerializer.Deserialize<Rectangle>(s);
    }
    public void SetHeight(float newHeight)
    {
        _height = newHeight;
    }
}