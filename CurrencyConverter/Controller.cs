using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter
{
    //Overarching controller class of program that to help manipulate the model
    class Controller
    {
        private Conversion exchange = new Conversion();
        private Account account = new Account();

        public double convert(string currency, double amount) 
        {
            return amount / exchange.getRate(currency);
        }

        public void deposit(string curr, double amount, int acctNum)
        {
            double depositAmount = convert(curr, amount);
            account.depositMoney(acctNum, depositAmount);
        }

        public void withdraw(string curr, double amount, int acctNum)
        {
            double withdrawAmount = convert(curr, amount);
            account.withdrawMoney(acctNum, withdrawAmount);
        }

        public double getBalance()
        {
            return account.getBalance();
        }

        public List<int> getAccts()
        {
            return account.accountList();
        }

        public List<string> getCurrency()
        {
            return exchange.getCurrs();
        }

        public int getID()
        {
            return account.getCurrAcct();
        }
    }
}
