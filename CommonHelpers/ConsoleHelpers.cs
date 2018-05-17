using System;

namespace CommonHelpers
{
    public static class ConsoleHelpers
    {
        public static string ReadFromConsole()
        {
            var attempts = 0;
            string returnString;
            do
            {
                returnString = Console.ReadLine();
                if (returnString.IsEmptyString())
                    Console.WriteLine("You've entered empty string. Please try again");
                else
                    break;
                attempts++;
            } while (attempts < 3);
            if (attempts >= 3)
                throw new Exception("You've reached max number of your attempts to enter a valid strings");
            return returnString;
        }
    }
}
