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

            var triangle = new Triangle(firstSide, secondSide, thirdSide);
            
            Console.WriteLine(triangle.Type);
        }
    }
}
