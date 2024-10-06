using MasterTDD.Services.Module2;
using FluentAssertions;

namespace MasterTDD.UnitTests.Services.Module2
{
    public class PasswordValidationShould
    {
        private readonly PasswordValidator _passwordValidator;

        public PasswordValidationShould()
        {
            _passwordValidator = new PasswordValidator();
        }

        [Theory]
        [InlineData("aT9_coi")]
        [InlineData("aTf1_c")]
        [InlineData("poT2_c")]
        public void ThrowArgumentExceptionForShortPassword(string password)
        {
            Action result = () => _passwordValidator.ValidatePassword(password);

            result.Should().Throw<ArgumentException>();
        }

        [Theory]
        [InlineData("aBCDE@_123")]
        [InlineData("bBCDE@_83")]
        [InlineData("cBERE@_123")]
        public void BeValid(string password)
        {
            var result = _passwordValidator.ValidatePassword(password);

            result.Should().BeTrue();
        }

        [Theory]
        [InlineData("ABCDE@_123")]
        [InlineData("ABCDE@_83")]
        [InlineData("ABERE@_123")]
        public void BeInvalidWithNoLowercase(string password)
        {
            var result = _passwordValidator.ValidatePassword(password);

            result.Should().BeFalse();
        }

        [Theory]
        [InlineData("aBERE123")]
        [InlineData("cBERE1253")]
        [InlineData("iBERE19953")]
        public void BeInvalidWithNoUnderscore(string password)
        {
            var result = _passwordValidator.ValidatePassword(password);

            result.Should().BeFalse();
        }

        [Theory]
        [InlineData("aBERE_cfdfv")]
        [InlineData("cBERE_cdvfsw")]
        [InlineData("iBERE_cmjdi")]
        public void BeInvalidWithNoNumber(string password)
        {
            var result = _passwordValidator.ValidatePassword(password);

            result.Should().BeFalse();
        }

        [Theory]
        [InlineData("a545_cfdfv")]
        [InlineData("c89748970_cdvfsw")]
        [InlineData("i584121_cmjdi")]
        public void BeInvalidWithNoUppercase(string password)
        {
            var result = _passwordValidator.ValidatePassword(password);

            result.Should().BeFalse();
        }
    }
}
