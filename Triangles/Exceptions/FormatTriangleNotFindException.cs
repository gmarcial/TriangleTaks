using System;

namespace TaskTriangle.Triangles.Exceptions
{
    public class FormatTriangleNotFindException : Exception
    {
        public FormatTriangleNotFindException(string message) : base(message)
        {
        }
    }
}