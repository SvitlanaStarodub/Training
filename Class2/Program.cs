using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class2
{
    //class Employee
    //{
    //    static void Main(string[] args)
    //    {
    //        Object o = new Employee();
    //        Employee e = (Employee) o;
    //        e.GetType();

    //        Manager m = new Manager();
    //        PromoteEmployee (m);

    //        DateTime newYear = new DateTime(2013, 1, 1);
    //        PromoteEmployee(newYear);
    //    }

    //    public static void PromoteEmployee(Manager m)
    //    {
    //        throw new NotImplementedException();
    //    }
    //    public static void DateTime(Object o)
    //    {
    //        Employee e = (Employee)o;
    //        //throw new NotImplementedException();
    //    }

    //    internal class Manager : Employee
    //    {

    //    }

    //}
    class types {
        //static public void Main(string[] args)
        //{ int i = 100; string s = "Hello, world";
        //    Console.WriteLine("Before, i = " + i);
        //    ChangeInt(ref i);
        //    Console.WriteLine("After, i = " + i);
        //    Console.WriteLine("Before, s = " + s);
        //    ChangeString(ref s);
        //    Console.WriteLine("After, s = " + s);
        //    Console.ReadKey();
        //}
        //static void ChangeInt(ref int i) { i = 99; }
        //static void ChangeString(ref string s) { s = "Hello, I've been changed.";        }

       //static public void Main(string[] args)
        //{
        //    int i = 100;
        //    string s = "Hello, world";
        //    Console.WriteLine("Before, i = " + i);
        //    ChangeInt(i);
        //    Console.WriteLine("After, i = " + i);
        //    Console.WriteLine("Before, s = " + s);
        //    ChangeString(s);
        //    Console.WriteLine("After, s = " + s);
        //}
        //static void ChangeInt(int i)
        //{
        //    i = 99;
        //}
        //static void ChangeString(string s)
        //{
        //    s = "Hello, I've been changed.";
        //}
        static void Main()
        {          string s = "Hello, world. ";    s.Trim();      
            Console.WriteLine(s + "I wasn’t trimmed!");
        }
}
}
