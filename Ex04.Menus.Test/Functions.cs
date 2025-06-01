using System;

namespace Ex04.Menus.Test
{
    public class Functions
    {
        public void ShowVersion()
        {
            Console.WriteLine("App Version 25.2.4.4480");
        }

        public void CountLowerLetters()
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();
            int count = 0;
            foreach (char c in input)
            {
                if (char.IsLower(c))
                {
                    count++;
                }
            }

            Console.WriteLine($"Number of small letters: {count}");
        }

        public void ShowCurrentDate()
        {
            Console.WriteLine($"Current date: {DateTime.Now.ToShortDateString()}");
        }

        public void ShowCurrentTime()
        {
            Console.WriteLine($"Current time: {DateTime.Now.ToShortTimeString()}");
        }
    }
}
