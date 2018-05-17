using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Person
{
    class Bank
        {
            Person person = new Person();
            Citizen citizen = new Citizen();

        public void PutMoneyToAccount(IHasId accountHolder, int quantity)
        {

        }

        public void GetMoneyFromAccount(IHasId accountHolder, int quantity)
        {

        }

        public int GetAccountBalance(IHasId accountHolder)
        {
            int accountBalance = 7;
            return accountBalance;
        }
    }
}
