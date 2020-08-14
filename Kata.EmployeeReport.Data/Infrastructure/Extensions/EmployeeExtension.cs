using System;
using System.Collections.Generic;
using System.Text;

namespace Kata.EmployeeReport.Data.Infrastructure.Extensions
{
    public static class EmployeeExtension
    {
        public static string ToUpperFirstLetter(this string employeeName)
        {
            if (string.IsNullOrEmpty(employeeName))
                return string.Empty;
            char[] letters = employeeName.ToCharArray();
            letters[0] = char.ToUpper(letters[0]);
            return new string(letters);
        }
    }
}
