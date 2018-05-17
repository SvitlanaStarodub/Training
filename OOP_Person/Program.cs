using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Person
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            Citizen citizen = new Citizen();
            LegalPerson legalPerson = new LegalPerson();
            Bank bank = new Bank();

            bank.PutMoneyToAccount(legalPerson, 5000);
            bank.PutMoneyToAccount(citizen, 10000);

            bank.GetAccountBalance(legalPerson);
            


        }

        
    }
}
