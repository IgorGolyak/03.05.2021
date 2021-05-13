using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1.46
            Console.Write("Ввведи число");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ввведи число");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ввведи число");
            int c = Convert.ToInt32(Console.ReadLine());
            int s = b * c;
            int v = s * a;
            Console.Write("Площадь: " + s + " Объем : " + v);
            Console.ReadKey();
        }
    }
}
