using JaffaMania.Website.Extensions;
using Xunit;

namespace JaffaMania.Website.Tests.Extensions
{
    public class StringExtensions_Should
    {
        [Fact]
        [Trait("Unit Test", "Extensions")]
        public void ReturnTrueWhenGivenValidGuid()
        {
            //  Arrange
            const string validGuid = "ab38493a-7186-4ed0-8e65-7ef6e5c69744";

            //  Act
            var result = validGuid.IsValidGuid();
            
            //  Assert
            Assert.True(result);
        }


        [Fact]
        [Trait("Unit Test", "Extensions")]
        public void ReturnFalseWhenGivenEmptyString()
        {
            //  Arrange
            const string validGuid = "";

            //  Act
            var result = validGuid.IsValidGuid();

            //  Assert
            Assert.False(result);
        }


        [Fact]
        [Trait("Unit Test", "Extensions")]
        public void ReturnFalseWhenGivenStringWhichIsNotGuid()
        {
            //  Arrange
            const string validGuid = "test";

            //  Act
            var result = validGuid.IsValidGuid();

            //  Assert
            Assert.False(result);
        }

    }
}