using TaskTriangle.Triangles.Interfaces;

namespace TaskTriangle.Triangles
{
    public class Isosceles : ITriangle
    {
        internal Isosceles(Triangle triangle) => Triangle = triangle;


        ThreeSides ITriangle.ThreeSides => Triangle.ThreeSides;
        TriangleTypes ITriangle.Types { get => Triangle.Types;  }

        private Triangle Triangle { get; }

        //Possibles behavior this type of triangle
    }
}