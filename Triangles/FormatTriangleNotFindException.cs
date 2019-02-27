using System;

namespace TaskTriangle.Triangles
{
    public class FormatTriangleNotFindException : Exception
    {
        public FormatTriangleNotFindException(string message) : base(message)
        {
        }
    }
}