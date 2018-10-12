using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace Chapter_8_NumeralSystems.Problems12and13
{
    class NumericManager
    {
        public void ValidateArabicNumber(int arabic)
        {
            if (arabic < 1 || arabic > 3999)
            {
                throw new InvalidDataException("Must be in the interval [1-3999]!");
            }
        }

        public string FromArabicToRoman(int number)
        {
            var roman = new StringBuilder();

            foreach (var item in NumericData.NumberRomanDictionary)
            {
                while (number >= item.Key)
                {
                    roman.Append(item.Value);
                    number -= item.Key;
                }
            }

            return roman.ToString();
        }

        public int FromRomanToArabic(string roman)
        {
            int total = 0;

            int current, previous = 0;
            char currentRoman, previousRoman = '\0';

            for (int i = 0; i < roman.Length; i++)
            {
                currentRoman = roman[i];

                previous = previousRoman != '\0' ? NumericData.RomanNumberDictionary[previousRoman] : '\0';
                current = NumericData.RomanNumberDictionary[currentRoman];

                if (previous != 0 && current > previous)
                {
                    total = total - (2 * previous) + current;
                }
                else
                {
                    total += current;
                }

                previousRoman = currentRoman;
            }

            return total;
        }

        public void ValidateRomanNumber(string roman)
        {
            if (!Regex.IsMatch(roman, "(^(?=[MDCLXVI])M*(C[MD]|D?C{0,3})(X[CL]|L?X{0,3})(I[XV]|V?I{0,3})$)"))
            {
                throw new InvalidDataException("Invalid roman number!");
            }
        }
    }
}