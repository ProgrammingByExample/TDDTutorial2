using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApplication
{
    public class AccountDatabase : IAccountData
    {
        Dictionary<int, IAccount> storedAccounts;

        public AccountDatabase() 
        {
            storedAccounts = new Dictionary<int, IAccount>();

            // TODO: Impliment database to retrive accounts.

            // This test account would be in an actual database when created.
            IAccount testAccount = new Account();
            testAccount.Balance = 3456;
            storedAccounts.Add(1000, testAccount);
        }

        public IAccount GetAccount(int accountNumber)
        {
            IAccount retrivedAccount = null;
            if (!storedAccounts.TryGetValue(accountNumber, out retrivedAccount))
            {
                throw new KeyNotFoundException
                    ($"{typeof(AccountDatabase)}: Account not found: {accountNumber}");
            }

            return retrivedAccount;
        }
    }
}
