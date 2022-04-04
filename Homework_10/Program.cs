using System;

    internal class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int randomNumber;
        int numberMinimum = 5;
        int numberMaximum = 100;
        int divisibleNumberThree = 3;
        int divisibleNumberFive = 5;
        int numberThree;
        int numberFive;
        int divisibleNumberAmount;

        for (numberMinimum = 0; numberMinimum <= numberMaximum;)
        {
            randomNumber = random.Next(numberMinimum, numberMaximum);
            Console.WriteLine($"Случайное число: {randomNumber}.");

            if ((randomNumber % divisibleNumberThree == 0) && (randomNumber % divisibleNumberFive == 0))
            {
                numberThree = +randomNumber / divisibleNumberThree;
                numberFive = +randomNumber / divisibleNumberFive;
                divisibleNumberAmount = +numberThree + numberFive;

                Console.WriteLine($"Сумма чисел кратное 3 и 5: {divisibleNumberAmount}.");
            }
            Console.ReadKey();
        }
    }
}