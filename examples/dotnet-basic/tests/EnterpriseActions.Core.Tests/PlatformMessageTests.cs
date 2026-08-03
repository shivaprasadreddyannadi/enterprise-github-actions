using EnterpriseActions.Core;

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