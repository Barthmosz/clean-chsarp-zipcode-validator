using System.Text.RegularExpressions;

namespace Clean.ZipCodeValidator
{
    public static class ZipCodeValidator
    {
        /// <summary>
        /// Validates a zip code.
        /// </summary>
        /// <param name="zipCode"></param>
        /// <returns></returns>
        public static bool Validate(string zipCode)
        {
            string zipCodeRegex = "^\\d{5}$";
            return Regex.IsMatch(zipCode, zipCodeRegex);
        }
    }
}
