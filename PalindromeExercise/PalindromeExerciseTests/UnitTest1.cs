using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("talented", false)]
        [InlineData("deified", true)]
        [InlineData("tent", false)]
        public void IsAPalindrome(string input, bool expected)
        {
            // Arrange
             WordSmith challenger = new WordSmith();
            // Act
            var actual = challenger.IsAPalindrome(input);
            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
