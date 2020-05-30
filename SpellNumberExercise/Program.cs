using System;

namespace SpellNumberExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            SpellNumber spellNumber = new SpellNumber();
            var result =spellNumber.FinalNumberToWord(23560);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
