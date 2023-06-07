using System;

namespace opd3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите последовательность целых чисел (через пробелы):");
            string vvod = Console.ReadLine();

            Console.WriteLine("Введите значение X:");
            int x = Convert.ToInt32(Console.ReadLine());

            int sum = 0;

// разделение строки "vvod" на отдельные числа по пробелам и сохранение в массив         
            string[] numbers = vvod.Split(' ');

// цикл, выполняющийся для каждого числа из массива       
            foreach (string number in numbers)
            {
                int num = Convert.ToInt32(number);

                if (num < 0)
                    continue;

                if (num > 0 && num % x == 0)
                    sum += num;
            }

            Console.WriteLine("Сумма положительных чисел, кратных X, до 1-го отрицательного: " + sum);
        }
    }
}
