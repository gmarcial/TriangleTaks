using TaskTriangle.Triangles.Exceptions;
using TaskTriangle.Triangles.Interfaces;
using TaskTriangle.Triangles.TriangleTypeCalculators.Interfaces;

namespace TaskTriangle.Triangles.Factories
{
    public class TriangleFactory
    {
        private Triangle _triangle { get; set; }
        public ITriangle Create(
            ThreeSides threeSides, ITriangleTypeCalculator triangleTypeCalculator)
        {
            _triangle = new Triangle(threeSides, triangleTypeCalculator);

            switch (_triangle.Types)
            {
                case TriangleTypes.Equilateral:
                    return new Equilateral(_triangle);
                case TriangleTypes.Scalene:
                    return new Scalene(_triangle);
                case TriangleTypes.Isosceles:
                    return new Isosceles(_triangle);
                default:
                    throw new FormatTriangleNotFindException("Format triangle not yet implemented or find.");
            }
        }
    }
}