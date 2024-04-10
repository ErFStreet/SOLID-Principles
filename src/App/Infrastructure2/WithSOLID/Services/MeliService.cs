namespace App.Infrastructure2.WithSOLID.Services;

public class MeliService : IPayment
{
    public MeliService() : base()
    {
    }

    public double GetTransactionFee(double amount)
    {
        return amount * 0.4;
    }
}
