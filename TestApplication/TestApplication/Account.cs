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
    public class Account
    {
        /// <summary>
        /// Balance for the account. Is kept in check by <see cref="Overdraft"/>
        /// </summary>
        public int Balance 
        {
            get => balance; 
            set 
            {
                balance = ReturnHighestSafeBalance(balance, value);
            }
        }
        private int balance;

        /// <summary>
        /// Overdraft for the account. Allows <see cref="Balance"/> to decend below zero.
        /// </summary>
        public int Overdraft;

        /// <summary>
        /// Ensures value is not below <see cref="Overdraft"/>
        /// </summary>
        /// <param name="existingValue"> Value started at. </param>
        /// <param name="newValue"> Proposed value. </param>
        /// <returns> 
        /// A value no lower than <see cref="Overdraft"/>. May equal <see cref="Overdraft"/> if proposed is below.
        /// </returns>
        private int ReturnHighestSafeBalance(int existingValue, int newValue)
        {
            int safeValue = existingValue;
            if (newValue >= -Overdraft)
            {
                safeValue = newValue;
            }
            else
            {
                safeValue = -Overdraft;
            }

            return safeValue;
        }
    }
}
