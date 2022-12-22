using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApplication
{
    /// <summary>
    /// Provides accounts using a database
    /// </summary>
    public class AccountDatabase : IAccountData
    {
        /// <summary>
        /// The currently loaded accounts
        /// </summary>
        private Dictionary<int, IAccount> storedAccounts;

        public AccountDatabase() 
        {
            storedAccounts = new Dictionary<int, IAccount>();

            // TODO: Impliment database to retrive accounts.

            // This test account would be in an actual database when created.
            IAccount testAccount = new Account();
            testAccount.Balance = 3456;
            storedAccounts.Add(1000, testAccount);
        }

        /// <summary>
        /// Gets the account given by the account number.
        /// </summary>
        /// <param name="accountNumber"> The account number to search for. </param>
        /// <returns> The <see cref="IAccount"/> found or null if not found. </returns>
        /// <exception cref="KeyNotFoundException">
        /// Throws when account number is not found or retrievable.
        /// </exception>
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
