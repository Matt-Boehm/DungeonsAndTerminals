using System;

class Program
{
    static void Main(string[] args)
    {
        // Present user with a choice of options
        Console.WriteLine("Choose your character:");
        Console.WriteLine("1. Wizard");
        Console.WriteLine("2. Knight");


        // Get user input
        string input = Console.ReadLine();

        // Handle user input
        switch (input)
        {
            case "1":
                // Instantiate a new instance of Class1 and call its method
                Wizard class1 = new Wizard();
                class1.Method1();
                break;
            case "2":
                // Instantiate a new instance of Class2 and call its method
                Knight class2 = new Knight();
                class2.Method2();
                break;

            default:
                Console.WriteLine("Invalid choice.");
                break;

        }

        // Wait for user input to close console window
        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }


}

