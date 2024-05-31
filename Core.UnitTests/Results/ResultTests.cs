using HT.Core.Errors;
using HT.Core.Results;
using HT.Core.UnitTests.Fakes.Errors;

namespace HT.Core.UnitTests.Results;

public class UnitTest1
{
    [Fact]
    public void Create_Successful_Ok()
    {
        var exception = Record.Exception(Result.Success);
        Assert.Null(exception);
    }


    [Fact]
    public void Create_Failure_Ok()
    {
        var exception = Record.Exception(() => Result.Failure(FakeError.Error));
        Assert.Null(exception);
    }

    [Fact]
    public void Create_Failure_Exception()
    {
        var exception = Record.Exception(() => Result.Failure(Error.None));
        Assert.NotNull(exception);
    }
}