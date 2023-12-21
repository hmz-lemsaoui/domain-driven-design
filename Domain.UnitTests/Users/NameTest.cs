using Domain.Users;
using System.ComponentModel.DataAnnotations;

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

    }
}