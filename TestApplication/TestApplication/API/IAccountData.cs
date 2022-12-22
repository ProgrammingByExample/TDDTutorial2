using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApplication
{
    /// <summary>
    /// Provides accounts persistently from an external source.
    /// </summary>
    public interface IAccountData
    {
        /// <summary>
        /// Gets the account given by the account number.
        /// </summary>
        /// <param name="accountNumber"> The account number to search for. </param>
        /// <returns> The <see cref="IAccount"/> found. </returns>
        /// <exception cref="KeyNotFoundException">
        /// Throws when account number is not found or retrievable.
        /// </exception>
        IAccount GetAccount(int accountNumber);
    }
}
