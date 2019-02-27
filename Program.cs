using System;

namespace TaskTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Descubra qual é o tipo do triangulo!");
            Console.WriteLine("Informe os tres lados que compoem seu triangulo:");
            
            Console.Write("O primeiro lado: ");
            var firstSide = decimal.Parse(Console.ReadLine());

            Console.Write("O segundo lado: ");
            var secondSide = decimal.Parse(Console.ReadLine());

            Console.Write("O terciero e ultimo lado: ");
            var thirdSide = decimal.Parse(Console.ReadLine());

            if(!((firstSide < (secondSide + thirdSide)) && (secondSide < (firstSide + thirdSide)) && (thirdSide < (firstSide + secondSide))))
            {
                Console.WriteLine("Os lados informados não formam um triangulo...");
                return;
            }

            if(firstSide == secondSide && firstSide == thirdSide && secondSide == thirdSide) Console.WriteLine("O tipo é equilatero");
            else if(firstSide != secondSide && firstSide != thirdSide && secondSide != thirdSide) Console.WriteLine("O tipo é escaleno");
            else Console.WriteLine("O tipo é isosceles");

            /*if(firstSide == secondSide && firstSide != thirdSide && secondSide != thirdSide || 
            secondSide == thirdSide && firstSide != secondSide && firstSide != thirdSide ||
            firstSide == thirdSide && firstSide != secondSide && secondSide != thirdSide) Console.WriteLine("Esosceles");*/

        }
    }
}
