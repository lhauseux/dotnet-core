using LH.Core.Errors;
using LH.Core.Results;
using LH.Core.UnitTests.Fakes.Errors;

namespace LH.Core.UnitTests.Results;

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