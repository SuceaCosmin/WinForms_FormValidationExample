using System.Text.RegularExpressions;


namespace FormValidationExample.Checkers
{
    public class NamingConventionChecker
    {
        public bool IsValidName(string value) {

            if (string.IsNullOrEmpty(value)) {
                return false;
            }

            if (value.Contains(" ")) {
                return false;
            }

            Regex regex = new Regex(@"^[a-zA-Z]([a-zA-Z0-9_]+)");
            return regex.IsMatch(value);
        }
    }
}
