using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class3
{
    class Program
    {
        static void Main(string[] args)
        {


            //var b = 9 < 0;

            //var bb = !Method1() is bool aa;

            //object o1 = "test";
            //object o2 = 9;

            //var a = o1.Equals(02);

            //var r1 = Method1() && Method2();
            //var r2 = Method1() || Method2();

            
    

            var condition = 9;

            switch (condition)
            {
                case 0:
                    Console.WriteLine(0);
                    break;
                case 9:
                    Console.WriteLine(9);
                    break;
                default:
                    Console.WriteLine(0);
                    break;
            }

            var condition2 = true;
            int result = condition2 ? 1 : 0;   //тернарные операторы
                                               //int result = condition2 ? 1 : throw new Exception();


            var condition3 = true;
            if (condition3)
                result = 1;
            else
                result = 0;


            var str1 = "";
            string str2 = null;

            var a = str2 ?? str1;
            var b = str2 ?? throw new NullReferenceException();


            int i = 9;
            object o = null;

            var res = o?.Equals(i);     // null condition

            //    }

            //    static bool Method1()
            //    {
            //        Console.WriteLine(nameof(Method1));
            //        return true;
            //        }

            //    static bool Method2()
            //    {
            //        Console.WriteLine(nameof(Method2)) ;
            //        return false;
        }
    }
}
