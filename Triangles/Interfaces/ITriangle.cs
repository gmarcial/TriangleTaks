namespace TaskTriangle.Triangles.Interfaces
{
    public interface ITriangle
    {
        ThreeSides ThreeSides { get; }
        TriangleTypes Types { get; }
    }
}