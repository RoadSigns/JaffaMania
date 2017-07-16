using System;

namespace JaffaMania.Website.Extensions
{
    public static class StringExtensions
    {
        public static bool IsValidGuid(this string inputString)
        {
            var isValidGuid = Guid.TryParse(inputString, out Guid _);
            return isValidGuid;
        }
    }
}