using EnterpriseActions.Core;
using Xunit;

namespace EnterpriseActions.Core.Tests;

public class PlatformMessageTests
{
    [Fact]
    public void GetMessage_ReturnsExpectedValue()
    {
        Assert.Equal(
            "Enterprise GitHub Actions",
            PlatformMessage.GetMessage());
    }
}