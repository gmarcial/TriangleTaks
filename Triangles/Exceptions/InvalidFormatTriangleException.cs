using System;

namespace TaskTriangle.Triangles.Exceptions
{
    public class InvalidFormatTriangleException : Exception
    {
        public InvalidFormatTriangleException(string message) : base(message)
        {
        }
    }
}