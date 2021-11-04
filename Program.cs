using System;

namespace homework_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание № 2");
            Console.WriteLine("Введите число: ");

            int number = Convert.ToInt32(Console.ReadLine());
            if (number > 5 && number < 10)
            {
                Console.WriteLine("Число больше 5 и меньше 10.");
            }
            else
            {
                Console.WriteLine("Неизвестное число");
            }
        }
    }
}