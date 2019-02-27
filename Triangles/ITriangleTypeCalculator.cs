namespace TaskTriangle.Triangles
{
    public interface ITriangleTypeCalculator
    {
         TriangleType Calculate(double firstSide, double secondSide, double thirdSide);
    }
}