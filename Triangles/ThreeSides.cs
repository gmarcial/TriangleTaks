namespace TaskTriangle.Triangles
{
    public class ThreeSides
    {
        public ThreeSides(
            double firstSide, 
            double secondSide, 
            double thirdSide)
        {
            FirstSide = firstSide;
            SecondSide = secondSide;
            ThirdSide = thirdSide;
        }
        
        public double FirstSide { get; }
        public double SecondSide { get; }
        public double ThirdSide { get; }
    }
}