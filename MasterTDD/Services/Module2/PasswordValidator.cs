namespace MasterTDD.Services.Module2
{
    public class PasswordValidator
    {
        public bool ValidatePassword(string password)
        {
            if (password.Length < 8)
                throw new ArgumentException();

            var hasLowerCase = false;
            var hasUderscore = false;
            var hasNumber = false;
            var hasUppercase = false;
            foreach (var character in password)
            {
                if (char.IsLower(character))
                    hasLowerCase = true;

                if (character == '_')
                    hasUderscore = true;

                if (char.IsDigit(character))
                    hasNumber = true;

                if (char.IsUpper(character))
                    hasUppercase = true;
            }

            return hasLowerCase && hasUderscore && hasNumber && hasUppercase;
        }
    }
}
