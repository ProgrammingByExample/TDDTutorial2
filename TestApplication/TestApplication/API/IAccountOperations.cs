using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApplication.API
{
    /// <summary>
    /// Performs basic operations on accounts.
    /// </summary>
    public interface IAccountOperations
    {
        /// <summary>
        /// Gets the balance for the given account number
        /// </summary>
        /// <param name="accountNumber"> Account number to search for. </param>
        /// <returns> The balance of the account or zero if not found. </returns>
        int GetBalanceForSingleAccount(int accountNumber);
    }
}
