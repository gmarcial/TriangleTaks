using System;

namespace TaskTriangle.Triangles
{
    public class InvalidFormatTriangleException : Exception
    {
        public InvalidFormatTriangleException(string message) : base(message)
        {
        }
    }
}