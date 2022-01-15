using System;

namespace _string_
{
    class Program
    {
        //Gotta do it the c++ way you know :)
        static int Main(string[] args)
        {
            string? SstringS = "string";
            Console.Write("Welcome to string!\nEnter a word to begin: ");
            while (SstringS != null)
            {
                int i = 0;
                SstringS = Console.ReadLine();
                if(i != 0)
                {
                    Console.WriteLine("Enter a word: ");
                }
                i++;
                #pragma warning disable CS8604
                DaString(SstringS);
            }
            
            return 0;
        }

        static void DaString(string Word)
        {
            Word = Word.ToLower();
            Console.WriteLine("Length: " + Word.Length);
            Console.Write("This are the letters its made from: ");
            char[] word = Word.ToCharArray();
            for (int i = 0; i < Word.Length; i++)
            {
                char c = word[i];
                if (i != Word.Length - 1)
                {
                    Console.Write(c + " ");
                }
                else
                {
                    Console.WriteLine(c + " ");
                }
                
            }
            Console.Write("In alphabetical order: ");
            Array.Sort(word);
            Console.WriteLine(word);
            Console.Write("In reverse alphabetical: ");
            for (int i = word.Length - 1; i >= 0; i--)
            {
                if (i != 0)
                {
                    Console.Write(word[i]);
                }
                else
                {
                    Console.WriteLine(word[i]);
                }
            }
            Console.Write("In reverse: ");
            for(int i = Word.Length - 1; i >= 0; i--)
            {
                if(i != 0)
                {
                    Console.Write(Word[i]);
                }
                else
                {
                    Console.WriteLine(Word[i]);
                }
            }
            Environment.Exit(0);
        }
    }
}
