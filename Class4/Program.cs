using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            //Task 1
            // 1)	You have string array {"apple", "avocado", "banana", "apricot", "jackfruit", "cherimoya", "papaya", "pineapple", "lime", "lemon", "grape", "orange", "grapefruit", "strawberry" }. 
            //Please bring the value which are not contains “ap” to the console.
            //Implementation

            //string[] arrayFruits =
            //{
            //    "apple", "avocado", "banana", "apricot", "jackfruit", "cherimoya", "papaya", "pineapple", "lime",
            //    "lemon", "grape", "orange", "grapefruit", "strawberry"
            //};

            //foreach (var fruit in arrayFruits)
            //{
            //    if (fruit.Contains("ap"))
            //    {
            //        continue;
            //    }
            //    else
            //    {
            //        Console.WriteLine(fruit);
            //    }
            //}
            #endregion

            #region
            //Task 1 B 

            //Console.WriteLine("additional sub-task");
            //string[] arrayFruitsUpperCase =
            //{
            //    "Apple", "Avocado", "Banana", "Apricot", "Jackfruit", "Cherimoya", "Papaya", "Pineapple", "Lime",
            //    "Lemon", "Grape", "Orange", "Grapefruit", "Strawberry"
            //};


            //foreach (var fruit in arrayFruits)
            //{
            //    if (!fruit.ToLower().Contains("ap")) 
            //    Console.WriteLine(fruit);
            //}

            //var selectedFruits = arrayFruits.Where(fruit => !fruit.Contains("ap"));
            //foreach (var fruit in selectedFruits)
            //{
            //    Console.WriteLine(fruit);
            //}
            #endregion

            #region
            //Task 2

            //Console.WriteLine("Please enter a number ");
            //var number = Console.ReadLine();
            //double userNumber;
            //var verifiedUserNumber = double.TryParse(number, out userNumber);

            //double[] arrayUserNumber = {userNumber };
            //double[] arrayInitial = {1, 2, 3};

            //double sum1 = 0;
            //for (int i =0; i<arrayInitial.Length; i++)
            //{
            //    sum1 += arrayInitial[i];

            //}

            //double sum2 = sum1;
            //for (int j = 0; j < arrayUserNumber.Length; j++)
            //{

            //    sum2 = sum1 + arrayUserNumber[j];

            //}
            //Console.WriteLine($"Array sum is equale {sum2}");
            #endregion

            #region
            //Task 5

           //var correctPassword = "root";
            
           // while (true)
           // {
           //     Console.WriteLine("Please enter your Password");
           //     var userData = Console.ReadLine();

           //     if (userData != correctPassword)
           //     {
           //         Console.WriteLine("The Password is invalid. Please try again");
           //     }

           //     else
           //     {
           //         Console.WriteLine("Your Password is correct");
           //         break;
           //     }
           // }
            

            #endregion

            #region
            //Task 6

            //for (int i = 37; i < 87; i++)
            //{
            //    if (i == 71)
            //        continue;
            //    Console.WriteLine(i);
            //}



            #endregion

            #region
            //Task4
            //string userDecision = null;
            //do
            //{
            //    Console.WriteLine("What is the color of Banana?");
            //    string[] arrayAnswers = { "Red", "Green", "Yellow", "Blue", "Purple" };
            //    for (int i = 0; i < arrayAnswers.Length; i++)
            //    {
            //        Console.WriteLine(arrayAnswers[i]);
            //    }
            //    Console.WriteLine("It is time to type your answer");
            //    var userAnswer = Console.ReadLine();
            //    while (true)
            //    {
            //        Console.WriteLine(" Do you want to continue? (Yes/No)");
            //        userDecision = Console.ReadLine()?.ToLower();
            //        if (userDecision == "yes" || userDecision == "no")
            //            break;
            //    }


            //} while (userDecision !="no");








            #endregion

            Console.ReadKey();


        }





        






    }

        //public static int SummarizeNumbers(int userNumber, int arrayStaticNumbers)
        //{
        //    int sum = arrayStaticNumbers + userNumber;
        //    return sum;
        //}
    }

