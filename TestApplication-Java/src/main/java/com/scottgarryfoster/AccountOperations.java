package com.scottgarryfoster;

import com.scottgarryfoster.API.IAccountData;

public class AccountOperations
{
    public AccountOperations(IAccountData accountData)
    {
        if (accountData == null)
        {
            throw new NullPointerException(IAccountData.class + " may not be null.");
        }
    }
}
