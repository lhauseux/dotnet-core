
using HT.Core.Errors;

namespace HT.Core.UnitTests.Fakes.Errors;

public static class FakeError
{
    public static Error Error => new("Error.code", "Error.message");
}