using FormValidationExample.Checkers;
using Xunit;

namespace FromValidationExample.Tests.Checkers
{
    public class NamingConventionCheckerTests
    {
        private NamingConventionChecker checker;

        public NamingConventionCheckerTests() {
            checker = new NamingConventionChecker();
        }


        [Fact]
        public void ShouldFailOnEmptyOrNull() {

            Assert.False(checker.IsValidName(""));
            Assert.False(checker.IsValidName(null));
        }

        [Fact]
        public void ShouldFailWhenContainingWhiteSpace() {
            Assert.False(checker.IsValidName("Some text"));
        }

        [Fact]
        public void ShoulFailWhenStartingWithDigitOrOtherNonLetter() {
            Assert.False(checker.IsValidName("1Signal"));

        }

        [Fact]
        public void ShouldPassWithLetterOnlyWord() {
            Assert.True(checker.IsValidName("Signal"));
        }
        [Fact]
        public void ShouldPassWithLetterAndUnderscoreOrNumbersInTheMiddle()
        {
            Assert.True(checker.IsValidName("Signal_Name"));
            Assert.True(checker.IsValidName("Signal_1Name"));
        }


    }
}
