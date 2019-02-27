namespace TaskTriangle.Triangles
{
    public interface ITriangle
    {
        double FirstSide { get; }
        double SecondSide { get; }
        double ThirdSide { get; }
        TriangleType Type { get; }
    }
}