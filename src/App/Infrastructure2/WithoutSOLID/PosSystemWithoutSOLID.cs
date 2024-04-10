namespace App.Infrastructure2.WithoutSOLID;

public class PosSystemWithoutSOLID : object
{
    public PosSystemWithoutSOLID() : base()
    {
    }

    public double GetTransactionFee(double amount, PaymentType paymentType)
    {
        if (paymentType == PaymentType.Meli)
        {
            return amount * 0.4;
        }
        else if (paymentType == PaymentType.Mellat)
        {
            return amount * 0.5;
        }
        else if (paymentType == PaymentType.Saman)
        {
            return amount * 0.6;
        }

        return 0;
    }
}
