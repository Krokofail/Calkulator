using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Oper3
    {
        public int operat;
        public char[] ds;
        public void op()
        {
            char[] ds = new char[3];
            ds[0] = '1';
            ds[1] = '2';
            Console.WriteLine($"Введите операцию ({ds[0]}: &, {ds[1]}: |)");
            bool isNumber = int.TryParse(Console.ReadLine(), out operat);
            if (operat < 0 || operat >= ds.Length)
            {
                Console.WriteLine($"Вы ввели: {operat}");
                Console.WriteLine("Вы ввели неправильную операцию");
                Console.WriteLine("Для выхода нажмите любую клавишу...");
                Console.ReadKey();
                Environment.Exit(0);
            }
            else if (!isNumber)
            {
                Console.WriteLine($"Вы ввели:{operat}");
                Console.WriteLine("Вы ввели неправильную операцию");
                Console.WriteLine("Для выхода нажмите любую клавишу...");
                Console.ReadKey();
                Environment.Exit(0);
            }
        }
    }
}
