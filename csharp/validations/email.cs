using System.Text.RegularExpressions;

namespace Validations
{
	static class EmailValidation
	{
		private static bool IsEmailValido(string email)
        {
            var emailPattern = @"^[a-zA-Z0-9._-]+@[a-zA-Z0-9]+(\.[a-zA-Z0-9]+)*(\.[a-zA-Z]{2,6})$";
            var regex = new Regex(emailPattern);

            return regex.IsMatch(email);
        }
    }
}