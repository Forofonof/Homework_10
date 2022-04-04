using System;

    internal class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int number;
        int numberDivisibleA = 3;
        int numberDivisibleB = 5;
        int sum;
        int sumA;
        int sumB;
        int numberMinimum = 5;
        int numberMaximum = 100;

        for (int i = 0; i < numberMinimum;)
        {
            number = random.Next(numberMinimum, numberMaximum);

            if ((number % numberDivisibleA == 0) || (number % numberDivisibleB == 0))
            {
                sumA = number / 3;
                sumB = number / 5;
                sum = sumA + sumB;
                Console.WriteLine($"случайное число: {number}. Сумма кратных чисел 3 или 5: {sum}. ");
                Console.ReadKey();
            }
        }
    }
}