using LH.Results.Errors;

namespace LH.Core.Exceptions;

public class DomainException : Exception
{
    public Error Error { get; }

    public DomainException(Error error)
        : base(error.Message)
    {
        Error = error;
    }
}