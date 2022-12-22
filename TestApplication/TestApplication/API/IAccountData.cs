using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApplication
{
    public interface IAccountData
    {
        IAccount GetAccount(int accountNumber);
    }
}
