namespace TaskTriangle.Triangles
{
    public class TriangleTypeCalculator : ITriangleTypeCalculator
    {
        public TriangleType Calculate(double firstSide, double secondSide, double thirdSide)
        {
            if (firstSide == secondSide && firstSide == thirdSide && secondSide == thirdSide) return TriangleType.Equilateral;
            else if (firstSide != secondSide && firstSide != thirdSide && secondSide != thirdSide) return TriangleType.Scalene;
            else if (firstSide == secondSide && firstSide != thirdSide && secondSide != thirdSide ||
                    secondSide == thirdSide && firstSide != secondSide && firstSide != thirdSide ||
                    firstSide == thirdSide && firstSide != secondSide && secondSide != thirdSide) return TriangleType.Isosceles;
            else return TriangleType.Undefined;
        }
    }
}