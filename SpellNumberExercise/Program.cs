using System;

namespace SpellNumberExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            SpellNumber spellNumber = new SpellNumber();
            var result =spellNumber.FinalNumberToWord(345333);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
