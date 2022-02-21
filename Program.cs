using System;

namespace Kata17_Smooth_Sentences
{
    class Program
    {
        static void Main(string[] args)
        {
            IsSmooth("Marta appreciated deep perpendicular right trapezoids", true) ; // true

            IsSmooth("Someone is outside the doorway", false) ; // false

            IsSmooth("She eats super righteously", true) ; // true
        }

        private static bool IsSmooth(string smoothString, bool expected)
        {
            var smoothWords = smoothString.ToLower().Split(' ');
            bool actual = true;
            for (int i = 0; i < smoothWords.Length-1; i++)
            {
                var currentWord = smoothWords[i];
                var nextWord = smoothWords[i + 1];
                //If the last letter of currentword is not equal the first letter of the next word
                if (currentWord[currentWord.Length-1] != nextWord[0])
                {
                    //Not a smooth sentence
                    actual = false;
                    break;
                }
            }
            
            Console.WriteLine($"actual: {actual}, expected: {expected}, are same: {actual == expected}");
            return actual;
        }
    }
}
