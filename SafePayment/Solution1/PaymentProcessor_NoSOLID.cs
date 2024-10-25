using System;

/*
 * Payment processing and validation
 * Author: Rafael Luiz Pires Lima
*/

public class PaymentProcessor
{
    public void ProcessPayment(string paymentType, decimal amount)
    {
        if (paymentType == "CreditCard")
        {
            // Process credit card payment
            Console.WriteLine($"Processing credit card payment of {amount}");
        }
        else if (paymentType == "Pix")
        {
            // Process pix payment
            Console.WriteLine($"Processing pix payment of {amount}");
        }
        else if (paymentType == "Boleto")
        {
            // Process boleto payment
            Console.WriteLine($"Processing boleto payment of {amount}");
        }
        else
        {
            // No support for the payment type
            throw new NotSupportedException("Payment type not supported");
        }
    }
}

