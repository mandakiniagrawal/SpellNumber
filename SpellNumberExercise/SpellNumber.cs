using System;

namespace SpellNumberExercise
{
    class SpellNumber
    {
        public string NumberToWord(int num)
        {
            if (num == 0)
                return "Zero";

            if (num < 0)
                return "Not supported";

            else return string.Empty;
        }
    }
}