//----------------------------------------
// Tarteeb School (c) All rights reserved
//----------------------------------------
using Balance.Services.UserBalanceServices;

internal class Program
{
    private static void Main(string[] args)
    {
        IBalanceService balanceService = new BalanceService();
        string choice;
        do
        {
            PrintMenu();
            choice = Console.ReadLine();
            switch(choice) 
            {
                case "1":
                    {
                        Console.Clear();
                        Console.Write("Enter amount ");
                        decimal amount = Convert.ToDecimal(Console.ReadLine());
                        balanceService.Add(amount);
                    }
                    break;
                case "2":
                    {
                        Console.Clear();
                        Console.Write("Enter amount ");
                        decimal amount = Convert.ToDecimal(Console.ReadLine());
                        balanceService.Subtract(amount);
                    }
                    break;
                case "3":
                    {
                        Console.Clear();
                        Console.WriteLine(balanceService.Get());
                    }
                    break;
            }
        } while (choice != "4");
    }
    static void PrintMenu()
    {
        Console.WriteLine("1. Add Money");
        Console.WriteLine("2. Subtract Money");
        Console.WriteLine("3. Get Balance");
        Console.WriteLine("4. Exit");
    }
}