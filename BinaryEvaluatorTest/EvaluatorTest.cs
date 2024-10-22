namespace BinaryEvaluatorTest;

public class EvaluatorTest
{
    [Fact]
    public void Test_GoodBinaryString_ReturnsTrue()
    {
        // Arrange
        string binaryString = "1100";

        // Act
        bool result = Evaluator.IsGoodBinaryString(binaryString);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void Test_BinaryStringWithMoreZerosThanOnes_ReturnsFalse()
    {
        // Arrange
        string binaryString = "0001";

        // Act
        bool result = Evaluator.IsGoodBinaryString(binaryString);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void Test_BinaryStringWithPrefixHavingMoreOnesThanZeros_ReturnsFalse()
    {
        // Arrange
        string binaryString = "1110";

        // Act
        bool result = Evaluator.IsGoodBinaryString(binaryString);

        // Assert
        Assert.False(result);
    }
}