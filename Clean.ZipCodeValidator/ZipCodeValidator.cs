using System.Text.RegularExpressions;

namespace Clean.ZipCodeValidator
{
    public static class ZipCodeValidator
    {
        public static bool Validate(string zipCode)
        {
            string zipCodeRegex = "^\\d{5}$";
            return Regex.IsMatch(zipCode, zipCodeRegex);
        }
    }
}
