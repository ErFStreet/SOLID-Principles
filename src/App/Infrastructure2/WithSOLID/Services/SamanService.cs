namespace App.Infrastructure2.WithSOLID.Services;

public class SamanService : IPayment
{
    public SamanService() : base()
    {
    }

    public double GetTransactionFee(double amount)
    {
        return amount * 0.6;
    }
}
