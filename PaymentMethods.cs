using System;

public abstract class Payment 
{
    public abstract void ProcessPayment(double amount);
    
    public void DisplayReceipt() 
    {
        Console.WriteLine("Thank you for your payment.");
    }
}

public class CreditCardPayment : Payment 
{
    public override void ProcessPayment(double amount) 
    {
        Console.WriteLine("Processing credit card payment of $" + amount);
    }
}

public class PayPalPayment : Payment 
{
    public override void ProcessPayment(double amount) 
    {
        Console.WriteLine("Processing PayPal payment of $" + amount);
    }
}

public class PaymentMethods 
{
	public static void Main(string[] args) 
	{
		CreditCardPayment c = new CreditCardPayment();
		PayPalPayment p = new PayPalPayment();
		c.ProcessPayment(100);
		c.DisplayReceipt();
		p.ProcessPayment(50);
		p.DisplayReceipt();
	}
}
