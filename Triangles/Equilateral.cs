namespace TaskTriangle.Triangles
{
    public class Equilateral : ITriangle
    {
        public Equilateral(Triangle triangle) => Triangle = triangle;

        double ITriangle.FirstSide { get => Triangle.FirstSide; }
        double ITriangle.SecondSide { get => Triangle.SecondSide; }
        double ITriangle.ThirdSide { get => Triangle.ThirdSide;  }
        TriangleType ITriangle.Type { get => Triangle.Type;  }

        protected Triangle Triangle { get; private set; }

        //Possibles behavior this type of triangle
    }
}