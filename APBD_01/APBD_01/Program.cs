// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//modification 1
Console.WriteLine("Well, it's my first time using C#");

//modification 2
Console.WriteLine("I have no idea what I'm doing");

//modification 3
Console.WriteLine("let's see...");

//task 3: testing
int[] arr = { 1, 2, 3, 4, 5 };
Console.WriteLine("calculated average: " + Calculator.CalculateAverage(arr)); //output: 3

//task 4: testing
Console.WriteLine("max: " + Calculator.FindMax(arr)); //output: 5

public static class Calculator
{
    //task 3: calculate average
    public static double CalculateAverage(int[] values)
    {
        if (values == null || values.Length == 0)
            throw new ArgumentException("Array cannot be null or empty.");

        return values.Average(); //C# has a built-in average function
    }


    //task 4: find max
    public static int FindMax(int[] numbers)
    {
            if (numbers == null || numbers.Length == 0)
                throw new ArgumentException("Array cannot be null or empty.");
            return numbers.Max(); //built-in max function
    }

}