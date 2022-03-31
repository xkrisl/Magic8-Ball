using System;

namespace Magic8_Ball
{
    internal class Program
    {
        public static int randomNumber;
        public static string textOutput;
        public static ConsoleColor foregroundColor;
        static void Main(string[] args)
        {
            // I hate using \n. But, it's better than having multiple WriteLines I guess.
            while (true)
            {
                try
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("Would you like some advice from the magical 8-Ball?\nIf so, type 'Yes'.\n\n");

                    GenerateNumber();

                    if (Console.ReadLine() == "Yes")
                    {
                        TextArray();
                        TextColor();

                        Console.WriteLine($"\n\n{textOutput}\n\n");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.WriteLine("\n\nOops, I cannot accept that answer. Please try again.\n\n");
                    }
                }
                catch (Exception EX)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"\n\n{EX.Message}\n\n");
                    Console.ReadLine();
                }
            }
        }
        public static void GenerateNumber()
        {
            // Let's get our random int for the text array.
            Random random = new Random();
            randomNumber = random.Next(0, 19);
        }
        public static void TextArray()
        {
            // Doing this since it's much cleaner than a massive switch case, imo.
            string[] eightBallList = new string[]
            {
                "It is certain.",
                "It is decidedly so.",
                "Without a doubt.",
                "Yes, definitely.",
                "You may rely on it.",
                "As I see it, yes.",
                "Most likely.",
                "Outlook good.",
                "Yes.",
                "Signs point to yes.",
                "Reply hazy, try again.",
                "Ask again later.",
                "Better not tell you now.",
                "Cannot predict now.",
                "Concentrate and ask again.",
                "Don't count on it.",
                "My reply is no.",
                "My sources say no.",
                "Outlook not so good.",
                "Very doubtful."
            };

            textOutput = eightBallList[randomNumber];
        }
        public static void TextColor()
        {
            // So I don't have to manually apply colors for 20 different outputs.
            try
            {
                if (randomNumber >= 15)
                {
                    foregroundColor = Console.ForegroundColor = ConsoleColor.Red;

                }
                else
                {
                    if (randomNumber >= 10)
                    {
                        foregroundColor = Console.ForegroundColor = ConsoleColor.DarkYellow;
                    }
                    else
                    {
                        foregroundColor = Console.ForegroundColor = ConsoleColor.Green;
                    }
                }
            }
            catch (Exception EX)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"\n\n{EX.Message}\n\n");
                Console.ReadLine();
            }
        }
    }
}
