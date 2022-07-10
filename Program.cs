using System;

namespace StringProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a word or phrase");
            string phrase = Console.ReadLine();
            Console.WriteLine("Please enter the word or characters that you would like to search for");
            Console.WriteLine("in the phrase that you just entered");
            string search = Console.ReadLine();
            Console.WriteLine( phrase.Contains(search));

        }
    }
}
 