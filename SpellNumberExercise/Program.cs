using System;

namespace SpellNumberExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            SpellNumber spellNumber = new SpellNumber();
            var result =spellNumber.NumberToWord(0);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
