import com.scottgarryfoster.*;
import org.junit.jupiter.api.Test;

import static org.junit.jupiter.api.Assertions.*;

public class AccountTests
{
    @Test
    public void Balance_ReturnsZero_WhenANewAccountIsCreatedTest()
    {
        // Arrange
        Account newAccount = new Account();

        // Act
        int balance = newAccount.GetBalance();

        // Assert
        assertEquals(0, balance);
    }

    @Test
    public void Overdraft_ReturnsZero_WhenANewAccountIsCreatedTest()
    {
        // Arrange
        Account newAccount = new Account();

        // Act
        int overdraft = newAccount.GetOverdraft();

        // Assert
        assertEquals(0, overdraft);
    }

    @Test
    public void Balance_ReturnsZero_WhenOverdraftAndBalanceAreZeroAnd100IsTakenTest()
    {
        // Arrange
        Account newAccount = new Account();
        int originalBalance = newAccount.GetBalance();

        // Act
        newAccount.SetBalance(originalBalance - 100);
        int balance = newAccount.GetBalance();

        // Assert
        assertEquals(0, balance);
    }

    @Test
    public void Balance_Returns100_When100IsAddedToABlankBalanceTest()
    {
        // Arrange
        var newAccount = new Account();
        int originalBalance = newAccount.GetBalance();

        // Act
        newAccount.SetBalance(originalBalance + 100);
        int balance = newAccount.GetBalance();

        // Assert
        assertEquals(100, balance);
    }

    @Test
    public void Balance_ReturnsMinus100_WhenBalanceIsZeroAndOverdraftIs100And100IsTakenFromBalanceTest()
    {
        int expectedValue = -100;

        // Arrange
        var newAccount = new Account();
        int originalBalance = newAccount.GetBalance();

        newAccount.SetOverdraft(100);

        // Act
        newAccount.SetBalance(originalBalance - 100);
        int balance = newAccount.GetBalance();

        // Assert
        assertEquals(expectedValue, balance);
    }

}
