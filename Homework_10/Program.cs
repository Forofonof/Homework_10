using System;

    internal class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int randomNumber;
        int divisibleNumberThree;
        int divisibleNumberFive;
        int sumNumber;
        while (true)
        {
            randomNumber = random.Next(0, 101);
            divisibleNumberThree = randomNumber / 3;
            divisibleNumberFive = randomNumber / 5;
            sumNumber = divisibleNumberFive + divisibleNumberThree;

            Console.WriteLine($"случайное число: {randomNumber}. Сумма чисел, которые кратные 3 и 5: {sumNumber}.");
            Console.ReadKey();
        }
    }
}