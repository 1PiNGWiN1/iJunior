using System;

namespace MyFirstProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string RUBToUSDCommand = "1";
            const string RUBToEURCommand = "2";
            const string USDToRUBCommand = "3";
            const string USDToEURCommand = "4";
            const string EURToRUBCommand = "5";
            const string EURToUSDCommand = "6";
            const string exitCommand = "7";

            Console.WriteLine("Добро пожаловать в конвертер валют Золотые Горы!\n");            

            Console.Write("Сколько у вас рублей? ");
            double balanceRUB = Convert.ToSingle(Console.ReadLine());
            Console.Write("Сколько у вас долларов? ");
            double balanceUSD = Convert.ToSingle(Console.ReadLine());
            Console.Write("Сколько у вас евро? ");
            double balanceEUR = Convert.ToSingle(Console.ReadLine());            

            double RUBToUSDRate = 31.40;
            double RUBToEURRate = 45.40;

            double USDToEURRate = 1;
            double USDToRUBRate = 0.016298;

            double EURToUSDRate = 1;
            double EURToRUBRate = 0.016241;

            bool isOpen = true;
            int amountToChange = 0;

            while (isOpen == true) 
            {
                double balanceRUBRound = Math.Round(balanceRUB, 2);
                double balanceUSDRound = Math.Round(balanceUSD, 2);
                double balanceEURRound = Math.Round(balanceEUR, 2);

                Console.WriteLine("\nВаш баланс: ");
                Console.WriteLine($"Рубли: {balanceRUBRound}");
                Console.WriteLine($"Доллары: {balanceUSDRound}");
                Console.WriteLine($"Евро: {balanceEURRound}");
                
                Console.WriteLine("Что вы хотите обменять?");
                Console.WriteLine($"{RUBToUSDCommand}. Рубли в доллары.| {RUBToEURCommand}.Рубли в евро.| {USDToRUBCommand}.Доллары в рубли.| {USDToEURCommand}.Доллары в евро.| {EURToRUBCommand}.Евро в рубли.| {EURToUSDCommand}.Евро в доллары.| {exitCommand}. Выход.");
                Console.Write("Введите номер обменника или команду выхода: ");
                
                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case RUBToUSDCommand:
                        Console.WriteLine("Сколько рублей вы хотите обменять?");
                        amountToChange = Convert.ToInt32(Console.ReadLine());

                        if (amountToChange <= balanceRUB)
                        {
                            balanceRUB -= amountToChange;
                            balanceUSD += amountToChange / RUBToUSDRate;
                        }
                        else
                        {
                            Console.WriteLine("Не хватает денег для обмена.");
                        }
                        break;
                    case RUBToEURCommand:
                        Console.WriteLine("Сколько рублей вы хотите обменять?");
                        amountToChange = Convert.ToInt32(Console.ReadLine());

                        if (amountToChange <= balanceRUB)
                        {
                            balanceRUB -= amountToChange;
                            balanceEUR += amountToChange / RUBToEURRate;
                        }
                        else
                        {
                            Console.WriteLine("Не хватает денег для обмена.");
                        }
                        break;
                    case USDToRUBCommand:
                        Console.WriteLine("Сколько долларов вы хотите обменять?");
                        amountToChange = Convert.ToInt32(Console.ReadLine());

                        if (amountToChange <= balanceRUB)
                        {
                            balanceUSD -= amountToChange;
                            balanceRUB += amountToChange / USDToRUBRate;
                        }
                        else
                        {
                            Console.WriteLine("Не хватает денег для обмена.");
                        }
                        break;
                    case USDToEURCommand:
                        Console.WriteLine("Сколько долларов вы хотите обменять?");
                        amountToChange = Convert.ToInt32(Console.ReadLine());

                        if (amountToChange <= balanceRUB)
                        {
                            balanceUSD -= amountToChange;
                            balanceEUR += amountToChange / USDToEURRate;
                        }
                        else
                        {
                            Console.WriteLine("Не хватает денег для обмена.");
                        }
                        break;
                    case EURToRUBCommand:
                        Console.WriteLine("Сколько евро вы хотите обменять?");
                        amountToChange = Convert.ToInt32(Console.ReadLine());

                        if (amountToChange <= balanceRUB)
                        {
                            balanceEUR -= amountToChange;
                            balanceRUB += amountToChange / EURToRUBRate;
                        }
                        else
                        {
                            Console.WriteLine("Не хватает денег для обмена.");
                        }
                        break;
                    case EURToUSDCommand:
                        Console.WriteLine("Сколько евро вы хотите обменять?");
                        amountToChange = Convert.ToInt32(Console.ReadLine());

                        if (amountToChange <= balanceRUB)
                        {
                            balanceEUR -= amountToChange;
                            balanceUSD += amountToChange / EURToUSDRate;
                        }
                        else
                        {
                            Console.WriteLine("Не хватает денег для обмена.");
                        }
                        break;

                    case exitCommand:
                        isOpen = false;
                        break;
                }
            }
        }
    }
}