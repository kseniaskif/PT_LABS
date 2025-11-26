using System;
using System.Collections.Generic; // Добавлено для использования List<int>

namespace Lab03_CS_basics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("# Lab03_Cs_Basics");
            Console.WriteLine("Основы языка программирования C#");
            Console.WriteLine("---------------------------------------------\n\n");
            Console.WriteLine("Выберите блок для выполнения: ");
            Console.WriteLine("1 - Переменные и операторы");
            Console.WriteLine("2 - Условные операторы (if-else, switch)");
            Console.WriteLine("3 - Циклы (while, do-while, for)");
            Console.WriteLine("4 - Массивы (одномерные и двумерные)");
            Console.WriteLine("5 - Функции и методы"); 
            Console.WriteLine("0 - Выход из программы\n\n");
            Console.WriteLine("---------------------------------------------\n");
            Console.WriteLine("Введите номер блока: ");

            string input = Console.ReadLine();
            int number = int.Parse(input);

            switch (number)
            {
                case 1:
                    Console.WriteLine("Блок 1: Переменные и операторы: ");
                    Console.WriteLine("Выберите номер задачи: ");
                    string task = Console.ReadLine();
                    int nt = int.Parse(task);

                    switch (nt)
                    {
                        case 1:
                            Console.WriteLine("Конвертация температуры: пользователь вводит температуру в градусах Цельсия, программа переводит в Фаренгейты ");
                            Console.WriteLine("Введите температуру в градусах Цельсия: ");
                            string t = Console.ReadLine();
                            float temp = float.Parse(t);
                            float f = temp * 9 / 5 + 32;
                            Console.WriteLine($"Температура в градусах по Фаренгейту: {f}");
                            break;
                        case 3:
                            Console.WriteLine("Введите сумму в рублях: ");
                            string sum = Console.ReadLine();
                            double tranc = double.Parse(sum);
                            double doll = tranc / 3.38;
                            Console.WriteLine($"Сумма в долларах: {doll}");
                            break;
                        case 5:
                            Console.WriteLine("Введите три числа: ");
                            string num1 = Console.ReadLine();
                            double n1 = double.Parse(num1);
                            string num2 = Console.ReadLine();
                            double n2 = double.Parse(num2);
                            string num3 = Console.ReadLine();
                            double n3 = double.Parse(num3);
                            double average = (n1 + n2 + n3) / 3;
                            Console.WriteLine($"Среднее арифметическое: {average}");
                            break;
                    }
                    break;

                case 2:
                    Console.WriteLine("Блок 2: Условные операторы if-else, switch: ");
                    Console.WriteLine("Выберите номер задачи: ");
                    string tasks = Console.ReadLine();
                    int numt = int.Parse(tasks);

                    switch (numt)
                    {
                        case 1:
                            Console.WriteLine("Введите номер месяца: ");
                            int month = int.Parse(Console.ReadLine());

                            string season;
                            if (month == 12 || month == 1 || month == 2)
                            {
                                season = "Зима";
                            }
                            else if (month == 3 || month == 4 || month == 5)
                            {
                                season = "Весна";
                            }
                            else if (month == 6 || month == 7 || month == 8)
                            {
                                season = "Лето";
                            }
                            else if (month == 9 || month == 10 || month == 11)
                            {
                                season = "Осень";
                            }
                            else
                            {
                                season = "Неверный номер месяца!";
                            }
                            Console.WriteLine($"Месяц {month} - это {season}");
                            break;

                        case 3:
                            Console.WriteLine("Введите координаты (х,у): ");
                            float x = float.Parse(Console.ReadLine());
                            float y = float.Parse(Console.ReadLine());

                            if (x > 0 && y > 0)
                            {
                                Console.WriteLine("это первая четверть ");
                            }
                            else if (x < 0 && y > 0)
                            {
                                Console.WriteLine("это вторая четверть ");
                            }
                            else if (x < 0 && y < 0)
                            {
                                Console.WriteLine("это третья четверть ");
                            }
                            else if (x > 0 && y < 0)
                            {
                                Console.WriteLine("это четвертая четверть ");
                            }
                            else if (x == 0 || y == 0)
                            {
                                Console.WriteLine("точка лежит на границе ");
                            }
                            break;

                        case 5:
                            Console.WriteLine("Введите время: ");
                            float time = float.Parse(Console.ReadLine());

                            if (time >= 0 && time < 4)
                            {
                                Console.WriteLine("это ночь ");
                            }
                            else if (time < 12 && time >= 4)
                            {
                                Console.WriteLine("это утро ");
                            }
                            else if (time < 17 && time >= 12)
                            {
                                Console.WriteLine("это день ");
                            }
                            else if (time >= 17 && time < 24)
                            {
                                Console.WriteLine("это вечер ");
                            }
                            else
                            {
                                Console.WriteLine("Неверно введено время ");
                            }
                            break;
                    }
                    break;

                case 3:
                    Console.WriteLine("Блок 3: Циклы while do-while: ");
                    Console.WriteLine("Выберите номер задачи: ");
                    string tasks3 = Console.ReadLine();
                    int numt3 = int.Parse(tasks3);
                    switch (numt3)
                    {
                        case 1:
                            Console.WriteLine("Введите число: ");
                            int min = 9;
                            int max = 0;
                            int chis = int.Parse(Console.ReadLine());

                            while (chis > 0)
                            {
                                int cur = chis % 10;

                                if (cur > max)
                                {
                                    max = cur;
                                }
                                if (cur < min)
                                {
                                    min = cur;
                                }
                                chis = chis / 10;
                            }

                            Console.WriteLine($"Max digit = {max}, Min digit = {min}");


                            break;

                        case 3:
                            Console.WriteLine("введите какое количество чисел Фибоначчи вывести");
                            int count = int.Parse(Console.ReadLine());

                            Console.WriteLine($"Первые {count} чисел Фибоначчи:");

                            int a = 0;
                            int b = 1;

                            for (int i = 0; i < count; i++)
                            {
                                Console.Write(a + " ");
                                int next = a + b;
                                a = b;
                                b = next;
                            }


                            break;

                        case 5:
                            Console.WriteLine("введите  количество чисел для рассчета среднего арифметического ");
                            int n = int.Parse(Console.ReadLine());
                            double summa = 0;

                            for (int i = 1; i <= n; i++)
                            {
                                Console.WriteLine($"введите число {i}: ");
                                double nomer = double.Parse(Console.ReadLine());
                                summa += nomer;

                            }
                            double av = summa / n;

                            Console.WriteLine($" Среднее арифметическое: {av}");
                            break;
                    }
                    break;

                case 4:
                    Console.WriteLine("Блок 4: массивы: ");
                    Console.WriteLine("Выберите номер задачи: ");
                    string tasks4 = Console.ReadLine();
                    int numt4 = int.Parse(tasks4);

                    switch (numt4)
                    {
                        case 1:
                            Random random = new Random();
                            Console.WriteLine("Введите параметры массива n,m");
                            int n = int.Parse(Console.ReadLine());
                            int m = int.Parse(Console.ReadLine());

                            int[,] matrix = new int[n, m];

                            for (int i = 0; i < n; i++)
                            {
                                for (int j = 0; j < m; j++)
                                {
                                    matrix[i, j] = random.Next(1, 101);
                                }
                            }

                            Console.WriteLine("Массив n на m со случайными числами: ");
                            for (int i = 0; i < n; i++)
                            {
                                for (int j = 0; j < m; j++)
                                {
                                    Console.Write($"{matrix[i, j],3}");
                                }
                                Console.WriteLine();
                            }

                            Console.WriteLine("\nСуммы по строкам:");
                            for (int i = 0; i < n; i++)
                            {
                                int rowSum = 0;
                                for (int j = 0; j < m; j++)
                                {
                                    rowSum += matrix[i, j];
                                }
                                Console.WriteLine($"строка {i}: {rowSum}");
                            }

                            Console.WriteLine("\nСуммы по столбцам:");
                            for (int j = 0; j < m; j++)
                            {
                                int colSum = 0;
                                for (int i = 0; i < n; i++)
                                {
                                    colSum += matrix[i, j];
                                }
                                Console.WriteLine($"Столбец {j}: {colSum}");
                            }
                            break;

                        case 3:
                            Random random1 = new Random();
                            Console.WriteLine(" Введите количество элементов в массиве: ");
                            int amount = int.Parse(Console.ReadLine());

                            int[] array = new int[amount];
                            for (int i = 0; i < amount; i++)
                            {
                                array[i] = random1.Next(1, 101);
                            }

                            Console.WriteLine("Исходный массив:");
                            for (int i = 0; i < amount; i++)
                            {
                                Console.Write($"{array[i],3}");
                            }
                            Console.WriteLine();

                            Console.WriteLine("Массив в обратном порядке:");
                            for (int i = array.Length - 1; i >= 0; i--)
                            {
                                Console.Write(array[i] + " ");
                            }
                            break;

                        case 5:
                            Random random5 = new Random();
                            Console.WriteLine(" Введите количество элементов в массиве: ");
                            int amount5 = int.Parse(Console.ReadLine());

                            double[] array5 = new double[amount5];
                            for (int i = 0; i < amount5; i++)
                            {
                                array5[i] = random5.Next(-101, 101);
                            }

                            Console.WriteLine("Исходный массив:");
                            foreach (var el in array5)
                            {
                                Console.Write($"{el,3} ");
                            }
                            Console.WriteLine();

                            int positiveCount = 0;
                            int negativeCount = 0;

                            foreach (double el in array5)
                            {
                                if (el > 0) positiveCount++;
                                else if (el < 0) negativeCount++;
                            }

                            double[] positiveNumbers = new double[positiveCount];
                            double[] negativeNumbers = new double[negativeCount];

                            int positiveIndex = 0;
                            int negativeIndex = 0;
                            foreach (double el in array5)
                            {
                                if (el > 0)
                                {
                                    positiveNumbers[positiveIndex] = el;
                                    positiveIndex++;
                                }
                                else if (el < 0)
                                {
                                    negativeNumbers[negativeIndex] = el;
                                    negativeIndex++;
                                }
                            }

                            Console.WriteLine("Положительные числа:");
                            foreach (double num in positiveNumbers)
                                Console.Write(num + " ");

                            Console.WriteLine("\nОтрицательные числа:");
                            foreach (double num in negativeNumbers)
                                Console.Write(num + " ");
                            break;
                    }
                    break;

                case 5:
                    Console.WriteLine("Блок 5: Функции: ");
                    Console.WriteLine("Выберите номер задачи: ");
                    string tasks5 = Console.ReadLine();
                    int numt5 = int.Parse(tasks5);

                    switch (numt5)
                    {
                        case 1:
                            static long Factorial(int numb)
                            {
                                if (numb == 0 || numb == 1)
                                    return 1;

                                return numb * Factorial(numb - 1);

                            }

                            Console.Write(" Введите число: ");
                            int f = int.Parse(Console.ReadLine());

                            long factorial = Factorial(f);
                            Console.WriteLine($"{f}! = {factorial}");

                            break;

                        case 3: //реализовать рекурсивно
                            static long Sum()
                            {
                                Random random53 = new Random();


                                int numb3 = int.Parse(Console.ReadLine());

                                int[] array = new int[numb3];

                                for (int i = 0; i < numb3; i++)
                                {


                                    array[i] = random53.Next(1, 101);


                                }
                                for (int i = 0; i < numb3; i++)
                                {

                                    Console.Write($"{array[i],3}");

                                    Console.WriteLine();

                                }

                                int summaryofarr = 0;

                                for (int i = 0; i < numb3; i++)
                                {
                                    summaryofarr = summaryofarr + array[i];
                                }

                                return summaryofarr;
                            }

                            Console.WriteLine(" Введите количество элементов в массиве: ");
                            long sui = Sum();
                            Console.WriteLine($"Сумма элементов массива: {sui}");
                            break;

                        case 5:


                            static void Divide(int dividend, int divisor, out int quotient, out int remainder)
                            {

                                quotient = dividend / divisor;


                                remainder = dividend % divisor;
                            }
                            Console.Write("Введите делимое: ");
                            int dividend = int.Parse(Console.ReadLine());
                            Console.Write("Введите делитель: ");
                            int divisor = int.Parse(Console.ReadLine());

                            int quotient;
                            int remainder;

                            Divide(dividend, divisor, out quotient, out remainder);


                            Console.WriteLine($"\nРезультат деления:");
                            Console.WriteLine($"{dividend} / {divisor} = {quotient}");
                            Console.WriteLine($"{dividend} % {divisor} = {remainder}");
                            Console.WriteLine($"Проверка: {divisor} × {quotient} + {remainder} = {divisor * quotient + remainder}");

                            break;

                        case 7:
                            Random random1 = new Random();
                            Console.WriteLine("Введите количество элементов в массиве: ");

                            int amount = int.Parse(Console.ReadLine());

                            int[] array = new int[amount];


                            for (int i = 0; i < amount; i++)
                            {
                                array[i] = random1.Next(1, 101);
                            }


                            Console.WriteLine("\nИсходный массив:");
                            for (int i = 0; i < amount; i++)
                            {
                                Console.Write($"{array[i],3} ");
                            }
                            Console.WriteLine();


                            int[] evenNumbers = FilterEven(array);


                            Console.WriteLine("\nЧетные числа (отфильтрованные функцией):");
                            for (int i = 0; i < evenNumbers.Length; i++)
                            {
                                Console.Write($"{evenNumbers[i],3} ");
                            }
                            Console.WriteLine();


                            Console.WriteLine($"\nСтатистика:");
                            Console.WriteLine($"Всего чисел: {amount}");
                            Console.WriteLine($"Четных чисел: {evenNumbers.Length}");
                            Console.WriteLine($"Нечетных чисел: {amount - evenNumbers.Length}");


                            Console.WriteLine("\n=== Демонстрация FilterEven с params ===");
                            int[] testResult = FilterEven(2, 4, 5, 6, 8, 11, 12);
                            Console.WriteLine("FilterEven(2, 4, 5, 6, 8, 11, 12):");
                            Console.WriteLine("Результат: " + string.Join(" ", testResult));


                            static int[] FilterEven(params int[] numbers)
                            {

                                List<int> evenList = new List<int>();

                                Console.WriteLine($"\nФункция FilterEven обрабатывает {numbers.Length} чисел...");


                                foreach (int number in numbers)
                                {
                                    if (number % 2 == 0)
                                    {
                                        evenList.Add(number);
                                        Console.WriteLine($"  Число {number} - четное  (добавлено в список)");
                                    }
                                    else
                                    {
                                        Console.WriteLine($"  Число {number} - нечетное ");
                                    }
                                }

                                Console.WriteLine($"В списке собрано {evenList.Count} четных чисел");
                                return evenList.ToArray();
                            }
                            break;
                    }
                    break;

            }
            Console.ReadKey();
        }

       
    }
}