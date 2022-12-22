using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApplication.API;

namespace TestApplication
{
    /// <summary>
    /// Performs basic operations on accounts.
    /// </summary>
    public class AccountOperations : IAccountOperations
    {
        /// <summary>
        /// Provides accounts persistently from an external source.
        /// </summary>
        private IAccountData accountData;

        public AccountOperations(IAccountData accountData) 
        {
            this.accountData = accountData ?? throw new ArgumentNullException(nameof(accountData));
        }

        /// <summary>
        /// Gets the balance for the given account number
        /// </summary>
        /// <param name="accountNumber"> Account number to search for. </param>
        /// <returns> The balance of the account or zero if not found. </returns>
        public int GetBalanceForSingleAccount(int accountId) 
        {
            int returnBalance = 0;

            try
            {
                IAccount account = accountData.GetAccount(accountId);
                returnBalance = account.Balance;
            }
            catch (KeyNotFoundException)
            {

            }
            

            return returnBalance;
        }
    }
}
