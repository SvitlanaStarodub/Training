using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hi, please enter integer from 0 to 100 ");
            var value = Console.ReadLine();
            int userNumber;
            var isValidNumber = int.TryParse(value, out userNumber);

            if (userNumber >= 0 && userNumber <= 100 && isValidNumber)
            {
                Console.WriteLine("Your integer is accepted. Your number is: " + userNumber);
              
            }
            else
            {
                Console.WriteLine("Your number is invalid. Please enter integer from 0 to 100");

            }

            if (IsUnique(userNumber))
            {
                Console.WriteLine($"Your {userNumber} is unique for our program! Congratulations on it!");
            }

            if (IsEven(userNumber))
            {
                Console.WriteLine("Your number is even!");
            }
            

            Console.ReadKey();


        }

        public static bool IsUnique(int userNumber)


        {
            return (userNumber == 11 || userNumber == 22 || userNumber == 67);
        }

        public static bool IsEven(int userNumber)
        {

            return userNumber % 2 == 0;

        }

    }

}



