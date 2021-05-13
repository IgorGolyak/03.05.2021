using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            //4.25 а
            Console.WriteLine("введите целое число от 10 до 99");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = 0;
            if ((a / 10 + a % 10) == b)
            {
                Console.WriteLine("Сумма цифр является двузначным числом");
            }

            else ((a / 10 + a % 10) % a == 0)
            {
                Console.WriteLine("Сумма цифр не является двузначным числом");
            }
            
           


            Console.ReadKey();
        }
    }
}
