using HT.Core.Errors;

namespace HT.Core.Exceptions;

public class DomainException : Exception
{
    public Error Error { get; }

    public DomainException(Error error)
        : base(error.Message)
    {
        Error = error;
    }
}