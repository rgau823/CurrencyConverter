using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter
{
    //Account class (model) that allows for one user to have multiple balances with different account IDs
    public class Account
    {
        private Dictionary<int, double> accounts = new Dictionary<int, double>();
        int currAcct;

        public Account()
        {
            accounts.Add(1234, 1000.00);
            currAcct = 1234;
        }

        public int getAcct()
        {
            return currAcct;
        }

        //Return balance of currently selected account (if no changes)
        public double getBalance()
        {
            return accounts[currAcct];
        }

        //Returns balance of specific account
        public double getBalance(int id)
        {
            return accounts[id];
        }

        //Returns currently selected account ID
        public int getCurrAcct()
        {
            return currAcct;
        }

        public void setCurrAcct(int acctID)
        {
            currAcct = acctID;
        }

        //Function to deposit money
        public void depositMoney(int id, double amount)
        {
            changeBalance(id, amount);
        }

        //Function to withdraw money, convert to negative for easier addition
        public void withdrawMoney(int id, double amount)
        {
            changeBalance(id, amount * -1);
        }

        public List<int> accountList()
        {
            List<int> accountIDS = new List<int>();
            foreach(KeyValuePair<int, double> entry in accounts)
            {
                accountIDS.Add(entry.Key);
            }
            return accountIDS;

        }

        //Internal function to change balance that cannot be called by any external class
        //If withdrawal amount is less than 0, withdrawal does not occur
        //Returns bool for future error checking
        private bool changeBalance(int id, double amount)
        {
            double current = accounts[id];
            double final = current + amount;
            if (final < 0)
            {
                return false;
            }
            accounts[id] = final;
            return true;
        }
    }
}
