using Domain.Users;
using FluentAssertions;

namespace Domain.UnitTests.Users;

public class NameTest
{
    [Theory]
    [InlineData("")]
    [InlineData(null)]
    public void Constructor_Shoud_ThrowArgumentException_WhenValueIsInvalid(string? value)
    {
        Name Action() => new(value);

        // Assert 
        FluentActions.Invoking(Action).Should().ThrowExactly<ArgumentException>()
            .Which.ParamName.Should().Be("value");

    }
}