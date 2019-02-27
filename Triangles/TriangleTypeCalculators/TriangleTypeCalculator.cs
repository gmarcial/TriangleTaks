using TaskTriangle.Triangles.TriangleTypeCalculators.Interfaces;

namespace TaskTriangle.Triangles.TriangleTypeCalculators
{
    public class TriangleTypeCalculator : ITriangleTypeCalculator
    {
        public TriangleTypes Calculate(ThreeSides threeSides)
        {
            if (threeSides.FirstSide == threeSides.SecondSide && threeSides.FirstSide == threeSides.ThirdSide &&
                threeSides.SecondSide == threeSides.ThirdSide) return TriangleTypes.Equilateral;
            if (threeSides.FirstSide != threeSides.SecondSide && threeSides.FirstSide != threeSides.ThirdSide &&
                threeSides.SecondSide != threeSides.ThirdSide) return TriangleTypes.Scalene;
            if (threeSides.FirstSide == threeSides.SecondSide && threeSides.FirstSide != threeSides.ThirdSide &&
                     threeSides.SecondSide != threeSides.ThirdSide ||
                     threeSides.SecondSide == threeSides.ThirdSide && threeSides.FirstSide != threeSides.SecondSide &&
                     threeSides.FirstSide != threeSides.ThirdSide ||
                     threeSides.FirstSide == threeSides.ThirdSide && threeSides.FirstSide != threeSides.SecondSide &&
                     threeSides.SecondSide != threeSides.ThirdSide) return TriangleTypes.Isosceles;
            return TriangleTypes.Undefined;
        }
    }
}