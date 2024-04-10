namespace App.Infrastructure2.WithSOLID.Services;

public class MellatService : IPayment
{
    public MellatService() : base()
    {
    }

    public double GetTransactionFee(double amount)
    {
        return amount * 0.5;
    }
}
