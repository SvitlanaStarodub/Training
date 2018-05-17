using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using CommonHelper;

namespace HomeWork5Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            #region MyRegion

            //Task 1
            //string[] simpleArray = {"Have", "a", "nice", "day","!"};
            //for (int i =0; i< simpleArray.Length; i++)
            //{
            //    Console.WriteLine($"\t {simpleArray[i]}");

            //как вывести массив в одну строку?

            #endregion

            #region Task2

            //Task 2 version1
            //int[] numbersArray = { 10, 20, 30, 40, 50 };
            //int lastNumberIs = numbersArray[4];
            //Console.WriteLine(numbersArray[4]);

            //Task 2 version 2
            //int[] arrayAndLoop = { 10, 20, 30, 40, 50 };

            //for (int i = arrayAndLoop.Length - 1; i >= 0; --i)
            //{
            //    Console.WriteLine(arrayAndLoop[i]);
            //    break;
            //}

            //Console.WriteLine(arrayAndLoop.Any());


            #endregion

            #region Task1

            //List<int> listOfNumbers = new List<int>();

            //while (true)
            //{
            //    Console.WriteLine("Enter your number");
            //    var userNumber = Console.ReadLine();
            //    int newNumber;
            //    var verifiedUserNumber = int.TryParse(userNumber, out newNumber);

            //    if(!verifiedUserNumber)
            //        Console.WriteLine("You entered not a number");
            //    else
            //    listOfNumbers.Add(newNumber);

            //    Console.WriteLine("Would you like to continue? (yes/no)");

            //    if (Console.ReadLine() == "no")
            //    {
            //        break;
            //    }

            //}

            //string numbers = string.Join(", ", listOfNumbers); 
            //Console.WriteLine($"Here is list of a numbers {numbers}.");


            #endregion

            #region Task5
            var users = new Dictionary<string, string>
            {
                {"Alisa", "111" }
            };

            var stuff = new Dictionary<string, int>
            {
                {"Backpack", 2},
                {"Tent", 3},
                {"Battery", 4}
            };



            Shop shop = new Shop(users, stuff);


            while (true)
            {

                Console.WriteLine("Hi, are you authorized user? (Yes/No)");
                var authorized = ConsoleHelpers.ReadFromConsole();
                bool success = false;
                if (authorized?.ToLower() == "no")
                {
                    AuthorizeUser(shop);
                    success = true;
                    Console.WriteLine("you successfully logged in");
                }
                    
                else
                {
                    int numberAttempts = 0;
                    while (numberAttempts < 3)
                    {
                        success = LoginUser(shop);

                        if (success)
                        {
                            Console.WriteLine("you successfully logged in");
                            break;
                        }

                    Console.WriteLine("User name or Password is incorrect. Try again");
                    numberAttempts++;

                    }
                }
                if (success)
                {
                    string order;
                    int amount;
                    int numberAttemptsOrder = 0;
                    while (numberAttemptsOrder < 3)
                        
                    {
                        var clientOrderSuccess = Order(shop, out order, out amount);
                        if (clientOrderSuccess)
                        {
                            Console.WriteLine("Order is submitted");

                            break;
                        }
                        Console.WriteLine(
                            $"Please check your order : {order}, {amount}. Something went wrong, check amount or stuff name.");
                        numberAttemptsOrder++;
                    }
                }




                Console.WriteLine("Do you want to exit (Yes/No)");
                var exit = Console.ReadLine();
                if (exit?.ToLower() == "yes")
                    break;
            }


            Console.ReadKey();
        }

        static void AuthorizeUser(Shop shop)
        {
            Console.WriteLine("Let's create your account. Please enter your name");
            
            int attemptsTologin = 0;
            bool isUserValid = false;
            var newClientName = "";
            do
            {
                newClientName = ConsoleHelpers.ReadFromConsole();
                if (shop.getUsers().Contains(newClientName))
                    Console.WriteLine("This user is existed. Please choose another one.");

                else
                {
                    isUserValid = true;
                    break;
                }
                attemptsTologin++;

            } while (attemptsTologin < 3);
            if (!isUserValid)
                throw new ArgumentException("You haven't entered valid user.");
            
                
            

            Console.WriteLine("Enter your password");
            var newClientPassword = Console.ReadLine();

            shop.AddClient(newClientName, newClientPassword);
        }

        static bool LoginUser(Shop shop)
        {
            Console.WriteLine("Welcome to the shop. Please enter your name");
            var userName = Console.ReadLine();

            Console.WriteLine("Welcome to the shop. Please enter your password");
            var password = Console.ReadLine();

            return shop.Login(userName, password);
        }

        static bool Order(Shop shop, out string order, out int amount)
        {
            Console.WriteLine($"What do you want to order: Backpack, Battery, Tent?");
            order = Console.ReadLine().Trim();

            Console.WriteLine("Enter item quantity");
            amount = int.Parse(Console.ReadLine().Trim());

            return shop.OrderStuff(order, amount);

        }

        #endregion
    }
}

   

