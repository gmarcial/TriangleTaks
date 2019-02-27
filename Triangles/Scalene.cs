using TaskTriangle.Triangles.Interfaces;

namespace TaskTriangle.Triangles
{
    public class Scalene : ITriangle
    {
        internal Scalene(Triangle triangle) => Triangle = triangle;


        ThreeSides ITriangle.ThreeSides => Triangle.ThreeSides;
        TriangleTypes ITriangle.Types { get => Triangle.Types;  }

        private Triangle Triangle { get; }

        //Possibles behaviors this type of triangle
    }
}