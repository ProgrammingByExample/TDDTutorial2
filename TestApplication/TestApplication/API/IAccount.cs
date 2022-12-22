using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApplication
{
    /// <summary>
    /// Bank account for a given user.
    /// </summary>
    public interface IAccount
    {
        /// <summary>
        /// Balance for the account.
        /// </summary>
        int Balance { get; set; }
    }
}
