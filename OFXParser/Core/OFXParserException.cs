using System;

namespace OFXParser.Core
{
    class OFXParserException : Exception
    {
        public OFXParserException(String message) : base(message)
        {

        }

        public OFXParserException(String message, Exception innerException) : base(message, innerException)
        {

        }
    }
}
