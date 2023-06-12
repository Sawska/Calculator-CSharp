using System;

class Calculator
{
    public static void Greatings()
    {
        Console.WriteLine("Welcome to the terminal calculator!");
        Options();
    }
    public static void CalculatorCommand(int arg)
    {
        if (arg == 5) {
            Console.WriteLine("goodbye");
            Environment.Exit(0);
        }
        if (arg <= 0 || arg > 4)
        {
            Console.WriteLine("This option is not allowed");
        } else
        {
            try
            {
                Console.WriteLine("Write first number:");
                int firstNumber = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Write second number:");
                int secondNumber = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(Operations(firstNumber, secondNumber, arg));
            } catch(FormatException)
            {
                Console.WriteLine("This it not a number");
                Console.WriteLine("Press any button to continue");
                Console.ReadLine();
                CalculatorCommand(arg);
            }
        }
        Console.WriteLine("Press any button to continue");
        Console.ReadLine();
        Options();
    }
    public static string Operations(int first,int second,int operation)
    {
        int result = 0;
        string operationSymbol = "";
        if(operation == 1)
        {
             operationSymbol = "+";
            result = first + second;
        }
        if(operation == 2)
        {
            operationSymbol = "-";
            result = first - second;
        }
        if(operation == 3)
        {
            operationSymbol = "*";
            result = first * second;
        }
        if(operation == 4)
        {
            try
            {
                operationSymbol = "/";
                result = first / second;
            } catch(DivideByZeroException)
            {
                return "Division by zero is not allowed";
            }
        }
        return $"{first} {operationSymbol} {second} = {result}";
    }
    public static void Options()
    {
        try
        {
            Console.WriteLine("Select an option:");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Substraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.WriteLine("5. Exit");
            Console.WriteLine("Enter your choice:");
            int arg = Convert.ToInt32(Console.ReadLine());
            CalculatorCommand(arg);
        } catch(FormatException)
        {
            Console.WriteLine("This is not a number");
            Console.WriteLine("Press any button to continue");
            Console.ReadLine();
            Options();
        }
    }
    public static void Main()
    {
        Greatings();
    }
}

