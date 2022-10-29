using System;
using System.Runtime.InteropServices;

namespace MyFirstProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string exitFromApp = "exit";

            Console.Write("Сколько у вас рублей? ");
            double balanceRUB = Convert.ToSingle(Console.ReadLine());

            Console.Write("Сколько у вас долларов? ");
            double balanceUSD = Convert.ToSingle(Console.ReadLine());

            Console.Write("Сколько у вас евро? ");
            double balanceEUR = Convert.ToSingle(Console.ReadLine());

            double exchangeRateRubToUSD = 31.40;
            double exchangeRateRubToEUR = 45.40;
            double exchangeRateEURToUSD = 1;
            double exchangeRateUSDToEUR = 1;
            double exchangeRateEURToRUB = 0.016241;
            double exchangeRateUSDToRUB = 0.016298;

            Console.WriteLine("Что вы хотите обменять?");
            Console.WriteLine("1. Рубли в доллары.| 2.Рубли в евро.| 3.Доллары в рубли.| 4.Доллары в евро.| 5.Евро в рубли.| 6.Евро в доллары.| Для выхода введите exit.");
            Console.Write("Введите номер обменника или команду выхода: ");
            string userInput = Console.ReadLine();
            while (userInput != exitFromApp) 
            {
                switch (userInput)
                {
                    case "1":
                        Console.WriteLine("Сколько долларов вы хотите купить?");
                        
                        break;
                    case "2":
                        Console.WriteLine("Сколько евро вы хотите купить?");
                        break;
                    case "3":
                        Console.WriteLine("Сколько рублей вы хотите купить?");
                        break;
                    case "4":
                        Console.WriteLine("Сколько евро вы хотите купить?");
                        break;
                    case "5":
                        Console.WriteLine("Сколько рублей вы хотите купить?");
                        break;
                    case "6":
                        Console.WriteLine("Сколько долларов вы хотите купить?");
                        break;
                }
            }
        }
    }
}