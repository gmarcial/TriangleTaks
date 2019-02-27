using System;

namespace TaskTriangle.Triangles
{
    public class TriangleFactory
    {
        private Triangle _triangle { get; set; }
        public ITriangle Create(
            double firstSide, double secondSide, double thirdSide, ITriangleTypeCalculator triangleTypeCalculator)
        {
            _triangle = new Triangle(firstSide, secondSide, thirdSide, triangleTypeCalculator);

            if(_triangle.Type == TriangleType.Equilateral) return new Equilateral(_triangle);
            else if(_triangle.Type == TriangleType.Scalene) return new Scalene(_triangle);
            else if(_triangle.Type == TriangleType.Isosceles) return new Isosceles(_triangle);
            else throw new FormatTriangleNotFindException("Format triangle not yet implemented or find.");
        }
    }
}