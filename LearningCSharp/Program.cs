using System;

namespace LearningCSharp
{
    class Program
    {
        static void Main2(string[] args)
        {
            var senctanceCount = SentenceCounter(string.Join(string.Empty, args).ToCharArray());
            Console.WriteLine(senctanceCount);
        }
        
        private static void DisplaySentence(string[] sentence)
        {
            for (int i = 0, y = 2; i < sentence.Length; i++)
                Console.Write(sentence[i]);
            Console.WriteLine();
        }

        public static int SentenceCounter(char[] sentence)
        {
            int sentences = 0;

            for (int i = 0, y = 2; i < sentence.Length; y++, i++)
            {
                if (y < sentence.Length && (sentence[y] == '.' && sentence[y - 1] == '.' && sentence[y - 2] == '.'))
                {
                    sentences += 1;

                    Console.Write(sentence[y].ToString() + sentence[y].ToString() + sentence[y].ToString() + " ");
                    Console.WriteLine(y - 1);

                    i += 2;
                    y += 2;
                }
                else if (sentence[i] == '.' || sentence[i] == '?' || sentence[i] == '!')
                {
                    sentences += 1;
                }
            }

            return sentences;
        }
    }
}