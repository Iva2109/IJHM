using Xunit;
using IJHM.StringManipulator; 

public class StringManipulatorTests
{
    [Fact]
    public void ReverseString_ShouldReturnReversedString()
    {
        // Arrange
        var stringManipulator = new StringManipulator();
        string input = "hello";
        string expected = "olleh";

        // Act
        string result = stringManipulator.ReverseString(input);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void RemoveSpaces_ShouldReturnStringWithoutSpaces()
    {
        // Arrange
        var stringManipulator = new StringManipulator();
        string input = "h e l l o";
        string expected = "hello";

        // Act
        string result = stringManipulator.RemoveSpaces(input);

        // Assert
        Assert.Equal(expected, result);
    }
}
