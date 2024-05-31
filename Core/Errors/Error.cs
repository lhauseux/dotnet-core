
namespace HT.Core.Errors;

public class Error : ValueObject
{
    public string Code { get; }
    public string Message { get; }

    public Error(string code, string message)
    {
        Code = code;
        Message = message;
    }

    protected override IEnumerable<object> GetAtomicValues()
    {
        yield return Code;
        yield return Message;
    }

    public static Error None => new(string.Empty, string.Empty);
}