using System;

class Program {
    public static void Main (string[] args) {
        Console.WriteLine("Enter first number: ");
        int num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number: ");
        int num2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Sign: ");
        string sign = Console.ReadLine();
        Console.WriteLine("");

        switch (sign) {
            case "+" :
                Console.WriteLine(num1 + num2);
                break;
            case "-": 
                Console.WriteLine(num1 - num2);
                break;
            case "*":
                Console.WriteLine(num1 * num2);
                break;
            case "/":
                Console.WriteLine(num1 / num2);
                break;
        }
        
    }
}