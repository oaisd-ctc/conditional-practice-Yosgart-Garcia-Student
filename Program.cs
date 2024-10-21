using System;

public class Program
{
    public static void Main(string[] args)
    {
        FahrenheitToCelsius(68);
        CheckForPositiveNegativeZero(-1);
        CheckForPositiveNegativeZero(0);
        CheckForPositiveNegativeZero(1);
        FindMinimum(45, 15, 50);
        FindMaximum(45, 15, 50);
        IsDivisibleBy5(26);
        IsDivisibleBy5(25);
        CheckEvenOrOdd(7);
        CheckEvenOrOdd(10);
        CheckVowelOrConsonant('e');
        CheckVowelOrConsonant('t');
        DisplayDayOfWeek(0);
        DisplayDayOfWeek(3);
        DisplayDayOfWeek(6);
        DisplayDayOfWeek(7);
    }

    public static void FahrenheitToCelsius(double fahrenheit)
    {
        double celsiusDegree = (fahrenheit - 32) * 5/9; 
        Console.WriteLine($"{fahrenheit} degrees Fahrenheit is {celsiusDegree} degrees Celsius.");
    }

    public static void CheckForPositiveNegativeZero(int number)
    {
        if(number > 0) Console.WriteLine($"{number} is positive!");
        else if(number == 0) Console.WriteLine($"{number} is zero!");
        else Console.WriteLine($"{number} is negative!");
    }

    public static void FindMinimum(int num1, int num2, int num3)
    {
        //if(num1 < num2 && num1 < num3) Console.WriteLine($"The smallest number is {num1}");
        //else if(num2 < num1 && num2 < num3) Console.WriteLine($"The smallest number is {num2}");
        //else if(num3 < num1 && num3 < num2) Console.WriteLine($"The smallest number is {num3}");
        //else Console.WriteLine("idk");
        Console.WriteLine("The smallest number is " + Math.Min(Math.Min(num1, num2), num3));
    }

    public static void FindMaximum(int num1, int num2, int num3)
    {
        //if(num1 > num2 && num1 > num3) Console.WriteLine($"The largest number is {num1}");
        //else if(num2 > num1 && num2 > num3) Console.WriteLine($"The largest number is {num2}");
        //else if(num3 > num1 && num3 > num2) Console.WriteLine($"The largest number is {num3}");
        //else Console.WriteLine("idk");
        Console.WriteLine("The largest number is " + Math.Max(Math.Max(num1, num2), num3));
    }

    public static void IsDivisibleBy5(int number)
    {
        int mod = number % 5;
        if(mod == 0) Console.WriteLine($"{number} is divisible by 5.");
        else Console.WriteLine($"{number} is not divisible by 5.");
    }

    public static void CheckEvenOrOdd(int number)
    {
        int mod = number % 2;
        if(mod == 0) Console.WriteLine($"{number} is even.");
        else Console.WriteLine($"{number} is odd.");
    }

    public static void CheckVowelOrConsonant(char letter)
    {
        switch (letter)
        {
            case 'a' or 'e' or 'i' or 'o' or 'u':
                Console.WriteLine($"{letter} is a vowel!");
                break;
            default:
                Console.WriteLine($"{letter} is a consonant!");
                break;
        }
    }

    public static void DisplayDayOfWeek(int dayCode)
    {
        switch (dayCode)
        {
            case 0 or 7:
                Console.WriteLine($"{dayCode} is Sunday");
                break;
            case 1:
                Console.WriteLine($"{dayCode} is Monday");
                break;
            case 2:
                Console.WriteLine($"{dayCode} is Tuesday");
                break;
            case 3:
                Console.WriteLine($"{dayCode} is Wednesday");
                break;
            case 4:
                Console.WriteLine($"{dayCode} is Thursday");
                break;
            case 5:
                Console.WriteLine($"{dayCode} is Friday");
                break;
            case 6:
                Console.WriteLine($"{dayCode} is Saturday");
                break;
            default:
                Console.WriteLine($"{dayCode} is idk");
                break;
        }
    }
}
