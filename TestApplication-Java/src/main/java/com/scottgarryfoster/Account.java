package com.scottgarryfoster;

/**
 * A bank account for a given user.
 */
public class Account
{
    /**
     * Balance for the account. Is kept in check by {@link this.overdraft overdraft}
     */
    private int balance;

    /**
     * Overdraft for the account. Allows {@link this.balance balance} to descend below zero.
     */
    private int overdraft;


    /**
     * Gets the balance for the current account
     * @return The account balance.
     */
    public int GetBalance()
    {
        return this.balance;
    }

    /**
     * Updates the account balance. Is kept in check by {@link this.overdraft overdraft}.
     * @param value New value for the account.
     */
    public void SetBalance(int value)
    {
        this.balance = ReturnHighestSafeBalance(this.balance, value);
    }

    /**
     * Gets the overdraft for the current account.
     * @return The account overdraft.
     */
    public int GetOverdraft()
    {
        return this.overdraft;
    }

    /**
     * Updates the account overdraft.
     * @param value New value for the account.
     */
    public void SetOverdraft(int value)
    {
        this.overdraft = value;
    }

    /**
     * Ensures value is not below {@link this.overdraft overdraft}
     * @param existingValue Value started at.
     * @param newValue Proposed value.
     * @return A value no lower than {@link this.overdraft overdraft}.
     * May equal {@link this.overdraft overdraft} if proposed is below.
     */
    private int ReturnHighestSafeBalance(int existingValue, int newValue)
    {
        int safeValue = existingValue;
        if (newValue >= -this.overdraft)
        {
            safeValue = newValue;
        }

        return safeValue;
    }
}
