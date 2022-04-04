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
        int sumA;
        int sumB;
        int numberMinimum = 0;
        int numberMaximum = 100;
        int j = 0;

        number = random.Next(numberMinimum, numberMaximum);

        for (; numberMinimum <= number; numberMinimum++)
        {
            sumA = numberMinimum / numberDivisibleA;
            sumB = numberMinimum / numberDivisibleB;
            if ((sumA / numberDivisibleA == j) || (sumB / numberDivisibleB == j))
            {
                sum = sumA + sumB;
            }
        }
        Console.WriteLine($"случайное число: {number}. Сумма кратных чисел 3 или 5: {sum}");
    }
}