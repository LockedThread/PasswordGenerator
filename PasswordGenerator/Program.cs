using System;

namespace PasswordGenerator
{
    internal class Program
    {
        public static char[] Symbols =
            {'~', '`', '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '_', '-', '+', '='};

        public static char[] Alphanumeric =
        {
            'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u',
            'v', 'w', 'x', 'y', 'z', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9'
        };

        private static void Main()
        {
            Console.WriteLine(
                "Welcome to my First C# Program\nYou may use this program to create complex passwords using efficient methods.\n");

            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Title = "First C# Program | Password Generator";

            Console.WriteLine("Do you want your password to be alphanumeric?(y/n)");
            var isAlphanumeric = ParseBoolean(Console.ReadLine());

            Console.WriteLine("Do you want to have Symbols in your password?(y/n)");
            var isSymbolical = ParseBoolean(Console.ReadLine());

            Console.WriteLine("How long do you want your password to be?(integer)");
            var length = int.Parse(Console.ReadLine());

            var random = new Random();

            var password = new Password(length, isAlphanumeric, isSymbolical);
            Console.WriteLine("Password: " + password.CreatePassword(random));
            Console.WriteLine(
                "Press ENTER to generate another password with the same profile. Press anything else to close.");
            while (!(Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Enter))
                if (Console.ReadKey(true).Key == ConsoleKey.Enter)
                    Console.WriteLine("Password: " + password.CreatePassword(random));
                else
                    Environment.Exit(1);
        }

        private static bool ParseBoolean(string input)
        {
            if (input.Equals("y", StringComparison.OrdinalIgnoreCase)) return true;
            if (input.Equals("n", StringComparison.OrdinalIgnoreCase)) return false;

            throw new BooleanConsoleParseException("Unable to parse \"" + input + "\" as y or n");
        }
    }
}