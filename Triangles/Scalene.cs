namespace TaskTriangle.Triangles
{
    public class Scalene : ITriangle
    {
        public Scalene(Triangle triangle) => Triangle = triangle;

        double ITriangle.FirstSide { get => Triangle.FirstSide; }
        double ITriangle.SecondSide { get => Triangle.SecondSide; }
        double ITriangle.ThirdSide { get => Triangle.ThirdSide;  }
        TriangleType ITriangle.Type { get => Triangle.Type;  }

        protected Triangle Triangle { get; private set; }

        //Possibles behaviors this type of triangle
    }
}