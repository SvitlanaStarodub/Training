using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP_Homework.Polymorphism;

namespace OOP_Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            var myCurrentCuurency = new Currency(2, 80);
            var addedValue = myCurrentCuurency.Add(new Currency(2, 20));
            addedValue.Print();

            var myCurrentCurencyMult = new Currency(1, 3);
            var multipleValue = myCurrentCurencyMult.Multiply(new Currency(1, 5));
            multipleValue.Print();

            var myEncapsulatedCurrency = new CurrencyEncapsulation(2, 80);
            Console.WriteLine(myEncapsulatedCurrency.Cents);
            //myEncapsulatedCurrency.Cents = 9; - throw error


            Console.ReadKey();













            //var apple = new Apple();
            //var pear = new Pears();

            //CutAndPlace(apple);
            //CutAndPlace(pear);

            
        }

        //private static void CutAndPlace(IFruits fruit)
        //{
        //    fruit.Cut();
        //    Console.WriteLine("Place");
        //}
    }
}
