namespace Validator
    {
        public class ValidatorForExecutable
        {
            public static bool ValidateUsername(string username)
            {
                return username.Length >= 2;
            }

            public static bool ValidateFirstName(string firstName)
            {
                return firstName.Length >= 2;
            }

            public static bool ValidateSurname(string surname)
            {
                return surname.Length >= 2;
            }

            public static bool ValidatePassword(string password)
            {
                if (password.Length < 8)
                    return false;

                bool isUpperCase = false;
                bool isLowerCase = false;
                bool isDigit = false;
                bool isSymbol = false;

                foreach (char code in password)
                {
                    if (char.IsUpper(code)) isUpperCase = true;
                    else if (char.IsLower(code)) isLowerCase = true;
                    else if (char.IsDigit(code)) isDigit = true;
                }

                return isUpperCase && isLowerCase && isDigit;
            }

            public static bool ValidateAge(int age)
            {
                return age >= 0;
            }

            public static bool ValidateBirthDate(DateTime birthDate)
            {
                return birthDate.Year >= 1970;
            }
        }
    }
