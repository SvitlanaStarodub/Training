using System;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;

namespace OOP_Homework
{
    public class Currency
    {
        private readonly int _dollars;
        private readonly int _cents;
        private double _doubleValue;
        private int _zeroValue;

        public Currency(int dollars, int cents)
        {
            _dollars = dollars;
            _cents = cents;
        }

        public Currency(double doubleValue)
        {
            _doubleValue = doubleValue;
        }

        public Currency()
        {
            _zeroValue = 0;
        }
        //todo еще 2 конструктора


        public Currency Add(Currency valueToAdd)
        {
            var myCurrent = ToDouble(this);
            var addedCurrency = ToDouble(valueToAdd);
            var added = (myCurrent + addedCurrency).ToString().Split('.');

            //todo обработка целых чисел

            if (added.Length == 1)
            {
                return new Currency(int.Parse(added[0]), 0);
            }
            { return new Currency(int.Parse(added[0]), int.Parse(added[1])); }

            
              
            
            
        }

        public Currency Multiply(Currency valueToMultiple)
        {
            var myCurrentMult = ToDouble(this);
            var multiplyCurrent = ToDouble(valueToMultiple);
            var multiply = (myCurrentMult * multiplyCurrent).ToString().Split('.');

            return new Currency(int.Parse(multiply[0]), int.Parse(multiply[1]));
        }

        //todo mMultiply method
        public void Print()
        {
            Console.WriteLine($"CurrentCurrency: {_dollars}.{_cents}");
        }

        private double ToDouble(Currency myCurrency)
        {
            return double.Parse($"{myCurrency._dollars}.{myCurrency._cents}");
        }
    }
}
