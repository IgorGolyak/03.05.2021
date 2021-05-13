using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //2.19
            Console.WriteLine("введите четырехзначное число");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= 4; i++)
            {
                sum = n + i;
            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
