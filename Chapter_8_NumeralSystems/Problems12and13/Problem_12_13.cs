using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using Chapter_8_NumeralSystems.Problems12and13;
using Utilities;

namespace Chapter_8_NumeralSystems.Problem12
{
    class Problem_12_13:Problem
    {
        public override void Run()
        {
            NumericManager manager = new NumericManager();

            try
            {
                int arabic = EnterArabicNumber();
                manager.ValidateArabicNumber(arabic);

                DisplayTheResult(manager, arabic);

                string roman = EnterRomanNumber();
                manager.ValidateRomanNumber(roman);

                DisplayTheResult(manager, roman);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private void DisplayTheResult(NumericManager manager, string roman)
        {
            Writer.WriteLine($"The arabic equivalent is equal to: {manager.FromRomanToArabic(roman)}");
        }

        private void DisplayTheResult(NumericManager manager, int arabic)
        {
            Writer.WriteLine($"The roman equivalent is equal to: {manager.FromArabicToRoman(arabic)}");
        }

        private string EnterRomanNumber()
        {
            Writer.WriteLine("Please enter an roman number:");
            return Reader.ReadLine().Trim();
        }

        private int EnterArabicNumber()
        {
            Writer.WriteLine("Please enter an arabic number in interval [1-3999]:");
            return int.Parse(Reader.ReadLine());
        }
    }
}
