using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Homework
{
    public class CurrencyEncapsulation
    {
        public int Dollars { get; private set; }
        public int Cents { get; }

        //public double DoubleValue { get; }

        public CurrencyEncapsulation(int dollars, int cents)
        {
            Dollars = dollars;
            Cents = cents;
        }
    }
}
