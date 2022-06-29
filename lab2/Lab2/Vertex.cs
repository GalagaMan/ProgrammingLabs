namespace Lab2;

public class Pair<T, U> {
    public Pair() {
    }

    public Pair(T first, U second) {
        this.First = first;
        this.Second = second;
    }

    private T First { get; set; }
    private U Second { get; set; }
};
public struct Vertex
{
    public float X, Y;

    public Vertex(float X, float Y)
    {
        this.X = X;
        this.Y = Y;
    }
}