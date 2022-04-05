using System;

    internal class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int number;
        int numberDivisibleA = 3;
        int numberDivisibleB = 5;
        int sum = 0;
        int numberMinimum = 0;
        int numberMaximum = 100;
        int i;

        number = random.Next(numberMinimum, numberMaximum);

        for (i = 0; numberMinimum <= number; numberMinimum++)
        {
            if (numberMinimum % numberDivisibleA == i || numberMinimum % numberDivisibleB == i)
            {
                sum += numberMinimum;
            }
        }
        Console.WriteLine($"случайное число: {number}. Сумма кратных чисел {numberDivisibleA} или {numberDivisibleB}: {sum}");
    }
}