using System;

namespace DomainDrivenDesign.Infra.Data
{
    public static class StringExtensionMethods
    {
        public static int IndexOfIgnoringNullAndEmpty(this String currentString, string value)
        {
            int failResultCode = -1;

            if (string.IsNullOrWhiteSpace(currentString))
            {
                return failResultCode; 
            }

            if (String.IsNullOrWhiteSpace(value))
            {
                return failResultCode;
            }

            return currentString.IndexOf(value, StringComparison.OrdinalIgnoreCase);
        }
    }
}
