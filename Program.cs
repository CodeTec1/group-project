using System;

class Program
{
    static void Main(string[] args)
    {
        bool loggedIn = false;
        double savings = 0.0;
        double investment = 0.0;

        while (!loggedIn)
        {
            Console.WriteLine("1. Login");
            Console.WriteLine("2. Create account");
            Console.WriteLine("3. Exit");
            Console.Write("Enter your choice: ");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    loggedIn = Login();
                    break;
                case 2:
                    CreateAccount();
                    break;
                case 3:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }

        Console.WriteLine("Welcome to the finance management system!");
        Console.WriteLine("Please select an option:");
        Console.WriteLine("1. Save money");
        Console.WriteLine("2. Get investment ideas");
        Console.WriteLine("3. Calculate savings");
        Console.WriteLine("4. Manage expenses");
        Console.WriteLine("5. Access training blogs about finances");
        Console.WriteLine("6. Check balance in savings account");
        Console.WriteLine("7. Check balance in investment account");

        while (true)
        {
            Console.Write("Enter your choice (or type 'exit' to quit): ");
            string option = Console.ReadLine().ToLower();

            if (option == "exit")
            {
                Environment.Exit(0);
            }
            else if (option == "save money")
            {
                Console.Write("Enter your salary: ");
                double salary = double.Parse(Console.ReadLine());

                Console.Write("Enter your expenses: ");
                double expenses = double.Parse(Console.ReadLine());

                double currentSavings = salary - expenses;
                Console.WriteLine("Your current savings are: $" + currentSavings);

                savings += currentSavings;
                Console.WriteLine("Your total savings are: $" + savings);

                double investmentAmount = currentSavings * 0.25;
                investment += investmentAmount;
                Console.WriteLine("You invested $" + investmentAmount + " in your investment account.");
            }
            else if (option == "get investment ideas")
            {
                Console.WriteLine("Here are some investment ideas:");
                Console.WriteLine("- Stock market");
                Console.WriteLine("- Real estate");
                Console.WriteLine("- Cryptocurrency");
            }
            else if (option == "calculate savings")
            {
                Console.WriteLine("Your current savings are: $" + savings);
            }
            else if (option == "manage expenses")
            {
                Console.WriteLine("Here are some tips for managing expenses:");
                Console.WriteLine("- Make a budget and stick to it");
                Console.WriteLine("- Cut down on unnecessary expenses");
                Console.WriteLine("- Use coupons and promo codes");
            }
            else if (option == "access training blogs about finances")
            {
                Console.WriteLine("Here are some finance blogs you might find useful:");
                Console.WriteLine("- NerdWallet");
                Console.WriteLine("- The Simple Dollar");
                Console.WriteLine("- Investopedia");
            }
            else if (option == "check balance in savings account")
            {
                Console.WriteLine("Your current balance in your savings account is: $" + savings);
            }
            else if (option == "check balance in investment account")
            {
                Console.WriteLine("Your current balance in your investment account is: $" + investment);
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }
        }
    }

    static bool Login()
    {
        Console.Write("Enter your username: ");
        string username = Console.ReadLine();
        Console.Write("Enter your password: ");
        string password = Console.ReadLine();

        if (username == "Tecla Horace" && password == "1234")
        {
            Console.WriteLine("Login successful!");
            return true;
        }
        else
        {
            Console.WriteLine("Wrong username or password. Please try again.");
            return false;
        }
    }
    static void CreateAccount()
    {
        Console.Write("Enter your username: ");
        string username = Console.ReadLine();
        Console.Write("Enter your password: ");
        string password = Console.ReadLine();
        Console.Write("Enter your age: ");
        int age = int.Parse(Console.ReadLine());
        Console.Write("Are you employed or in business? (yes/no): ");
        string employmentStatus = Console.ReadLine().ToLower();
        Console.Write("Enter your email address: ");
        string email = Console.ReadLine();

        Console.WriteLine("Account created successfully!");
    }
}
