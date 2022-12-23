package com.scottgarryfoster;

import com.scottgarryfoster.API.IAccountData;
import org.junit.jupiter.api.Assertions;
import org.junit.jupiter.api.Test;

public class AccountOperationsTests
{
    @Test
    public void OnConstruction_ThrowsNullArgumentException_WhenDatabaseIsNullTest()
    {
        // Arrange
        IAccountData nullDatabase = null;

        // Act / Assert
        NullPointerException thrown = Assertions.assertThrows(NullPointerException.class, () ->
        {
            new AccountOperations(nullDatabase);
        });
    }
}
