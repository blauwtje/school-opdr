using System;

class Program
{
    static void Main(string[] args)
    {
        double balance = Convert.ToDouble(Console.ReadLine());
        int interest = Convert.ToInt32(Console.ReadLine());
        int years = Convert.ToInt32(Console.ReadLine());
        double taxesPaid = 0;

        for (int i = 0; i < years; i++)
        {
            balance += balance * interest / 100.0;
            if (balance > 50000)
            {
                double taxes;
                if (balance <= 100000)
                {
                    taxes = (balance - 50000) * 0.015;
                }
                else
                {
                    taxes = (100000 - 50000) * 0.015 + (balance - 100000) * 0.03;
                }
                balance -= taxes;
                taxesPaid += taxes;
            }
        }
        Console.WriteLine($"Balance after {years} years: {Convert.ToInt32(balance)}");
        Console.WriteLine($"Amount of taxes paid: {Convert.ToInt32(taxesPaid)}");
    }
}