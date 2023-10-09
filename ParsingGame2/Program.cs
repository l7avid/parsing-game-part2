using System.Text.RegularExpressions;

namespace ParsingGame2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\david.reina\Documents\Personal Devs\Ruta N Udemy - C#\24 - Parse Fame Assignment 2\input2.txt";
            string text = File.ReadAllText(path);
            string pattern = @"\d{2,3}";
            var numbers = Regex.Matches(text, pattern);

            foreach (Match match in numbers)
            {
                int numbersInt = int.Parse(match.Groups[0].Value);
                Console.WriteLine((char)numbersInt);
            }
        }
    }
}