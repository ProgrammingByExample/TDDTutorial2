using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApplication
{
    public class AccountOperations
    {
        private IAccountData accountData;

        public AccountOperations(IAccountData accountData) 
        {
            this.accountData = accountData ?? throw new ArgumentNullException(nameof(accountData));
        }

        public int GetBalanceForSingleAccount(int accountId) 
        {
            IAccount account = accountData.GetAccount(accountId);
            return account.Balance;
        }
    }
}
