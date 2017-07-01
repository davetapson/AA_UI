using System;

namespace AA.Common
{
    public static class Guard
    {
        public static void AgainstNull(string item, string inputValue)
        {
            if (string.IsNullOrEmpty(inputValue)) throw new ArgumentException($"{item} is null or empty.");
        }
        public static void AgainstEmpty(string item, string inputValue)
        {
            if (string.IsNullOrEmpty(inputValue)) throw new ArgumentException($"{item} is null or empty.");
        }

        public static void AgainstNullEmptyWhiteSpace(string item, string inputValue)
        {
            if (string.IsNullOrEmpty(inputValue) || string.IsNullOrWhiteSpace(inputValue))
                throw new ArgumentException($"{item} is null or empty.");
        }

        public static void AgainstIncorrectLength(string item, string inputValue, int stringLength)
        {
            if (inputValue.Length > stringLength) throw new ArgumentException($"{item}  is too long.");
            if (inputValue.Length < stringLength) throw new ArgumentException($"{item}  is too short.");
        }

        public static void AgainstInvalidCharacters(string item, string inputString)
        {
            foreach (char c in inputString)
            {
                if (c < '0' || c > '9')
                    throw new ArgumentException($"{item}  contains invalid characters.");
            }
        }

        public static void AgainstInvalidDate(string item, string inputDateString)
        {         
            try
            {
                string dateString = inputDateString.Substring(0, 6);
                DateTime birthDate = DateTime.ParseExact(dateString, "yyMMdd", System.Globalization.CultureInfo.InvariantCulture);
            }
            catch
            {
                throw new ArgumentException($"{item}  contains invalid date.");
            }
        }
    }
}
