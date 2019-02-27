using System;
using TaskTriangle.Triangles;
using TaskTriangle.Triangles.Factories;
using TaskTriangle.Triangles.TriangleTypeCalculators;

namespace Hey
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
            
            var threeSides = new ThreeSides(firstSide, secondSide, thirdSide);
            
            var triangleFactory = new TriangleFactory();
            var triangleTypeCalculator = new TriangleTypeCalculator();
            var triangle = triangleFactory.Create(threeSides, triangleTypeCalculator);
            
            Console.WriteLine(triangle.Types);
        }
    }
}
