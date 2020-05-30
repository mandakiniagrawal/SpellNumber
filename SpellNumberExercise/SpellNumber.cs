using System;

namespace SpellNumberExercise
{
    public class SpellNumber
    {
        public string FinalNumberToWord(int num)
        {
            return NumberToWord(num).Trim();
        }
        public string NumberToWord(int num)
        {
            if (num == 0)
                return "Zero";

            if (num < 0)
                return "Not supported";

            var words = "";
            string[] strones = { "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
            string[] strtens = { "Twenty", "Thirty", "Fourty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };

            int thousands = 0, hundreds = 0, tens = 0, single = 0;
            thousands = num / 1000;
            num -= thousands * 1000;
            hundreds = num / 100;
            num -= hundreds * 100;
            if (num > 19)
            {
                tens = num / 10; num = num - tens * 10;
            }
            single = num;

            if (thousands > 0)
            {
                if (thousands > 19)
                    words += NumberToWord(thousands) + "Thousand ";
                else
                    words += strones[thousands - 1] + " Thousand ";
            }

            if (hundreds > 0)
                words += strones[hundreds - 1] + " Hundred ";

            if (tens > 0)
                words += strtens[tens - 2] + " ";

            if (single > 0)
                words += strones[single - 1] + " ";

            return words;
        }
    }
}