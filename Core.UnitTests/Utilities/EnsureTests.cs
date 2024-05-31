using HT.Core.Utilities;

namespace HT.Core.UnitTests.Utilities;

public class EnsureTests
{
    [Fact]
    public void NotEmpty_NotEmpty_NoError()
    {
        var exception = Record.Exception(() => Ensure.NotEmpty("value", "message", "argumentName"));
        Assert.Null(exception);
    }

    [Fact]
    public void NotEmpty_Empty_Error()
    {
        var exception = Record.Exception(() => Ensure.NotEmpty(string.Empty, "message", "argumentName"));
        Assert.NotNull(exception);
    }

    [Fact]
    public void NotEmpty_Guid_NoError()
    {
        var exception = Record.Exception(() => Ensure.NotEmpty(Guid.NewGuid(), "message", "argumentName"));
        Assert.Null(exception);
    }


    [Fact]
    public void NotEmpty_EmptyGuid_Error()
    {
        var exception = Record.Exception(() => Ensure.NotEmpty(Guid.Empty, "message", "argumentName"));
        Assert.NotNull(exception);
    }


    [Fact]
    public void NotEmpty_DateTime_NoError()
    {
        var exception = Record.Exception(() => Ensure.NotEmpty(DateTime.Today, "message", "argumentName"));
        Assert.Null(exception);
    }


    [Fact]
    public void NotEmpty_EmptyDateTime_Error()
    {
        var exception = Record.Exception(() => Ensure.NotEmpty((DateTime)default, "message", "argumentName"));
        Assert.NotNull(exception);
    }

    [Fact]
    public void NotNull_NotNull_NoError()
    {
        var exception = Record.Exception(() => Ensure.NotNull(new object(), "message", "argumentName"));
        Assert.Null(exception);
    }

    [Fact]
    public void NotNull_Null_Error()
    {
        var exception = Record.Exception(() => Ensure.NotNull<object?>(null, "message", "argumentName"));
        Assert.NotNull(exception);
    }
}