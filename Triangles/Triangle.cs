using TaskTriangle.Triangles.Exceptions;
using TaskTriangle.Triangles.Interfaces;
using TaskTriangle.Triangles.TriangleTypeCalculators.Interfaces;

namespace TaskTriangle.Triangles
{
        public class Triangle : ITriangle
    {
        public Triangle(
            ThreeSides threeSides,
            ITriangleTypeCalculator triangleTypeCalculator)
        {
            if (!((threeSides.FirstSide < (threeSides.SecondSide + threeSides.ThirdSide)) &&
                  (threeSides.SecondSide < (threeSides.FirstSide + threeSides.ThirdSide)) &&
                  (threeSides.ThirdSide < (threeSides.FirstSide + threeSides.SecondSide)))) 
                //TODO: For me, it should not be a exception, as it is a quick thing to do, but it can be refactored for another approach.
                throw new InvalidFormatTriangleException("The sides informed form one triangle invalid.");

            ThreeSides = threeSides;
            _triangleTypeCalculator = triangleTypeCalculator;
        }

        public ThreeSides ThreeSides { get; }
        public TriangleTypes Types => _triangleTypeCalculator.Calculate(ThreeSides);
        private ITriangleTypeCalculator _triangleTypeCalculator;
    }
}