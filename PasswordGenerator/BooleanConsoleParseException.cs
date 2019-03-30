using System;

namespace PasswordGenerator
{
    public class BooleanConsoleParseException : SystemException
    {
        public BooleanConsoleParseException(string message)
            : base(message)
        {
            Console.WriteLine(message);
        }
    }
}