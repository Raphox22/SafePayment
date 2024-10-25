using System;

/*
 * Payment processing and validation experiment using S.O.L.I.D principles
 * Author: Rafael Luiz Pires Lima
*/

public interface IPaymentMethod
{
    void ProcessPayment(decimal amount);
}

public class CreditCardPayment : IPaymentMethod
{
    public void ProcessPayment(decimal amount)
    {
        // Process credit card payment
        Console.WriteLine($"Processing credit card payment of {amount}");
    }
}

public class PixPayment : IPaymentMethod
{
    public void ProcessPayment(decimal amount)
    {
        // Process pix payment
        Console.WriteLine($"Processing pix payment of {amount}");
    }
}

public class BankTransferPayment : IPaymentMethod
{
    public void ProcessPayment(decimal amount)
    {
        // Process boleto payment
        Console.WriteLine($"Processing boleto payment of {amount}");
    }
}

public class PaymentProcessor
{
    private readonly IPaymentMethod _paymentMethod;

    public PaymentProcessor(IPaymentMethod paymentMethod)
    {
        _paymentMethod = paymentMethod;
    }

    public void ProcessPayment(decimal amount)
    {
        _paymentMethod.ProcessPayment(amount);
    }
}

