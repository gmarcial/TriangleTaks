using System;

namespace TaskTriangle.Triangles
{
    public class Triangle : ITriangle
    {
        public Triangle(
            double firstSide, 
            double secondSide, 
            double thirdSide,
            ITriangleTypeCalculator triangleTypeCalculator)
        {
            if(!((firstSide < (secondSide + thirdSide)) && (secondSide < (firstSide + thirdSide)) && (thirdSide < (firstSide + secondSide)))) 
                //TODO: For me, it should not be a exception, as it is a quick thing to do, but it can be refactored for another approach.
                throw new InvalidFormatTriangleException("The sides informed form one triangle invalid.");

            FirstSide = firstSide;
            SecondSide = secondSide;
            ThirdSide = thirdSide;
            _triangleTypeCalculator = triangleTypeCalculator;
        }

        public double FirstSide { get; private set; }
        public double SecondSide { get; private set; }
        public double ThirdSide { get; private set; }
        public TriangleType Type => _triangleTypeCalculator.Calculate(FirstSide, SecondSide, ThirdSide);
        private ITriangleTypeCalculator _triangleTypeCalculator;
    }
}