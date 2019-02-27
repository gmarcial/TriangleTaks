using System;
using TaskTriangle.Triangles;

namespace TaskTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Descubra qual é o tipo do triangulo!");
            Console.WriteLine("Informe os tres lados que compoem seu triangulo:");
            
            Console.Write("O primeiro lado: ");
            var firstSide = double.Parse(Console.ReadLine());

            Console.Write("O segundo lado: ");
            var secondSide = double.Parse(Console.ReadLine());

            Console.Write("O terciero e ultimo lado: ");
            var thirdSide = double.Parse(Console.ReadLine());

            var triangleFactory = new TriangleFactory();
            var triangleTypeCalculator = new TriangleTypeCalculator();
            var triangle = triangleFactory.Create(firstSide, secondSide, thirdSide, triangleTypeCalculator);
            
            Console.WriteLine(triangle.Type);
        }
    }
}
