using System;

namespace TaskTriangle.Triangles
{
    public class Triangle : ITriangle
    {
        public Triangle(
            double firstSide, 
            double secondSide, 
            double thirdSide)
        {
            if(!((firstSide < (secondSide + thirdSide)) && (secondSide < (firstSide + thirdSide)) && (thirdSide < (firstSide + secondSide)))) 
                throw new InvalidFormatTriangleException("The sides informed form one triangle invalid.");

            FirstSide = firstSide;
            SecondSide = secondSide;
            ThirdSide = thirdSide;
        }

        public double FirstSide { get; private set; }
        public double SecondSide { get; private set; }
        public double ThirdSide { get; private set; }
        public TriangleType Type => CalculateType();

        private TriangleType CalculateType()
        {
            if(FirstSide == SecondSide && FirstSide == ThirdSide && SecondSide == ThirdSide) return TriangleType.Equilateral;
            else if(FirstSide != SecondSide && FirstSide != ThirdSide && SecondSide != ThirdSide) return TriangleType.Scalene;
            else return TriangleType.Isosceles;
        }
    }
}