using System;

namespace MyFirstProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string RubToUsdCommand = "1";
            const string RubToEurCommand = "2";
            const string UsdToRubCommand = "3";
            const string UsdToEurCommand = "4";
            const string EurToRubCommand = "5";
            const string EurToUsdCommand = "6";
            const string ExitCommand = "7";

            Console.WriteLine("Добро пожаловать в конвертер валют Золотые Горы!\n");            

            Console.Write("Сколько у вас рублей? ");
            double balanceRub = Convert.ToSingle(Console.ReadLine());
            Console.Write("Сколько у вас долларов? ");
            double balanceUsd = Convert.ToSingle(Console.ReadLine());
            Console.Write("Сколько у вас евро? ");
            double balanceEur = Convert.ToSingle(Console.ReadLine());            

            double rubToUsdRate = 31.40;
            double rubToEurRate = 45.40;

            double usdToEurRate = 1;
            double usdToRubRate = 0.016298;

            double eurToUsdRate = 1;
            double eurToRubRate = 0.016241;

            bool isOpen = true;
            int amountToChange = 0;

            while (isOpen == true) 
            {
                double balanceRubRound = Math.Round(balanceRub, 2);
                double balanceUsdRound = Math.Round(balanceUsd, 2);
                double balanceEurRound = Math.Round(balanceEur, 2);

                Console.WriteLine("\nВаш баланс: ");
                Console.WriteLine($"Рубли: {balanceRubRound}");
                Console.WriteLine($"Доллары: {balanceUsdRound}");
                Console.WriteLine($"Евро: {balanceEurRound}");
                
                Console.WriteLine("Что вы хотите обменять?");
                Console.WriteLine($"{RubToUsdCommand}. Рубли в доллары.| {RubToEurCommand}.Рубли в евро.| {UsdToRubCommand}.Доллары в рубли.| {UsdToEurCommand}.Доллары в евро.| {EurToRubCommand}.Евро в рубли.| {EurToUsdCommand}.Евро в доллары.| {ExitCommand}. Выход.");
                Console.Write("Введите номер обменника или команду выхода: ");
                
                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case RubToUsdCommand:
                        Console.WriteLine("Сколько рублей вы хотите обменять?");
                        amountToChange = Convert.ToInt32(Console.ReadLine());

                        if (amountToChange <= balanceRub)
                        {
                            balanceRub -= amountToChange;
                            balanceUsd += amountToChange / rubToUsdRate;
                        }
                        else
                        {
                            Console.WriteLine("Не хватает денег для обмена.");
                        }
                        break;
                    case RubToEurCommand:
                        Console.WriteLine("Сколько рублей вы хотите обменять?");
                        amountToChange = Convert.ToInt32(Console.ReadLine());

                        if (amountToChange <= balanceRub)
                        {
                            balanceRub -= amountToChange;
                            balanceEur += amountToChange / rubToEurRate;
                        }
                        else
                        {
                            Console.WriteLine("Не хватает денег для обмена.");
                        }
                        break;
                    case UsdToRubCommand:
                        Console.WriteLine("Сколько долларов вы хотите обменять?");
                        amountToChange = Convert.ToInt32(Console.ReadLine());

                        if (amountToChange <= balanceRub)
                        {
                            balanceUsd -= amountToChange;
                            balanceRub += amountToChange / usdToRubRate;
                        }
                        else
                        {
                            Console.WriteLine("Не хватает денег для обмена.");
                        }
                        break;
                    case UsdToEurCommand:
                        Console.WriteLine("Сколько долларов вы хотите обменять?");
                        amountToChange = Convert.ToInt32(Console.ReadLine());

                        if (amountToChange <= balanceRub)
                        {
                            balanceUsd -= amountToChange;
                            balanceEur += amountToChange / usdToEurRate;
                        }
                        else
                        {
                            Console.WriteLine("Не хватает денег для обмена.");
                        }
                        break;
                    case EurToRubCommand:
                        Console.WriteLine("Сколько евро вы хотите обменять?");
                        amountToChange = Convert.ToInt32(Console.ReadLine());

                        if (amountToChange <= balanceRub)
                        {
                            balanceEur -= amountToChange;
                            balanceRub += amountToChange / eurToRubRate;
                        }
                        else
                        {
                            Console.WriteLine("Не хватает денег для обмена.");
                        }
                        break;
                    case EurToUsdCommand:
                        Console.WriteLine("Сколько евро вы хотите обменять?");
                        amountToChange = Convert.ToInt32(Console.ReadLine());

                        if (amountToChange <= balanceRub)
                        {
                            balanceEur -= amountToChange;
                            balanceUsd += amountToChange / eurToUsdRate;
                        }
                        else
                        {
                            Console.WriteLine("Не хватает денег для обмена.");
                        }
                        break;

                    case ExitCommand:
                        isOpen = false;
                        break;
                }
            }
        }
    }
}