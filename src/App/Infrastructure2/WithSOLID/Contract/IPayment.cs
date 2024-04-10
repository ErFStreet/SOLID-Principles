namespace App.Infrastructure2.WithSOLID.Contract;

public interface IPayment
{
    double GetTransactionFee(double amount);
}
