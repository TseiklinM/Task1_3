using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Дано целое число N большее 0, найти число, полученное при прочтении числа N справа 
            налево. Например, если было введено число 345, то программа должна вывести число 543.
            */

            //Ввод данных
            Console.Write("\n Введите целое положительное число: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int newNumber = 0;

            //Проверка условий ввода
            if (number < 0)
                number *= -1;

            //Решение и вывод результата
            while (number > 0)
            {
                newNumber = newNumber * 10 + number % 10;
                number /= 10;
            }
            Console.WriteLine($" Число наоборот = {newNumber}");
        }
    }
}
