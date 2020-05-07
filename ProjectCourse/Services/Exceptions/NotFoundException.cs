using System;

namespace ProjectCourse.Services.Exceptions
{
    public class NotFoundException : ApplicationException
    {
        public NotFoundException(string msg) : base(msg)
        {
        }
    }
}
