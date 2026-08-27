internal class ATM_Application
{
    static decimal accBalance = 1000;

    static void Main(string[] args)
    {
        int option = 0;

        while (option != 4)
        {
            Console.WriteLine("Welcome to ATM Service!\n\n1. Check Balance\n\n2. Withdraw Cash\n\n3. Deposit Cash\n\n4. Quit");

            option = Convert.ToInt32(Console.ReadLine());

            if (option == 1)
            {
                Console.WriteLine("Your Current Balance is $" + accBalance);
            }
            else if (option == 2)
            {
                Console.WriteLine("Enter Amount to Withdraw:");

                string tempamount = Console.ReadLine();
                decimal amount = Convert.ToDecimal(tempamount);

                if (amount <= accBalance)
                {
                    accBalance -= amount;
                    Console.WriteLine("Withdraw Success.");
                }
                else
                {
                    Console.WriteLine("Insufficient Funds.");
                }
            }
            else if (option == 3)
            {
                Console.WriteLine("Enter Amount to Deposit:");

                string tempamount = Console.ReadLine();
                decimal amount = Convert.ToDecimal(tempamount);

                if (amount > 0)
                {
                    accBalance += amount;
                    Console.WriteLine("Deposit Successful");
                }
                else
                {
                    Console.WriteLine("Invalid Amount.");
                }
            }
            else if (option == 4)
            {
                
            }
            else
            {
                Console.WriteLine("Invalid Option.");
            }
        }

        Console.WriteLine("Thank you for using our ATM Service!");
    }
}