using System;

namespace Utilities.Exceptions
{
    public class FileParseException : Exception
    {
        private const string DefaultMessage = "File {0} is not valid because of the line {1} (it's without digit)!";

        public FileParseException()
        {
        }

        public FileParseException(string fileName, int invalidRow)
            : base(string.Format(DefaultMessage, fileName, invalidRow))
        {
        }

        public FileParseException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}